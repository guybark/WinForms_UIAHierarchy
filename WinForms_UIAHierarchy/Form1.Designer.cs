
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBoxContent.SuspendLayout();
            this.panelSuboptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(13, 13);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(234, 25);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "Some helpful instructions.";
            // 
            // groupBoxContent
            // 
            this.groupBoxContent.Controls.Add(this.radioButtonFirst);
            this.groupBoxContent.Controls.Add(this.panelSuboptions);
            this.groupBoxContent.Controls.Add(this.radioButtonSecond);
            this.groupBoxContent.Controls.Add(this.labelSecondOptionInstructions);
            this.groupBoxContent.Location = new System.Drawing.Point(18, 66);
            this.groupBoxContent.Name = "groupBoxContent";
            this.groupBoxContent.Size = new System.Drawing.Size(874, 335);
            this.groupBoxContent.TabIndex = 2;
            this.groupBoxContent.TabStop = false;
            this.groupBoxContent.Text = "&Content";
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(7, 45);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(137, 29);
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
            this.panelSuboptions.Location = new System.Drawing.Point(48, 90);
            this.panelSuboptions.Name = "panelSuboptions";
            this.panelSuboptions.Size = new System.Drawing.Size(793, 106);
            this.panelSuboptions.TabIndex = 1;
            // 
            // radioButtonSuboptionOne
            // 
            this.radioButtonSuboptionOne.AutoSize = true;
            this.radioButtonSuboptionOne.Location = new System.Drawing.Point(18, 18);
            this.radioButtonSuboptionOne.Name = "radioButtonSuboptionOne";
            this.radioButtonSuboptionOne.Size = new System.Drawing.Size(169, 29);
            this.radioButtonSuboptionOne.TabIndex = 0;
            this.radioButtonSuboptionOne.TabStop = true;
            this.radioButtonSuboptionOne.Text = "Suboption &One";
            this.radioButtonSuboptionOne.UseVisualStyleBackColor = true;
            // 
            // radioButtonSuboptionTwo
            // 
            this.radioButtonSuboptionTwo.AutoSize = true;
            this.radioButtonSuboptionTwo.Location = new System.Drawing.Point(225, 18);
            this.radioButtonSuboptionTwo.Name = "radioButtonSuboptionTwo";
            this.radioButtonSuboptionTwo.Size = new System.Drawing.Size(169, 29);
            this.radioButtonSuboptionTwo.TabIndex = 1;
            this.radioButtonSuboptionTwo.TabStop = true;
            this.radioButtonSuboptionTwo.Text = "Suboption &Two";
            this.radioButtonSuboptionTwo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "Appointment One";
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleName = "Appointment Two";
            this.dateTimePicker2.Location = new System.Drawing.Point(480, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // radioButtonSecond
            // 
            this.radioButtonSecond.AutoSize = true;
            this.radioButtonSecond.Location = new System.Drawing.Point(7, 233);
            this.radioButtonSecond.Name = "radioButtonSecond";
            this.radioButtonSecond.Size = new System.Drawing.Size(168, 29);
            this.radioButtonSecond.TabIndex = 2;
            this.radioButtonSecond.TabStop = true;
            this.radioButtonSecond.Text = "&Second Option";
            this.radioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // labelSecondOptionInstructions
            // 
            this.labelSecondOptionInstructions.AutoSize = true;
            this.labelSecondOptionInstructions.Location = new System.Drawing.Point(32, 269);
            this.labelSecondOptionInstructions.Name = "labelSecondOptionInstructions";
            this.labelSecondOptionInstructions.Size = new System.Drawing.Size(302, 25);
            this.labelSecondOptionInstructions.TabIndex = 3;
            this.labelSecondOptionInstructions.Text = "Instructions for the second option.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 498);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.groupBoxContent);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
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
    }
}

