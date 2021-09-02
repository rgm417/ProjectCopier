using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCopier
{
    public partial class MainForm : Form
    {
        string m_src_folder = "";
        string m_src_name = "";
        string m_tar_name = "";
        string m_tar_folder = "";
        string m_new_solution_file = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            init_ui();
        }

        void add_log(string log)
        {
            txt_log.Text += DateTime.Now.ToString("HH:mm:ss") + " " + log + "\n";
        }

        void init_ui()
        {
            // explanation
            txt_log.Text = 
                "1. Open a *.sln file. There supposed to be a folder xxx in the same directory while you open xxx.sln.\n" + 
                "2. Choose a folder to make a new project in. A new solution folder will be created there.\n\n\n";
        }

        private void btn_open_src_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open source solution file";
                dlg.Filter = "VS solution files|*.sln|All files|*.*";
                dlg.InitialDirectory = "F:\\";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_src.Text = dlg.FileName;
                    open_src();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }

        }

        void open_src(bool show_log = true)
        {
            var path = txt_src.Text;
            if (check_src_folder(path))
            {
                if(show_log)
                {
                    add_log($"A source solution file selected: {path}");
                }
            }
            else
            {
                MessageBox.Show("The source folder is not valid.\nIt is supposed to have a subfolder with the same name as the solution file.");
                return;
            }
        }

        bool check_src_folder(string path)
        {
            m_src_folder = Path.GetDirectoryName(path);
            m_src_name = Path.GetFileNameWithoutExtension(path);
            if (Directory.Exists(Path.Combine(m_src_folder, m_src_name)))
                return true;
            return false;
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.IsFolderPicker = true;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_target.Text = dlg.FileName;
                open_tar();
                
            }
        }

        void open_tar(bool show_log = true)
        {
            var path = txt_target.Text;
            m_tar_folder = path;
            if (show_log)
            {
                add_log($"Target folder selected: {path}");
            }
        }

        private void txt_new_name_TextChanged(object sender, EventArgs e)
        {
            m_tar_name = txt_new_name.Text;
        }

        private void btn_copy_now_Click(object sender, EventArgs e)
        {
            open_src(false);
            open_tar(false);

            if(!Directory.Exists(m_src_folder) || !Directory.Exists(m_tar_folder))
            {
                MessageBox.Show("Source folder or target valid is not valid.");
                add_log($"SRC:{m_src_folder}");
                add_log($"TAR:{m_tar_folder}");
                return;
            }

            if(m_tar_name == "")
            {
                MessageBox.Show("New project name is not valid.");
                return;
            }

            add_log("=============================================");
            add_log($"Project copying from {m_src_name} to {m_tar_name} started.");

            try
            {
                // create new directory
                m_tar_folder = Path.Combine(m_tar_folder, m_tar_name);
                Directory.CreateDirectory(m_tar_folder);
                add_log($"Solution folder created: {m_tar_folder}");

                // copy the solution file
                m_new_solution_file = Path.Combine(m_tar_folder, m_tar_name) + ".sln";
                File.Copy(Path.Combine(m_src_folder, m_src_name) + ".sln", m_new_solution_file);
                add_log($"Solution file created: {m_new_solution_file}");

                // copy the solution folder
                add_log($"Solution folder copying...");
                deep_copy(Path.Combine(m_src_folder, m_src_name), Path.Combine(m_tar_folder, m_tar_name));
                add_log($"Solution folder copied.");

                // rename proj files
                var new_proj_folder = Path.Combine(m_tar_folder, m_tar_name);
                var files = Directory.GetFiles(new_proj_folder);
                foreach(var file in files)
                {
                    if(file.Contains(m_src_name))
                    {
                        var new_file = file.Replace(m_src_name, m_tar_name);
                        File.Move(file, new_file);
                        add_log($"Renamed {Path.GetFileName(file)} to {Path.GetFileName(new_file)}.");
                    }
                }

                // rename contents of files with specific extension
                add_log($"Changing contents...");
                var extensions = (new string[] { "cs", "config", "csproj", "user", "res", "sln" }).ToList();
                var all_files = Directory.EnumerateFiles(m_tar_folder, "*.*", SearchOption.AllDirectories);
                foreach(var file in all_files)
                {
                    var ext = Path.GetExtension(file).Substring(1);
                    if(extensions.Contains(ext))
                    {
                        if(replace_content(file, m_src_name, m_tar_name))
                            add_log($"Changed {Path.GetFileName(file)}.");
                    }
                }
            }
            catch(Exception ex)
            {
                add_log("Failed" + ex.Message + "\n" + ex.StackTrace);
            }

            add_log("=============================================");
            add_log("Finished.");
        }

        bool replace_content(string file, string from, string to)
        {
            try
            {
                var all_text = File.ReadAllText(file);
                var new_text = all_text.Replace(from, to);
                if(all_text != new_text)
                {
                    File.WriteAllText(file, new_text);
                    return true;
                }
            }
            catch
            {
                
            }
            return false;
        }

        private static void deep_copy(string sourcePath, string targetPath)
        {
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        private void btn_open_now_Click(object sender, EventArgs e)
        {
            if (File.Exists(m_new_solution_file))
                System.Diagnostics.Process.Start(m_new_solution_file);
        }

        private void txt_target_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
