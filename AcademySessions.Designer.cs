namespace FitnessApplication
{
    partial class AcademySessions
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
            this.DatePickers = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.textBoxPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.textBoxAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DurationPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.sfButtonPrevious = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonNextSession = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabelNumSession = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickers
            // 
            this.DatePickers.DateTimeIcon = null;
            this.DatePickers.Enabled = false;
            this.DatePickers.Location = new System.Drawing.Point(614, 37);
            this.DatePickers.Name = "DatePickers";
            this.DatePickers.Size = new System.Drawing.Size(146, 38);
            this.DatePickers.TabIndex = 76;
            this.DatePickers.ToolTipText = "";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AccessibilityEnabled = true;
            this.textBoxPrice.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxPrice.CurrencySymbol = "EGP ";
            this.textBoxPrice.DecimalValue = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.textBoxPrice.Location = new System.Drawing.Point(191, 336);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 75;
            this.textBoxPrice.Text = "EGP 1.00";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxAddress.Location = new System.Drawing.Point(191, 153);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddress.Size = new System.Drawing.Size(222, 92);
            this.textBoxAddress.TabIndex = 74;
            this.textBoxAddress.ThemeName = "Metro";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxDescription.Location = new System.Drawing.Point(191, 35);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(222, 92);
            this.textBoxDescription.TabIndex = 73;
            this.textBoxDescription.ThemeName = "Metro";
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Location = new System.Drawing.Point(302, 336);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(57, 20);
            this.checkBoxFree.TabIndex = 72;
            this.checkBoxFree.Text = "Free";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 71;
            this.label5.Text = "Address:";
            // 
            // DurationPicker
            // 
            this.DurationPicker.CustomFormat = "hh:mm";
            this.DurationPicker.Enabled = false;
            this.DurationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationPicker.Location = new System.Drawing.Point(614, 153);
            this.DurationPicker.Name = "DurationPicker";
            this.DurationPicker.ShowUpDown = true;
            this.DurationPicker.Size = new System.Drawing.Size(95, 22);
            this.DurationPicker.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "Time:";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Enabled = false;
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(614, 98);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(95, 22);
            this.TimePicker.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "Date:";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(191, 276);
            this.numericUpDownLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.ReadOnly = true;
            this.numericUpDownLimit.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLimit.TabIndex = 65;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Limit members:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(42, 332);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 22);
            this.labelPassword.TabIndex = 63;
            this.labelPassword.Text = "Price:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(41, 35);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 22);
            this.labelDescription.TabIndex = 62;
            this.labelDescription.Text = "Description:";
            // 
            // sfButtonPrevious
            // 
            this.sfButtonPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonPrevious.Location = new System.Drawing.Point(242, 418);
            this.sfButtonPrevious.Name = "sfButtonPrevious";
            this.sfButtonPrevious.Size = new System.Drawing.Size(96, 28);
            this.sfButtonPrevious.TabIndex = 78;
            this.sfButtonPrevious.Text = "Previous";
            // 
            // sfButtonNextSession
            // 
            this.sfButtonNextSession.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonNextSession.Location = new System.Drawing.Point(523, 418);
            this.sfButtonNextSession.Name = "sfButtonNextSession";
            this.sfButtonNextSession.Size = new System.Drawing.Size(96, 28);
            this.sfButtonNextSession.TabIndex = 79;
            this.sfButtonNextSession.Text = "Next";
            // 
            // autoLabelNumSession
            // 
            this.autoLabelNumSession.Location = new System.Drawing.Point(377, 430);
            this.autoLabelNumSession.Name = "autoLabelNumSession";
            this.autoLabelNumSession.Size = new System.Drawing.Size(104, 16);
            this.autoLabelNumSession.TabIndex = 80;
            this.autoLabelNumSession.Text = "Session #1 of 20";
            // 
            // AcademySessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 509);
            this.Controls.Add(this.autoLabelNumSession);
            this.Controls.Add(this.sfButtonNextSession);
            this.Controls.Add(this.sfButtonPrevious);
            this.Controls.Add(this.DatePickers);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxFree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DurationPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDescription);
            this.Name = "AcademySessions";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Sessions";
            this.Load += new System.EventHandler(this.AcademySessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Input.SfDateTimeEdit DatePickers;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox textBoxPrice;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxAddress;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DurationPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDescription;
        private Syncfusion.WinForms.Controls.SfButton sfButtonPrevious;
        private Syncfusion.WinForms.Controls.SfButton sfButtonNextSession;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelNumSession;
    }
}