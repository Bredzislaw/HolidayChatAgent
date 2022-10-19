namespace HolidayChatAgent
{
    partial class BookingPreview
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblReferenceValue = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblHotelNameValue = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(660, 390);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(267, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 32);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Booking confirmation";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(33, 132);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(62, 15);
            this.lblReference.TabIndex = 6;
            this.lblReference.Text = "Reference:";
            // 
            // lblReferenceValue
            // 
            this.lblReferenceValue.AutoSize = true;
            this.lblReferenceValue.Location = new System.Drawing.Point(101, 132);
            this.lblReferenceValue.Name = "lblReferenceValue";
            this.lblReferenceValue.Size = new System.Drawing.Size(49, 15);
            this.lblReferenceValue.TabIndex = 7;
            this.lblReferenceValue.Text = "refValue";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.Location = new System.Drawing.Point(204, 91);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(396, 25);
            this.lblSubtitle.TabIndex = 8;
            this.lblSubtitle.Text = "Please check and confirm the booking details:";
            // 
            // lblHotelNameValue
            // 
            this.lblHotelNameValue.AutoSize = true;
            this.lblHotelNameValue.Location = new System.Drawing.Point(101, 166);
            this.lblHotelNameValue.Name = "lblHotelNameValue";
            this.lblHotelNameValue.Size = new System.Drawing.Size(62, 15);
            this.lblHotelNameValue.TabIndex = 10;
            this.lblHotelNameValue.Text = "hotelValue";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Location = new System.Drawing.Point(33, 166);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(72, 15);
            this.lblHotelName.TabIndex = 9;
            this.lblHotelName.Text = "Hotel name:";
            // 
            // BookingPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHotelNameValue);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblReferenceValue);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "BookingPreview";
            this.Text = "BookingPreview";
            this.Load += new System.EventHandler(this.BookingPreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblReference;
        private Label lblReferenceValue;
        private Label lblSubtitle;
        private Label lblHotelNameValue;
        private Label lblHotelName;
    }
}