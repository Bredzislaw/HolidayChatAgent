namespace HolidayChatAgent
{
    partial class HolidayDestinations
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.holidayDestinationGrid = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayDestinationGrid
            // 
            this.holidayDestinationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holidayDestinationGrid.Location = new System.Drawing.Point(0, 0);
            this.holidayDestinationGrid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // 
            // 
            this.holidayDestinationGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.holidayDestinationGrid.Name = "holidayDestinationGrid";
            this.holidayDestinationGrid.Size = new System.Drawing.Size(800, 450);
            this.holidayDestinationGrid.TabIndex = 0;
            this.holidayDestinationGrid.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.holidayDestinations_CellClick);
            // 
            // HolidayDestinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.holidayDestinationGrid);
            this.Name = "HolidayDestinations";
            this.Text = "Holiday Destinations";
            this.Load += new System.EventHandler(this.holidayDestinations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView holidayDestinationGrid;
    }
}