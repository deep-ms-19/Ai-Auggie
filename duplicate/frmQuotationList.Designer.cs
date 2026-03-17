// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
//####using ExceptionManager;
using System.Data;
// End of VB project level imports

using DWERP;

namespace DWERP
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class frmQuotationList : DevExpress.XtraEditors.XtraForm
		{
		
		// ''Form overrides dispose to clean up the component list.
		//'<System.Diagnostics.DebuggerNonUserCode()> _
		//'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		//'    If disposing AndAlso components IsNot Nothing Then
		//'        components.Dispose()
		//'    End If
		//'    MyBase.Dispose(disposing)
		//'End Sub
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucQuotationList1 = new DWERP.Controls.Quotation.ucQuotationList();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.ucQuotationList1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1276, 622);
            this.PanelControl1.TabIndex = 0;
            // 
            // ucQuotationList1
            // 
            this.ucQuotationList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuotationList1.LayoutFile = "";
            this.ucQuotationList1.Location = new System.Drawing.Point(0, 0);
            this.ucQuotationList1.Name = "ucQuotationList1";
            this.ucQuotationList1.Size = new System.Drawing.Size(1276, 622);
            this.ucQuotationList1.TabIndex = 0;
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 622);
            this.Controls.Add(this.PanelControl1);
            this.Name = "frmQuotationList";
            this.Text = "frmQuotationList";
            this.Load += new System.EventHandler(this.frmQuotationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal DevExpress.XtraEditors.PanelControl PanelControl1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components;
        private Controls.Quotation.ucQuotationList ucQuotationList1;
    }
	
}
