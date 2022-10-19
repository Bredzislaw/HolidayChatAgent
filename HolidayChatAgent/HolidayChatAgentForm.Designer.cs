namespace HolidayChatAgent
{
    partial class HolidayChatAgentForm
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
            this.mainRadChat = new Telerik.WinControls.UI.RadChat();
            ((System.ComponentModel.ISupportInitialize)(this.mainRadChat)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRadChat
            // 
            this.mainRadChat.AvatarSize = new System.Drawing.SizeF(106.8115F, 106.8115F);
            this.mainRadChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRadChat.Location = new System.Drawing.Point(0, 0);
            this.mainRadChat.Margin = new System.Windows.Forms.Padding(12);
            this.mainRadChat.Name = "mainRadChat";
            this.mainRadChat.Size = new System.Drawing.Size(453, 527);
            this.mainRadChat.TabIndex = 0;
            this.mainRadChat.Text = "radChat1";
            this.mainRadChat.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            this.mainRadChat.SendMessage += new Telerik.WinControls.UI.SendMessageEventHandler(this.mainRadChat_SendMessage);
            // 
            // HolidayChatAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 527);
            this.Controls.Add(this.mainRadChat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidayChatAgentForm";
            this.Text = "First Holiday Ltd";
            this.Load += new System.EventHandler(this.HolidayChatAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRadChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadChat mainRadChat;
    }
}