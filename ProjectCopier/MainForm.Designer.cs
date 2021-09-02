
namespace ProjectCopier
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_copy_now = new System.Windows.Forms.Button();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_open_src = new System.Windows.Forms.Button();
            this.btn_target = new System.Windows.Forms.Button();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.txt_new_name = new System.Windows.Forms.TextBox();
            this.btn_open_now = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_copy_now
            // 
            this.btn_copy_now.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_copy_now.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_copy_now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy_now.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_copy_now.FlatAppearance.BorderSize = 0;
            this.btn_copy_now.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumBlue;
            this.btn_copy_now.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btn_copy_now.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_copy_now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy_now.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy_now.ForeColor = System.Drawing.Color.White;
            this.btn_copy_now.Location = new System.Drawing.Point(150, 110);
            this.btn_copy_now.Name = "btn_copy_now";
            this.btn_copy_now.Size = new System.Drawing.Size(181, 35);
            this.btn_copy_now.TabIndex = 0;
            this.btn_copy_now.Text = "Copy Now";
            this.btn_copy_now.UseVisualStyleBackColor = false;
            this.btn_copy_now.Click += new System.EventHandler(this.btn_copy_now_Click);
            // 
            // txt_src
            // 
            this.txt_src.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_src.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_src.Location = new System.Drawing.Point(138, 15);
            this.txt_src.Name = "txt_src";
            this.txt_src.Size = new System.Drawing.Size(507, 23);
            this.txt_src.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source [*.sln]";
            // 
            // btn_open_src
            // 
            this.btn_open_src.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open_src.BackgroundImage = global::ProjectCopier.Properties.Resources.Opened_Folder_48px;
            this.btn_open_src.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open_src.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open_src.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_open_src.FlatAppearance.BorderSize = 0;
            this.btn_open_src.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_open_src.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_src.Location = new System.Drawing.Point(650, 15);
            this.btn_open_src.Name = "btn_open_src";
            this.btn_open_src.Size = new System.Drawing.Size(25, 23);
            this.btn_open_src.TabIndex = 0;
            this.btn_open_src.UseVisualStyleBackColor = true;
            this.btn_open_src.Click += new System.EventHandler(this.btn_open_src_Click);
            // 
            // btn_target
            // 
            this.btn_target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_target.BackgroundImage = global::ProjectCopier.Properties.Resources.Opened_Folder_48px;
            this.btn_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_target.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_target.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_target.FlatAppearance.BorderSize = 0;
            this.btn_target.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_target.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_target.Location = new System.Drawing.Point(650, 44);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(25, 23);
            this.btn_target.TabIndex = 0;
            this.btn_target.UseVisualStyleBackColor = true;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // txt_target
            // 
            this.txt_target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_target.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_target.Location = new System.Drawing.Point(138, 44);
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(507, 23);
            this.txt_target.TabIndex = 1;
            this.txt_target.Text = "F:\\Projects";
            this.txt_target.TextChanged += new System.EventHandler(this.txt_target_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Project Name";
            // 
            // txt_log
            // 
            this.txt_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_log.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(12, 151);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(663, 446);
            this.txt_log.TabIndex = 3;
            this.txt_log.Text = "";
            // 
            // txt_new_name
            // 
            this.txt_new_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_new_name.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_name.Location = new System.Drawing.Point(138, 73);
            this.txt_new_name.Name = "txt_new_name";
            this.txt_new_name.Size = new System.Drawing.Size(507, 23);
            this.txt_new_name.TabIndex = 1;
            this.txt_new_name.TextChanged += new System.EventHandler(this.txt_new_name_TextChanged);
            // 
            // btn_open_now
            // 
            this.btn_open_now.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_open_now.BackColor = System.Drawing.Color.Tomato;
            this.btn_open_now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open_now.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_open_now.FlatAppearance.BorderSize = 0;
            this.btn_open_now.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumBlue;
            this.btn_open_now.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btn_open_now.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btn_open_now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_now.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_now.ForeColor = System.Drawing.Color.White;
            this.btn_open_now.Location = new System.Drawing.Point(337, 110);
            this.btn_open_now.Name = "btn_open_now";
            this.btn_open_now.Size = new System.Drawing.Size(181, 35);
            this.btn_open_now.TabIndex = 0;
            this.btn_open_now.Text = "Open New Project";
            this.btn_open_now.UseVisualStyleBackColor = false;
            this.btn_open_now.Click += new System.EventHandler(this.btn_open_now_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 609);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_new_name);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.txt_src);
            this.Controls.Add(this.btn_open_src);
            this.Controls.Add(this.btn_open_now);
            this.Controls.Add(this.btn_copy_now);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Project Copier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copy_now;
        private System.Windows.Forms.TextBox txt_src;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_open_src;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.TextBox txt_new_name;
        private System.Windows.Forms.Button btn_open_now;
    }
}

