namespace HolidayChatAgent
{
    partial class PossibleDestinations
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
            this.radNavigationView1 = new Telerik.WinControls.UI.RadNavigationView();
            this.radPageViewNorthAmerica = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewEurope = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewMorocco = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radNavigationView1)).BeginInit();
            this.radNavigationView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNavigationView1
            // 
            this.radNavigationView1.CollapsedPaneWidth = 50;
            this.radNavigationView1.CompactModeThresholdWidth = 801;
            this.radNavigationView1.Controls.Add(this.radPageViewNorthAmerica);
            this.radNavigationView1.Controls.Add(this.radPageViewEurope);
            this.radNavigationView1.Controls.Add(this.radPageViewMorocco);
            this.radNavigationView1.Controls.Add(this.radPageViewPage4);
            this.radNavigationView1.Controls.Add(this.radPageViewPage5);
            this.radNavigationView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radNavigationView1.ExpandedModeThresholdWidth = 1260;
            this.radNavigationView1.ExpandedPaneWidth = 350;
            this.radNavigationView1.HeaderHeight = 38;
            this.radNavigationView1.HierarchyIndent = 25;
            this.radNavigationView1.Location = new System.Drawing.Point(0, 0);
            this.radNavigationView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNavigationView1.Name = "radNavigationView1";
            this.radNavigationView1.SelectedPage = this.radPageViewNorthAmerica;
            this.radNavigationView1.Size = new System.Drawing.Size(1397, 731);
            this.radNavigationView1.TabIndex = 0;
            // 
            // radPageViewNorthAmerica
            // 
            this.radPageViewNorthAmerica.ItemSize = new System.Drawing.SizeF(160F, 38F);
            this.radPageViewNorthAmerica.Location = new System.Drawing.Point(351, 38);
            this.radPageViewNorthAmerica.Name = "radPageViewNorthAmerica";
            this.radPageViewNorthAmerica.Size = new System.Drawing.Size(1045, 692);
            this.radPageViewNorthAmerica.Text = "North America";
            // 
            // radPageViewEurope
            // 
            this.radPageViewEurope.ItemSize = new System.Drawing.SizeF(160F, 38F);
            this.radPageViewEurope.Location = new System.Drawing.Point(351, 38);
            this.radPageViewEurope.Name = "radPageViewEurope";
            this.radPageViewEurope.Size = new System.Drawing.Size(1045, 692);
            this.radPageViewEurope.Text = "Europe";
            // 
            // radPageViewMorocco
            // 
            this.radPageViewMorocco.ItemSize = new System.Drawing.SizeF(160F, 38F);
            this.radPageViewMorocco.Location = new System.Drawing.Point(351, 38);
            this.radPageViewMorocco.Name = "radPageViewMorocco";
            this.radPageViewMorocco.Size = new System.Drawing.Size(1045, 692);
            this.radPageViewMorocco.Text = "radPageViewMorocco";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(160F, 38F);
            this.radPageViewPage4.Location = new System.Drawing.Point(351, 38);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(1045, 692);
            this.radPageViewPage4.Text = "radPageViewPage4";
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.ItemSize = new System.Drawing.SizeF(160F, 38F);
            this.radPageViewPage5.Location = new System.Drawing.Point(351, 38);
            this.radPageViewPage5.Name = "radPageViewPage5";
            this.radPageViewPage5.Size = new System.Drawing.Size(1045, 692);
            this.radPageViewPage5.Text = "radPageViewPage5";
            // 
            // PossibleDestinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 731);
            this.Controls.Add(this.radNavigationView1);
            this.Name = "PossibleDestinations";
            this.Text = "PossibleDestinations";
            ((System.ComponentModel.ISupportInitialize)(this.radNavigationView1)).EndInit();
            this.radNavigationView1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadNavigationView radNavigationView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewNorthAmerica;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewEurope;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewMorocco;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
    }
}