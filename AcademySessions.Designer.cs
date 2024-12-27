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
            this.textBoxExtSearchSession = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.labelStatus = new System.Windows.Forms.Label();
            this.sfButtonCancelEditing = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonUpload = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonDelete = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonStats = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonEdit = new Syncfusion.WinForms.Controls.SfButton();
            this.numericUpDownNumSeats = new System.Windows.Forms.NumericUpDown();
            this.sfButtonReserve = new Syncfusion.WinForms.Controls.SfButton();
            this.labelseats = new System.Windows.Forms.Label();
            this.labelReservationExists = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtSearchSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickers
            // 
            this.DatePickers.DateTimeIcon = null;
            this.DatePickers.Enabled = false;
            this.DatePickers.Location = new System.Drawing.Point(607, 116);
            this.DatePickers.Name = "DatePickers";
            this.DatePickers.Size = new System.Drawing.Size(146, 38);
            this.DatePickers.TabIndex = 76;
            this.DatePickers.ToolTipText = "";
            this.DatePickers.Value = new System.DateTime(2024, 12, 26, 0, 0, 0, 0);
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
            this.textBoxPrice.Location = new System.Drawing.Point(184, 415);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 75;
            this.textBoxPrice.Text = "EGP 1.00";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxAddress.Location = new System.Drawing.Point(184, 232);
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
            this.textBoxDescription.Location = new System.Drawing.Point(184, 114);
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
            this.checkBoxFree.Enabled = false;
            this.checkBoxFree.Location = new System.Drawing.Point(295, 415);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(57, 20);
            this.checkBoxFree.TabIndex = 72;
            this.checkBoxFree.Text = "Free";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            this.checkBoxFree.CheckedChanged += new System.EventHandler(this.checkBoxFree_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 232);
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
            this.DurationPicker.Location = new System.Drawing.Point(607, 232);
            this.DurationPicker.Name = "DurationPicker";
            this.DurationPicker.ShowUpDown = true;
            this.DurationPicker.Size = new System.Drawing.Size(95, 22);
            this.DurationPicker.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 177);
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
            this.TimePicker.Location = new System.Drawing.Point(607, 177);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(95, 22);
            this.TimePicker.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "Date:";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(184, 355);
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
            this.label1.Location = new System.Drawing.Point(35, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Limit members:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(35, 411);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 22);
            this.labelPassword.TabIndex = 63;
            this.labelPassword.Text = "Price:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(34, 114);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 22);
            this.labelDescription.TabIndex = 62;
            this.labelDescription.Text = "Description:";
            // 
            // sfButtonPrevious
            // 
            this.sfButtonPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonPrevious.Location = new System.Drawing.Point(256, 503);
            this.sfButtonPrevious.Name = "sfButtonPrevious";
            this.sfButtonPrevious.Size = new System.Drawing.Size(96, 22);
            this.sfButtonPrevious.TabIndex = 78;
            this.sfButtonPrevious.Text = "Previous";
            this.sfButtonPrevious.Click += new System.EventHandler(this.sfButtonPrevious_Click);
            // 
            // sfButtonNextSession
            // 
            this.sfButtonNextSession.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonNextSession.Location = new System.Drawing.Point(488, 503);
            this.sfButtonNextSession.Name = "sfButtonNextSession";
            this.sfButtonNextSession.Size = new System.Drawing.Size(96, 22);
            this.sfButtonNextSession.TabIndex = 79;
            this.sfButtonNextSession.Text = "Next";
            this.sfButtonNextSession.Click += new System.EventHandler(this.sfButtonNextSession_Click);
            // 
            // autoLabelNumSession
            // 
            this.autoLabelNumSession.Location = new System.Drawing.Point(367, 535);
            this.autoLabelNumSession.Name = "autoLabelNumSession";
            this.autoLabelNumSession.Size = new System.Drawing.Size(104, 16);
            this.autoLabelNumSession.TabIndex = 80;
            this.autoLabelNumSession.Text = "Session #1 of 20";
            this.autoLabelNumSession.Click += new System.EventHandler(this.autoLabelNumSession_Click);
            // 
            // textBoxExtSearchSession
            // 
            this.textBoxExtSearchSession.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxExtSearchSession.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxExtSearchSession.Location = new System.Drawing.Point(367, 503);
            this.textBoxExtSearchSession.Name = "textBoxExtSearchSession";
            this.textBoxExtSearchSession.Size = new System.Drawing.Size(106, 22);
            this.textBoxExtSearchSession.TabIndex = 81;
            this.textBoxExtSearchSession.Text = "Search Session";
            this.textBoxExtSearchSession.Click += new System.EventHandler(this.textBoxExtSearchSession_Click);
            this.textBoxExtSearchSession.TextChanged += new System.EventHandler(this.textBoxExt1_TextChanged);
            this.textBoxExtSearchSession.Enter += new System.EventHandler(this.textBoxExtSearchSession_Enter);
            this.textBoxExtSearchSession.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExtSearchSession_KeyPress);
            this.textBoxExtSearchSession.MouseEnter += new System.EventHandler(this.textBoxExtSearchSession_MouseEnter);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(267, 58);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 22);
            this.labelStatus.TabIndex = 88;
            this.labelStatus.Text = "Status:";
            // 
            // sfButtonCancelEditing
            // 
            this.sfButtonCancelEditing.BackColor = System.Drawing.Color.White;
            this.sfButtonCancelEditing.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonCancelEditing.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonCancelEditing.Location = new System.Drawing.Point(21, 17);
            this.sfButtonCancelEditing.Name = "sfButtonCancelEditing";
            this.sfButtonCancelEditing.Size = new System.Drawing.Size(40, 43);
            this.sfButtonCancelEditing.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonCancelEditing.Style.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonCancelEditing.Style.Image = global::FitnessApplication.Properties.Resources.cross;
            this.sfButtonCancelEditing.TabIndex = 86;
            this.sfButtonCancelEditing.TabStop = false;
            this.sfButtonCancelEditing.UseVisualStyleBackColor = false;
            this.sfButtonCancelEditing.Visible = false;
            this.sfButtonCancelEditing.Click += new System.EventHandler(this.sfButtonCancelEditing_Click);
            // 
            // sfButtonUpload
            // 
            this.sfButtonUpload.BackColor = System.Drawing.Color.White;
            this.sfButtonUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonUpload.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonUpload.Location = new System.Drawing.Point(161, 17);
            this.sfButtonUpload.Name = "sfButtonUpload";
            this.sfButtonUpload.Size = new System.Drawing.Size(40, 43);
            this.sfButtonUpload.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonUpload.Style.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonUpload.Style.Image = global::FitnessApplication.Properties.Resources.upload;
            this.sfButtonUpload.TabIndex = 85;
            this.sfButtonUpload.TabStop = false;
            this.sfButtonUpload.UseVisualStyleBackColor = false;
            this.sfButtonUpload.Visible = false;
            this.sfButtonUpload.Click += new System.EventHandler(this.sfButtonUpload_Click);
            // 
            // sfButtonDelete
            // 
            this.sfButtonDelete.BackColor = System.Drawing.Color.White;
            this.sfButtonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonDelete.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfButtonDelete.Location = new System.Drawing.Point(67, 17);
            this.sfButtonDelete.Name = "sfButtonDelete";
            this.sfButtonDelete.Size = new System.Drawing.Size(40, 43);
            this.sfButtonDelete.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonDelete.Style.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonDelete.Style.Image = global::FitnessApplication.Properties.Resources.trash;
            this.sfButtonDelete.TabIndex = 84;
            this.sfButtonDelete.TabStop = false;
            this.sfButtonDelete.UseVisualStyleBackColor = true;
            this.sfButtonDelete.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // sfButtonStats
            // 
            this.sfButtonStats.BackColor = System.Drawing.Color.White;
            this.sfButtonStats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonStats.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonStats.Location = new System.Drawing.Point(115, 17);
            this.sfButtonStats.Name = "sfButtonStats";
            this.sfButtonStats.Size = new System.Drawing.Size(40, 43);
            this.sfButtonStats.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonStats.Style.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonStats.Style.Image = global::FitnessApplication.Properties.Resources.stats;
            this.sfButtonStats.TabIndex = 83;
            this.sfButtonStats.TabStop = false;
            this.sfButtonStats.UseVisualStyleBackColor = false;
            this.sfButtonStats.Click += new System.EventHandler(this.sfButtonStats_Click);
            // 
            // sfButtonEdit
            // 
            this.sfButtonEdit.BackColor = System.Drawing.Color.White;
            this.sfButtonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonEdit.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonEdit.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfButtonEdit.Location = new System.Drawing.Point(18, 17);
            this.sfButtonEdit.Name = "sfButtonEdit";
            this.sfButtonEdit.Size = new System.Drawing.Size(40, 43);
            this.sfButtonEdit.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonEdit.Style.ForeColor = System.Drawing.Color.Transparent;
            this.sfButtonEdit.Style.Image = global::FitnessApplication.Properties.Resources.pencil;
            this.sfButtonEdit.TabIndex = 82;
            this.sfButtonEdit.TabStop = false;
            this.sfButtonEdit.UseVisualStyleBackColor = false;
            this.sfButtonEdit.Click += new System.EventHandler(this.sfButtonEdit_Click);
            // 
            // numericUpDownNumSeats
            // 
            this.numericUpDownNumSeats.Location = new System.Drawing.Point(577, 386);
            this.numericUpDownNumSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumSeats.Name = "numericUpDownNumSeats";
            this.numericUpDownNumSeats.Size = new System.Drawing.Size(85, 22);
            this.numericUpDownNumSeats.TabIndex = 89;
            this.numericUpDownNumSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumSeats.Visible = false;
            // 
            // sfButtonReserve
            // 
            this.sfButtonReserve.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonReserve.Location = new System.Drawing.Point(668, 386);
            this.sfButtonReserve.Name = "sfButtonReserve";
            this.sfButtonReserve.Size = new System.Drawing.Size(85, 22);
            this.sfButtonReserve.TabIndex = 90;
            this.sfButtonReserve.Text = "Reserve";
            this.sfButtonReserve.Visible = false;
            this.sfButtonReserve.Click += new System.EventHandler(this.sfButtonReserve_Click);
            // 
            // labelseats
            // 
            this.labelseats.AutoSize = true;
            this.labelseats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseats.Location = new System.Drawing.Point(478, 386);
            this.labelseats.Name = "labelseats";
            this.labelseats.Size = new System.Drawing.Size(94, 22);
            this.labelseats.TabIndex = 91;
            this.labelseats.Text = "No. Seats:";
            this.labelseats.Visible = false;
            // 
            // labelReservationExists
            // 
            this.labelReservationExists.AutoSize = true;
            this.labelReservationExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationExists.ForeColor = System.Drawing.Color.IndianRed;
            this.labelReservationExists.Location = new System.Drawing.Point(584, 417);
            this.labelReservationExists.Name = "labelReservationExists";
            this.labelReservationExists.Size = new System.Drawing.Size(169, 16);
            this.labelReservationExists.TabIndex = 92;
            this.labelReservationExists.Text = "Reservation already exists.";
            // 
            // AcademySessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 683);
            this.Controls.Add(this.labelReservationExists);
            this.Controls.Add(this.labelseats);
            this.Controls.Add(this.sfButtonReserve);
            this.Controls.Add(this.numericUpDownNumSeats);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.sfButtonCancelEditing);
            this.Controls.Add(this.sfButtonUpload);
            this.Controls.Add(this.sfButtonDelete);
            this.Controls.Add(this.sfButtonStats);
            this.Controls.Add(this.sfButtonEdit);
            this.Controls.Add(this.textBoxExtSearchSession);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AcademySessions";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Sessions";
            this.Load += new System.EventHandler(this.AcademySessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtSearchSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumSeats)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExtSearchSession;
        private Syncfusion.WinForms.Controls.SfButton sfButtonEdit;
        private Syncfusion.WinForms.Controls.SfButton sfButtonStats;
        private Syncfusion.WinForms.Controls.SfButton sfButtonDelete;
        private Syncfusion.WinForms.Controls.SfButton sfButtonUpload;
        private Syncfusion.WinForms.Controls.SfButton sfButtonCancelEditing;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownNumSeats;
        private Syncfusion.WinForms.Controls.SfButton sfButtonReserve;
        private System.Windows.Forms.Label labelseats;
        private System.Windows.Forms.Label labelReservationExists;
    }
}