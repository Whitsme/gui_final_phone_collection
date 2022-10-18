
namespace GUIFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonOpenEditor = new System.Windows.Forms.Button();
            this.labelImages = new System.Windows.Forms.Label();
            this.labelFolder = new System.Windows.Forms.Label();
            this.buttonImages = new System.Windows.Forms.Button();
            this.buttonJSON = new System.Windows.Forms.Button();
            this.folderBrowserDialogJSON = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogImages = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Controls.Add(this.buttonOpenEditor);
            this.panelMain.Controls.Add(this.labelImages);
            this.panelMain.Controls.Add(this.labelFolder);
            this.panelMain.Controls.Add(this.buttonImages);
            this.panelMain.Controls.Add(this.buttonJSON);
            this.panelMain.Location = new System.Drawing.Point(154, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(316, 424);
            this.panelMain.TabIndex = 48;
            // 
            // buttonOpenEditor
            // 
            this.buttonOpenEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenEditor.Location = new System.Drawing.Point(11, 221);
            this.buttonOpenEditor.Name = "buttonOpenEditor";
            this.buttonOpenEditor.Size = new System.Drawing.Size(296, 40);
            this.buttonOpenEditor.TabIndex = 83;
            this.buttonOpenEditor.Text = "Open Editor";
            this.buttonOpenEditor.UseVisualStyleBackColor = true;
            this.buttonOpenEditor.Click += new System.EventHandler(this.buttonOpenEditor_Click_1);
            // 
            // labelImages
            // 
            this.labelImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelImages.AutoSize = true;
            this.labelImages.Location = new System.Drawing.Point(20, 196);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(137, 15);
            this.labelImages.TabIndex = 79;
            this.labelImages.Text = "Open a folder of images:";
            // 
            // labelFolder
            // 
            this.labelFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(20, 167);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(151, 15);
            this.labelFolder.TabIndex = 80;
            this.labelFolder.Text = "Open a folder of JSON files:";
            this.labelFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonImages
            // 
            this.buttonImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonImages.Location = new System.Drawing.Point(181, 192);
            this.buttonImages.Name = "buttonImages";
            this.buttonImages.Size = new System.Drawing.Size(126, 23);
            this.buttonImages.TabIndex = 82;
            this.buttonImages.Text = "Select folder...";
            this.buttonImages.UseVisualStyleBackColor = true;
            this.buttonImages.Click += new System.EventHandler(this.buttonImages_Click_1);
            // 
            // buttonJSON
            // 
            this.buttonJSON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonJSON.Location = new System.Drawing.Point(181, 163);
            this.buttonJSON.Name = "buttonJSON";
            this.buttonJSON.Size = new System.Drawing.Size(126, 23);
            this.buttonJSON.TabIndex = 81;
            this.buttonJSON.Text = "Select folder...";
            this.buttonJSON.UseVisualStyleBackColor = true;
            this.buttonJSON.Click += new System.EventHandler(this.buttonJSON_Click_1);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(20, -37);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(142, 497);
            this.pictureBox13.TabIndex = 49;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(464, -37);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(127, 497);
            this.pictureBox14.TabIndex = 50;
            this.pictureBox14.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelMain);
            this.groupBox1.Controls.Add(this.pictureBox13);
            this.groupBox1.Controls.Add(this.pictureBox14);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 424);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aaron Whitaker GUI Final";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonOpenEditor;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button buttonImages;
        private System.Windows.Forms.Button buttonJSON;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogJSON;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImages;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

