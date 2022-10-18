
namespace GUIFinal
{
    partial class PhoneEditor
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
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textScreenSize = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.labelScreensize = new System.Windows.Forms.Label();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxPhones = new System.Windows.Forms.ComboBox();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.labelIn = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            this.panelMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBrand.Location = new System.Drawing.Point(189, 99);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(285, 23);
            this.textBoxBrand.TabIndex = 2;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxModel.Location = new System.Drawing.Point(189, 125);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(285, 23);
            this.textBoxModel.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxYear.Location = new System.Drawing.Point(227, 154);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(96, 23);
            this.textBoxYear.TabIndex = 4;
            // 
            // textScreenSize
            // 
            this.textScreenSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textScreenSize.Location = new System.Drawing.Point(227, 183);
            this.textScreenSize.Name = "textScreenSize";
            this.textScreenSize.Size = new System.Drawing.Size(96, 23);
            this.textScreenSize.TabIndex = 5;
            // 
            // labelBrand
            // 
            this.labelBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(126, 99);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(41, 15);
            this.labelBrand.TabIndex = 7;
            this.labelBrand.Text = "Brand:";
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(126, 128);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(44, 15);
            this.labelModel.TabIndex = 8;
            this.labelModel.Text = "Model:";
            // 
            // labelGeneration
            // 
            this.labelGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(126, 157);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(32, 15);
            this.labelGeneration.TabIndex = 9;
            this.labelGeneration.Text = "Year:";
            // 
            // labelScreensize
            // 
            this.labelScreensize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScreensize.AutoSize = true;
            this.labelScreensize.Location = new System.Drawing.Point(126, 185);
            this.labelScreensize.Name = "labelScreensize";
            this.labelScreensize.Size = new System.Drawing.Size(68, 15);
            this.labelScreensize.TabIndex = 10;
            this.labelScreensize.Text = "Screen Size:";
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPhone.Location = new System.Drawing.Point(329, 157);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(145, 165);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhone.TabIndex = 14;
            this.pictureBoxPhone.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(227, 328);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 40);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxPhones
            // 
            this.comboBoxPhones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPhones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPhones.FormattingEnabled = true;
            this.comboBoxPhones.Location = new System.Drawing.Point(127, 32);
            this.comboBoxPhones.Name = "comboBoxPhones";
            this.comboBoxPhones.Size = new System.Drawing.Size(347, 23);
            this.comboBoxPhones.TabIndex = 1;
            this.comboBoxPhones.Text = "                                           Select a Phone";
            this.comboBoxPhones.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhones_SelectedIndexChanged);
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.labelIn);
            this.panelMovie.Controls.Add(this.textBoxIn);
            this.panelMovie.Controls.Add(this.labelPrice);
            this.panelMovie.Controls.Add(this.labelMass);
            this.panelMovie.Controls.Add(this.labelUnit);
            this.panelMovie.Controls.Add(this.textBoxPrice);
            this.panelMovie.Controls.Add(this.textBoxMass);
            this.panelMovie.Controls.Add(this.textBoxUnit);
            this.panelMovie.Controls.Add(this.labelID);
            this.panelMovie.Controls.Add(this.textBoxID);
            this.panelMovie.Controls.Add(this.comboBoxPhones);
            this.panelMovie.Controls.Add(this.buttonSave);
            this.panelMovie.Controls.Add(this.pictureBoxPhone);
            this.panelMovie.Controls.Add(this.labelScreensize);
            this.panelMovie.Controls.Add(this.labelGeneration);
            this.panelMovie.Controls.Add(this.labelModel);
            this.panelMovie.Controls.Add(this.labelBrand);
            this.panelMovie.Controls.Add(this.textScreenSize);
            this.panelMovie.Controls.Add(this.textBoxYear);
            this.panelMovie.Controls.Add(this.textBoxModel);
            this.panelMovie.Controls.Add(this.textBoxBrand);
            this.panelMovie.Location = new System.Drawing.Point(12, 12);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(600, 400);
            this.panelMovie.TabIndex = 15;
            // 
            // labelIn
            // 
            this.labelIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(162, 241);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(57, 15);
            this.labelIn.TabIndex = 34;
            this.labelIn.Text = "In Inches:";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIn.Location = new System.Drawing.Point(260, 241);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ReadOnly = true;
            this.textBoxIn.Size = new System.Drawing.Size(63, 23);
            this.textBoxIn.TabIndex = 33;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(126, 302);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 15);
            this.labelPrice.TabIndex = 32;
            this.labelPrice.Text = "Price:";
            // 
            // labelMass
            // 
            this.labelMass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMass.AutoSize = true;
            this.labelMass.Location = new System.Drawing.Point(126, 273);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(37, 15);
            this.labelMass.TabIndex = 31;
            this.labelMass.Text = "Mass:";
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(162, 212);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(32, 15);
            this.labelUnit.TabIndex = 30;
            this.labelUnit.Text = "Unit:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.Location = new System.Drawing.Point(227, 299);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(96, 23);
            this.textBoxPrice.TabIndex = 29;
            // 
            // textBoxMass
            // 
            this.textBoxMass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMass.Location = new System.Drawing.Point(227, 270);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(96, 23);
            this.textBoxMass.TabIndex = 28;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnit.Location = new System.Drawing.Point(260, 212);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(63, 23);
            this.textBoxUnit.TabIndex = 27;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(126, 70);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 15);
            this.labelID.TabIndex = 26;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(189, 67);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(285, 23);
            this.textBoxID.TabIndex = 25;
            // 
            // PhoneEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.panelMovie);
            this.Name = "PhoneEditor";
            this.Text = "Phone Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textScreenSize;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.Label labelScreensize;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxPhones;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.TextBox textBoxIn;
    }
}