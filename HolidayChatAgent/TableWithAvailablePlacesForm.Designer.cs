﻿namespace HolidayChatAgent
{
    partial class TableWithAvailablePlacesForm
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
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.holidayDestinationGrid = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(94, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(487, 340);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // holidayDestinationGrid
            // 
            this.holidayDestinationGrid.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.holidayDestinationGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.holidayDestinationGrid.Name = "holidayDestinationGrid";
            this.holidayDestinationGrid.Size = new System.Drawing.Size(707, 286);
            this.holidayDestinationGrid.TabIndex = 3;
            // 
            // TableWithAvailablePlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 395);
            this.Controls.Add(this.holidayDestinationGrid);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableWithAvailablePlacesForm";
            this.Text = "Holiday Destinations";
            this.Load += new System.EventHandler(this.TableWithAvailablePlacesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDestinationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Button btnCancel;
        private Button btnConfirm;
        private Telerik.WinControls.UI.RadGridView holidayDestinationGrid;
    }
}