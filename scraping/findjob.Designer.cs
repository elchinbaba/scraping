﻿
namespace scraping
{
    partial class findjob
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
            this.job_title = new System.Windows.Forms.ComboBox();
            this.work_experience = new System.Windows.Forms.ComboBox();
            this.remote_or_office = new System.Windows.Forms.ComboBox();
            this.jobs = new System.Windows.Forms.RichTextBox();
            this.get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // job_title
            // 
            this.job_title.FormattingEnabled = true;
            this.job_title.Location = new System.Drawing.Point(23, 71);
            this.job_title.Name = "job_title";
            this.job_title.Size = new System.Drawing.Size(193, 21);
            this.job_title.TabIndex = 0;
            // 
            // work_experience
            // 
            this.work_experience.FormattingEnabled = true;
            this.work_experience.Location = new System.Drawing.Point(291, 71);
            this.work_experience.Name = "work_experience";
            this.work_experience.Size = new System.Drawing.Size(179, 21);
            this.work_experience.TabIndex = 1;
            // 
            // remote_or_office
            // 
            this.remote_or_office.FormattingEnabled = true;
            this.remote_or_office.Location = new System.Drawing.Point(563, 71);
            this.remote_or_office.Name = "remote_or_office";
            this.remote_or_office.Size = new System.Drawing.Size(192, 21);
            this.remote_or_office.TabIndex = 2;
            // 
            // jobs
            // 
            this.jobs.Location = new System.Drawing.Point(35, 163);
            this.jobs.Name = "jobs";
            this.jobs.ReadOnly = true;
            this.jobs.Size = new System.Drawing.Size(720, 244);
            this.jobs.TabIndex = 3;
            this.jobs.Text = "";
            // 
            // get
            // 
            this.get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get.Location = new System.Drawing.Point(332, 114);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(99, 43);
            this.get.TabIndex = 4;
            this.get.Text = "get";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // findjob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.get);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.remote_or_office);
            this.Controls.Add(this.work_experience);
            this.Controls.Add(this.job_title);
            this.Name = "findjob";
            this.Text = "Find your job";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox job_title;
        private System.Windows.Forms.ComboBox work_experience;
        private System.Windows.Forms.ComboBox remote_or_office;
        private System.Windows.Forms.RichTextBox jobs;
        private System.Windows.Forms.Button get;
    }
}

