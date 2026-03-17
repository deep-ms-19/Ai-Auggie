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
using DWERP.Forms.GEN;

namespace DWERP
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frmVersionHistory : ColoredHeaderForm
    {
		
		//Form overrides dispose to clean up the component list.
		//[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		//{
		//	try
		//	{
		//		if (disposing && components != null)
		//		{
		//			components.Dispose();
		//		}
		//	}
		//	finally
		//	{
		//		base.Dispose(disposing);
		//	}
		//}
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.gcVersionHistory = new DevExpress.XtraGrid.GridControl();
            this.gvVersionHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RptViewVersionButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVersionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVersionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RptViewVersionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(327, 165);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(128, 25);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Set as Current Version";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gcVersionHistory
            // 
            this.gcVersionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVersionHistory.Location = new System.Drawing.Point(2, 2);
            this.gcVersionHistory.MainView = this.gvVersionHistory;
            this.gcVersionHistory.Name = "gcVersionHistory";
            this.gcVersionHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RptViewVersionButton});
            this.gcVersionHistory.Size = new System.Drawing.Size(555, 144);
            this.gcVersionHistory.TabIndex = 0;
            this.gcVersionHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVersionHistory});
            // 
            // gvVersionHistory
            // 
            this.gvVersionHistory.ColumnPanelRowHeight = 35;
            this.gvVersionHistory.GridControl = this.gcVersionHistory;
            this.gvVersionHistory.Name = "gvVersionHistory";
            this.gvVersionHistory.OptionsCustomization.AllowSort = false;
            this.gvVersionHistory.OptionsView.ShowGroupPanel = false;
            this.gvVersionHistory.RowHeight = 25;
            // 
            // RptViewVersionButton
            // 
            this.RptViewVersionButton.AccessibleName = "";
            this.RptViewVersionButton.AutoHeight = false;
            editorButtonImageOptions1.Image = global::My.Resources.Resources.ERP16_Preview;
            this.RptViewVersionButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Quotation", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "View Quotation", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.RptViewVersionButton.Name = "RptViewVersionButton";
            this.RptViewVersionButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RptViewVersionButton.Click += new System.EventHandler(this.RptViewVersionButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.gcVersionHistory);
            this.PanelControl1.Location = new System.Drawing.Point(6, 9);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(559, 148);
            this.PanelControl1.TabIndex = 0;
            // 
            // frmVersionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 197);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVersionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Version History";
            this.Load += new System.EventHandler(this.frmVersionfrmVersionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVersionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVersionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RptViewVersionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
		internal DevExpress.XtraEditors.SimpleButton btnLoad;
		internal DevExpress.XtraGrid.GridControl gcVersionHistory;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvVersionHistory;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;


        //Form overrides dispose to clean up the component list.
        //<System.Diagnostics.DebuggerNonUserCode()> _
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RptViewVersionButton;
    }
	
}
