
namespace WinForms_UIAHierarchy
{
    partial class Form1
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.groupBoxContent = new System.Windows.Forms.GroupBox();
            this.radioButtonFirst = new System.Windows.Forms.RadioButton();
            this.panelSuboptions = new System.Windows.Forms.Panel();
            this.radioButtonSuboptionOne = new System.Windows.Forms.RadioButton();
            this.radioButtonSuboptionTwo = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSecond = new System.Windows.Forms.RadioButton();
            this.labelSecondOptionInstructions = new System.Windows.Forms.Label();
            this.labelFirstChoice = new System.Windows.Forms.Label();
            this.textBoxFirstChoice = new System.Windows.Forms.TextBox();
            this.buttonBrowseFirst = new System.Windows.Forms.Button();
            this.buttonSecondBrowse = new System.Windows.Forms.Button();
            this.textBoxSecondChoice = new System.Windows.Forms.TextBox();
            this.labelSecondChoice = new System.Windows.Forms.Label();
            this.labelThirdchoice = new System.Windows.Forms.Label();
            this.comboBoxThirdChoice = new System.Windows.Forms.ComboBox();
            this.groupBoxContent.SuspendLayout();
            this.panelSuboptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(806, 615);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(167, 68);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(14, 14);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(259, 25);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Some helpful instructions.";
            // 
            // groupBoxContent
            // 
            this.groupBoxContent.Controls.Add(this.radioButtonFirst);
            this.groupBoxContent.Controls.Add(this.panelSuboptions);
            this.groupBoxContent.Controls.Add(this.radioButtonSecond);
            this.groupBoxContent.Controls.Add(this.labelSecondOptionInstructions);
            this.groupBoxContent.Location = new System.Drawing.Point(20, 69);
            this.groupBoxContent.Name = "groupBoxContent";
            this.groupBoxContent.Size = new System.Drawing.Size(953, 349);
            this.groupBoxContent.TabIndex = 1;
            this.groupBoxContent.TabStop = false;
            this.groupBoxContent.Text = "&Content";
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(8, 47);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(154, 29);
            this.radioButtonFirst.TabIndex = 0;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.Text = "&First Option";
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // panelSuboptions
            // 
            this.panelSuboptions.AccessibleName = "First Option details";
            this.panelSuboptions.Controls.Add(this.radioButtonSuboptionOne);
            this.panelSuboptions.Controls.Add(this.radioButtonSuboptionTwo);
            this.panelSuboptions.Controls.Add(this.dateTimePicker1);
            this.panelSuboptions.Controls.Add(this.dateTimePicker2);
            this.panelSuboptions.Location = new System.Drawing.Point(52, 94);
            this.panelSuboptions.Name = "panelSuboptions";
            this.panelSuboptions.Size = new System.Drawing.Size(865, 110);
            this.panelSuboptions.TabIndex = 1;
            // 
            // radioButtonSuboptionOne
            // 
            this.radioButtonSuboptionOne.AutoSize = true;
            this.radioButtonSuboptionOne.Location = new System.Drawing.Point(20, 19);
            this.radioButtonSuboptionOne.Name = "radioButtonSuboptionOne";
            this.radioButtonSuboptionOne.Size = new System.Drawing.Size(186, 29);
            this.radioButtonSuboptionOne.TabIndex = 0;
            this.radioButtonSuboptionOne.TabStop = true;
            this.radioButtonSuboptionOne.Text = "Suboption &One";
            this.radioButtonSuboptionOne.UseVisualStyleBackColor = true;
            // 
            // radioButtonSuboptionTwo
            // 
            this.radioButtonSuboptionTwo.AutoSize = true;
            this.radioButtonSuboptionTwo.Location = new System.Drawing.Point(245, 19);
            this.radioButtonSuboptionTwo.Name = "radioButtonSuboptionTwo";
            this.radioButtonSuboptionTwo.Size = new System.Drawing.Size(186, 29);
            this.radioButtonSuboptionTwo.TabIndex = 1;
            this.radioButtonSuboptionTwo.TabStop = true;
            this.radioButtonSuboptionTwo.Text = "Suboption &Two";
            this.radioButtonSuboptionTwo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "Appointment One";
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleName = "Appointment Two";
            this.dateTimePicker2.Location = new System.Drawing.Point(524, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 31);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // radioButtonSecond
            // 
            this.radioButtonSecond.AutoSize = true;
            this.radioButtonSecond.Location = new System.Drawing.Point(8, 243);
            this.radioButtonSecond.Name = "radioButtonSecond";
            this.radioButtonSecond.Size = new System.Drawing.Size(185, 29);
            this.radioButtonSecond.TabIndex = 2;
            this.radioButtonSecond.TabStop = true;
            this.radioButtonSecond.Text = "&Second Option";
            this.radioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // labelSecondOptionInstructions
            // 
            this.labelSecondOptionInstructions.AutoSize = true;
            this.labelSecondOptionInstructions.Location = new System.Drawing.Point(35, 280);
            this.labelSecondOptionInstructions.Name = "labelSecondOptionInstructions";
            this.labelSecondOptionInstructions.Size = new System.Drawing.Size(336, 25);
            this.labelSecondOptionInstructions.TabIndex = 3;
            this.labelSecondOptionInstructions.Text = "Instructions for the second option.";
            // 
            // labelFirstChoice
            // 
            this.labelFirstChoice.AutoSize = true;
            this.labelFirstChoice.Location = new System.Drawing.Point(59, 449);
            this.labelFirstChoice.Name = "labelFirstChoice";
            this.labelFirstChoice.Size = new System.Drawing.Size(133, 25);
            this.labelFirstChoice.TabIndex = 2;
            this.labelFirstChoice.Text = "First &Choice:";
            // 
            // textBoxFirstChoice
            // 
            this.textBoxFirstChoice.Location = new System.Drawing.Point(195, 443);
            this.textBoxFirstChoice.Name = "textBoxFirstChoice";
            this.textBoxFirstChoice.Size = new System.Drawing.Size(418, 31);
            this.textBoxFirstChoice.TabIndex = 3;
            // 
            // buttonBrowseFirst
            // 
            this.buttonBrowseFirst.AccessibleName = "Browse First Choice";
            this.buttonBrowseFirst.Location = new System.Drawing.Point(627, 440);
            this.buttonBrowseFirst.Name = "buttonBrowseFirst";
            this.buttonBrowseFirst.Size = new System.Drawing.Size(129, 39);
            this.buttonBrowseFirst.TabIndex = 4;
            this.buttonBrowseFirst.Text = "&Browse";
            this.buttonBrowseFirst.UseVisualStyleBackColor = true;
            // 
            // buttonSecondBrowse
            // 
            this.buttonSecondBrowse.AccessibleName = "Browse Second Choice";
            this.buttonSecondBrowse.Location = new System.Drawing.Point(627, 515);
            this.buttonSecondBrowse.Name = "buttonSecondBrowse";
            this.buttonSecondBrowse.Size = new System.Drawing.Size(129, 39);
            this.buttonSecondBrowse.TabIndex = 7;
            this.buttonSecondBrowse.Text = "B&rowse";
            this.buttonSecondBrowse.UseVisualStyleBackColor = true;
            // 
            // textBoxSecondChoice
            // 
            this.textBoxSecondChoice.Location = new System.Drawing.Point(195, 518);
            this.textBoxSecondChoice.Name = "textBoxSecondChoice";
            this.textBoxSecondChoice.Size = new System.Drawing.Size(418, 31);
            this.textBoxSecondChoice.TabIndex = 6;
            // 
            // labelSecondChoice
            // 
            this.labelSecondChoice.AutoSize = true;
            this.labelSecondChoice.Location = new System.Drawing.Point(28, 520);
            this.labelSecondChoice.Name = "labelSecondChoice";
            this.labelSecondChoice.Size = new System.Drawing.Size(164, 25);
            this.labelSecondChoice.TabIndex = 5;
            this.labelSecondChoice.Text = "Second C&hoice:";
            // 
            // labelThirdchoice
            // 
            this.labelThirdchoice.AutoSize = true;
            this.labelThirdchoice.Location = new System.Drawing.Point(48, 584);
            this.labelThirdchoice.Name = "labelThirdchoice";
            this.labelThirdchoice.Size = new System.Drawing.Size(134, 25);
            this.labelThirdchoice.TabIndex = 8;
            this.labelThirdchoice.Text = "Third Choic&e";
            // 
            // comboBoxThirdChoice
            // 
            this.comboBoxThirdChoice.FormattingEnabled = true;
            this.comboBoxThirdChoice.Location = new System.Drawing.Point(195, 582);
            this.comboBoxThirdChoice.Name = "comboBoxThirdChoice";
            this.comboBoxThirdChoice.Size = new System.Drawing.Size(121, 33);
            this.comboBoxThirdChoice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 699);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.groupBoxContent);
            this.Controls.Add(this.labelFirstChoice);
            this.Controls.Add(this.textBoxFirstChoice);
            this.Controls.Add(this.buttonBrowseFirst);
            this.Controls.Add(this.labelSecondChoice);
            this.Controls.Add(this.textBoxSecondChoice);
            this.Controls.Add(this.buttonSecondBrowse);
            this.Controls.Add(this.labelThirdchoice);
            this.Controls.Add(this.comboBoxThirdChoice);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UIA Hierarchy Test";
            this.groupBoxContent.ResumeLayout(false);
            this.groupBoxContent.PerformLayout();
            this.panelSuboptions.ResumeLayout(false);
            this.panelSuboptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.GroupBox groupBoxContent;
        private System.Windows.Forms.Label labelSecondOptionInstructions;
        private System.Windows.Forms.RadioButton radioButtonSecond;
        private System.Windows.Forms.Panel panelSuboptions;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonSuboptionTwo;
        private System.Windows.Forms.RadioButton radioButtonSuboptionOne;
        private System.Windows.Forms.RadioButton radioButtonFirst;
        private System.Windows.Forms.Label labelFirstChoice;
        private System.Windows.Forms.TextBox textBoxFirstChoice;
        private System.Windows.Forms.Button buttonBrowseFirst;
        private System.Windows.Forms.Button buttonSecondBrowse;
        private System.Windows.Forms.TextBox textBoxSecondChoice;
        private System.Windows.Forms.Label labelSecondChoice;
        private System.Windows.Forms.Label labelThirdchoice;
        private System.Windows.Forms.ComboBox comboBoxThirdChoice;
    }
}

