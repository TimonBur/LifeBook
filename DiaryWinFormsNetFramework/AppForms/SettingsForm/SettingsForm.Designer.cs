﻿namespace DiaryWinFormsNetFramework.Plugins.SettingsForm
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.PanelDirectoryProjects = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialogForProjectsDirectory = new System.Windows.Forms.Button();
            this.labelDirectoryProjects = new System.Windows.Forms.Label();
            this.labelProjectsDirectory = new System.Windows.Forms.Label();
            this.panelDirectoryIdeas = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialogForIdeasDirectory = new System.Windows.Forms.Button();
            this.labelDirectoryIdeas = new System.Windows.Forms.Label();
            this.labelIdeasDirectory = new System.Windows.Forms.Label();
            this.panelDirectoryStories = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialogForStories = new System.Windows.Forms.Button();
            this.labelDirectoryStories = new System.Windows.Forms.Label();
            this.labelStoryDirectory = new System.Windows.Forms.Label();
            this.panelDirectorySetting = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.labelDirectorySetting = new System.Windows.Forms.Label();
            this.labelSettingsDirectory = new System.Windows.Forms.Label();
            this.BottomCommandsPanel = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BodyPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.PanelDirectoryProjects.SuspendLayout();
            this.panelDirectoryIdeas.SuspendLayout();
            this.panelDirectoryStories.SuspendLayout();
            this.panelDirectorySetting.SuspendLayout();
            this.BottomCommandsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.ContentPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1120, 690);
            this.BodyPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Controls.Add(this.PanelDirectoryProjects);
            this.ContentPanel.Controls.Add(this.labelProjectsDirectory);
            this.ContentPanel.Controls.Add(this.panelDirectoryIdeas);
            this.ContentPanel.Controls.Add(this.labelIdeasDirectory);
            this.ContentPanel.Controls.Add(this.panelDirectoryStories);
            this.ContentPanel.Controls.Add(this.labelStoryDirectory);
            this.ContentPanel.Controls.Add(this.panelDirectorySetting);
            this.ContentPanel.Controls.Add(this.labelSettingsDirectory);
            this.ContentPanel.Controls.Add(this.BottomCommandsPanel);
            this.ContentPanel.Location = new System.Drawing.Point(28, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1064, 648);
            this.ContentPanel.TabIndex = 4;
            // 
            // PanelDirectoryProjects
            // 
            this.PanelDirectoryProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDirectoryProjects.Controls.Add(this.btnOpenFolderDialogForProjectsDirectory);
            this.PanelDirectoryProjects.Controls.Add(this.labelDirectoryProjects);
            this.PanelDirectoryProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDirectoryProjects.Location = new System.Drawing.Point(0, 179);
            this.PanelDirectoryProjects.Name = "PanelDirectoryProjects";
            this.PanelDirectoryProjects.Size = new System.Drawing.Size(1064, 37);
            this.PanelDirectoryProjects.TabIndex = 4;
            // 
            // btnOpenFolderDialogForProjectsDirectory
            // 
            this.btnOpenFolderDialogForProjectsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialogForProjectsDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnOpenFolderDialogForProjectsDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialogForProjectsDirectory.Location = new System.Drawing.Point(1007, -1);
            this.btnOpenFolderDialogForProjectsDirectory.Name = "btnOpenFolderDialogForProjectsDirectory";
            this.btnOpenFolderDialogForProjectsDirectory.Size = new System.Drawing.Size(56, 37);
            this.btnOpenFolderDialogForProjectsDirectory.TabIndex = 1;
            this.btnOpenFolderDialogForProjectsDirectory.Text = "...";
            this.btnOpenFolderDialogForProjectsDirectory.UseVisualStyleBackColor = false;
            this.btnOpenFolderDialogForProjectsDirectory.Click += new System.EventHandler(this.btnOpenFolderDialogForProjectsDirectory_Click);
            // 
            // labelDirectoryProjects
            // 
            this.labelDirectoryProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectoryProjects.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectoryProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelDirectoryProjects.Location = new System.Drawing.Point(0, 0);
            this.labelDirectoryProjects.Name = "labelDirectoryProjects";
            this.labelDirectoryProjects.Size = new System.Drawing.Size(1001, 35);
            this.labelDirectoryProjects.TabIndex = 0;
            this.labelDirectoryProjects.Text = "default directory";
            this.labelDirectoryProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProjectsDirectory
            // 
            this.labelProjectsDirectory.AutoSize = true;
            this.labelProjectsDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProjectsDirectory.Location = new System.Drawing.Point(0, 162);
            this.labelProjectsDirectory.Name = "labelProjectsDirectory";
            this.labelProjectsDirectory.Size = new System.Drawing.Size(147, 17);
            this.labelProjectsDirectory.TabIndex = 6;
            this.labelProjectsDirectory.Text = "Projects files directory";
            // 
            // panelDirectoryIdeas
            // 
            this.panelDirectoryIdeas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectoryIdeas.Controls.Add(this.btnOpenFolderDialogForIdeasDirectory);
            this.panelDirectoryIdeas.Controls.Add(this.labelDirectoryIdeas);
            this.panelDirectoryIdeas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectoryIdeas.Location = new System.Drawing.Point(0, 125);
            this.panelDirectoryIdeas.Name = "panelDirectoryIdeas";
            this.panelDirectoryIdeas.Size = new System.Drawing.Size(1064, 37);
            this.panelDirectoryIdeas.TabIndex = 3;
            // 
            // btnOpenFolderDialogForIdeasDirectory
            // 
            this.btnOpenFolderDialogForIdeasDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialogForIdeasDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnOpenFolderDialogForIdeasDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialogForIdeasDirectory.Location = new System.Drawing.Point(1007, -1);
            this.btnOpenFolderDialogForIdeasDirectory.Name = "btnOpenFolderDialogForIdeasDirectory";
            this.btnOpenFolderDialogForIdeasDirectory.Size = new System.Drawing.Size(56, 37);
            this.btnOpenFolderDialogForIdeasDirectory.TabIndex = 1;
            this.btnOpenFolderDialogForIdeasDirectory.Text = "...";
            this.btnOpenFolderDialogForIdeasDirectory.UseVisualStyleBackColor = false;
            this.btnOpenFolderDialogForIdeasDirectory.Click += new System.EventHandler(this.btnOpenFolderDialogForIdeasDirectory_Click);
            // 
            // labelDirectoryIdeas
            // 
            this.labelDirectoryIdeas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectoryIdeas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectoryIdeas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelDirectoryIdeas.Location = new System.Drawing.Point(0, 0);
            this.labelDirectoryIdeas.Name = "labelDirectoryIdeas";
            this.labelDirectoryIdeas.Size = new System.Drawing.Size(1001, 35);
            this.labelDirectoryIdeas.TabIndex = 0;
            this.labelDirectoryIdeas.Text = "default directory";
            this.labelDirectoryIdeas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdeasDirectory
            // 
            this.labelIdeasDirectory.AutoSize = true;
            this.labelIdeasDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIdeasDirectory.Location = new System.Drawing.Point(0, 108);
            this.labelIdeasDirectory.Name = "labelIdeasDirectory";
            this.labelIdeasDirectory.Size = new System.Drawing.Size(130, 17);
            this.labelIdeasDirectory.TabIndex = 5;
            this.labelIdeasDirectory.Text = "Ideas files directory";
            // 
            // panelDirectoryStories
            // 
            this.panelDirectoryStories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectoryStories.Controls.Add(this.btnOpenFolderDialogForStories);
            this.panelDirectoryStories.Controls.Add(this.labelDirectoryStories);
            this.panelDirectoryStories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectoryStories.Location = new System.Drawing.Point(0, 71);
            this.panelDirectoryStories.Name = "panelDirectoryStories";
            this.panelDirectoryStories.Size = new System.Drawing.Size(1064, 37);
            this.panelDirectoryStories.TabIndex = 2;
            // 
            // btnOpenFolderDialogForStories
            // 
            this.btnOpenFolderDialogForStories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialogForStories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnOpenFolderDialogForStories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialogForStories.Location = new System.Drawing.Point(1007, -1);
            this.btnOpenFolderDialogForStories.Name = "btnOpenFolderDialogForStories";
            this.btnOpenFolderDialogForStories.Size = new System.Drawing.Size(56, 37);
            this.btnOpenFolderDialogForStories.TabIndex = 1;
            this.btnOpenFolderDialogForStories.Text = "...";
            this.btnOpenFolderDialogForStories.UseVisualStyleBackColor = false;
            this.btnOpenFolderDialogForStories.Click += new System.EventHandler(this.btnOpenFolderDialogForStories_Click);
            // 
            // labelDirectoryStories
            // 
            this.labelDirectoryStories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectoryStories.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectoryStories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelDirectoryStories.Location = new System.Drawing.Point(0, 0);
            this.labelDirectoryStories.Name = "labelDirectoryStories";
            this.labelDirectoryStories.Size = new System.Drawing.Size(1001, 35);
            this.labelDirectoryStories.TabIndex = 0;
            this.labelDirectoryStories.Text = "default directory";
            this.labelDirectoryStories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStoryDirectory
            // 
            this.labelStoryDirectory.AutoSize = true;
            this.labelStoryDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStoryDirectory.Location = new System.Drawing.Point(0, 54);
            this.labelStoryDirectory.Name = "labelStoryDirectory";
            this.labelStoryDirectory.Size = new System.Drawing.Size(129, 17);
            this.labelStoryDirectory.TabIndex = 3;
            this.labelStoryDirectory.Text = "Story files directory";
            // 
            // panelDirectorySetting
            // 
            this.panelDirectorySetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectorySetting.Controls.Add(this.btnOpenFolderDialog);
            this.panelDirectorySetting.Controls.Add(this.labelDirectorySetting);
            this.panelDirectorySetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectorySetting.Location = new System.Drawing.Point(0, 17);
            this.panelDirectorySetting.Name = "panelDirectorySetting";
            this.panelDirectorySetting.Size = new System.Drawing.Size(1064, 37);
            this.panelDirectorySetting.TabIndex = 0;
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnOpenFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(1007, -1);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(56, 37);
            this.btnOpenFolderDialog.TabIndex = 1;
            this.btnOpenFolderDialog.Text = "...";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = false;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // labelDirectorySetting
            // 
            this.labelDirectorySetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectorySetting.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectorySetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelDirectorySetting.Location = new System.Drawing.Point(-1, 0);
            this.labelDirectorySetting.Name = "labelDirectorySetting";
            this.labelDirectorySetting.Size = new System.Drawing.Size(1002, 35);
            this.labelDirectorySetting.TabIndex = 0;
            this.labelDirectorySetting.Text = "default directory";
            this.labelDirectorySetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSettingsDirectory
            // 
            this.labelSettingsDirectory.AutoSize = true;
            this.labelSettingsDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSettingsDirectory.Location = new System.Drawing.Point(0, 0);
            this.labelSettingsDirectory.Name = "labelSettingsDirectory";
            this.labelSettingsDirectory.Size = new System.Drawing.Size(189, 17);
            this.labelSettingsDirectory.TabIndex = 2;
            this.labelSettingsDirectory.Text = "Application settings directory";
            // 
            // BottomCommandsPanel
            // 
            this.BottomCommandsPanel.Controls.Add(this.btnChangePassword);
            this.BottomCommandsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomCommandsPanel.Location = new System.Drawing.Point(0, 595);
            this.BottomCommandsPanel.Name = "BottomCommandsPanel";
            this.BottomCommandsPanel.Size = new System.Drawing.Size(1064, 53);
            this.BottomCommandsPanel.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.BackgroundImage")));
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(61, 53);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.PanelDirectoryProjects.ResumeLayout(false);
            this.panelDirectoryIdeas.ResumeLayout(false);
            this.panelDirectoryStories.ResumeLayout(false);
            this.panelDirectorySetting.ResumeLayout(false);
            this.BottomCommandsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel panelDirectorySetting;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.Label labelDirectorySetting;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Panel panelDirectoryStories;
        private System.Windows.Forms.Button btnOpenFolderDialogForStories;
        private System.Windows.Forms.Label labelDirectoryStories;
        private System.Windows.Forms.Label labelSettingsDirectory;
        private System.Windows.Forms.Label labelStoryDirectory;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel BottomCommandsPanel;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panelDirectoryIdeas;
        private System.Windows.Forms.Button btnOpenFolderDialogForIdeasDirectory;
        private System.Windows.Forms.Label labelDirectoryIdeas;
        private System.Windows.Forms.Label labelIdeasDirectory;
        private System.Windows.Forms.Panel PanelDirectoryProjects;
        private System.Windows.Forms.Button btnOpenFolderDialogForProjectsDirectory;
        private System.Windows.Forms.Label labelDirectoryProjects;
        private System.Windows.Forms.Label labelProjectsDirectory;
    }
}