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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frmQuotationFollowUpList : DevExpress.XtraEditors.XtraForm
	{
		
		//Form overrides dispose to clean up the component list.
		////[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		////{
		////	if (disposing && components != null)
		////	{
		////		components.Dispose();
		////	}
		////	base.Dispose(disposing);
		////}
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuotationFollowUpList));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            this.ImageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnPOFilter = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnLayoutSetting = new DevExpress.XtraBars.BarButtonItem();
            this.cmbReportType = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemReportType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.btnCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.ExpandAll = new DevExpress.XtraBars.BarButtonItem();
            this.BarCompBranch = new DevExpress.XtraBars.BarEditItem();
            this.repCheckedComboBranch = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.RepCompBranch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCozy = new DevExpress.XtraBars.BarButtonItem();
            this.btnComfortable = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompact = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popAdd = new DevExpress.XtraBars.BarButtonItem();
            this.popEdit = new DevExpress.XtraBars.BarButtonItem();
            this.popDelete = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mnuResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mnuPrint = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopyPO = new DevExpress.XtraBars.BarButtonItem();
            this.popCopyPO = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFilter = new DevExpress.XtraBars.BarButtonItem();
            this.cmbPOType = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.LEPOType = new DevExpress.XtraBars.BarEditItem();
            this.RepPOType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnGoodsReceiptNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoodsReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiveBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gcQuotationChasing = new DevExpress.XtraGrid.GridControl();
            this.gvQuotationChasing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RepSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.PopupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.cmbQuotationStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.btnLogHistory = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemReportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckedComboBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepCompBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepPOType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuotationChasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuotationChasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuotationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageCollection2
            // 
            this.ImageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection2.ImageStream")));
            this.ImageCollection2.Images.SetKeyName(0, "feature_16x16.png");
            // 
            // btnResetLayout
            // 
            this.btnResetLayout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnResetLayout.Caption = "Reset Layout";
            this.btnResetLayout.Id = 4;
            this.btnResetLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetLayout.ImageOptions.Image")));
            this.btnResetLayout.Name = "btnResetLayout";
            this.btnResetLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Reset Layout";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Click here to reset layout of listing\r\n";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnResetLayout.SuperTip = superToolTip1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Refresh";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Click here to refresh the list\r\n";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnRefresh.SuperTip = superToolTip2;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnPOFilter
            // 
            this.btnPOFilter.Caption = "Filter";
            this.btnPOFilter.Id = 6;
            this.btnPOFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPOFilter.ImageOptions.Image")));
            this.btnPOFilter.Name = "btnPOFilter";
            this.btnPOFilter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem3.Text = "Filter  (Ctrl+F)";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Click here to filter the listing";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnPOFilter.SuperTip = superToolTip3;
            this.btnPOFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPOFilter_ItemClick);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "Export To Excel";
            this.btnExportToExcel.Id = 7;
            this.btnExportToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.ImageOptions.Image")));
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem4.Text = "Export To Excel";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Click here to export listing to excel\r\n";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.btnExportToExcel.SuperTip = superToolTip4;
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Print";
            this.btnPrint.Id = 48;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnLayoutSetting
            // 
            this.btnLayoutSetting.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnLayoutSetting.Caption = "Layout Setting";
            this.btnLayoutSetting.Id = 35;
            this.btnLayoutSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLayoutSetting.ImageOptions.Image")));
            this.btnLayoutSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLayoutSetting.ImageOptions.LargeImage")));
            this.btnLayoutSetting.Name = "btnLayoutSetting";
            this.btnLayoutSetting.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // cmbReportType
            // 
            this.cmbReportType.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.cmbReportType.Caption = "Report Type";
            this.cmbReportType.Edit = this.RepositoryItemReportType;
            this.cmbReportType.EditWidth = 170;
            this.cmbReportType.Id = 24;
            this.cmbReportType.Name = "cmbReportType";
            // 
            // RepositoryItemReportType
            // 
            this.RepositoryItemReportType.AutoHeight = false;
            this.RepositoryItemReportType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemReportType.Name = "RepositoryItemReportType";
            this.RepositoryItemReportType.SmallImages = this.ImageCollection2;
            this.RepositoryItemReportType.SelectedIndexChanged += new System.EventHandler(this.RepositoryItemReportType_SelectedIndexChanged);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Id = 27;
            this.btnCollapse.Name = "btnCollapse";
            // 
            // ExpandAll
            // 
            this.ExpandAll.Caption = "Expand All";
            this.ExpandAll.Id = 49;
            this.ExpandAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExpandAll.ImageOptions.Image")));
            this.ExpandAll.Name = "ExpandAll";
            this.ExpandAll.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.ExpandAll.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ExpandAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExpandAll_ItemClick);
            // 
            // BarCompBranch
            // 
            this.BarCompBranch.Caption = "Branch : ";
            this.BarCompBranch.Edit = this.repCheckedComboBranch;
            this.BarCompBranch.EditWidth = 417;
            this.BarCompBranch.Id = 22;
            this.BarCompBranch.Name = "BarCompBranch";
            this.BarCompBranch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            toolTipTitleItem5.Text = "Company Branch";
            toolTipItem5.LeftIndent = 6;
            toolTipItem5.Text = "Select company branch to see records branch wise";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.BarCompBranch.SuperTip = superToolTip5;
            this.BarCompBranch.EditValueChanged += new System.EventHandler(this.BarCompBranch_EditValueChanged);
            // 
            // repCheckedComboBranch
            // 
            this.repCheckedComboBranch.AutoHeight = false;
            this.repCheckedComboBranch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCheckedComboBranch.Name = "repCheckedComboBranch";
            // 
            // RepCompBranch
            // 
            this.RepCompBranch.AutoHeight = false;
            this.RepCompBranch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepCompBranch.DropDownRows = 4;
            this.RepCompBranch.Name = "RepCompBranch";
            this.RepCompBranch.NullText = "";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "Save Layout";
            this.btnSaveLayout.Id = 3;
            this.btnSaveLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveLayout.ImageOptions.Image")));
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem6.Text = "Save Layout";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "Click here to save layout of listing\r\n";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.btnSaveLayout.SuperTip = superToolTip6;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 880);
            // 
            // BarManager1
            // 
            this.BarManager1.AllowCustomization = false;
            this.BarManager1.AllowMoveBarOnToolbar = false;
            this.BarManager1.AllowQuickCustomization = false;
            this.BarManager1.AllowShowToolbarsPopup = false;
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar1});
            this.BarManager1.DockControls.Add(this.barDockControlTop);
            this.BarManager1.DockControls.Add(this.barDockControlBottom);
            this.BarManager1.DockControls.Add(this.barDockControlLeft);
            this.BarManager1.DockControls.Add(this.barDockControlRight);
            this.BarManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.BarManager1.Form = this;
            this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSaveLayout,
            this.btnResetLayout,
            this.btnRefresh,
            this.btnPOFilter,
            this.btnExportToExcel,
            this.btnPrint,
            this.btnLayoutSetting,
            this.cmbReportType,
            this.btnCollapse,
            this.ExpandAll,
            this.popAdd,
            this.popEdit,
            this.popDelete,
            this.mnuSaveLayout,
            this.mnuResetLayout,
            this.mnuPrint,
            this.mnuExportToExcel,
            this.btnCopyPO,
            this.popCopyPO,
            this.mnuFilter,
            this.cmbPOType,
            this.LEPOType,
            this.btnGoodsReceiptNote,
            this.btnGoodsReceipt,
            this.BarCompBranch,
            this.btnReceiveBarcode,
            this.btnCozy,
            this.btnComfortable,
            this.btnCompact,
            this.btnLogHistory});
            this.BarManager1.MaxItemId = 29;
            this.BarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemComboBox1,
            this.RepPOType,
            this.RepCompBranch,
            this.RepositoryItemReportType,
            this.repCheckedComboBranch});
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Tools";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar1.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.btnAdd, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ExpandAll, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPOFilter, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogHistory, true),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.BarCompBranch, "", false, true, true, 155, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLayoutSetting, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmbReportType, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCozy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnComfortable),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCompact)});
            this.Bar1.OptionsBar.AllowQuickCustomization = false;
            this.Bar1.OptionsBar.DrawDragBorder = false;
            this.Bar1.OptionsBar.UseWholeRow = true;
            this.Bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.Bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add New";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem7.Text = "Add New   (Ctrl+N)";
            toolTipItem7.LeftIndent = 6;
            toolTipItem7.Text = "Click here to add new item\r\n";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            this.btnAdd.SuperTip = superToolTip7;
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem8.Text = "Edit   (Ctrl+E)";
            toolTipItem8.LeftIndent = 6;
            toolTipItem8.Text = "Click here to edit selected item\r\n";
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            this.btnEdit.SuperTip = superToolTip8;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem9.Text = "Delete   (Ctrl+D)";
            toolTipItem9.LeftIndent = 6;
            toolTipItem9.Text = "Click here to delete selected item\r\n";
            superToolTip9.Items.Add(toolTipTitleItem9);
            superToolTip9.Items.Add(toolTipItem9);
            this.btnDelete.SuperTip = superToolTip9;
            // 
            // btnCozy
            // 
            this.btnCozy.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCozy.Caption = "Cozy";
            this.btnCozy.Id = 24;
            this.btnCozy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCozy.ImageOptions.Image")));
            this.btnCozy.Name = "btnCozy";
            this.btnCozy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCozy_ItemClick);
            // 
            // btnComfortable
            // 
            this.btnComfortable.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnComfortable.Caption = "Comfortable";
            this.btnComfortable.Id = 25;
            this.btnComfortable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnComfortable.ImageOptions.Image")));
            this.btnComfortable.Name = "btnComfortable";
            this.btnComfortable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnComfortable_ItemClick);
            // 
            // btnCompact
            // 
            this.btnCompact.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCompact.Caption = "Compact";
            this.btnCompact.Id = 26;
            this.btnCompact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCompact.ImageOptions.Image")));
            this.btnCompact.Name = "btnCompact";
            this.btnCompact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompact_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl1.Manager = this.BarManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1685, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1689, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 880);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1689, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1689, 0);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 880);
            // 
            // popAdd
            // 
            this.popAdd.Caption = "Add New";
            this.popAdd.Id = 8;
            this.popAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popAdd.ImageOptions.Image")));
            this.popAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.popAdd.Name = "popAdd";
            // 
            // popEdit
            // 
            this.popEdit.Caption = "Edit";
            this.popEdit.Id = 9;
            this.popEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popEdit.ImageOptions.Image")));
            this.popEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.popEdit.Name = "popEdit";
            // 
            // popDelete
            // 
            this.popDelete.Caption = "Delete";
            this.popDelete.Id = 10;
            this.popDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popDelete.ImageOptions.Image")));
            this.popDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.popDelete.Name = "popDelete";
            // 
            // mnuSaveLayout
            // 
            this.mnuSaveLayout.Caption = "Save Layout";
            this.mnuSaveLayout.Id = 11;
            this.mnuSaveLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveLayout.ImageOptions.Image")));
            this.mnuSaveLayout.Name = "mnuSaveLayout";
            // 
            // mnuResetLayout
            // 
            this.mnuResetLayout.Caption = "Reset Layout";
            this.mnuResetLayout.Id = 12;
            this.mnuResetLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuResetLayout.ImageOptions.Image")));
            this.mnuResetLayout.Name = "mnuResetLayout";
            // 
            // mnuPrint
            // 
            this.mnuPrint.Caption = "Print";
            this.mnuPrint.Id = 13;
            this.mnuPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.ImageOptions.Image")));
            this.mnuPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.mnuPrint.Name = "mnuPrint";
            // 
            // mnuExportToExcel
            // 
            this.mnuExportToExcel.Caption = "Export To Excel";
            this.mnuExportToExcel.Id = 14;
            this.mnuExportToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuExportToExcel.ImageOptions.Image")));
            this.mnuExportToExcel.Name = "mnuExportToExcel";
            // 
            // btnCopyPO
            // 
            this.btnCopyPO.Caption = "Copy PO";
            this.btnCopyPO.Id = 15;
            this.btnCopyPO.Name = "btnCopyPO";
            toolTipTitleItem10.Text = "Copy PO";
            toolTipItem10.LeftIndent = 6;
            toolTipItem10.Text = "Click here to copy selected PO";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            this.btnCopyPO.SuperTip = superToolTip10;
            // 
            // popCopyPO
            // 
            this.popCopyPO.Caption = "Copy PO";
            this.popCopyPO.Id = 16;
            this.popCopyPO.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popCopyPO.ImageOptions.Image")));
            this.popCopyPO.Name = "popCopyPO";
            // 
            // mnuFilter
            // 
            this.mnuFilter.Caption = "Filter";
            this.mnuFilter.Id = 17;
            this.mnuFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilter.ImageOptions.Image")));
            this.mnuFilter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.mnuFilter.Name = "mnuFilter";
            // 
            // cmbPOType
            // 
            this.cmbPOType.Caption = "BarEditItem1";
            this.cmbPOType.Edit = this.RepositoryItemComboBox1;
            this.cmbPOType.Id = 18;
            this.cmbPOType.Name = "cmbPOType";
            // 
            // RepositoryItemComboBox1
            // 
            this.RepositoryItemComboBox1.AutoHeight = false;
            this.RepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1";
            // 
            // LEPOType
            // 
            this.LEPOType.Caption = "BarEditItem1";
            this.LEPOType.Edit = this.RepPOType;
            this.LEPOType.EditWidth = 37;
            this.LEPOType.Id = 19;
            this.LEPOType.Name = "LEPOType";
            toolTipTitleItem11.Text = "Item type";
            toolTipItem11.LeftIndent = 6;
            toolTipItem11.Text = "Select Item type to see records ItemType Wise";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            this.LEPOType.SuperTip = superToolTip11;
            // 
            // RepPOType
            // 
            this.RepPOType.AutoHeight = false;
            this.RepPOType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepPOType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "DisplayText")});
            this.RepPOType.Name = "RepPOType";
            this.RepPOType.NullText = "";
            // 
            // btnGoodsReceiptNote
            // 
            this.btnGoodsReceiptNote.Caption = "Receiving Notes";
            this.btnGoodsReceiptNote.Id = 20;
            this.btnGoodsReceiptNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoodsReceiptNote.ImageOptions.Image")));
            this.btnGoodsReceiptNote.Name = "btnGoodsReceiptNote";
            // 
            // btnGoodsReceipt
            // 
            this.btnGoodsReceipt.Caption = "Goods Receive";
            this.btnGoodsReceipt.Id = 21;
            this.btnGoodsReceipt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoodsReceipt.ImageOptions.Image")));
            this.btnGoodsReceipt.Name = "btnGoodsReceipt";
            // 
            // btnReceiveBarcode
            // 
            this.btnReceiveBarcode.Caption = "Receive Barcode";
            this.btnReceiveBarcode.Id = 23;
            this.btnReceiveBarcode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReceiveBarcode.ImageOptions.Image")));
            this.btnReceiveBarcode.Name = "btnReceiveBarcode";
            this.btnReceiveBarcode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem12.Text = "Receive Barcode";
            superToolTip12.Items.Add(toolTipTitleItem12);
            this.btnReceiveBarcode.SuperTip = superToolTip12;
            // 
            // PopupMenu2
            // 
            this.PopupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.popEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.popDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.popCopyPO),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuResetLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFilter, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGoodsReceipt),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGoodsReceiptNote)});
            this.PopupMenu2.Manager = this.BarManager1;
            this.PopupMenu2.Name = "PopupMenu2";
            // 
            // gcQuotationChasing
            // 
            this.gcQuotationChasing.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcQuotationChasing.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcQuotationChasing.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcQuotationChasing.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcQuotationChasing.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcQuotationChasing.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcQuotationChasing.Location = new System.Drawing.Point(2, 103);
            this.gcQuotationChasing.MainView = this.gvQuotationChasing;
            this.gcQuotationChasing.Margin = new System.Windows.Forms.Padding(0);
            this.gcQuotationChasing.Name = "gcQuotationChasing";
            this.gcQuotationChasing.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepSupplier});
            this.gcQuotationChasing.Size = new System.Drawing.Size(1685, 775);
            this.gcQuotationChasing.TabIndex = 14;
            this.gcQuotationChasing.Tag = "Quotation Chasing ";
            this.gcQuotationChasing.UseEmbeddedNavigator = true;
            this.gcQuotationChasing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuotationChasing});
            // 
            // gvQuotationChasing
            // 
            this.gvQuotationChasing.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvQuotationChasing.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvQuotationChasing.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gvQuotationChasing.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvQuotationChasing.ColumnPanelRowHeight = 45;
            this.gvQuotationChasing.DetailHeight = 630;
            this.gvQuotationChasing.GridControl = this.gcQuotationChasing;
            this.gvQuotationChasing.Name = "gvQuotationChasing";
            this.gvQuotationChasing.OptionsEditForm.PopupEditFormWidth = 1400;
            this.gvQuotationChasing.OptionsNavigation.AutoFocusNewRow = true;
            this.gvQuotationChasing.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvQuotationChasing.OptionsPrint.AllowMultilineHeaders = true;
            this.gvQuotationChasing.OptionsPrint.MaxMergedCellHeight = 80;
            this.gvQuotationChasing.OptionsPrint.PrintDetails = true;
            this.gvQuotationChasing.OptionsPrint.PrintFilterInfo = true;
            this.gvQuotationChasing.OptionsPrint.RtfPageHeader = null;
            this.gvQuotationChasing.OptionsPrint.RtfReportHeader = resources.GetString("gvQuotationChasing.OptionsPrint.RtfReportHeader");
            this.gvQuotationChasing.OptionsView.RowAutoHeight = true;
            this.gvQuotationChasing.OptionsView.ShowAutoFilterRow = true;
            this.gvQuotationChasing.OptionsView.ShowGroupPanel = false;
            this.gvQuotationChasing.Tag = "Quotation Chasing";
            this.gvQuotationChasing.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.dtgQuotation_CustomDrawCell);
            this.gvQuotationChasing.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvQuotationChasing_RowStyle);
            this.gvQuotationChasing.DoubleClick += new System.EventHandler(this.gvQuotationChasing_DoubleClick);
            // 
            // RepSupplier
            // 
            this.RepSupplier.AutoHeight = false;
            this.RepSupplier.Name = "RepSupplier";
            // 
            // PopupMenu1
            // 
            this.PopupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.popEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.popDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.popCopyPO),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuResetLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFilter, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGoodsReceipt),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGoodsReceiptNote)});
            this.PopupMenu1.Manager = this.BarManager1;
            this.PopupMenu1.Name = "PopupMenu1";
            // 
            // cmbQuotationStatus
            // 
            this.cmbQuotationStatus.Location = new System.Drawing.Point(116, 68);
            this.cmbQuotationStatus.Name = "cmbQuotationStatus";
            this.cmbQuotationStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cmbQuotationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbQuotationStatus.Properties.NullText = "<Select>";
            this.cmbQuotationStatus.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbQuotationStatus.Properties.ShowFooter = false;
            this.cmbQuotationStatus.Properties.ShowHeader = false;
            this.cmbQuotationStatus.Size = new System.Drawing.Size(257, 26);
            this.cmbQuotationStatus.StyleController = this.layoutControl1;
            this.cmbQuotationStatus.TabIndex = 372;
            this.cmbQuotationStatus.EditValueChanged += new System.EventHandler(this.cmbQuotationStatus_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.standaloneBarDockControl1);
            this.layoutControl1.Controls.Add(this.gcQuotationChasing);
            this.layoutControl1.Controls.Add(this.cmbQuotationStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1689, 880);
            this.layoutControl1.TabIndex = 34;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1689, 880);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcQuotationChasing;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 101);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1689, 779);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1689, 65);
            this.layoutControlGroup1.Text = "Filter";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbQuotationStatus;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(370, 30);
            this.layoutControlItem1.Text = "Quotation Status:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(370, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1309, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.standaloneBarDockControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1689, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnLogHistory
            // 
            this.btnLogHistory.Caption = "History";
            this.btnLogHistory.Id = 28;
            this.btnLogHistory.ImageOptions.Image = global::My.Resources.Resources.ERP16_LogHistory;
            this.btnLogHistory.Name = "btnLogHistory";
            this.btnLogHistory.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLogHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogHistory_ItemClick);
            // 
            // frmQuotationFollowUpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 880);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuotationFollowUpList";
            this.Text = "frmQuotationFollowUpList";
            this.Load += new System.EventHandler(this.frmQuotationFollowUpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemReportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckedComboBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepCompBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepPOType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuotationChasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuotationChasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuotationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal DevExpress.Utils.ImageCollection ImageCollection2;
		internal DevExpress.XtraBars.BarButtonItem btnResetLayout;
		internal DevExpress.XtraBars.BarButtonItem btnRefresh;
		internal DevExpress.XtraBars.BarButtonItem btnPOFilter;
		internal DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        internal DevExpress.XtraBars.BarButtonItem btnPrint;
        internal DevExpress.XtraBars.BarButtonItem btnLayoutSetting;
        internal DevExpress.XtraBars.BarButtonItem btnCollapse;
        internal DevExpress.XtraBars.BarButtonItem ExpandAll;
        private DevExpress.XtraBars.BarEditItem cmbReportType;
        internal DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox RepositoryItemReportType;
        internal DevExpress.XtraBars.BarEditItem BarCompBranch;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepCompBranch;
		internal DevExpress.XtraBars.BarButtonItem btnSaveLayout;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarButtonItem mnuPrint;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		public DevExpress.XtraBars.BarButtonItem btnCopyPO;
		internal DevExpress.XtraBars.BarEditItem cmbPOType;
		internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox RepositoryItemComboBox1;
		internal DevExpress.XtraBars.BarEditItem LEPOType;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepPOType;
		internal DevExpress.XtraBars.BarButtonItem btnReceiveBarcode;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.PopupMenu PopupMenu2;
		public DevExpress.XtraBars.BarButtonItem popAdd;
		public DevExpress.XtraBars.BarButtonItem popEdit;
		public DevExpress.XtraBars.BarButtonItem popDelete;
		public DevExpress.XtraBars.BarButtonItem popCopyPO;
		internal DevExpress.XtraBars.BarButtonItem mnuSaveLayout;
		internal DevExpress.XtraBars.BarButtonItem mnuResetLayout;
		internal DevExpress.XtraBars.BarButtonItem mnuFilter;
		internal DevExpress.XtraBars.BarButtonItem mnuExportToExcel;
		internal DevExpress.XtraBars.BarButtonItem btnGoodsReceipt;
		internal DevExpress.XtraBars.BarButtonItem btnGoodsReceiptNote;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar Bar1;
		public DevExpress.XtraBars.BarButtonItem btnAdd;
		public DevExpress.XtraBars.BarButtonItem btnEdit;
		public DevExpress.XtraBars.BarButtonItem btnDelete;
		internal DevExpress.XtraGrid.GridControl gcQuotationChasing;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvQuotationChasing;
		internal DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit RepSupplier;
		internal DevExpress.XtraBars.PopupMenu PopupMenu1;
		internal DevExpress.XtraEditors.LookUpEdit cmbQuotationStatus;
		internal DevExpress.XtraBars.BarButtonItem btnCozy;
		internal DevExpress.XtraBars.BarButtonItem btnComfortable;
		internal DevExpress.XtraBars.BarButtonItem btnCompact;

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
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repCheckedComboBranch;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarButtonItem btnLogHistory;
    }
	
}
