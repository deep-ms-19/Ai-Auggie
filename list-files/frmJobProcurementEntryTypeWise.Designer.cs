using DevExpress.XtraLayout;
using DWERP;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
//using ExceptionManager;
using System.Xml;

namespace DWERP
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class frmJobProcurementEntryTypeWise : DevExpress.XtraEditors.XtraForm
    {

        //Form overrides dispose to clean up the component list.
        //[System.Diagnostics.DebuggerNonUserCode()]
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && components != null)
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        // ''Form overrides dispose to clean up the component list.
        // '<System.Diagnostics.DebuggerNonUserCode()> _
        // 'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        // '    If disposing AndAlso components IsNot Nothing Then
        // '        components.Dispose()
        // '    End If
        // '    MyBase.Dispose(disposing)
        // 'End Sub

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobProcurementEntryTypeWise));
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
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip40 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem40 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem38 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip41 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem41 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem39 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip42 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem42 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem40 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.Utils.SuperToolTip superToolTip16 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem16 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem16 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip17 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem17 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem17 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip18 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem18 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem18 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip20 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem20 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem20 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip13 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem13 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem13 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip14 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem14 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem14 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip15 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem15 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem15 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip21 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem21 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem21 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip19 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem19 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem19 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip22 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem22 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem22 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip23 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem23 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem23 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip24 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem24 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip25 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem25 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem24 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip27 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem27 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem26 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip26 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem26 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem25 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip30 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem30 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem29 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip28 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem28 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem27 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip29 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem29 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem28 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip31 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem31 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem30 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip32 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem32 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem31 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip33 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem33 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem32 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip34 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem34 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem33 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip35 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem35 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem34 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip36 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem36 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem35 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip37 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem37 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem36 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip38 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem38 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem37 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip39 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem39 = new DevExpress.Utils.ToolTipTitleItem();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TLPmain = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scProdurementGeneratePO = new DevExpress.XtraEditors.SplitContainerControl();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.gcGeneratePO = new DevExpress.XtraGrid.GridControl();
            this.gvGeneratePO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar2 = new DevExpress.XtraBars.Bar();
            this.btnAddNewCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.StandaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standJobMaster = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.StandaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.StandaloneBarDockControl3 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.popAddNewCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.popEditCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.popDeleteCorrespondence = new DevExpress.XtraBars.BarButtonItem();
            this.mnuPrint = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAdditionalCost123 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAdditionalCostEntryCancel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEstimationMainItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDetailItemSendMail = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDetailItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEstimationMainItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEstimationMainItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDetailItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCancelAddCost = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDeleteAddCost = new DevExpress.XtraBars.BarButtonItem();
            this.POPInsertRow = new DevExpress.XtraBars.BarButtonItem();
            this.popCopyRows = new DevExpress.XtraBars.BarButtonItem();
            this.popInsertCopiedRows = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem94 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectionSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectionResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectionRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectionExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.chkOrderAsPerReqQty = new DevExpress.XtraBars.BarCheckItem();
            this.btnSetDefaultSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelCozy = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelComfortable = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelCompact = new DevExpress.XtraBars.BarButtonItem();
            this.GenPOSel = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcUseFromStock = new DevExpress.XtraGrid.GridControl();
            this.gvUseFromStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl17 = new DevExpress.XtraEditors.PanelControl();
            this.btnPOComfortable = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenPO = new DevExpress.XtraEditors.SimpleButton();
            this.btnPOCompact = new DevExpress.XtraEditors.SimpleButton();
            this.btnPOCozy = new DevExpress.XtraEditors.SimpleButton();
            this.btnexportselect = new DevExpress.XtraEditors.SimpleButton();
            this.chkSelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.rbPurchaseGroupType = new DevExpress.XtraEditors.RadioGroup();
            this.pnlGeneratePurchaseOrder = new DevExpress.XtraEditors.PanelControl();
            this.lblGeneratePO = new DevExpress.XtraEditors.LabelControl();
            this.gcSelection = new DevExpress.XtraGrid.GridControl();
            this.gvSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlMainSelection = new DevExpress.XtraEditors.PanelControl();
            this.lblSelection = new DevExpress.XtraEditors.LabelControl();
            this.tabQuotation = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageReferenceSelection = new DevExpress.XtraTab.XtraTabPage();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.PanelControl13 = new DevExpress.XtraEditors.PanelControl();
            this.PanelControl14 = new DevExpress.XtraEditors.PanelControl();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl15 = new DevExpress.XtraEditors.PanelControl();
            this.PanelControl16 = new DevExpress.XtraEditors.PanelControl();
            this.btnGeneratePOPre = new DevExpress.XtraEditors.SimpleButton();
            this.TabPageSelection = new DevExpress.XtraTab.XtraTabPage();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelglass = new DevExpress.XtraEditors.PanelControl();
            this.chkselall = new DevExpress.XtraEditors.CheckEdit();
            this.PanelControl18 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectionPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveSelection = new DevExpress.XtraEditors.SimpleButton();
            this.TabPageGeneratePO = new DevExpress.XtraTab.XtraTabPage();
            this.pnlMainPOType = new DevExpress.XtraEditors.PanelControl();
            this.lblPoType = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.txtJobNo = new DevExpress.XtraEditors.TextEdit();
            this.dtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtToDate = new DevExpress.XtraEditors.DateEdit();
            this.chkSelect = new DevExpress.XtraEditors.CheckEdit();
            this.gcProcurementJobList = new DevExpress.XtraGrid.GridControl();
            this.gvProcurementJobList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RepSel = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.JobProSel = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rgProcurementType = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutProcess = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grpQuotationCorrespondence = new DevExpress.XtraEditors.GroupControl();
            this.gridQuotationChasing = new DevExpress.XtraGrid.GridControl();
            this.dtgQuotationChasingDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RepCusotmer = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.RepStatus = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.popupEnquiryChasing = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopyPO = new DevExpress.XtraBars.BarButtonItem();
            this.btnPOFilter = new DevExpress.XtraBars.BarButtonItem();
            this.LEPOType = new DevExpress.XtraBars.BarEditItem();
            this.RepPOType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarCompBranch = new DevExpress.XtraBars.BarEditItem();
            this.RepCompBranch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar15 = new DevExpress.XtraBars.Bar();
            this.BarDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.popAdd = new DevExpress.XtraBars.BarButtonItem();
            this.popEdit = new DevExpress.XtraBars.BarButtonItem();
            this.popdelete = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mnuResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.popCopyPO = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFilter = new DevExpress.XtraBars.BarButtonItem();
            this.cmbPOType = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnGoodsReceiptNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoodsReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiveBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem95 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCozy = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompact = new DevExpress.XtraBars.BarButtonItem();
            this.btnComfortable = new DevExpress.XtraBars.BarButtonItem();
            this.BarDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl11 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl12 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl13 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl14 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl15 = new DevExpress.XtraBars.BarDockControl();
            this.Bar3 = new DevExpress.XtraBars.Bar();
            this.Bar4 = new DevExpress.XtraBars.Bar();
            this.BarDockControl19 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl18 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl20 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl17 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl21 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl22 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl16 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl23 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl24 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl25 = new DevExpress.XtraBars.BarDockControl();
            this.Bar5 = new DevExpress.XtraBars.Bar();
            this.BarDockControl29 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl28 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl30 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl27 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl31 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl32 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl26 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl33 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl34 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl35 = new DevExpress.XtraBars.BarDockControl();
            this.Bar6 = new DevExpress.XtraBars.Bar();
            this.Bar7 = new DevExpress.XtraBars.Bar();
            this.BarDockControl39 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl38 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl40 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl37 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl41 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl42 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl36 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl43 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl44 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl45 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl49 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl48 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl50 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl47 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl51 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl52 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl46 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl53 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl54 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl55 = new DevExpress.XtraBars.BarDockControl();
            this.Bar8 = new DevExpress.XtraBars.Bar();
            this.BarDockControl75 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl74 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl76 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl73 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl77 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl78 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl72 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl79 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl80 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl81 = new DevExpress.XtraBars.BarDockControl();
            this.Bar9 = new DevExpress.XtraBars.Bar();
            this.BarDockControl85 = new DevExpress.XtraBars.BarDockControl();
            this.BarButtonItem93 = new DevExpress.XtraBars.BarButtonItem();
            this.BarEditItem15 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemLookUpEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.RepositoryItemLookUpEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarButtonItem92 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem91 = new DevExpress.XtraBars.BarButtonItem();
            this.BarEditItem14 = new DevExpress.XtraBars.BarEditItem();
            this.BarEditItem13 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.BarButtonItem90 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem77 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem75 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem74 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem73 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem56 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem54 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem53 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem52 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem35 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem33 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem32 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem31 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.Bar11 = new DevExpress.XtraBars.Bar();
            this.Bar12 = new DevExpress.XtraBars.Bar();
            this.Bar14 = new DevExpress.XtraBars.Bar();
            this.Bar13 = new DevExpress.XtraBars.Bar();
            this.btnRefeRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefeResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefeSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefeExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BarManager8 = new DevExpress.XtraBars.BarManager(this.components);
            this.BarReferenceSelection = new DevExpress.XtraBars.Bar();
            this.BarDockControl86 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl87 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl88 = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControl89 = new DevExpress.XtraBars.BarDockControl();
            this.BarButtonItem99 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem100 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem101 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem102 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem103 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem104 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem105 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem106 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem107 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem108 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem109 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem110 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem111 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem112 = new DevExpress.XtraBars.BarButtonItem();
            this.BarEditItem16 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemComboBox7 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.BarEditItem17 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemLookUpEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarButtonItem113 = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem114 = new DevExpress.XtraBars.BarButtonItem();
            this.BarEditItem18 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemLookUpEdit12 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarButtonItem115 = new DevExpress.XtraBars.BarButtonItem();
            this.pnlDefaultSupplier = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDefaultsuppierApply = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefaultSupplierClose = new DevExpress.XtraEditors.SimpleButton();
            this.LESupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ImageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tileBarGrpDeliveryStatus = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.TLPmain.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProdurementGeneratePO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scProdurementGeneratePO.Panel1)).BeginInit();
            this.scProdurementGeneratePO.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProdurementGeneratePO.Panel2)).BeginInit();
            this.scProdurementGeneratePO.Panel2.SuspendLayout();
            this.scProdurementGeneratePO.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl7)).BeginInit();
            this.PanelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl6)).BeginInit();
            this.PanelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGeneratePO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeneratePO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenPOSel)).BeginInit();
            this.TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).BeginInit();
            this.PanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUseFromStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUseFromStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl8)).BeginInit();
            this.PanelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl17)).BeginInit();
            this.PanelControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbPurchaseGroupType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGeneratePurchaseOrder)).BeginInit();
            this.pnlGeneratePurchaseOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainSelection)).BeginInit();
            this.pnlMainSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabQuotation)).BeginInit();
            this.tabQuotation.SuspendLayout();
            this.TabPageReferenceSelection.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl13)).BeginInit();
            this.PanelControl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl14)).BeginInit();
            this.PanelControl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl15)).BeginInit();
            this.PanelControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl16)).BeginInit();
            this.PanelControl16.SuspendLayout();
            this.TabPageSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelglass)).BeginInit();
            this.panelglass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkselall.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl18)).BeginInit();
            this.PanelControl18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainPOType)).BeginInit();
            this.pnlMainPOType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcurementJobList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcurementJobList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobProSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgProcurementType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuotationCorrespondence)).BeginInit();
            this.grpQuotationCorrespondence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuotationChasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuotationChasingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepCusotmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupEnquiryChasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepPOType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepCompBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDefaultSupplier)).BeginInit();
            this.pnlDefaultSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LESupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl1.Appearance.Options.UseBackColor = true;
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.TLPmain);
            this.PanelControl1.Controls.Add(this.grpQuotationCorrespondence);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1330, 876);
            this.PanelControl1.TabIndex = 0;
            // 
            // TLPmain
            // 
            this.TLPmain.ColumnCount = 1;
            this.TLPmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPmain.Controls.Add(this.TableLayoutPanel3, 0, 5);
            this.TLPmain.Controls.Add(this.pnlGeneratePurchaseOrder, 0, 4);
            this.TLPmain.Controls.Add(this.gcSelection, 0, 3);
            this.TLPmain.Controls.Add(this.pnlMainSelection, 0, 0);
            this.TLPmain.Controls.Add(this.tabQuotation, 0, 6);
            this.TLPmain.Controls.Add(this.pnlMainPOType, 0, 2);
            this.TLPmain.Controls.Add(this.layoutControl3, 0, 1);
            this.TLPmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPmain.Location = new System.Drawing.Point(0, 0);
            this.TLPmain.Margin = new System.Windows.Forms.Padding(0);
            this.TLPmain.Name = "TLPmain";
            this.TLPmain.Padding = new System.Windows.Forms.Padding(2);
            this.TLPmain.RowCount = 7;
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPmain.Size = new System.Drawing.Size(1330, 876);
            this.TLPmain.TabIndex = 2;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel3.ColumnCount = 1;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Controls.Add(this.scProdurementGeneratePO, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.PanelControl17, 0, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(6, 581);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(1318, 219);
            this.TableLayoutPanel3.TabIndex = 4;
            // 
            // scProdurementGeneratePO
            // 
            this.scProdurementGeneratePO.Appearance.BackColor = System.Drawing.Color.White;
            this.scProdurementGeneratePO.Appearance.Options.UseBackColor = true;
            this.scProdurementGeneratePO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scProdurementGeneratePO.Location = new System.Drawing.Point(1, 49);
            this.scProdurementGeneratePO.Margin = new System.Windows.Forms.Padding(0);
            this.scProdurementGeneratePO.Name = "scProdurementGeneratePO";
            // 
            // scProdurementGeneratePO.Panel1
            // 
            this.scProdurementGeneratePO.Panel1.Controls.Add(this.TableLayoutPanel1);
            this.scProdurementGeneratePO.Panel1.Text = "Panel1";
            // 
            // scProdurementGeneratePO.Panel2
            // 
            this.scProdurementGeneratePO.Panel2.Controls.Add(this.TableLayoutPanel2);
            this.scProdurementGeneratePO.Panel2.Text = "Panel2";
            this.scProdurementGeneratePO.Size = new System.Drawing.Size(1316, 169);
            this.scProdurementGeneratePO.SplitterPosition = 556;
            this.scProdurementGeneratePO.TabIndex = 2;
            this.scProdurementGeneratePO.Text = "SplitContainerControl1";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.PanelControl7, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.PanelControl6, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(556, 169);
            this.TableLayoutPanel1.TabIndex = 2;
            // 
            // PanelControl7
            // 
            this.PanelControl7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.PanelControl7.Appearance.Options.UseBackColor = true;
            this.PanelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl7.Controls.Add(this.LabelControl1);
            this.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl7.Location = new System.Drawing.Point(0, 0);
            this.PanelControl7.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl7.Name = "PanelControl7";
            this.PanelControl7.Size = new System.Drawing.Size(556, 37);
            this.PanelControl7.TabIndex = 3;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(10, 9);
            this.LabelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(89, 16);
            this.LabelControl1.TabIndex = 362;
            this.LabelControl1.Text = "Purchase Order";
            // 
            // PanelControl6
            // 
            this.PanelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.PanelControl6.Appearance.Options.UseBackColor = true;
            this.PanelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl6.Controls.Add(this.gcGeneratePO);
            this.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl6.Location = new System.Drawing.Point(0, 37);
            this.PanelControl6.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl6.Name = "PanelControl6";
            this.PanelControl6.Size = new System.Drawing.Size(556, 132);
            this.PanelControl6.TabIndex = 365;
            // 
            // gcGeneratePO
            // 
            this.gcGeneratePO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGeneratePO.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcGeneratePO.Location = new System.Drawing.Point(0, 0);
            this.gcGeneratePO.MainView = this.gvGeneratePO;
            this.gcGeneratePO.Margin = new System.Windows.Forms.Padding(0);
            this.gcGeneratePO.MenuManager = this.BarManager1;
            this.gcGeneratePO.Name = "gcGeneratePO";
            this.gcGeneratePO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GenPOSel});
            this.gcGeneratePO.Size = new System.Drawing.Size(556, 132);
            this.gcGeneratePO.TabIndex = 0;
            this.gcGeneratePO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGeneratePO});
            // 
            // gvGeneratePO
            // 
            this.gvGeneratePO.ColumnPanelRowHeight = 43;
            this.gvGeneratePO.DetailHeight = 431;
            this.gvGeneratePO.GridControl = this.gcGeneratePO;
            this.gvGeneratePO.Name = "gvGeneratePO";
            this.gvGeneratePO.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvGeneratePO.OptionsView.ShowGroupPanel = false;
            this.gvGeneratePO.RowHeight = 31;
            this.gvGeneratePO.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvGeneratePO_RowStyle);
            this.gvGeneratePO.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gvGeneratePO_MasterRowExpanded);
            // 
            // BarManager1
            // 
            this.BarManager1.AllowCustomization = false;
            this.BarManager1.AllowQuickCustomization = false;
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar2});
            this.BarManager1.DockControls.Add(this.barDockControlTop);
            this.BarManager1.DockControls.Add(this.barDockControlBottom);
            this.BarManager1.DockControls.Add(this.barDockControlLeft);
            this.BarManager1.DockControls.Add(this.barDockControlRight);
            this.BarManager1.DockControls.Add(this.StandaloneBarDockControl2);
            this.BarManager1.DockControls.Add(this.standJobMaster);
            this.BarManager1.DockControls.Add(this.StandaloneBarDockControl1);
            this.BarManager1.DockControls.Add(this.StandaloneBarDockControl3);
            this.BarManager1.DockWindowTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarManager1.Form = this;
            this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddNewCorrespondence,
            this.btnEditCorrespondence,
            this.btnDeleteCorrespondence,
            this.btnPrintCorrespondence,
            this.btnExportToExcel,
            this.popAddNewCorrespondence,
            this.popEditCorrespondence,
            this.popDeleteCorrespondence,
            this.mnuPrint,
            this.mnuExportToExcel,
            this.mnuAdditionalCost123,
            this.mnuAdditionalCostEntryCancel,
            this.mnuEstimationMainItemDelete,
            this.mnuDetailItemSendMail,
            this.mnuDetailItemDelete,
            this.BarButtonItem1,
            this.BarButtonItem2,
            this.mnuEstimationMainItemEdit,
            this.mnuEstimationMainItemCopy,
            this.mnuDetailItemCopy,
            this.mnuCancelAddCost,
            this.mnuDeleteAddCost,
            this.POPInsertRow,
            this.popCopyRows,
            this.popInsertCopiedRows,
            this.BarButtonItem94,
            this.btnSelectionSaveLayout,
            this.btnSelectionResetLayout,
            this.btnSelectionRefresh,
            this.btnSelectionExportExcel,
            this.chkOrderAsPerReqQty,
            this.btnSetDefaultSupplier,
            this.btnSelCozy,
            this.btnSelComfortable,
            this.btnSelCompact});
            this.BarManager1.MaxItemId = 35;
            // 
            // Bar2
            // 
            this.Bar2.BarName = "Tools";
            this.Bar2.DockCol = 0;
            this.Bar2.DockRow = 0;
            this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar2.FloatLocation = new System.Drawing.Point(64, 463);
            this.Bar2.FloatSize = new System.Drawing.Size(420, 31);
            this.Bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewCorrespondence),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditCorrespondence, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteCorrespondence, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintCorrespondence, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel, true)});
            this.Bar2.OptionsBar.AllowQuickCustomization = false;
            this.Bar2.OptionsBar.DrawDragBorder = false;
            this.Bar2.OptionsBar.UseWholeRow = true;
            this.Bar2.StandaloneBarDockControl = this.StandaloneBarDockControl2;
            this.Bar2.Text = "Tools";
            this.Bar2.Visible = false;
            // 
            // btnAddNewCorrespondence
            // 
            this.btnAddNewCorrespondence.Caption = "Add New";
            this.btnAddNewCorrespondence.Enabled = false;
            this.btnAddNewCorrespondence.Id = 0;
            this.btnAddNewCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCorrespondence.ImageOptions.Image")));
            this.btnAddNewCorrespondence.Name = "btnAddNewCorrespondence";
            this.btnAddNewCorrespondence.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Add New";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Click here to add new item\r\n";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnAddNewCorrespondence.SuperTip = superToolTip1;
            // 
            // btnEditCorrespondence
            // 
            this.btnEditCorrespondence.Caption = "Edit";
            this.btnEditCorrespondence.Enabled = false;
            this.btnEditCorrespondence.Id = 1;
            this.btnEditCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCorrespondence.ImageOptions.Image")));
            this.btnEditCorrespondence.Name = "btnEditCorrespondence";
            this.btnEditCorrespondence.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Edit";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Click here to edit selected item\r\n";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnEditCorrespondence.SuperTip = superToolTip2;
            // 
            // btnDeleteCorrespondence
            // 
            this.btnDeleteCorrespondence.Caption = "Delete";
            this.btnDeleteCorrespondence.Enabled = false;
            this.btnDeleteCorrespondence.Id = 2;
            this.btnDeleteCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCorrespondence.ImageOptions.Image")));
            this.btnDeleteCorrespondence.Name = "btnDeleteCorrespondence";
            this.btnDeleteCorrespondence.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem3.Text = "Delete";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Click here to delete selected item\r\n";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnDeleteCorrespondence.SuperTip = superToolTip3;
            // 
            // btnPrintCorrespondence
            // 
            this.btnPrintCorrespondence.Caption = "Print";
            this.btnPrintCorrespondence.Id = 3;
            this.btnPrintCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCorrespondence.ImageOptions.Image")));
            this.btnPrintCorrespondence.Name = "btnPrintCorrespondence";
            this.btnPrintCorrespondence.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem4.Text = "Print";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Click here to print";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.btnPrintCorrespondence.SuperTip = superToolTip4;
            this.btnPrintCorrespondence.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "Export To Excel";
            this.btnExportToExcel.Id = 4;
            this.btnExportToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.ImageOptions.Image")));
            this.btnExportToExcel.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnExportToExcel.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem5.Text = "Export To Excel";
            toolTipItem5.LeftIndent = 6;
            toolTipItem5.Text = "Click here to export listing to excel\r\n";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.btnExportToExcel.SuperTip = superToolTip5;
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // StandaloneBarDockControl2
            // 
            this.StandaloneBarDockControl2.CausesValidation = false;
            this.StandaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.StandaloneBarDockControl2.Location = new System.Drawing.Point(2, 27);
            this.StandaloneBarDockControl2.Manager = this.BarManager1;
            this.StandaloneBarDockControl2.Margin = new System.Windows.Forms.Padding(0);
            this.StandaloneBarDockControl2.Name = "StandaloneBarDockControl2";
            this.StandaloneBarDockControl2.Size = new System.Drawing.Size(117, 36);
            this.StandaloneBarDockControl2.Text = "StandaloneBarDockControl2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 876);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 876);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1330, 0);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 876);
            // 
            // standJobMaster
            // 
            this.standJobMaster.CausesValidation = false;
            this.standJobMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standJobMaster.Location = new System.Drawing.Point(0, 0);
            this.standJobMaster.Manager = this.BarManager1;
            this.standJobMaster.Margin = new System.Windows.Forms.Padding(0);
            this.standJobMaster.Name = "standJobMaster";
            this.standJobMaster.Size = new System.Drawing.Size(115, 34);
            this.standJobMaster.Text = "StandaloneBarDockControl1";
            // 
            // StandaloneBarDockControl1
            // 
            this.StandaloneBarDockControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StandaloneBarDockControl1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.StandaloneBarDockControl1.Appearance.Options.UseBorderColor = true;
            this.StandaloneBarDockControl1.CausesValidation = false;
            this.StandaloneBarDockControl1.Location = new System.Drawing.Point(404, 5);
            this.StandaloneBarDockControl1.Manager = this.BarManager1;
            this.StandaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(0);
            this.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1";
            this.StandaloneBarDockControl1.Size = new System.Drawing.Size(906, 34);
            this.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1";
            // 
            // StandaloneBarDockControl3
            // 
            this.StandaloneBarDockControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StandaloneBarDockControl3.CausesValidation = false;
            this.StandaloneBarDockControl3.Location = new System.Drawing.Point(705, 5);
            this.StandaloneBarDockControl3.Manager = this.BarManager1;
            this.StandaloneBarDockControl3.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.StandaloneBarDockControl3.Name = "StandaloneBarDockControl3";
            this.StandaloneBarDockControl3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.StandaloneBarDockControl3.Size = new System.Drawing.Size(607, 31);
            this.StandaloneBarDockControl3.Text = "StandaloneBarDockControl1";
            // 
            // popAddNewCorrespondence
            // 
            this.popAddNewCorrespondence.Caption = "Add New";
            this.popAddNewCorrespondence.Id = 5;
            this.popAddNewCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popAddNewCorrespondence.ImageOptions.Image")));
            this.popAddNewCorrespondence.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.popAddNewCorrespondence.Name = "popAddNewCorrespondence";
            // 
            // popEditCorrespondence
            // 
            this.popEditCorrespondence.Caption = "Edit";
            this.popEditCorrespondence.Id = 6;
            this.popEditCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popEditCorrespondence.ImageOptions.Image")));
            this.popEditCorrespondence.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.popEditCorrespondence.Name = "popEditCorrespondence";
            // 
            // popDeleteCorrespondence
            // 
            this.popDeleteCorrespondence.Caption = "Delete";
            this.popDeleteCorrespondence.Id = 7;
            this.popDeleteCorrespondence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popDeleteCorrespondence.ImageOptions.Image")));
            this.popDeleteCorrespondence.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.popDeleteCorrespondence.Name = "popDeleteCorrespondence";
            // 
            // mnuPrint
            // 
            this.mnuPrint.Caption = "Print";
            this.mnuPrint.Id = 8;
            this.mnuPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.ImageOptions.Image")));
            this.mnuPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuExportToExcel
            // 
            this.mnuExportToExcel.Caption = "Export To Excel";
            this.mnuExportToExcel.Id = 9;
            this.mnuExportToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuExportToExcel.ImageOptions.Image")));
            this.mnuExportToExcel.Name = "mnuExportToExcel";
            // 
            // mnuAdditionalCost123
            // 
            this.mnuAdditionalCost123.Caption = "New Item";
            this.mnuAdditionalCost123.Id = 10;
            this.mnuAdditionalCost123.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdditionalCost123.ImageOptions.Image")));
            this.mnuAdditionalCost123.Name = "mnuAdditionalCost123";
            // 
            // mnuAdditionalCostEntryCancel
            // 
            this.mnuAdditionalCostEntryCancel.Caption = "Cancel";
            this.mnuAdditionalCostEntryCancel.Id = 11;
            this.mnuAdditionalCostEntryCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdditionalCostEntryCancel.ImageOptions.Image")));
            this.mnuAdditionalCostEntryCancel.Name = "mnuAdditionalCostEntryCancel";
            // 
            // mnuEstimationMainItemDelete
            // 
            this.mnuEstimationMainItemDelete.Caption = "Delete";
            this.mnuEstimationMainItemDelete.Id = 12;
            this.mnuEstimationMainItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuEstimationMainItemDelete.ImageOptions.Image")));
            this.mnuEstimationMainItemDelete.Name = "mnuEstimationMainItemDelete";
            // 
            // mnuDetailItemSendMail
            // 
            this.mnuDetailItemSendMail.Caption = "Email";
            this.mnuDetailItemSendMail.Id = 13;
            this.mnuDetailItemSendMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuDetailItemSendMail.ImageOptions.Image")));
            this.mnuDetailItemSendMail.Name = "mnuDetailItemSendMail";
            // 
            // mnuDetailItemDelete
            // 
            this.mnuDetailItemDelete.Caption = "Delete";
            this.mnuDetailItemDelete.Id = 14;
            this.mnuDetailItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuDetailItemDelete.ImageOptions.Image")));
            this.mnuDetailItemDelete.Name = "mnuDetailItemDelete";
            // 
            // BarButtonItem1
            // 
            this.BarButtonItem1.Caption = "New Item";
            this.BarButtonItem1.Id = 15;
            this.BarButtonItem1.Name = "BarButtonItem1";
            // 
            // BarButtonItem2
            // 
            this.BarButtonItem2.Caption = "BarButtonItem2";
            this.BarButtonItem2.Id = 16;
            this.BarButtonItem2.Name = "BarButtonItem2";
            // 
            // mnuEstimationMainItemEdit
            // 
            this.mnuEstimationMainItemEdit.Caption = "Edit Item";
            this.mnuEstimationMainItemEdit.Id = 17;
            this.mnuEstimationMainItemEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuEstimationMainItemEdit.ImageOptions.Image")));
            this.mnuEstimationMainItemEdit.Name = "mnuEstimationMainItemEdit";
            // 
            // mnuEstimationMainItemCopy
            // 
            this.mnuEstimationMainItemCopy.Caption = "Copy Item as New";
            this.mnuEstimationMainItemCopy.Id = 18;
            this.mnuEstimationMainItemCopy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuEstimationMainItemCopy.ImageOptions.Image")));
            this.mnuEstimationMainItemCopy.Name = "mnuEstimationMainItemCopy";
            // 
            // mnuDetailItemCopy
            // 
            this.mnuDetailItemCopy.Caption = "Copy Item as New";
            this.mnuDetailItemCopy.Id = 19;
            this.mnuDetailItemCopy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuDetailItemCopy.ImageOptions.Image")));
            this.mnuDetailItemCopy.Name = "mnuDetailItemCopy";
            // 
            // mnuCancelAddCost
            // 
            this.mnuCancelAddCost.Caption = "Cancel";
            this.mnuCancelAddCost.Id = 20;
            this.mnuCancelAddCost.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuCancelAddCost.ImageOptions.Image")));
            this.mnuCancelAddCost.Name = "mnuCancelAddCost";
            // 
            // mnuDeleteAddCost
            // 
            this.mnuDeleteAddCost.Caption = "Delete";
            this.mnuDeleteAddCost.Id = 21;
            this.mnuDeleteAddCost.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuDeleteAddCost.ImageOptions.Image")));
            this.mnuDeleteAddCost.Name = "mnuDeleteAddCost";
            // 
            // POPInsertRow
            // 
            this.POPInsertRow.Caption = "Insert Blank Row";
            this.POPInsertRow.Id = 22;
            this.POPInsertRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("POPInsertRow.ImageOptions.Image")));
            this.POPInsertRow.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add));
            this.POPInsertRow.Name = "POPInsertRow";
            // 
            // popCopyRows
            // 
            this.popCopyRows.Caption = "Copy Selected Rows";
            this.popCopyRows.Id = 23;
            this.popCopyRows.Name = "popCopyRows";
            // 
            // popInsertCopiedRows
            // 
            this.popInsertCopiedRows.Caption = "Insert Copied Rows";
            this.popInsertCopiedRows.Id = 24;
            this.popInsertCopiedRows.Name = "popInsertCopiedRows";
            // 
            // BarButtonItem94
            // 
            this.BarButtonItem94.Caption = "BarButtonItem94";
            this.BarButtonItem94.Id = 25;
            this.BarButtonItem94.Name = "BarButtonItem94";
            // 
            // btnSelectionSaveLayout
            // 
            this.btnSelectionSaveLayout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelectionSaveLayout.Caption = "Save Layout";
            this.btnSelectionSaveLayout.Id = 26;
            this.btnSelectionSaveLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectionSaveLayout.ImageOptions.Image")));
            this.btnSelectionSaveLayout.Name = "btnSelectionSaveLayout";
            this.btnSelectionSaveLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem10.Text = "Save Layout";
            toolTipItem10.LeftIndent = 6;
            toolTipItem10.Text = "Click here to save layout of listing\r\n";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            this.btnSelectionSaveLayout.SuperTip = superToolTip10;
            this.btnSelectionSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectionSaveLayout_ItemClick);
            // 
            // btnSelectionResetLayout
            // 
            this.btnSelectionResetLayout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelectionResetLayout.Caption = "Reset Layout";
            this.btnSelectionResetLayout.Id = 27;
            this.btnSelectionResetLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectionResetLayout.ImageOptions.Image")));
            this.btnSelectionResetLayout.Name = "btnSelectionResetLayout";
            this.btnSelectionResetLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem9.Text = "Reset Layout";
            toolTipItem9.LeftIndent = 6;
            toolTipItem9.Text = "Click here to reset layout of listing\r\n";
            superToolTip9.Items.Add(toolTipTitleItem9);
            superToolTip9.Items.Add(toolTipItem9);
            this.btnSelectionResetLayout.SuperTip = superToolTip9;
            this.btnSelectionResetLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectionResetLayout_ItemClick);
            // 
            // btnSelectionRefresh
            // 
            this.btnSelectionRefresh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelectionRefresh.Caption = "Refresh";
            this.btnSelectionRefresh.Id = 28;
            this.btnSelectionRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectionRefresh.ImageOptions.Image")));
            this.btnSelectionRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionRefresh.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnSelectionRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSelectionRefresh.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnSelectionRefresh.Name = "btnSelectionRefresh";
            this.btnSelectionRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem11.Text = "Refresh";
            toolTipItem11.LeftIndent = 6;
            toolTipItem11.Text = "Click here to refresh the list\r\n";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            this.btnSelectionRefresh.SuperTip = superToolTip11;
            this.btnSelectionRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectionRefresh_ItemClick);
            // 
            // btnSelectionExportExcel
            // 
            this.btnSelectionExportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelectionExportExcel.Caption = "Export To Excel";
            this.btnSelectionExportExcel.Id = 29;
            this.btnSelectionExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectionExportExcel.ImageOptions.Image")));
            this.btnSelectionExportExcel.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnSelectionExportExcel.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnSelectionExportExcel.Name = "btnSelectionExportExcel";
            this.btnSelectionExportExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem12.Text = "Export To Excel";
            toolTipItem12.LeftIndent = 6;
            toolTipItem12.Text = "Click here to export listing to excel\r\n";
            superToolTip12.Items.Add(toolTipTitleItem12);
            superToolTip12.Items.Add(toolTipItem12);
            this.btnSelectionExportExcel.SuperTip = superToolTip12;
            this.btnSelectionExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectionExportExcel_ItemClick);
            // 
            // chkOrderAsPerReqQty
            // 
            this.chkOrderAsPerReqQty.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.chkOrderAsPerReqQty.Caption = "Order Required Qty";
            this.chkOrderAsPerReqQty.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.chkOrderAsPerReqQty.Id = 29;
            this.chkOrderAsPerReqQty.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrderAsPerReqQty.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.chkOrderAsPerReqQty.ItemAppearance.Normal.Options.UseFont = true;
            this.chkOrderAsPerReqQty.ItemAppearance.Normal.Options.UseForeColor = true;
            this.chkOrderAsPerReqQty.Name = "chkOrderAsPerReqQty";
            this.chkOrderAsPerReqQty.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkOrderAsPerReqQty_CheckedChanged);
            // 
            // btnSetDefaultSupplier
            // 
            this.btnSetDefaultSupplier.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSetDefaultSupplier.Caption = "Set Default Supplier";
            this.btnSetDefaultSupplier.Id = 30;
            this.btnSetDefaultSupplier.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDefaultSupplier.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnSetDefaultSupplier.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSetDefaultSupplier.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnSetDefaultSupplier.Name = "btnSetDefaultSupplier";
            this.btnSetDefaultSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetDefaultSupplier_ItemClick);
            // 
            // btnSelCozy
            // 
            this.btnSelCozy.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelCozy.Caption = "Cozy";
            this.btnSelCozy.Id = 32;
            this.btnSelCozy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelCozy.ImageOptions.Image")));
            this.btnSelCozy.Name = "btnSelCozy";
            toolTipTitleItem6.Text = "Cozy";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "Click here to set cozy style";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.btnSelCozy.SuperTip = superToolTip6;
            this.btnSelCozy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelCozy_ItemClick);
            // 
            // btnSelComfortable
            // 
            this.btnSelComfortable.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelComfortable.Caption = "Comfortable";
            this.btnSelComfortable.Id = 33;
            this.btnSelComfortable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelComfortable.ImageOptions.Image")));
            this.btnSelComfortable.Name = "btnSelComfortable";
            toolTipTitleItem7.Text = "Comfortable";
            toolTipItem7.LeftIndent = 6;
            toolTipItem7.Text = "Click here to set comfortable style";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            this.btnSelComfortable.SuperTip = superToolTip7;
            this.btnSelComfortable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelComfortable_ItemClick);
            // 
            // btnSelCompact
            // 
            this.btnSelCompact.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSelCompact.Caption = "Compact";
            this.btnSelCompact.Id = 34;
            this.btnSelCompact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelCompact.ImageOptions.Image")));
            this.btnSelCompact.Name = "btnSelCompact";
            toolTipTitleItem8.Text = "Compact";
            toolTipItem8.LeftIndent = 6;
            toolTipItem8.Text = "Click here to set compact style";
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            this.btnSelCompact.SuperTip = superToolTip8;
            this.btnSelCompact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelCompact_ItemClick);
            // 
            // GenPOSel
            // 
            this.GenPOSel.AutoHeight = false;
            this.GenPOSel.Name = "GenPOSel";
            this.GenPOSel.CheckedChanged += new System.EventHandler(this.GenPOSel_CheckedChanged);
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Controls.Add(this.PanelControl3, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.PanelControl8, 0, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 2;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(745, 169);
            this.TableLayoutPanel2.TabIndex = 3;
            // 
            // PanelControl3
            // 
            this.PanelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.PanelControl3.Appearance.Options.UseBackColor = true;
            this.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl3.Controls.Add(this.gcUseFromStock);
            this.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl3.Location = new System.Drawing.Point(0, 37);
            this.PanelControl3.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl3.Name = "PanelControl3";
            this.PanelControl3.Size = new System.Drawing.Size(745, 132);
            this.PanelControl3.TabIndex = 363;
            // 
            // gcUseFromStock
            // 
            this.gcUseFromStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUseFromStock.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcUseFromStock.Location = new System.Drawing.Point(0, 0);
            this.gcUseFromStock.MainView = this.gvUseFromStock;
            this.gcUseFromStock.Margin = new System.Windows.Forms.Padding(0);
            this.gcUseFromStock.MenuManager = this.BarManager1;
            this.gcUseFromStock.Name = "gcUseFromStock";
            this.gcUseFromStock.Size = new System.Drawing.Size(745, 132);
            this.gcUseFromStock.TabIndex = 1;
            this.gcUseFromStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUseFromStock});
            // 
            // gvUseFromStock
            // 
            this.gvUseFromStock.ColumnPanelRowHeight = 43;
            this.gvUseFromStock.DetailHeight = 431;
            this.gvUseFromStock.GridControl = this.gcUseFromStock;
            this.gvUseFromStock.Name = "gvUseFromStock";
            this.gvUseFromStock.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvUseFromStock.OptionsView.ShowGroupPanel = false;
            this.gvUseFromStock.RowHeight = 31;
            this.gvUseFromStock.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gvUseFromStock_MasterRowExpanded);
            // 
            // PanelControl8
            // 
            this.PanelControl8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.PanelControl8.Appearance.Options.UseBackColor = true;
            this.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl8.Controls.Add(this.LabelControl2);
            this.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl8.Location = new System.Drawing.Point(0, 0);
            this.PanelControl8.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl8.Name = "PanelControl8";
            this.PanelControl8.Size = new System.Drawing.Size(745, 37);
            this.PanelControl8.TabIndex = 4;
            // 
            // LabelControl2
            // 
            this.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.LabelControl2.Location = new System.Drawing.Point(12, 10);
            this.LabelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(138, 16);
            this.LabelControl2.TabIndex = 362;
            this.LabelControl2.Text = "Use From Current Stock";
            // 
            // PanelControl17
            // 
            this.PanelControl17.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl17.Appearance.Options.UseBackColor = true;
            this.PanelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl17.Controls.Add(this.btnPOComfortable);
            this.PanelControl17.Controls.Add(this.btnGenPO);
            this.PanelControl17.Controls.Add(this.btnPOCompact);
            this.PanelControl17.Controls.Add(this.btnPOCozy);
            this.PanelControl17.Controls.Add(this.btnexportselect);
            this.PanelControl17.Controls.Add(this.chkSelectAll);
            this.PanelControl17.Controls.Add(this.rbPurchaseGroupType);
            this.PanelControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl17.Location = new System.Drawing.Point(1, 1);
            this.PanelControl17.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl17.Name = "PanelControl17";
            this.PanelControl17.Size = new System.Drawing.Size(1316, 47);
            this.PanelControl17.TabIndex = 2;
            // 
            // btnPOComfortable
            // 
            this.btnPOComfortable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOComfortable.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOComfortable.Appearance.Options.UseFont = true;
            this.btnPOComfortable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPOComfortable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPOComfortable.ImageOptions.Image")));
            this.btnPOComfortable.Location = new System.Drawing.Point(937, 5);
            this.btnPOComfortable.Margin = new System.Windows.Forms.Padding(0);
            this.btnPOComfortable.Name = "btnPOComfortable";
            this.btnPOComfortable.Size = new System.Drawing.Size(29, 39);
            toolTipTitleItem40.Text = "Comfortable";
            toolTipItem38.LeftIndent = 6;
            toolTipItem38.Text = "Click here to set comfortable style";
            superToolTip40.Items.Add(toolTipTitleItem40);
            superToolTip40.Items.Add(toolTipItem38);
            this.btnPOComfortable.SuperTip = superToolTip40;
            this.btnPOComfortable.TabIndex = 8;
            this.btnPOComfortable.Click += new System.EventHandler(this.btnPOComfortable_Click);
            // 
            // btnGenPO
            // 
            this.btnGenPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenPO.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenPO.Appearance.Options.UseFont = true;
            this.btnGenPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGenPO.ImageOptions.Image = global::My.Resources.Resources.GeneratePO;
            this.btnGenPO.Location = new System.Drawing.Point(1197, 0);
            this.btnGenPO.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenPO.Name = "btnGenPO";
            this.btnGenPO.Size = new System.Drawing.Size(117, 43);
            this.btnGenPO.TabIndex = 0;
            this.btnGenPO.Click += new System.EventHandler(this.btnGenPO_Click);
            // 
            // btnPOCompact
            // 
            this.btnPOCompact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOCompact.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOCompact.Appearance.Options.UseFont = true;
            this.btnPOCompact.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPOCompact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPOCompact.ImageOptions.Image")));
            this.btnPOCompact.Location = new System.Drawing.Point(966, 5);
            this.btnPOCompact.Margin = new System.Windows.Forms.Padding(0);
            this.btnPOCompact.Name = "btnPOCompact";
            this.btnPOCompact.Size = new System.Drawing.Size(37, 39);
            toolTipTitleItem41.Text = "Compact";
            toolTipItem39.LeftIndent = 6;
            toolTipItem39.Text = "Click here to set compact style";
            superToolTip41.Items.Add(toolTipTitleItem41);
            superToolTip41.Items.Add(toolTipItem39);
            this.btnPOCompact.SuperTip = superToolTip41;
            this.btnPOCompact.TabIndex = 7;
            this.btnPOCompact.Click += new System.EventHandler(this.btnPOCompact_Click);
            // 
            // btnPOCozy
            // 
            this.btnPOCozy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOCozy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOCozy.Appearance.Options.UseFont = true;
            this.btnPOCozy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPOCozy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPOCozy.ImageOptions.Image")));
            this.btnPOCozy.Location = new System.Drawing.Point(898, 5);
            this.btnPOCozy.Margin = new System.Windows.Forms.Padding(0);
            this.btnPOCozy.Name = "btnPOCozy";
            this.btnPOCozy.Size = new System.Drawing.Size(35, 39);
            toolTipTitleItem42.Text = "Cozy";
            toolTipItem40.LeftIndent = 6;
            toolTipItem40.Text = "Click here to set cozy style";
            superToolTip42.Items.Add(toolTipTitleItem42);
            superToolTip42.Items.Add(toolTipItem40);
            this.btnPOCozy.SuperTip = superToolTip42;
            this.btnPOCozy.TabIndex = 6;
            this.btnPOCozy.Click += new System.EventHandler(this.btnPOCozy_Click);
            // 
            // btnexportselect
            // 
            this.btnexportselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportselect.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportselect.Appearance.Options.UseFont = true;
            this.btnexportselect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnexportselect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportselect.ImageOptions.Image")));
            this.btnexportselect.Location = new System.Drawing.Point(1011, 5);
            this.btnexportselect.Margin = new System.Windows.Forms.Padding(4);
            this.btnexportselect.Name = "btnexportselect";
            this.btnexportselect.Padding = new System.Windows.Forms.Padding(6);
            this.btnexportselect.Size = new System.Drawing.Size(173, 37);
            this.btnexportselect.TabIndex = 5;
            this.btnexportselect.Text = "Export Selected Items";
            this.btnexportselect.Click += new System.EventHandler(this.btnexportselect_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.EditValue = true;
            this.chkSelectAll.Location = new System.Drawing.Point(308, 15);
            this.chkSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.chkSelectAll.MenuManager = this.BarManager1;
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Properties.Caption = "Select All";
            this.chkSelectAll.Size = new System.Drawing.Size(88, 24);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // rbPurchaseGroupType
            // 
            this.rbPurchaseGroupType.EditValue = true;
            this.rbPurchaseGroupType.EnterMoveNextControl = true;
            this.rbPurchaseGroupType.Location = new System.Drawing.Point(4, 11);
            this.rbPurchaseGroupType.Margin = new System.Windows.Forms.Padding(4);
            this.rbPurchaseGroupType.Name = "rbPurchaseGroupType";
            this.rbPurchaseGroupType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rbPurchaseGroupType.Properties.Appearance.Options.UseBackColor = true;
            this.rbPurchaseGroupType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rbPurchaseGroupType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Job Wise Supplier PO"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Supplier Wise PO")});
            this.rbPurchaseGroupType.Size = new System.Drawing.Size(345, 30);
            this.rbPurchaseGroupType.TabIndex = 3;
            this.rbPurchaseGroupType.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.rbPurchaseGroupType_EditValueChanging);
            // 
            // pnlGeneratePurchaseOrder
            // 
            this.pnlGeneratePurchaseOrder.Controls.Add(this.lblGeneratePO);
            this.pnlGeneratePurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneratePurchaseOrder.Location = new System.Drawing.Point(6, 536);
            this.pnlGeneratePurchaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGeneratePurchaseOrder.Name = "pnlGeneratePurchaseOrder";
            this.pnlGeneratePurchaseOrder.Size = new System.Drawing.Size(1318, 41);
            this.pnlGeneratePurchaseOrder.TabIndex = 3;
            this.pnlGeneratePurchaseOrder.Click += new System.EventHandler(this.pnlGeneratePurchaseOrder_Click);
            // 
            // lblGeneratePO
            // 
            this.lblGeneratePO.Location = new System.Drawing.Point(10, 14);
            this.lblGeneratePO.Margin = new System.Windows.Forms.Padding(4);
            this.lblGeneratePO.Name = "lblGeneratePO";
            this.lblGeneratePO.Size = new System.Drawing.Size(145, 16);
            this.lblGeneratePO.TabIndex = 0;
            this.lblGeneratePO.Text = "Generate Purchase Order";
            this.lblGeneratePO.Click += new System.EventHandler(this.lblGeneratePO_Click);
            // 
            // gcSelection
            // 
            this.gcSelection.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelection.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSelection.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcSelection.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSelection.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcSelection.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSelection.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcSelection.Location = new System.Drawing.Point(6, 313);
            this.gcSelection.MainView = this.gvSelection;
            this.gcSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gcSelection.Name = "gcSelection";
            this.gcSelection.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbSupplier});
            this.gcSelection.Size = new System.Drawing.Size(1318, 219);
            this.gcSelection.TabIndex = 1;
            this.gcSelection.UseEmbeddedNavigator = true;
            this.gcSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelection,
            this.GridView1});
            // 
            // gvSelection
            // 
            this.gvSelection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvSelection.ColumnPanelRowHeight = 43;
            this.gvSelection.DetailHeight = 431;
            this.gvSelection.GridControl = this.gcSelection;
            this.gvSelection.Name = "gvSelection";
            this.gvSelection.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gvSelection.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvSelection.OptionsPrint.ExpandAllDetails = true;
            this.gvSelection.OptionsPrint.PrintDetails = true;
            this.gvSelection.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvSelection.OptionsView.RowAutoHeight = true;
            this.gvSelection.OptionsView.ShowAutoFilterRow = true;
            this.gvSelection.OptionsView.ShowGroupPanel = false;
            this.gvSelection.RowHeight = 31;
            this.gvSelection.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvSelection_CustomDrawCell);
            this.gvSelection.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvSelection_RowStyle);
            this.gvSelection.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvSelection_CustomRowCellEdit);
            this.gvSelection.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvSelection_CustomRowCellEditForEditing);
            this.gvSelection.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSelection_CellValueChanged);
            this.gvSelection.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSelection_CellValueChanging);
            this.gvSelection.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvSelection_ValidateRow);
            this.gvSelection.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvSelection_CustomColumnDisplayText);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoHeight = false;
            this.cmbSupplier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.EditValueChanged += new System.EventHandler(this.cmbSupplier_EditValueChanged_1);
            // 
            // GridView1
            // 
            this.GridView1.DetailHeight = 431;
            this.GridView1.GridControl = this.gcSelection;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // pnlMainSelection
            // 
            this.pnlMainSelection.Controls.Add(this.StandaloneBarDockControl3);
            this.pnlMainSelection.Controls.Add(this.lblSelection);
            this.pnlMainSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainSelection.Location = new System.Drawing.Point(6, 6);
            this.pnlMainSelection.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainSelection.Name = "pnlMainSelection";
            this.pnlMainSelection.Size = new System.Drawing.Size(1318, 34);
            this.pnlMainSelection.TabIndex = 1;
            this.pnlMainSelection.Click += new System.EventHandler(this.pnlMainSelection_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelection.Location = new System.Drawing.Point(10, 12);
            this.lblSelection.Margin = new System.Windows.Forms.Padding(4);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(52, 16);
            this.lblSelection.TabIndex = 0;
            this.lblSelection.Text = "Selection";
            this.lblSelection.Click += new System.EventHandler(this.lblSelection_Click);
            // 
            // tabQuotation
            // 
            this.tabQuotation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tabQuotation.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tabQuotation.Location = new System.Drawing.Point(2, 800);
            this.tabQuotation.Margin = new System.Windows.Forms.Padding(0);
            this.tabQuotation.Name = "tabQuotation";
            this.tabQuotation.SelectedTabPage = this.TabPageReferenceSelection;
            this.tabQuotation.Size = new System.Drawing.Size(117, 47);
            this.tabQuotation.TabIndex = 0;
            this.tabQuotation.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageReferenceSelection,
            this.TabPageSelection,
            this.TabPageGeneratePO});
            this.tabQuotation.Visible = false;
            this.tabQuotation.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabQuotation_SelectedPageChanged);
            // 
            // TabPageReferenceSelection
            // 
            this.TabPageReferenceSelection.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.TabPageReferenceSelection.Appearance.PageClient.BorderColor = System.Drawing.Color.Black;
            this.TabPageReferenceSelection.Appearance.PageClient.Options.UseBackColor = true;
            this.TabPageReferenceSelection.Appearance.PageClient.Options.UseBorderColor = true;
            this.TabPageReferenceSelection.Controls.Add(this.TableLayoutPanel4);
            this.TabPageReferenceSelection.Controls.Add(this.PanelControl13);
            this.TabPageReferenceSelection.Controls.Add(this.PanelControl14);
            this.TabPageReferenceSelection.Controls.Add(this.PanelControl15);
            this.TabPageReferenceSelection.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageReferenceSelection.Name = "TabPageReferenceSelection";
            this.TabPageReferenceSelection.PageEnabled = false;
            this.TabPageReferenceSelection.PageVisible = false;
            this.TabPageReferenceSelection.Size = new System.Drawing.Size(115, 17);
            this.TabPageReferenceSelection.Text = "SELECTION";
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel4.Controls.Add(this.PanelControl4, 0, 0);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(0, 34);
            this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 2;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(115, 0);
            this.TableLayoutPanel4.TabIndex = 3;
            // 
            // PanelControl4
            // 
            this.PanelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl4.Appearance.Options.UseBackColor = true;
            this.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl4.Location = new System.Drawing.Point(1, 1);
            this.PanelControl4.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl4.Name = "PanelControl4";
            this.PanelControl4.Size = new System.Drawing.Size(113, 52);
            this.PanelControl4.TabIndex = 3;
            // 
            // PanelControl13
            // 
            this.PanelControl13.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl13.Appearance.Options.UseBackColor = true;
            this.PanelControl13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl13.Controls.Add(this.standJobMaster);
            this.PanelControl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl13.Location = new System.Drawing.Point(0, 0);
            this.PanelControl13.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl13.Name = "PanelControl13";
            this.PanelControl13.Size = new System.Drawing.Size(115, 34);
            this.PanelControl13.TabIndex = 0;
            // 
            // PanelControl14
            // 
            this.PanelControl14.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl14.Appearance.Options.UseBackColor = true;
            this.PanelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl14.Controls.Add(this.btnNext);
            this.PanelControl14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl14.Location = new System.Drawing.Point(0, -32);
            this.PanelControl14.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControl14.Name = "PanelControl14";
            this.PanelControl14.Size = new System.Drawing.Size(115, 49);
            this.PanelControl14.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNext.Location = new System.Drawing.Point(13, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(6);
            this.btnNext.Size = new System.Drawing.Size(93, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            // 
            // PanelControl15
            // 
            this.PanelControl15.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl15.Appearance.Options.UseBackColor = true;
            this.PanelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl15.Controls.Add(this.PanelControl16);
            this.PanelControl15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl15.Location = new System.Drawing.Point(0, 0);
            this.PanelControl15.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl15.Name = "PanelControl15";
            this.PanelControl15.Size = new System.Drawing.Size(115, 17);
            this.PanelControl15.TabIndex = 0;
            // 
            // PanelControl16
            // 
            this.PanelControl16.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl16.Appearance.Options.UseBackColor = true;
            this.PanelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl16.Controls.Add(this.btnGeneratePOPre);
            this.PanelControl16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl16.Location = new System.Drawing.Point(0, -32);
            this.PanelControl16.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControl16.Name = "PanelControl16";
            this.PanelControl16.Size = new System.Drawing.Size(115, 49);
            this.PanelControl16.TabIndex = 1;
            // 
            // btnGeneratePOPre
            // 
            this.btnGeneratePOPre.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGeneratePOPre.Appearance.Options.UseFont = true;
            this.btnGeneratePOPre.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGeneratePOPre.Location = new System.Drawing.Point(7, 7);
            this.btnGeneratePOPre.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneratePOPre.Name = "btnGeneratePOPre";
            this.btnGeneratePOPre.Padding = new System.Windows.Forms.Padding(6);
            this.btnGeneratePOPre.Size = new System.Drawing.Size(93, 34);
            this.btnGeneratePOPre.TabIndex = 8;
            this.btnGeneratePOPre.Text = "Previous";
            // 
            // TabPageSelection
            // 
            this.TabPageSelection.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.TabPageSelection.Appearance.PageClient.BorderColor = System.Drawing.Color.Black;
            this.TabPageSelection.Appearance.PageClient.Options.UseBackColor = true;
            this.TabPageSelection.Appearance.PageClient.Options.UseBorderColor = true;
            this.TabPageSelection.Controls.Add(this.PanelControl2);
            this.TabPageSelection.Controls.Add(this.PanelControl18);
            this.TabPageSelection.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageSelection.Name = "TabPageSelection";
            this.TabPageSelection.PageEnabled = false;
            this.TabPageSelection.PageVisible = false;
            this.TabPageSelection.Size = new System.Drawing.Size(115, 17);
            this.TabPageSelection.Text = "Selection";
            // 
            // PanelControl2
            // 
            this.PanelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl2.Appearance.Options.UseBackColor = true;
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.panelglass);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl2.Location = new System.Drawing.Point(0, 0);
            this.PanelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(115, 0);
            this.PanelControl2.TabIndex = 10;
            // 
            // panelglass
            // 
            this.panelglass.Appearance.BackColor = System.Drawing.Color.White;
            this.panelglass.Appearance.Options.UseBackColor = true;
            this.panelglass.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelglass.Controls.Add(this.chkselall);
            this.panelglass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelglass.Location = new System.Drawing.Point(0, 0);
            this.panelglass.Margin = new System.Windows.Forms.Padding(0);
            this.panelglass.Name = "panelglass";
            this.panelglass.Size = new System.Drawing.Size(115, 0);
            this.panelglass.TabIndex = 8;
            this.panelglass.Visible = false;
            // 
            // chkselall
            // 
            this.chkselall.Location = new System.Drawing.Point(10, 10);
            this.chkselall.Margin = new System.Windows.Forms.Padding(4);
            this.chkselall.MenuManager = this.BarManager1;
            this.chkselall.Name = "chkselall";
            this.chkselall.Properties.Caption = "Select All";
            this.chkselall.Size = new System.Drawing.Size(88, 24);
            this.chkselall.TabIndex = 5;
            this.chkselall.CheckedChanged += new System.EventHandler(this.chkselall_CheckedChanged);
            // 
            // PanelControl18
            // 
            this.PanelControl18.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelControl18.Appearance.Options.UseBackColor = true;
            this.PanelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl18.Controls.Add(this.btnSelectionPrev);
            this.PanelControl18.Controls.Add(this.btnSaveSelection);
            this.PanelControl18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl18.Location = new System.Drawing.Point(0, -32);
            this.PanelControl18.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControl18.Name = "PanelControl18";
            this.PanelControl18.Size = new System.Drawing.Size(115, 49);
            this.PanelControl18.TabIndex = 4;
            // 
            // btnSelectionPrev
            // 
            this.btnSelectionPrev.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectionPrev.Appearance.Options.UseFont = true;
            this.btnSelectionPrev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSelectionPrev.Location = new System.Drawing.Point(7, 7);
            this.btnSelectionPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectionPrev.Name = "btnSelectionPrev";
            this.btnSelectionPrev.Padding = new System.Windows.Forms.Padding(6);
            this.btnSelectionPrev.Size = new System.Drawing.Size(93, 34);
            this.btnSelectionPrev.TabIndex = 7;
            this.btnSelectionPrev.Text = "Previous";
            this.btnSelectionPrev.Click += new System.EventHandler(this.btnSelectionPrev_Click);
            // 
            // btnSaveSelection
            // 
            this.btnSaveSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSelection.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveSelection.Appearance.Options.UseFont = true;
            this.btnSaveSelection.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSaveSelection.Location = new System.Drawing.Point(13, 7);
            this.btnSaveSelection.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSelection.Name = "btnSaveSelection";
            this.btnSaveSelection.Padding = new System.Windows.Forms.Padding(6);
            this.btnSaveSelection.Size = new System.Drawing.Size(93, 34);
            this.btnSaveSelection.TabIndex = 6;
            this.btnSaveSelection.Text = "Next";
            this.btnSaveSelection.Click += new System.EventHandler(this.btnSaveSelection_Click);
            // 
            // TabPageGeneratePO
            // 
            this.TabPageGeneratePO.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.TabPageGeneratePO.Appearance.PageClient.BorderColor = System.Drawing.Color.Black;
            this.TabPageGeneratePO.Appearance.PageClient.Options.UseBackColor = true;
            this.TabPageGeneratePO.Appearance.PageClient.Options.UseBorderColor = true;
            this.TabPageGeneratePO.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageGeneratePO.Name = "TabPageGeneratePO";
            this.TabPageGeneratePO.PageEnabled = false;
            this.TabPageGeneratePO.PageVisible = false;
            this.TabPageGeneratePO.Size = new System.Drawing.Size(115, 17);
            this.TabPageGeneratePO.Text = "GENERATE PURCHASE ORDER";
            // 
            // pnlMainPOType
            // 
            this.pnlMainPOType.Controls.Add(this.lblPoType);
            this.pnlMainPOType.Controls.Add(this.StandaloneBarDockControl1);
            this.pnlMainPOType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPOType.Location = new System.Drawing.Point(6, 268);
            this.pnlMainPOType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 2);
            this.pnlMainPOType.Name = "pnlMainPOType";
            this.pnlMainPOType.Size = new System.Drawing.Size(1318, 43);
            this.pnlMainPOType.TabIndex = 2;
            this.pnlMainPOType.Click += new System.EventHandler(this.lblPoType_Click);
            // 
            // lblPoType
            // 
            this.lblPoType.Location = new System.Drawing.Point(10, 14);
            this.lblPoType.Margin = new System.Windows.Forms.Padding(4);
            this.lblPoType.Name = "lblPoType";
            this.lblPoType.Size = new System.Drawing.Size(48, 16);
            this.lblPoType.TabIndex = 0;
            this.lblPoType.Text = "PO Type";
            this.lblPoType.Click += new System.EventHandler(this.lblPoType_Click);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.txtJobNo);
            this.layoutControl3.Controls.Add(this.dtFromDate);
            this.layoutControl3.Controls.Add(this.btnSearch);
            this.layoutControl3.Controls.Add(this.dtToDate);
            this.layoutControl3.Controls.Add(this.chkSelect);
            this.layoutControl3.Controls.Add(this.gcProcurementJobList);
            this.layoutControl3.Controls.Add(this.rgProcurementType);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(6, 48);
            this.layoutControl3.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.Root;
            this.layoutControl3.Size = new System.Drawing.Size(1318, 211);
            this.layoutControl3.TabIndex = 5;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // txtJobNo
            // 
            this.txtJobNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJobNo.Location = new System.Drawing.Point(83, 2);
            this.txtJobNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobNo.MenuManager = this.BarManager1;
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(129, 26);
            this.txtJobNo.StyleController = this.layoutControl3;
            this.txtJobNo.TabIndex = 1;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtFromDate.EditValue = null;
            this.dtFromDate.EnterMoveNextControl = true;
            this.dtFromDate.Location = new System.Drawing.Point(346, 2);
            this.dtFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFromDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.dtFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFromDate.Properties.EditFormat.FormatString = "dd-MMM-yyyy";
            this.dtFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFromDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtFromDate.Properties.MaskSettings.Set("mask", "dd-MMM-yyyy");
            this.dtFromDate.Size = new System.Drawing.Size(114, 26);
            this.dtFromDate.StyleController = this.layoutControl3;
            this.dtFromDate.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(736, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(7, 6, 6, 6);
            this.btnSearch.Size = new System.Drawing.Size(93, 38);
            this.btnSearch.StyleController = this.layoutControl3;
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtToDate.EditValue = null;
            this.dtToDate.EnterMoveNextControl = true;
            this.dtToDate.Location = new System.Drawing.Point(489, 2);
            this.dtToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtToDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.dtToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtToDate.Properties.EditFormat.FormatString = "dd-MMM-yyyy";
            this.dtToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtToDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtToDate.Properties.MaskSettings.Set("mask", "dd-MMM-yyyy");
            this.dtToDate.Size = new System.Drawing.Size(123, 26);
            this.dtToDate.StyleController = this.layoutControl3;
            this.dtToDate.TabIndex = 5;
            // 
            // chkSelect
            // 
            this.chkSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSelect.Location = new System.Drawing.Point(2, 44);
            this.chkSelect.Margin = new System.Windows.Forms.Padding(4);
            this.chkSelect.MenuManager = this.BarManager1;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Properties.Caption = "Select All";
            this.chkSelect.Size = new System.Drawing.Size(210, 24);
            this.chkSelect.StyleController = this.layoutControl3;
            this.chkSelect.TabIndex = 7;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // gcProcurementJobList
            // 
            this.gcProcurementJobList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProcurementJobList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProcurementJobList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProcurementJobList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProcurementJobList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProcurementJobList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcProcurementJobList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcProcurementJobList.Location = new System.Drawing.Point(2, 112);
            this.gcProcurementJobList.MainView = this.gvProcurementJobList;
            this.gcProcurementJobList.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.gcProcurementJobList.MenuManager = this.BarManager1;
            this.gcProcurementJobList.Name = "gcProcurementJobList";
            this.gcProcurementJobList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepSel,
            this.JobProSel});
            this.gcProcurementJobList.Size = new System.Drawing.Size(1314, 97);
            this.gcProcurementJobList.TabIndex = 0;
            this.gcProcurementJobList.TabStop = false;
            this.gcProcurementJobList.Tag = "Procurement Job List";
            this.gcProcurementJobList.UseEmbeddedNavigator = true;
            this.gcProcurementJobList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProcurementJobList,
            this.GridView2});
            // 
            // gvProcurementJobList
            // 
            this.gvProcurementJobList.ColumnPanelRowHeight = 43;
            this.gvProcurementJobList.DetailHeight = 431;
            this.gvProcurementJobList.GridControl = this.gcProcurementJobList;
            this.gvProcurementJobList.Name = "gvProcurementJobList";
            this.gvProcurementJobList.OptionsCustomization.AllowGroup = false;
            this.gvProcurementJobList.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvProcurementJobList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gvProcurementJobList.OptionsLayout.Columns.StoreAppearance = true;
            this.gvProcurementJobList.OptionsLayout.StoreAllOptions = true;
            this.gvProcurementJobList.OptionsLayout.StoreAppearance = true;
            this.gvProcurementJobList.OptionsLayout.StoreFormatRules = true;
            this.gvProcurementJobList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvProcurementJobList.OptionsView.ShowAutoFilterRow = true;
            this.gvProcurementJobList.OptionsView.ShowGroupPanel = false;
            this.gvProcurementJobList.RowHeight = 31;
            this.gvProcurementJobList.Tag = "Procurement Job List";
            this.gvProcurementJobList.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvProcurementJobList_CustomDrawCell);
            this.gvProcurementJobList.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvProcurementJobList_RowStyle);
            // 
            // RepSel
            // 
            this.RepSel.AutoHeight = false;
            this.RepSel.Name = "RepSel";
            // 
            // JobProSel
            // 
            this.JobProSel.AutoHeight = false;
            this.JobProSel.Name = "JobProSel";
            this.JobProSel.CheckedChanged += new System.EventHandler(this.JobProSel_CheckedChanged);
            // 
            // GridView2
            // 
            this.GridView2.DetailHeight = 431;
            this.GridView2.GridControl = this.gcProcurementJobList;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // rgProcurementType
            // 
            this.rgProcurementType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rgProcurementType.Location = new System.Drawing.Point(346, 44);
            this.rgProcurementType.Margin = new System.Windows.Forms.Padding(4);
            this.rgProcurementType.MenuManager = this.BarManager1;
            this.rgProcurementType.Name = "rgProcurementType";
            this.rgProcurementType.Properties.Columns = 4;
            this.rgProcurementType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Glass", "Glass"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Profile", "Profile"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Accessory", "Accessory"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Hardware", "Hardware")});
            this.rgProcurementType.Size = new System.Drawing.Size(358, 46);
            this.rgProcurementType.StyleController = this.layoutControl3;
            this.rgProcurementType.TabIndex = 9;
            this.rgProcurementType.EditValueChanged += new System.EventHandler(this.rgProcurementType_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem4,
            this.layoutControlItem12,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.emptySpaceItem5,
            this.layoutProcess,
            this.emptySpaceItem7,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.layoutControlItem11});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1318, 211);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gcProcurementJobList;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1318, 101);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtJobNo;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(214, 42);
            this.layoutControlItem9.Text = "Job Number:";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(76, 16);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.dtFromDate;
            this.layoutControlItem10.Location = new System.Drawing.Point(214, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(248, 42);
            this.layoutControlItem10.Text = "Date from:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(118, 16);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(649, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(85, 42);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnSearch;
            this.layoutControlItem12.Location = new System.Drawing.Point(734, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(97, 42);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkSelect;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(214, 50);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.rgProcurementType;
            this.layoutControlItem5.Location = new System.Drawing.Point(214, 42);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(492, 50);
            this.layoutControlItem5.Text = "Procurement Type*:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(118, 16);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(706, 42);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(125, 68);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutProcess
            // 
            this.layoutProcess.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem6});
            this.layoutProcess.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutProcess.Location = new System.Drawing.Point(900, 0);
            this.layoutProcess.Name = "layoutProcess";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 10D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 10D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 20D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 10D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition6.Width = 20D;
            this.layoutProcess.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition1.Height = 22D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutProcess.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.layoutProcess.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutProcess.Size = new System.Drawing.Size(418, 110);
            this.layoutProcess.Text = "Status Name:";
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(44, 79);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(831, 0);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(69, 110);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(69, 110);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(69, 110);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 92);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(706, 18);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(614, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(35, 42);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dtToDate;
            this.layoutControlItem11.Location = new System.Drawing.Point(462, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(152, 42);
            this.layoutControlItem11.Text = "To:";
            this.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(20, 16);
            this.layoutControlItem11.TextToControlDistance = 5;
            // 
            // grpQuotationCorrespondence
            // 
            this.grpQuotationCorrespondence.Controls.Add(this.gridQuotationChasing);
            this.grpQuotationCorrespondence.Controls.Add(this.StandaloneBarDockControl2);
            this.grpQuotationCorrespondence.Location = new System.Drawing.Point(1301, 590);
            this.grpQuotationCorrespondence.Margin = new System.Windows.Forms.Padding(4);
            this.grpQuotationCorrespondence.Name = "grpQuotationCorrespondence";
            this.grpQuotationCorrespondence.Size = new System.Drawing.Size(121, 59);
            this.grpQuotationCorrespondence.TabIndex = 1;
            this.grpQuotationCorrespondence.Text = "Correspondence";
            // 
            // gridQuotationChasing
            // 
            this.gridQuotationChasing.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridQuotationChasing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQuotationChasing.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridQuotationChasing.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridQuotationChasing.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridQuotationChasing.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridQuotationChasing.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridQuotationChasing.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridQuotationChasing.Location = new System.Drawing.Point(2, 63);
            this.gridQuotationChasing.MainView = this.dtgQuotationChasingDetails;
            this.gridQuotationChasing.Margin = new System.Windows.Forms.Padding(4);
            this.gridQuotationChasing.Name = "gridQuotationChasing";
            this.gridQuotationChasing.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepCusotmer,
            this.RepStatus});
            this.gridQuotationChasing.Size = new System.Drawing.Size(117, 0);
            this.gridQuotationChasing.TabIndex = 0;
            this.gridQuotationChasing.Tag = "Quotation Correspondence";
            this.gridQuotationChasing.UseEmbeddedNavigator = true;
            this.gridQuotationChasing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgQuotationChasingDetails});
            // 
            // dtgQuotationChasingDetails
            // 
            this.dtgQuotationChasingDetails.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dtgQuotationChasingDetails.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dtgQuotationChasingDetails.ColumnPanelRowHeight = 43;
            this.dtgQuotationChasingDetails.DetailHeight = 431;
            this.dtgQuotationChasingDetails.GridControl = this.gridQuotationChasing;
            this.dtgQuotationChasingDetails.Name = "dtgQuotationChasingDetails";
            this.dtgQuotationChasingDetails.OptionsBehavior.AllowIncrementalSearch = true;
            this.dtgQuotationChasingDetails.OptionsDetail.ShowDetailTabs = false;
            this.dtgQuotationChasingDetails.OptionsEditForm.PopupEditFormWidth = 933;
            this.dtgQuotationChasingDetails.OptionsLayout.Columns.AddNewColumns = false;
            this.dtgQuotationChasingDetails.OptionsLayout.Columns.RemoveOldColumns = false;
            this.dtgQuotationChasingDetails.OptionsView.ShowAutoFilterRow = true;
            this.dtgQuotationChasingDetails.OptionsView.ShowGroupPanel = false;
            this.dtgQuotationChasingDetails.Tag = "Quotation Correspondence";
            // 
            // RepCusotmer
            // 
            this.RepCusotmer.AutoHeight = false;
            this.RepCusotmer.Name = "RepCusotmer";
            // 
            // RepStatus
            // 
            this.RepStatus.AutoHeight = false;
            this.RepStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepStatus.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Completed", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Job Completed", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Estimate", 2, 2)});
            this.RepStatus.Name = "RepStatus";
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Tools";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar1.FloatLocation = new System.Drawing.Point(64, 463);
            this.Bar1.OptionsBar.AllowQuickCustomization = false;
            this.Bar1.OptionsBar.DrawDragBorder = false;
            this.Bar1.OptionsBar.UseWholeRow = true;
            this.Bar1.Text = "Tools";
            // 
            // popupEnquiryChasing
            // 
            this.popupEnquiryChasing.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popAddNewCorrespondence),
            new DevExpress.XtraBars.LinkPersistInfo(this.popEditCorrespondence),
            new DevExpress.XtraBars.LinkPersistInfo(this.popDeleteCorrespondence),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportToExcel)});
            this.popupEnquiryChasing.Manager = this.BarManager1;
            this.popupEnquiryChasing.Name = "popupEnquiryChasing";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "Save Layout";
            this.btnSaveLayout.Id = 3;
            this.btnSaveLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveLayout.ImageOptions.Image")));
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem16.Text = "Save Layout";
            toolTipItem16.LeftIndent = 6;
            toolTipItem16.Text = "Click here to save layout of the Listing";
            superToolTip16.Items.Add(toolTipTitleItem16);
            superToolTip16.Items.Add(toolTipItem16);
            this.btnSaveLayout.SuperTip = superToolTip16;
            // 
            // btnResetLayout
            // 
            this.btnResetLayout.Caption = "Reset Layout";
            this.btnResetLayout.Id = 4;
            this.btnResetLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetLayout.ImageOptions.Image")));
            this.btnResetLayout.Name = "btnResetLayout";
            this.btnResetLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem17.Text = "Reset Layout";
            toolTipItem17.LeftIndent = 6;
            toolTipItem17.Text = "Click here to Reset Layout of the Listing";
            superToolTip17.Items.Add(toolTipTitleItem17);
            superToolTip17.Items.Add(toolTipItem17);
            this.btnResetLayout.SuperTip = superToolTip17;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem18.Text = "Refresh";
            toolTipItem18.LeftIndent = 6;
            toolTipItem18.Text = "Click here to refresh the Listing";
            superToolTip18.Items.Add(toolTipTitleItem18);
            superToolTip18.Items.Add(toolTipItem18);
            this.btnRefresh.SuperTip = superToolTip18;
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Export To Excel";
            this.btnExport.Id = 7;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnExport.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnExport.Name = "btnExport";
            this.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem20.Text = "Export To Excel";
            toolTipItem20.LeftIndent = 6;
            toolTipItem20.Text = "Click here to Export the Listing To Excel";
            superToolTip20.Items.Add(toolTipTitleItem20);
            superToolTip20.Items.Add(toolTipItem20);
            this.btnExport.SuperTip = superToolTip20;
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add New";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem13.Text = "Add New   (Ctrl+N)";
            toolTipItem13.LeftIndent = 6;
            toolTipItem13.Text = "Click here Add new item...";
            superToolTip13.Items.Add(toolTipTitleItem13);
            superToolTip13.Items.Add(toolTipItem13);
            this.btnAdd.SuperTip = superToolTip13;
            this.btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem14.Text = "Edit   (Ctrl+E)";
            toolTipItem14.LeftIndent = 6;
            toolTipItem14.Text = "Click here to Edit selected item...";
            superToolTip14.Items.Add(toolTipTitleItem14);
            superToolTip14.Items.Add(toolTipItem14);
            this.btnEdit.SuperTip = superToolTip14;
            this.btnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem15.Text = "Delete   (Ctrl+D)";
            toolTipItem15.LeftIndent = 6;
            toolTipItem15.Text = "Click here to Delete selected item...";
            superToolTip15.Items.Add(toolTipTitleItem15);
            superToolTip15.Items.Add(toolTipItem15);
            this.btnDelete.SuperTip = superToolTip15;
            this.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnCopyPO
            // 
            this.btnCopyPO.Caption = "Copy PO";
            this.btnCopyPO.Id = 15;
            this.btnCopyPO.Name = "btnCopyPO";
            toolTipTitleItem21.Text = "Copy PO";
            toolTipItem21.LeftIndent = 6;
            toolTipItem21.Text = "Click here to copy selected PO";
            superToolTip21.Items.Add(toolTipTitleItem21);
            superToolTip21.Items.Add(toolTipItem21);
            this.btnCopyPO.SuperTip = superToolTip21;
            this.btnCopyPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnPOFilter
            // 
            this.btnPOFilter.Caption = "Filter";
            this.btnPOFilter.Id = 6;
            this.btnPOFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPOFilter.ImageOptions.Image")));
            this.btnPOFilter.Name = "btnPOFilter";
            this.btnPOFilter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem19.Text = "Filter  (Ctrl+F)";
            toolTipItem19.LeftIndent = 6;
            toolTipItem19.Text = "Click here to Filter the Listing";
            superToolTip19.Items.Add(toolTipTitleItem19);
            superToolTip19.Items.Add(toolTipItem19);
            this.btnPOFilter.SuperTip = superToolTip19;
            this.btnPOFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // LEPOType
            // 
            this.LEPOType.Caption = "BarEditItem1";
            this.LEPOType.Edit = this.RepPOType;
            this.LEPOType.Id = 19;
            this.LEPOType.Name = "LEPOType";
            toolTipTitleItem22.Text = "Item type";
            toolTipItem22.LeftIndent = 6;
            toolTipItem22.Text = "Select Item type to see records ItemType Wise";
            superToolTip22.Items.Add(toolTipTitleItem22);
            superToolTip22.Items.Add(toolTipItem22);
            this.LEPOType.SuperTip = superToolTip22;
            this.LEPOType.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // BarCompBranch
            // 
            this.BarCompBranch.Caption = "Company Branch";
            this.BarCompBranch.Edit = this.RepCompBranch;
            this.BarCompBranch.EditWidth = 217;
            this.BarCompBranch.Id = 22;
            this.BarCompBranch.Name = "BarCompBranch";
            toolTipTitleItem23.Text = "Company Branch";
            toolTipItem23.LeftIndent = 6;
            toolTipItem23.Text = "Select Company Branch to see records Branch Wise";
            superToolTip23.Items.Add(toolTipTitleItem23);
            superToolTip23.Items.Add(toolTipItem23);
            this.BarCompBranch.SuperTip = superToolTip23;
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
            // BarManager2
            // 
            this.BarManager2.AllowCustomization = false;
            this.BarManager2.AllowMoveBarOnToolbar = false;
            this.BarManager2.AllowQuickCustomization = false;
            this.BarManager2.AllowShowToolbarsPopup = false;
            this.BarManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar15});
            this.BarManager2.DockControls.Add(this.BarDockControl1);
            this.BarManager2.DockControls.Add(this.BarDockControl2);
            this.BarManager2.DockControls.Add(this.BarDockControl3);
            this.BarManager2.DockControls.Add(this.BarDockControl4);
            this.BarManager2.Form = this;
            this.BarManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSaveLayout,
            this.btnResetLayout,
            this.btnRefresh,
            this.btnPOFilter,
            this.btnExport,
            this.popAdd,
            this.popEdit,
            this.popdelete,
            this.mnuSaveLayout,
            this.mnuResetLayout,
            this.BarButtonItem4,
            this.BarButtonItem5,
            this.btnCopyPO,
            this.popCopyPO,
            this.mnuFilter,
            this.cmbPOType,
            this.LEPOType,
            this.btnGoodsReceiptNote,
            this.btnGoodsReceipt,
            this.BarCompBranch,
            this.btnReceiveBarcode,
            this.BarButtonItem95});
            this.BarManager2.MaxItemId = 25;
            this.BarManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemComboBox1,
            this.RepPOType,
            this.RepCompBranch});
            // 
            // Bar15
            // 
            this.Bar15.BarName = "SelectionTabTools";
            this.Bar15.DockCol = 0;
            this.Bar15.DockRow = 0;
            this.Bar15.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar15.FloatLocation = new System.Drawing.Point(506, 388);
            this.Bar15.FloatSize = new System.Drawing.Size(187, 155);
            this.Bar15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.chkOrderAsPerReqQty, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSetDefaultSupplier, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelCozy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelComfortable),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelCompact),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectionResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectionSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectionRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectionExportExcel, true)});
            this.Bar15.OptionsBar.AllowQuickCustomization = false;
            this.Bar15.OptionsBar.DrawBorder = false;
            this.Bar15.OptionsBar.UseWholeRow = true;
            this.Bar15.StandaloneBarDockControl = this.StandaloneBarDockControl1;
            this.Bar15.Text = "SelectionTabTools";
            // 
            // BarDockControl1
            // 
            this.BarDockControl1.CausesValidation = false;
            this.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl1.Manager = this.BarManager2;
            this.BarDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl1.Size = new System.Drawing.Size(1330, 0);
            // 
            // BarDockControl2
            // 
            this.BarDockControl2.CausesValidation = false;
            this.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl2.Location = new System.Drawing.Point(0, 876);
            this.BarDockControl2.Manager = this.BarManager2;
            this.BarDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl2.Size = new System.Drawing.Size(1330, 0);
            // 
            // BarDockControl3
            // 
            this.BarDockControl3.CausesValidation = false;
            this.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl3.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl3.Manager = this.BarManager2;
            this.BarDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl3.Size = new System.Drawing.Size(0, 876);
            // 
            // BarDockControl4
            // 
            this.BarDockControl4.CausesValidation = false;
            this.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl4.Location = new System.Drawing.Point(1330, 0);
            this.BarDockControl4.Manager = this.BarManager2;
            this.BarDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl4.Size = new System.Drawing.Size(0, 876);
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
            // popdelete
            // 
            this.popdelete.Caption = "Delete";
            this.popdelete.Id = 10;
            this.popdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("popdelete.ImageOptions.Image")));
            this.popdelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.popdelete.Name = "popdelete";
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
            // BarButtonItem4
            // 
            this.BarButtonItem4.Caption = "Print";
            this.BarButtonItem4.Id = 13;
            this.BarButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem4.ImageOptions.Image")));
            this.BarButtonItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.BarButtonItem4.Name = "BarButtonItem4";
            // 
            // BarButtonItem5
            // 
            this.BarButtonItem5.Caption = "Export To Excel";
            this.BarButtonItem5.Id = 14;
            this.BarButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem5.ImageOptions.Image")));
            this.BarButtonItem5.Name = "BarButtonItem5";
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
            toolTipTitleItem24.Text = "Receive Barcode";
            superToolTip24.Items.Add(toolTipTitleItem24);
            this.btnReceiveBarcode.SuperTip = superToolTip24;
            // 
            // BarButtonItem95
            // 
            this.BarButtonItem95.Caption = "BarButtonItem95";
            this.BarButtonItem95.Id = 24;
            this.BarButtonItem95.Name = "BarButtonItem95";
            // 
            // btnCozy
            // 
            this.btnCozy.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCozy.Caption = "Cozy";
            this.btnCozy.Id = 31;
            this.btnCozy.ImageOptions.DisabledImageIndex = 0;
            this.btnCozy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCozy.ImageOptions.Image")));
            this.btnCozy.ImageOptions.ImageIndex = 0;
            this.btnCozy.Name = "btnCozy";
            toolTipTitleItem25.Text = "Cozy";
            toolTipItem24.LeftIndent = 6;
            toolTipItem24.Text = "Click here to set cozy style";
            superToolTip25.Items.Add(toolTipTitleItem25);
            superToolTip25.Items.Add(toolTipItem24);
            this.btnCozy.SuperTip = superToolTip25;
            this.btnCozy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCozy_ItemClick);
            // 
            // btnCompact
            // 
            this.btnCompact.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCompact.Caption = "Compact";
            this.btnCompact.Id = 32;
            this.btnCompact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCompact.ImageOptions.Image")));
            this.btnCompact.Name = "btnCompact";
            toolTipTitleItem27.Text = "Compact";
            toolTipItem26.LeftIndent = 6;
            toolTipItem26.Text = "Click here to set compact style";
            superToolTip27.Items.Add(toolTipTitleItem27);
            superToolTip27.Items.Add(toolTipItem26);
            this.btnCompact.SuperTip = superToolTip27;
            this.btnCompact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompact_ItemClick);
            // 
            // btnComfortable
            // 
            this.btnComfortable.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnComfortable.Caption = "Comfortable";
            this.btnComfortable.Id = 31;
            this.btnComfortable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnComfortable.ImageOptions.Image")));
            this.btnComfortable.Name = "btnComfortable";
            toolTipTitleItem26.Text = "Comfortable";
            toolTipItem25.LeftIndent = 6;
            toolTipItem25.Text = "Click here to set comfortable style";
            superToolTip26.Items.Add(toolTipTitleItem26);
            superToolTip26.Items.Add(toolTipItem25);
            this.btnComfortable.SuperTip = superToolTip26;
            this.btnComfortable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnComfortable_ItemClick);
            // 
            // BarDockControl9
            // 
            this.BarDockControl9.CausesValidation = false;
            this.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl9.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl9.Manager = null;
            this.BarDockControl9.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl8
            // 
            this.BarDockControl8.CausesValidation = false;
            this.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl8.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl8.Manager = null;
            this.BarDockControl8.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl10
            // 
            this.BarDockControl10.CausesValidation = false;
            this.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl10.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl10.Manager = null;
            this.BarDockControl10.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl7
            // 
            this.BarDockControl7.CausesValidation = false;
            this.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl7.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl7.Manager = null;
            this.BarDockControl7.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl11
            // 
            this.BarDockControl11.CausesValidation = false;
            this.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl11.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl11.Manager = null;
            this.BarDockControl11.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl12
            // 
            this.BarDockControl12.CausesValidation = false;
            this.BarDockControl12.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl12.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl12.Manager = null;
            this.BarDockControl12.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl6
            // 
            this.BarDockControl6.CausesValidation = false;
            this.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl6.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl6.Manager = null;
            this.BarDockControl6.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl13
            // 
            this.BarDockControl13.CausesValidation = false;
            this.BarDockControl13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl13.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl13.Manager = null;
            this.BarDockControl13.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl14
            // 
            this.BarDockControl14.CausesValidation = false;
            this.BarDockControl14.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl14.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl14.Manager = null;
            this.BarDockControl14.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl15
            // 
            this.BarDockControl15.CausesValidation = false;
            this.BarDockControl15.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl15.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl15.Manager = null;
            this.BarDockControl15.Size = new System.Drawing.Size(0, 0);
            // 
            // Bar3
            // 
            this.Bar3.BarName = "Tools";
            this.Bar3.DockCol = 0;
            this.Bar3.DockRow = 0;
            this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar3.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport, true)});
            this.Bar3.OptionsBar.AllowQuickCustomization = false;
            this.Bar3.OptionsBar.DrawDragBorder = false;
            this.Bar3.OptionsBar.UseWholeRow = true;
            this.Bar3.Text = "Tools";
            // 
            // Bar4
            // 
            this.Bar4.BarName = "Tools";
            this.Bar4.DockCol = 0;
            this.Bar4.DockRow = 0;
            this.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar4.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport, true)});
            this.Bar4.OptionsBar.AllowQuickCustomization = false;
            this.Bar4.OptionsBar.DrawDragBorder = false;
            this.Bar4.OptionsBar.UseWholeRow = true;
            this.Bar4.Text = "Tools";
            // 
            // BarDockControl19
            // 
            this.BarDockControl19.CausesValidation = false;
            this.BarDockControl19.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl19.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl19.Manager = null;
            this.BarDockControl19.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl18
            // 
            this.BarDockControl18.CausesValidation = false;
            this.BarDockControl18.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl18.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl18.Manager = null;
            this.BarDockControl18.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl20
            // 
            this.BarDockControl20.CausesValidation = false;
            this.BarDockControl20.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl20.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl20.Manager = null;
            this.BarDockControl20.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl17
            // 
            this.BarDockControl17.CausesValidation = false;
            this.BarDockControl17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl17.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl17.Manager = null;
            this.BarDockControl17.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl21
            // 
            this.BarDockControl21.CausesValidation = false;
            this.BarDockControl21.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl21.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl21.Manager = null;
            this.BarDockControl21.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl22
            // 
            this.BarDockControl22.CausesValidation = false;
            this.BarDockControl22.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl22.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl22.Manager = null;
            this.BarDockControl22.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl16
            // 
            this.BarDockControl16.CausesValidation = false;
            this.BarDockControl16.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl16.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl16.Manager = null;
            this.BarDockControl16.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl23
            // 
            this.BarDockControl23.CausesValidation = false;
            this.BarDockControl23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl23.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl23.Manager = null;
            this.BarDockControl23.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl24
            // 
            this.BarDockControl24.CausesValidation = false;
            this.BarDockControl24.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl24.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl24.Manager = null;
            this.BarDockControl24.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl25
            // 
            this.BarDockControl25.CausesValidation = false;
            this.BarDockControl25.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl25.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl25.Manager = null;
            this.BarDockControl25.Size = new System.Drawing.Size(0, 0);
            // 
            // Bar5
            // 
            this.Bar5.BarName = "Tools";
            this.Bar5.DockCol = 0;
            this.Bar5.DockRow = 0;
            this.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.Bar5.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopyPO, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPOFilter, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.LEPOType, "", false, true, true, 116),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarCompBranch)});
            this.Bar5.OptionsBar.AllowQuickCustomization = false;
            this.Bar5.OptionsBar.DrawDragBorder = false;
            this.Bar5.OptionsBar.UseWholeRow = true;
            this.Bar5.Text = "Tools";
            // 
            // BarDockControl29
            // 
            this.BarDockControl29.CausesValidation = false;
            this.BarDockControl29.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl29.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl29.Manager = null;
            this.BarDockControl29.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl28
            // 
            this.BarDockControl28.CausesValidation = false;
            this.BarDockControl28.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl28.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl28.Manager = null;
            this.BarDockControl28.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl30
            // 
            this.BarDockControl30.CausesValidation = false;
            this.BarDockControl30.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl30.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl30.Manager = null;
            this.BarDockControl30.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl27
            // 
            this.BarDockControl27.CausesValidation = false;
            this.BarDockControl27.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl27.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl27.Manager = null;
            this.BarDockControl27.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl31
            // 
            this.BarDockControl31.CausesValidation = false;
            this.BarDockControl31.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl31.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl31.Manager = null;
            this.BarDockControl31.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl32
            // 
            this.BarDockControl32.CausesValidation = false;
            this.BarDockControl32.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl32.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl32.Manager = null;
            this.BarDockControl32.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl26
            // 
            this.BarDockControl26.CausesValidation = false;
            this.BarDockControl26.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl26.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl26.Manager = null;
            this.BarDockControl26.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl33
            // 
            this.BarDockControl33.CausesValidation = false;
            this.BarDockControl33.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl33.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl33.Manager = null;
            this.BarDockControl33.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl34
            // 
            this.BarDockControl34.CausesValidation = false;
            this.BarDockControl34.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl34.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl34.Manager = null;
            this.BarDockControl34.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl35
            // 
            this.BarDockControl35.CausesValidation = false;
            this.BarDockControl35.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl35.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl35.Manager = null;
            this.BarDockControl35.Size = new System.Drawing.Size(0, 0);
            // 
            // Bar6
            // 
            this.Bar6.BarName = "Tools";
            this.Bar6.DockCol = 0;
            this.Bar6.DockRow = 0;
            this.Bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar6.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport, true)});
            this.Bar6.OptionsBar.AllowQuickCustomization = false;
            this.Bar6.OptionsBar.DrawDragBorder = false;
            this.Bar6.OptionsBar.UseWholeRow = true;
            this.Bar6.Text = "Tools";
            // 
            // Bar7
            // 
            this.Bar7.BarName = "Tools";
            this.Bar7.DockCol = 0;
            this.Bar7.DockRow = 0;
            this.Bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar7.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport, true)});
            this.Bar7.OptionsBar.AllowQuickCustomization = false;
            this.Bar7.OptionsBar.DrawDragBorder = false;
            this.Bar7.OptionsBar.UseWholeRow = true;
            this.Bar7.Text = "Tools";
            // 
            // BarDockControl39
            // 
            this.BarDockControl39.CausesValidation = false;
            this.BarDockControl39.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl39.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl39.Manager = null;
            this.BarDockControl39.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl38
            // 
            this.BarDockControl38.CausesValidation = false;
            this.BarDockControl38.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl38.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl38.Manager = null;
            this.BarDockControl38.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl40
            // 
            this.BarDockControl40.CausesValidation = false;
            this.BarDockControl40.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl40.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl40.Manager = null;
            this.BarDockControl40.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl37
            // 
            this.BarDockControl37.CausesValidation = false;
            this.BarDockControl37.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl37.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl37.Manager = null;
            this.BarDockControl37.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl41
            // 
            this.BarDockControl41.CausesValidation = false;
            this.BarDockControl41.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl41.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl41.Manager = null;
            this.BarDockControl41.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl42
            // 
            this.BarDockControl42.CausesValidation = false;
            this.BarDockControl42.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl42.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl42.Manager = null;
            this.BarDockControl42.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl36
            // 
            this.BarDockControl36.CausesValidation = false;
            this.BarDockControl36.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl36.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl36.Manager = null;
            this.BarDockControl36.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl43
            // 
            this.BarDockControl43.CausesValidation = false;
            this.BarDockControl43.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl43.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl43.Manager = null;
            this.BarDockControl43.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl44
            // 
            this.BarDockControl44.CausesValidation = false;
            this.BarDockControl44.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl44.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl44.Manager = null;
            this.BarDockControl44.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl45
            // 
            this.BarDockControl45.CausesValidation = false;
            this.BarDockControl45.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl45.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl45.Manager = null;
            this.BarDockControl45.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl49
            // 
            this.BarDockControl49.CausesValidation = false;
            this.BarDockControl49.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl49.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl49.Manager = null;
            this.BarDockControl49.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl48
            // 
            this.BarDockControl48.CausesValidation = false;
            this.BarDockControl48.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl48.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl48.Manager = null;
            this.BarDockControl48.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl50
            // 
            this.BarDockControl50.CausesValidation = false;
            this.BarDockControl50.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl50.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl50.Manager = null;
            this.BarDockControl50.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl47
            // 
            this.BarDockControl47.CausesValidation = false;
            this.BarDockControl47.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl47.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl47.Manager = null;
            this.BarDockControl47.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl51
            // 
            this.BarDockControl51.CausesValidation = false;
            this.BarDockControl51.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl51.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl51.Manager = null;
            this.BarDockControl51.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl52
            // 
            this.BarDockControl52.CausesValidation = false;
            this.BarDockControl52.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl52.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl52.Manager = null;
            this.BarDockControl52.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl46
            // 
            this.BarDockControl46.CausesValidation = false;
            this.BarDockControl46.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl46.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl46.Manager = null;
            this.BarDockControl46.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl53
            // 
            this.BarDockControl53.CausesValidation = false;
            this.BarDockControl53.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl53.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl53.Manager = null;
            this.BarDockControl53.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl54
            // 
            this.BarDockControl54.CausesValidation = false;
            this.BarDockControl54.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl54.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl54.Manager = null;
            this.BarDockControl54.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl55
            // 
            this.BarDockControl55.CausesValidation = false;
            this.BarDockControl55.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl55.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl55.Manager = null;
            this.BarDockControl55.Size = new System.Drawing.Size(0, 0);
            // 
            // Bar8
            // 
            this.Bar8.BarName = "Tools";
            this.Bar8.DockCol = 0;
            this.Bar8.DockRow = 0;
            this.Bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar8.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport, true)});
            this.Bar8.OptionsBar.AllowQuickCustomization = false;
            this.Bar8.OptionsBar.DrawDragBorder = false;
            this.Bar8.OptionsBar.UseWholeRow = true;
            this.Bar8.Text = "Tools";
            // 
            // BarDockControl75
            // 
            this.BarDockControl75.CausesValidation = false;
            this.BarDockControl75.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl75.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl75.Manager = null;
            this.BarDockControl75.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl74
            // 
            this.BarDockControl74.CausesValidation = false;
            this.BarDockControl74.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl74.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl74.Manager = null;
            this.BarDockControl74.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl76
            // 
            this.BarDockControl76.CausesValidation = false;
            this.BarDockControl76.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl76.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl76.Manager = null;
            this.BarDockControl76.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl73
            // 
            this.BarDockControl73.CausesValidation = false;
            this.BarDockControl73.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl73.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl73.Manager = null;
            this.BarDockControl73.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl77
            // 
            this.BarDockControl77.CausesValidation = false;
            this.BarDockControl77.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl77.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl77.Manager = null;
            this.BarDockControl77.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl78
            // 
            this.BarDockControl78.CausesValidation = false;
            this.BarDockControl78.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl78.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl78.Manager = null;
            this.BarDockControl78.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl72
            // 
            this.BarDockControl72.CausesValidation = false;
            this.BarDockControl72.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl72.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl72.Manager = null;
            this.BarDockControl72.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl79
            // 
            this.BarDockControl79.CausesValidation = false;
            this.BarDockControl79.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl79.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl79.Manager = null;
            this.BarDockControl79.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl80
            // 
            this.BarDockControl80.CausesValidation = false;
            this.BarDockControl80.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl80.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl80.Manager = null;
            this.BarDockControl80.Size = new System.Drawing.Size(0, 0);
            // 
            // BarDockControl81
            // 
            this.BarDockControl81.CausesValidation = false;
            this.BarDockControl81.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl81.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl81.Manager = null;
            this.BarDockControl81.Size = new System.Drawing.Size(0, 0);
            // 
            // Bar9
            // 
            this.Bar9.BarName = "Tools";
            this.Bar9.DockCol = 0;
            this.Bar9.DockRow = 0;
            this.Bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar9.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar9.OptionsBar.AllowQuickCustomization = false;
            this.Bar9.OptionsBar.DrawDragBorder = false;
            this.Bar9.OptionsBar.UseWholeRow = true;
            this.Bar9.Text = "Tools";
            // 
            // BarDockControl85
            // 
            this.BarDockControl85.CausesValidation = false;
            this.BarDockControl85.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl85.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl85.Manager = null;
            this.BarDockControl85.Size = new System.Drawing.Size(0, 0);
            // 
            // BarButtonItem93
            // 
            this.BarButtonItem93.Name = "BarButtonItem93";
            // 
            // BarEditItem15
            // 
            this.BarEditItem15.Edit = null;
            this.BarEditItem15.Name = "BarEditItem15";
            // 
            // RepositoryItemLookUpEdit9
            // 
            this.RepositoryItemLookUpEdit9.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit9.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "DisplayText"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "DisplayText")});
            this.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9";
            this.RepositoryItemLookUpEdit9.NullText = "";
            // 
            // RepositoryItemLookUpEdit10
            // 
            this.RepositoryItemLookUpEdit10.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit10.Name = "RepositoryItemLookUpEdit10";
            // 
            // BarButtonItem92
            // 
            this.BarButtonItem92.Name = "BarButtonItem92";
            // 
            // BarButtonItem91
            // 
            this.BarButtonItem91.Name = "BarButtonItem91";
            // 
            // BarEditItem14
            // 
            this.BarEditItem14.Edit = null;
            this.BarEditItem14.Name = "BarEditItem14";
            // 
            // BarEditItem13
            // 
            this.BarEditItem13.Edit = null;
            this.BarEditItem13.Name = "BarEditItem13";
            // 
            // RepositoryItemComboBox6
            // 
            this.RepositoryItemComboBox6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6";
            // 
            // BarButtonItem90
            // 
            this.BarButtonItem90.Name = "BarButtonItem90";
            // 
            // BarButtonItem77
            // 
            this.BarButtonItem77.Name = "BarButtonItem77";
            // 
            // BarButtonItem75
            // 
            this.BarButtonItem75.Name = "BarButtonItem75";
            // 
            // BarButtonItem74
            // 
            this.BarButtonItem74.Name = "BarButtonItem74";
            // 
            // BarButtonItem73
            // 
            this.BarButtonItem73.Name = "BarButtonItem73";
            // 
            // BarButtonItem56
            // 
            this.BarButtonItem56.Name = "BarButtonItem56";
            // 
            // BarButtonItem54
            // 
            this.BarButtonItem54.Name = "BarButtonItem54";
            // 
            // BarButtonItem53
            // 
            this.BarButtonItem53.Name = "BarButtonItem53";
            // 
            // BarButtonItem52
            // 
            this.BarButtonItem52.Name = "BarButtonItem52";
            // 
            // BarButtonItem35
            // 
            this.BarButtonItem35.Name = "BarButtonItem35";
            // 
            // BarButtonItem33
            // 
            this.BarButtonItem33.Name = "BarButtonItem33";
            // 
            // BarButtonItem32
            // 
            this.BarButtonItem32.Name = "BarButtonItem32";
            // 
            // BarButtonItem31
            // 
            this.BarButtonItem31.Name = "BarButtonItem31";
            // 
            // BarButtonItem14
            // 
            this.BarButtonItem14.Name = "BarButtonItem14";
            // 
            // Bar11
            // 
            this.Bar11.BarName = "Tools";
            this.Bar11.DockCol = 0;
            this.Bar11.DockRow = 0;
            this.Bar11.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar11.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar11.OptionsBar.AllowQuickCustomization = false;
            this.Bar11.OptionsBar.DrawDragBorder = false;
            this.Bar11.OptionsBar.UseWholeRow = true;
            this.Bar11.Text = "Tools";
            // 
            // Bar12
            // 
            this.Bar12.BarName = "Tools";
            this.Bar12.DockCol = 0;
            this.Bar12.DockRow = 0;
            this.Bar12.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar12.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar12.OptionsBar.AllowQuickCustomization = false;
            this.Bar12.OptionsBar.DrawDragBorder = false;
            this.Bar12.OptionsBar.UseWholeRow = true;
            this.Bar12.Text = "Tools";
            // 
            // Bar14
            // 
            this.Bar14.BarName = "Tools";
            this.Bar14.DockCol = 0;
            this.Bar14.DockRow = 0;
            this.Bar14.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar14.FloatSize = new System.Drawing.Size(861, 94);
            this.Bar14.OptionsBar.AllowQuickCustomization = false;
            this.Bar14.OptionsBar.DrawDragBorder = false;
            this.Bar14.OptionsBar.UseWholeRow = true;
            this.Bar14.Text = "Tools";
            // 
            // Bar13
            // 
            this.Bar13.BarName = "Tools";
            this.Bar13.DockCol = 0;
            this.Bar13.DockRow = 0;
            this.Bar13.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.Bar13.FloatSize = new System.Drawing.Size(425, 31);
            this.Bar13.OptionsBar.AllowQuickCustomization = false;
            this.Bar13.OptionsBar.DrawDragBorder = false;
            this.Bar13.OptionsBar.UseWholeRow = true;
            this.Bar13.Text = "Tools";
            // 
            // btnRefeRefresh
            // 
            this.btnRefeRefresh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnRefeRefresh.Caption = "Refresh";
            this.btnRefeRefresh.Id = 5;
            this.btnRefeRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeRefresh.ImageOptions.Image")));
            this.btnRefeRefresh.Name = "btnRefeRefresh";
            this.btnRefeRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem30.Text = "Refresh";
            toolTipItem29.LeftIndent = 6;
            toolTipItem29.Text = "Click here to refresh the list\r\n";
            superToolTip30.Items.Add(toolTipTitleItem30);
            superToolTip30.Items.Add(toolTipItem29);
            this.btnRefeRefresh.SuperTip = superToolTip30;
            this.btnRefeRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefeRefresh_ItemClick);
            // 
            // btnRefeResetLayout
            // 
            this.btnRefeResetLayout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnRefeResetLayout.Caption = "Reset Layout";
            this.btnRefeResetLayout.Id = 4;
            this.btnRefeResetLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeResetLayout.ImageOptions.Image")));
            this.btnRefeResetLayout.Name = "btnRefeResetLayout";
            this.btnRefeResetLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem28.Text = "Reset Layout";
            toolTipItem27.LeftIndent = 6;
            toolTipItem27.Text = "Click here to reset layout of listing\r\n";
            superToolTip28.Items.Add(toolTipTitleItem28);
            superToolTip28.Items.Add(toolTipItem27);
            this.btnRefeResetLayout.SuperTip = superToolTip28;
            this.btnRefeResetLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefeResetLayout_ItemClick);
            // 
            // btnRefeSaveLayout
            // 
            this.btnRefeSaveLayout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnRefeSaveLayout.Caption = "Save Layout";
            this.btnRefeSaveLayout.Id = 3;
            this.btnRefeSaveLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeSaveLayout.ImageOptions.Image")));
            this.btnRefeSaveLayout.Name = "btnRefeSaveLayout";
            this.btnRefeSaveLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem29.Text = "Save Layout";
            toolTipItem28.LeftIndent = 6;
            toolTipItem28.Text = "Click here to save layout of listing\r\n";
            superToolTip29.Items.Add(toolTipTitleItem29);
            superToolTip29.Items.Add(toolTipItem28);
            this.btnRefeSaveLayout.SuperTip = superToolTip29;
            this.btnRefeSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefeSaveLayout_ItemClick);
            // 
            // btnRefeExportExcel
            // 
            this.btnRefeExportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnRefeExportExcel.Caption = "Export To Excel";
            this.btnRefeExportExcel.Id = 7;
            this.btnRefeExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeExportExcel.ImageOptions.Image")));
            this.btnRefeExportExcel.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnRefeExportExcel.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnRefeExportExcel.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnRefeExportExcel.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.btnRefeExportExcel.Name = "btnRefeExportExcel";
            this.btnRefeExportExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem31.Text = "Export To Excel";
            toolTipItem30.LeftIndent = 6;
            toolTipItem30.Text = "Click here to export listing to excel\r\n";
            superToolTip31.Items.Add(toolTipTitleItem31);
            superToolTip31.Items.Add(toolTipItem30);
            this.btnRefeExportExcel.SuperTip = superToolTip31;
            this.btnRefeExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefeExportExcel_ItemClick);
            // 
            // BarManager8
            // 
            this.BarManager8.AllowCustomization = false;
            this.BarManager8.AllowMoveBarOnToolbar = false;
            this.BarManager8.AllowQuickCustomization = false;
            this.BarManager8.AllowShowToolbarsPopup = false;
            this.BarManager8.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarReferenceSelection});
            this.BarManager8.DockControls.Add(this.BarDockControl86);
            this.BarManager8.DockControls.Add(this.BarDockControl87);
            this.BarManager8.DockControls.Add(this.BarDockControl88);
            this.BarManager8.DockControls.Add(this.BarDockControl89);
            this.BarManager8.Form = this;
            this.BarManager8.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarButtonItem99,
            this.BarButtonItem100,
            this.BarButtonItem101,
            this.btnRefeSaveLayout,
            this.btnRefeResetLayout,
            this.btnRefeRefresh,
            this.BarButtonItem102,
            this.btnRefeExportExcel,
            this.BarButtonItem103,
            this.BarButtonItem104,
            this.BarButtonItem105,
            this.BarButtonItem106,
            this.BarButtonItem107,
            this.BarButtonItem108,
            this.BarButtonItem109,
            this.BarButtonItem110,
            this.BarButtonItem111,
            this.BarButtonItem112,
            this.BarEditItem16,
            this.BarEditItem17,
            this.BarButtonItem113,
            this.BarButtonItem114,
            this.BarEditItem18,
            this.BarButtonItem115,
            this.btnCozy,
            this.btnComfortable,
            this.btnCompact});
            this.BarManager8.MaxItemId = 33;
            this.BarManager8.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemComboBox7,
            this.RepositoryItemLookUpEdit11,
            this.RepositoryItemLookUpEdit12});
            // 
            // BarReferenceSelection
            // 
            this.BarReferenceSelection.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarReferenceSelection.BarAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.BarReferenceSelection.BarAppearance.Normal.Options.UseFont = true;
            this.BarReferenceSelection.BarAppearance.Normal.Options.UseForeColor = true;
            this.BarReferenceSelection.BarName = "Tools";
            this.BarReferenceSelection.DockCol = 0;
            this.BarReferenceSelection.DockRow = 0;
            this.BarReferenceSelection.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.BarReferenceSelection.FloatLocation = new System.Drawing.Point(9, 11);
            this.BarReferenceSelection.FloatSize = new System.Drawing.Size(225, 25);
            this.BarReferenceSelection.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCozy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnComfortable),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCompact),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefeResetLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefeSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefeRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefeExportExcel, true)});
            this.BarReferenceSelection.OptionsBar.AllowQuickCustomization = false;
            this.BarReferenceSelection.OptionsBar.DrawDragBorder = false;
            this.BarReferenceSelection.OptionsBar.UseWholeRow = true;
            this.BarReferenceSelection.StandaloneBarDockControl = this.StandaloneBarDockControl3;
            this.BarReferenceSelection.Text = "Tools";
            // 
            // BarDockControl86
            // 
            this.BarDockControl86.CausesValidation = false;
            this.BarDockControl86.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControl86.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl86.Manager = this.BarManager8;
            this.BarDockControl86.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl86.Size = new System.Drawing.Size(1330, 0);
            // 
            // BarDockControl87
            // 
            this.BarDockControl87.CausesValidation = false;
            this.BarDockControl87.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControl87.Location = new System.Drawing.Point(0, 876);
            this.BarDockControl87.Manager = this.BarManager8;
            this.BarDockControl87.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl87.Size = new System.Drawing.Size(1330, 0);
            // 
            // BarDockControl88
            // 
            this.BarDockControl88.CausesValidation = false;
            this.BarDockControl88.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControl88.Location = new System.Drawing.Point(0, 0);
            this.BarDockControl88.Manager = this.BarManager8;
            this.BarDockControl88.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl88.Size = new System.Drawing.Size(0, 876);
            // 
            // BarDockControl89
            // 
            this.BarDockControl89.CausesValidation = false;
            this.BarDockControl89.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControl89.Location = new System.Drawing.Point(1330, 0);
            this.BarDockControl89.Manager = this.BarManager8;
            this.BarDockControl89.Margin = new System.Windows.Forms.Padding(4);
            this.BarDockControl89.Size = new System.Drawing.Size(0, 876);
            // 
            // BarButtonItem99
            // 
            this.BarButtonItem99.Caption = "Add New";
            this.BarButtonItem99.Id = 0;
            this.BarButtonItem99.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem99.ImageOptions.Image")));
            this.BarButtonItem99.Name = "BarButtonItem99";
            this.BarButtonItem99.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem32.Text = "Add New   (Ctrl+N)";
            toolTipItem31.LeftIndent = 6;
            toolTipItem31.Text = "Click here Add new item...";
            superToolTip32.Items.Add(toolTipTitleItem32);
            superToolTip32.Items.Add(toolTipItem31);
            this.BarButtonItem99.SuperTip = superToolTip32;
            this.BarButtonItem99.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // BarButtonItem100
            // 
            this.BarButtonItem100.Caption = "Edit";
            this.BarButtonItem100.Id = 1;
            this.BarButtonItem100.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem100.ImageOptions.Image")));
            this.BarButtonItem100.Name = "BarButtonItem100";
            this.BarButtonItem100.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem33.Text = "Edit   (Ctrl+E)";
            toolTipItem32.LeftIndent = 6;
            toolTipItem32.Text = "Click here to Edit selected item...";
            superToolTip33.Items.Add(toolTipTitleItem33);
            superToolTip33.Items.Add(toolTipItem32);
            this.BarButtonItem100.SuperTip = superToolTip33;
            this.BarButtonItem100.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // BarButtonItem101
            // 
            this.BarButtonItem101.Caption = "Delete";
            this.BarButtonItem101.Id = 2;
            this.BarButtonItem101.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem101.ImageOptions.Image")));
            this.BarButtonItem101.Name = "BarButtonItem101";
            this.BarButtonItem101.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem34.Text = "Delete   (Ctrl+D)";
            toolTipItem33.LeftIndent = 6;
            toolTipItem33.Text = "Click here to Delete selected item...";
            superToolTip34.Items.Add(toolTipTitleItem34);
            superToolTip34.Items.Add(toolTipItem33);
            this.BarButtonItem101.SuperTip = superToolTip34;
            this.BarButtonItem101.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // BarButtonItem102
            // 
            this.BarButtonItem102.Caption = "Filter";
            this.BarButtonItem102.Id = 6;
            this.BarButtonItem102.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem102.ImageOptions.Image")));
            this.BarButtonItem102.Name = "BarButtonItem102";
            this.BarButtonItem102.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem35.Text = "Filter  (Ctrl+F)";
            toolTipItem34.LeftIndent = 6;
            toolTipItem34.Text = "Click here to Filter the Listing";
            superToolTip35.Items.Add(toolTipTitleItem35);
            superToolTip35.Items.Add(toolTipItem34);
            this.BarButtonItem102.SuperTip = superToolTip35;
            this.BarButtonItem102.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // BarButtonItem103
            // 
            this.BarButtonItem103.Caption = "Add New";
            this.BarButtonItem103.Id = 8;
            this.BarButtonItem103.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem103.ImageOptions.Image")));
            this.BarButtonItem103.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.BarButtonItem103.Name = "BarButtonItem103";
            // 
            // BarButtonItem104
            // 
            this.BarButtonItem104.Caption = "Edit";
            this.BarButtonItem104.Id = 9;
            this.BarButtonItem104.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem104.ImageOptions.Image")));
            this.BarButtonItem104.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.BarButtonItem104.Name = "BarButtonItem104";
            // 
            // BarButtonItem105
            // 
            this.BarButtonItem105.Caption = "Delete";
            this.BarButtonItem105.Id = 10;
            this.BarButtonItem105.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem105.ImageOptions.Image")));
            this.BarButtonItem105.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.BarButtonItem105.Name = "BarButtonItem105";
            // 
            // BarButtonItem106
            // 
            this.BarButtonItem106.Caption = "Save Layout";
            this.BarButtonItem106.Id = 11;
            this.BarButtonItem106.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem106.ImageOptions.Image")));
            this.BarButtonItem106.Name = "BarButtonItem106";
            // 
            // BarButtonItem107
            // 
            this.BarButtonItem107.Caption = "Reset Layout";
            this.BarButtonItem107.Id = 12;
            this.BarButtonItem107.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem107.ImageOptions.Image")));
            this.BarButtonItem107.Name = "BarButtonItem107";
            // 
            // BarButtonItem108
            // 
            this.BarButtonItem108.Caption = "Print";
            this.BarButtonItem108.Id = 13;
            this.BarButtonItem108.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem108.ImageOptions.Image")));
            this.BarButtonItem108.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.BarButtonItem108.Name = "BarButtonItem108";
            // 
            // BarButtonItem109
            // 
            this.BarButtonItem109.Caption = "Export To Excel";
            this.BarButtonItem109.Id = 14;
            this.BarButtonItem109.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem109.ImageOptions.Image")));
            this.BarButtonItem109.Name = "BarButtonItem109";
            // 
            // BarButtonItem110
            // 
            this.BarButtonItem110.Caption = "Copy PO";
            this.BarButtonItem110.Id = 15;
            this.BarButtonItem110.Name = "BarButtonItem110";
            toolTipTitleItem36.Text = "Copy PO";
            toolTipItem35.LeftIndent = 6;
            toolTipItem35.Text = "Click here to copy selected PO";
            superToolTip36.Items.Add(toolTipTitleItem36);
            superToolTip36.Items.Add(toolTipItem35);
            this.BarButtonItem110.SuperTip = superToolTip36;
            this.BarButtonItem110.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // BarButtonItem111
            // 
            this.BarButtonItem111.Caption = "Copy PO";
            this.BarButtonItem111.Id = 16;
            this.BarButtonItem111.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem111.ImageOptions.Image")));
            this.BarButtonItem111.Name = "BarButtonItem111";
            // 
            // BarButtonItem112
            // 
            this.BarButtonItem112.Caption = "Filter";
            this.BarButtonItem112.Id = 17;
            this.BarButtonItem112.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem112.ImageOptions.Image")));
            this.BarButtonItem112.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.BarButtonItem112.Name = "BarButtonItem112";
            // 
            // BarEditItem16
            // 
            this.BarEditItem16.Caption = "BarEditItem1";
            this.BarEditItem16.Edit = this.RepositoryItemComboBox7;
            this.BarEditItem16.Id = 18;
            this.BarEditItem16.Name = "BarEditItem16";
            // 
            // RepositoryItemComboBox7
            // 
            this.RepositoryItemComboBox7.AutoHeight = false;
            this.RepositoryItemComboBox7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemComboBox7.Name = "RepositoryItemComboBox7";
            // 
            // BarEditItem17
            // 
            this.BarEditItem17.Caption = "BarEditItem1";
            this.BarEditItem17.Edit = this.RepositoryItemLookUpEdit11;
            this.BarEditItem17.Id = 19;
            this.BarEditItem17.Name = "BarEditItem17";
            toolTipTitleItem37.Text = "Item type";
            toolTipItem36.LeftIndent = 6;
            toolTipItem36.Text = "Select Item type to see records ItemType Wise";
            superToolTip37.Items.Add(toolTipTitleItem37);
            superToolTip37.Items.Add(toolTipItem36);
            this.BarEditItem17.SuperTip = superToolTip37;
            this.BarEditItem17.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // RepositoryItemLookUpEdit11
            // 
            this.RepositoryItemLookUpEdit11.AutoHeight = false;
            this.RepositoryItemLookUpEdit11.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit11.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "DisplayText")});
            this.RepositoryItemLookUpEdit11.Name = "RepositoryItemLookUpEdit11";
            this.RepositoryItemLookUpEdit11.NullText = "";
            // 
            // BarButtonItem113
            // 
            this.BarButtonItem113.Caption = "Receiving Notes";
            this.BarButtonItem113.Id = 20;
            this.BarButtonItem113.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem113.ImageOptions.Image")));
            this.BarButtonItem113.Name = "BarButtonItem113";
            // 
            // BarButtonItem114
            // 
            this.BarButtonItem114.Caption = "Goods Receive";
            this.BarButtonItem114.Id = 21;
            this.BarButtonItem114.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem114.ImageOptions.Image")));
            this.BarButtonItem114.Name = "BarButtonItem114";
            // 
            // BarEditItem18
            // 
            this.BarEditItem18.Caption = "Company Branch";
            this.BarEditItem18.Edit = this.RepositoryItemLookUpEdit12;
            this.BarEditItem18.EditWidth = 217;
            this.BarEditItem18.Id = 22;
            this.BarEditItem18.Name = "BarEditItem18";
            toolTipTitleItem38.Text = "Company Branch";
            toolTipItem37.LeftIndent = 6;
            toolTipItem37.Text = "Select Company Branch to see records Branch Wise";
            superToolTip38.Items.Add(toolTipTitleItem38);
            superToolTip38.Items.Add(toolTipItem37);
            this.BarEditItem18.SuperTip = superToolTip38;
            // 
            // RepositoryItemLookUpEdit12
            // 
            this.RepositoryItemLookUpEdit12.AutoHeight = false;
            this.RepositoryItemLookUpEdit12.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit12.DropDownRows = 4;
            this.RepositoryItemLookUpEdit12.Name = "RepositoryItemLookUpEdit12";
            this.RepositoryItemLookUpEdit12.NullText = "";
            // 
            // BarButtonItem115
            // 
            this.BarButtonItem115.Caption = "Receive Barcode";
            this.BarButtonItem115.Id = 23;
            this.BarButtonItem115.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarButtonItem115.ImageOptions.Image")));
            this.BarButtonItem115.Name = "BarButtonItem115";
            this.BarButtonItem115.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem39.Text = "Receive Barcode";
            superToolTip39.Items.Add(toolTipTitleItem39);
            this.BarButtonItem115.SuperTip = superToolTip39;
            // 
            // pnlDefaultSupplier
            // 
            this.pnlDefaultSupplier.Controls.Add(this.layoutControl1);
            this.pnlDefaultSupplier.Location = new System.Drawing.Point(340, 337);
            this.pnlDefaultSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDefaultSupplier.Name = "pnlDefaultSupplier";
            this.pnlDefaultSupplier.Size = new System.Drawing.Size(209, 123);
            this.pnlDefaultSupplier.TabIndex = 13;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDefaultsuppierApply);
            this.layoutControl1.Controls.Add(this.btnDefaultSupplierClose);
            this.layoutControl1.Controls.Add(this.LESupplier);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(205, 119);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDefaultsuppierApply
            // 
            this.btnDefaultsuppierApply.Location = new System.Drawing.Point(46, 80);
            this.btnDefaultsuppierApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefaultsuppierApply.Name = "btnDefaultsuppierApply";
            this.btnDefaultsuppierApply.Size = new System.Drawing.Size(77, 27);
            this.btnDefaultsuppierApply.StyleController = this.layoutControl1;
            this.btnDefaultsuppierApply.TabIndex = 6;
            this.btnDefaultsuppierApply.Text = "Apply";
            this.btnDefaultsuppierApply.Click += new System.EventHandler(this.btnDefaultsuppierApply_Click);
            // 
            // btnDefaultSupplierClose
            // 
            this.btnDefaultSupplierClose.Location = new System.Drawing.Point(127, 80);
            this.btnDefaultSupplierClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefaultSupplierClose.Name = "btnDefaultSupplierClose";
            this.btnDefaultSupplierClose.Size = new System.Drawing.Size(66, 27);
            this.btnDefaultSupplierClose.StyleController = this.layoutControl1;
            this.btnDefaultSupplierClose.TabIndex = 5;
            this.btnDefaultSupplierClose.Text = "Close";
            this.btnDefaultSupplierClose.Click += new System.EventHandler(this.btnDefaultSupplierClose_Click);
            // 
            // LESupplier
            // 
            this.LESupplier.EnterMoveNextControl = true;
            this.LESupplier.Location = new System.Drawing.Point(12, 32);
            this.LESupplier.Margin = new System.Windows.Forms.Padding(4);
            this.LESupplier.Name = "LESupplier";
            this.LESupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LESupplier.Properties.NullText = "";
            this.LESupplier.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.LESupplier.Properties.PopupWidth = 187;
            this.LESupplier.Properties.ShowFooter = false;
            this.LESupplier.Size = new System.Drawing.Size(161, 26);
            this.LESupplier.StyleController = this.layoutControl1;
            this.LESupplier.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(205, 119);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(67)))), ((int)(((byte)(179)))));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.LESupplier;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(165, 50);
            this.layoutControlItem1.Text = "Supplier Name*:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(97, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 68);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(34, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnDefaultSupplierClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(115, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(70, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDefaultsuppierApply;
            this.layoutControlItem3.Location = new System.Drawing.Point(34, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(81, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(185, 18);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(165, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(20, 50);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ImageCollection2
            // 
            this.ImageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection2.ImageStream")));
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Process Status:";
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup3.Size = new System.Drawing.Size(290, 81);
            this.layoutControlGroup3.Text = "Process Status:";
            // 
            // tileBarGrpDeliveryStatus
            // 
            this.tileBarGrpDeliveryStatus.Name = "tileBarGrpDeliveryStatus";
            // 
            // tileBarGroup1
            // 
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // frmJobProcurementEntryTypeWise
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 876);
            this.Controls.Add(this.pnlDefaultSupplier);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.BarDockControl3);
            this.Controls.Add(this.BarDockControl4);
            this.Controls.Add(this.BarDockControl2);
            this.Controls.Add(this.BarDockControl1);
            this.Controls.Add(this.BarDockControl88);
            this.Controls.Add(this.BarDockControl89);
            this.Controls.Add(this.BarDockControl87);
            this.Controls.Add(this.BarDockControl86);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmJobProcurementEntryTypeWise";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmQuotationAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.TLPmain.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scProdurementGeneratePO.Panel1)).EndInit();
            this.scProdurementGeneratePO.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scProdurementGeneratePO.Panel2)).EndInit();
            this.scProdurementGeneratePO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scProdurementGeneratePO)).EndInit();
            this.scProdurementGeneratePO.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl7)).EndInit();
            this.PanelControl7.ResumeLayout(false);
            this.PanelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl6)).EndInit();
            this.PanelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGeneratePO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeneratePO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenPOSel)).EndInit();
            this.TableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).EndInit();
            this.PanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUseFromStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUseFromStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl8)).EndInit();
            this.PanelControl8.ResumeLayout(false);
            this.PanelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl17)).EndInit();
            this.PanelControl17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbPurchaseGroupType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGeneratePurchaseOrder)).EndInit();
            this.pnlGeneratePurchaseOrder.ResumeLayout(false);
            this.pnlGeneratePurchaseOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainSelection)).EndInit();
            this.pnlMainSelection.ResumeLayout(false);
            this.pnlMainSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabQuotation)).EndInit();
            this.tabQuotation.ResumeLayout(false);
            this.TabPageReferenceSelection.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl13)).EndInit();
            this.PanelControl13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl14)).EndInit();
            this.PanelControl14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl15)).EndInit();
            this.PanelControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl16)).EndInit();
            this.PanelControl16.ResumeLayout(false);
            this.TabPageSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelglass)).EndInit();
            this.panelglass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkselall.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl18)).EndInit();
            this.PanelControl18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainPOType)).EndInit();
            this.pnlMainPOType.ResumeLayout(false);
            this.pnlMainPOType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcurementJobList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcurementJobList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobProSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgProcurementType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuotationCorrespondence)).EndInit();
            this.grpQuotationCorrespondence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuotationChasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuotationChasingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepCusotmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupEnquiryChasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepPOType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepCompBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDefaultSupplier)).EndInit();
            this.pnlDefaultSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LESupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraTab.XtraTabControl tabQuotation;
        internal DevExpress.XtraEditors.GroupControl grpQuotationCorrespondence;
        internal DevExpress.XtraGrid.GridControl gridQuotationChasing;
        internal DevExpress.XtraGrid.Views.Grid.GridView dtgQuotationChasingDetails;
        internal DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit RepCusotmer;
        internal DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox RepStatus;
        internal DevExpress.XtraBars.Bar Bar1;
        internal DevExpress.XtraBars.StandaloneBarDockControl StandaloneBarDockControl2;
        internal DevExpress.XtraBars.BarManager BarManager1;
        internal DevExpress.XtraBars.Bar Bar2;
        public DevExpress.XtraBars.BarButtonItem btnAddNewCorrespondence;
        public DevExpress.XtraBars.BarButtonItem btnEditCorrespondence;
        public DevExpress.XtraBars.BarButtonItem btnDeleteCorrespondence;
        internal DevExpress.XtraBars.BarButtonItem btnPrintCorrespondence;
        internal DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarButtonItem popAddNewCorrespondence;
        public DevExpress.XtraBars.BarButtonItem popEditCorrespondence;
        public DevExpress.XtraBars.BarButtonItem popDeleteCorrespondence;
        internal DevExpress.XtraBars.BarButtonItem mnuPrint;
        internal DevExpress.XtraBars.BarButtonItem mnuExportToExcel;
        internal DevExpress.XtraBars.BarButtonItem mnuAdditionalCost123;
        internal DevExpress.XtraBars.BarButtonItem mnuAdditionalCostEntryCancel;
        internal DevExpress.XtraBars.BarButtonItem mnuEstimationMainItemDelete;
        internal DevExpress.XtraBars.BarButtonItem mnuDetailItemSendMail;
        internal DevExpress.XtraBars.BarButtonItem mnuDetailItemDelete;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem1;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem2;
        internal DevExpress.XtraBars.BarButtonItem mnuEstimationMainItemEdit;
        internal DevExpress.XtraBars.BarButtonItem mnuEstimationMainItemCopy;
        internal DevExpress.XtraBars.BarButtonItem mnuDetailItemCopy;
        internal DevExpress.XtraBars.BarButtonItem mnuCancelAddCost;
        internal DevExpress.XtraBars.BarButtonItem mnuDeleteAddCost;
        internal DevExpress.XtraBars.BarButtonItem POPInsertRow;
        internal DevExpress.XtraBars.BarButtonItem popCopyRows;
        internal DevExpress.XtraBars.BarButtonItem popInsertCopiedRows;
        internal DevExpress.XtraBars.PopupMenu popupEnquiryChasing;
        internal DevExpress.XtraBars.BarDockControl BarDockControl3;
        internal DevExpress.XtraBars.BarDockControl BarDockControl4;
        internal DevExpress.XtraBars.BarDockControl BarDockControl2;
        internal DevExpress.XtraBars.BarDockControl BarDockControl1;
        public DevExpress.XtraBars.BarButtonItem btnAdd;
        public DevExpress.XtraBars.BarButtonItem btnEdit;
        public DevExpress.XtraBars.BarButtonItem btnDelete;
        public DevExpress.XtraBars.BarButtonItem btnCopyPO;
        internal DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        internal DevExpress.XtraBars.BarButtonItem btnResetLayout;
        internal DevExpress.XtraBars.BarButtonItem btnRefresh;
        internal DevExpress.XtraBars.BarButtonItem btnPOFilter;
        internal DevExpress.XtraBars.BarButtonItem btnExport;
        internal DevExpress.XtraBars.BarEditItem LEPOType;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepPOType;
        internal DevExpress.XtraBars.BarEditItem BarCompBranch;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepCompBranch;
        internal DevExpress.XtraBars.BarManager BarManager2;
        public DevExpress.XtraBars.BarButtonItem popAdd;
        public DevExpress.XtraBars.BarButtonItem popEdit;
        public DevExpress.XtraBars.BarButtonItem popdelete;
        internal DevExpress.XtraBars.BarButtonItem mnuSaveLayout;
        internal DevExpress.XtraBars.BarButtonItem mnuResetLayout;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem4;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem5;
        public DevExpress.XtraBars.BarButtonItem popCopyPO;
        internal DevExpress.XtraBars.BarButtonItem mnuFilter;
        internal DevExpress.XtraBars.BarEditItem cmbPOType;
        internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox RepositoryItemComboBox1;
        internal DevExpress.XtraBars.BarButtonItem btnGoodsReceiptNote;
        internal DevExpress.XtraBars.BarButtonItem btnGoodsReceipt;
        internal DevExpress.XtraBars.BarButtonItem btnReceiveBarcode;
        internal DevExpress.XtraBars.BarDockControl BarDockControl9;
        internal DevExpress.XtraBars.BarDockControl BarDockControl8;
        internal DevExpress.XtraBars.BarDockControl BarDockControl10;
        internal DevExpress.XtraBars.BarDockControl BarDockControl7;
        internal DevExpress.XtraBars.BarDockControl BarDockControl11;
        internal DevExpress.XtraBars.BarDockControl BarDockControl12;
        internal DevExpress.XtraBars.BarDockControl BarDockControl6;
        internal DevExpress.XtraBars.BarDockControl BarDockControl13;
        internal DevExpress.XtraBars.BarDockControl BarDockControl14;
        internal DevExpress.XtraBars.BarDockControl BarDockControl15;
        internal DevExpress.XtraBars.Bar Bar3;
        internal DevExpress.XtraBars.Bar Bar4;
        internal DevExpress.XtraBars.BarDockControl BarDockControl19;
        internal DevExpress.XtraBars.BarDockControl BarDockControl18;
        internal DevExpress.XtraBars.BarDockControl BarDockControl20;
        internal DevExpress.XtraBars.BarDockControl BarDockControl17;
        internal DevExpress.XtraBars.BarDockControl BarDockControl21;
        internal DevExpress.XtraBars.BarDockControl BarDockControl22;
        internal DevExpress.XtraBars.BarDockControl BarDockControl16;
        internal DevExpress.XtraBars.BarDockControl BarDockControl23;
        internal DevExpress.XtraBars.BarDockControl BarDockControl24;
        internal DevExpress.XtraBars.BarDockControl BarDockControl25;
        internal DevExpress.XtraBars.Bar Bar5;
        internal DevExpress.XtraBars.BarDockControl BarDockControl29;
        internal DevExpress.XtraBars.BarDockControl BarDockControl28;
        internal DevExpress.XtraBars.BarDockControl BarDockControl30;
        internal DevExpress.XtraBars.BarDockControl BarDockControl27;
        internal DevExpress.XtraBars.BarDockControl BarDockControl31;
        internal DevExpress.XtraBars.BarDockControl BarDockControl32;
        internal DevExpress.XtraBars.BarDockControl BarDockControl26;
        internal DevExpress.XtraBars.BarDockControl BarDockControl33;
        internal DevExpress.XtraBars.BarDockControl BarDockControl34;
        internal DevExpress.XtraBars.BarDockControl BarDockControl35;
        internal DevExpress.XtraBars.Bar Bar6;
        internal DevExpress.XtraBars.Bar Bar7;
        internal DevExpress.XtraBars.BarDockControl BarDockControl39;
        internal DevExpress.XtraBars.BarDockControl BarDockControl38;
        internal DevExpress.XtraBars.BarDockControl BarDockControl40;
        internal DevExpress.XtraBars.BarDockControl BarDockControl37;
        internal DevExpress.XtraBars.BarDockControl BarDockControl41;
        internal DevExpress.XtraBars.BarDockControl BarDockControl42;
        internal DevExpress.XtraBars.BarDockControl BarDockControl36;
        internal DevExpress.XtraBars.BarDockControl BarDockControl43;
        internal DevExpress.XtraBars.BarDockControl BarDockControl44;
        internal DevExpress.XtraBars.BarDockControl BarDockControl45;
        internal DevExpress.XtraBars.BarDockControl BarDockControl49;
        internal DevExpress.XtraBars.BarDockControl BarDockControl48;
        internal DevExpress.XtraBars.BarDockControl BarDockControl50;
        internal DevExpress.XtraBars.BarDockControl BarDockControl47;
        internal DevExpress.XtraBars.BarDockControl BarDockControl51;
        internal DevExpress.XtraBars.BarDockControl BarDockControl52;
        internal DevExpress.XtraBars.BarDockControl BarDockControl46;
        internal DevExpress.XtraBars.BarDockControl BarDockControl53;
        internal DevExpress.XtraBars.BarDockControl BarDockControl54;
        internal DevExpress.XtraBars.BarDockControl BarDockControl55;
        internal DevExpress.XtraBars.Bar Bar8;
        internal DevExpress.XtraTab.XtraTabPage TabPageReferenceSelection;
        internal DevExpress.XtraEditors.PanelControl PanelControl13;
        internal DevExpress.XtraEditors.PanelControl PanelControl14;
        internal DevExpress.XtraEditors.SimpleButton btnNext;
        internal DevExpress.XtraTab.XtraTabPage TabPageGeneratePO;
        internal DevExpress.XtraEditors.PanelControl PanelControl15;
        internal DevExpress.XtraGrid.GridControl gcGeneratePO;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvGeneratePO;
        internal DevExpress.XtraEditors.PanelControl PanelControl16;
        internal DevExpress.XtraEditors.SimpleButton btnGenPO;
        internal DevExpress.XtraEditors.PanelControl PanelControl17;
        public DevExpress.XtraEditors.RadioGroup rbPurchaseGroupType;
        internal DevExpress.XtraEditors.CheckEdit chkSelectAll;
        public DevExpress.XtraEditors.SimpleButton btnGeneratePOPre;
        internal DevExpress.XtraBars.StandaloneBarDockControl standJobMaster;
        internal DevExpress.XtraBars.BarDockControl BarDockControl75;
        internal DevExpress.XtraBars.BarDockControl BarDockControl74;
        internal DevExpress.XtraBars.BarDockControl BarDockControl76;
        internal DevExpress.XtraBars.BarDockControl BarDockControl73;
        internal DevExpress.XtraBars.BarDockControl BarDockControl77;
        internal DevExpress.XtraBars.BarDockControl BarDockControl78;
        internal DevExpress.XtraBars.BarDockControl BarDockControl72;
        internal DevExpress.XtraBars.BarDockControl BarDockControl79;
        internal DevExpress.XtraBars.BarDockControl BarDockControl80;
        internal DevExpress.XtraBars.BarDockControl BarDockControl81;
        internal DevExpress.XtraBars.Bar Bar9;
        internal DevExpress.XtraBars.BarDockControl BarDockControl85;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem93;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit9;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit10;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem92;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem91;
        internal DevExpress.XtraBars.BarEditItem BarEditItem14;
        internal DevExpress.XtraBars.BarEditItem BarEditItem13;
        internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox RepositoryItemComboBox6;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem90;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem77;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem75;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem74;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem73;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem56;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem54;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem53;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem52;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem35;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem33;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem32;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem31;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem14;
        internal DevExpress.XtraBars.Bar Bar11;
        internal DevExpress.XtraBars.Bar Bar12;
        internal DevExpress.XtraBars.Bar Bar14;
        internal DevExpress.XtraBars.Bar Bar13;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem94;
        internal DevExpress.XtraBars.BarDockControl BarDockControl88;
        internal DevExpress.XtraBars.BarDockControl BarDockControl89;
        internal DevExpress.XtraBars.BarDockControl BarDockControl87;
        internal DevExpress.XtraBars.BarDockControl BarDockControl86;
        internal DevExpress.XtraBars.BarButtonItem btnRefeSaveLayout;
        internal DevExpress.XtraBars.BarButtonItem btnRefeResetLayout;
        internal DevExpress.XtraBars.BarButtonItem btnRefeRefresh;
        internal DevExpress.XtraBars.BarButtonItem btnRefeExportExcel;
        internal DevExpress.XtraBars.BarManager BarManager8;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem99;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem100;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem101;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem102;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem103;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem104;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem105;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem106;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem107;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem108;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem109;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem110;
        public DevExpress.XtraBars.BarButtonItem BarButtonItem111;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem112;
        internal DevExpress.XtraBars.BarEditItem BarEditItem16;
        internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox RepositoryItemComboBox7;
        internal DevExpress.XtraBars.BarEditItem BarEditItem17;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit11;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem113;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem114;
        internal DevExpress.XtraBars.BarEditItem BarEditItem18;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit12;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem115;
        internal DevExpress.XtraGrid.GridControl gcUseFromStock;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvUseFromStock;
        internal DevExpress.XtraEditors.SplitContainerControl scProdurementGeneratePO;
        internal DevExpress.XtraTab.XtraTabPage TabPageSelection;
        internal DevExpress.XtraBars.BarButtonItem btnSelectionSaveLayout;
        internal DevExpress.XtraBars.BarButtonItem btnSelectionResetLayout;
        internal DevExpress.XtraBars.BarButtonItem btnSelectionRefresh;
        internal DevExpress.XtraBars.BarButtonItem btnSelectionExportExcel;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItem95;
        internal DevExpress.XtraEditors.PanelControl PanelControl18;
        public DevExpress.XtraEditors.SimpleButton btnSelectionPrev;
        public DevExpress.XtraEditors.SimpleButton btnSaveSelection;
        internal DevExpress.XtraEditors.PanelControl panelglass;
        internal DevExpress.XtraEditors.CheckEdit chkselall;
        internal DevExpress.XtraEditors.SimpleButton btnexportselect;
        internal DevExpress.XtraBars.BarCheckItem chkOrderAsPerReqQty;
        internal DevExpress.XtraBars.BarButtonItem btnSetDefaultSupplier;
        internal DevExpress.XtraBars.BarButtonItem btnCozy;
        internal DevExpress.XtraBars.BarButtonItem btnComfortable;
        internal DevExpress.XtraBars.BarButtonItem btnCompact;
        internal DevExpress.XtraBars.BarButtonItem btnSelCozy;
        internal DevExpress.XtraBars.BarButtonItem btnSelComfortable;
        internal DevExpress.XtraBars.BarButtonItem btnSelCompact;
        internal DevExpress.XtraEditors.SimpleButton btnPOComfortable;
        internal DevExpress.XtraEditors.SimpleButton btnPOCompact;
        internal DevExpress.XtraEditors.SimpleButton btnPOCozy;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.PanelControl PanelControl3;
        internal DevExpress.XtraEditors.PanelControl PanelControl6;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal TableLayoutPanel TableLayoutPanel1;
        internal DevExpress.XtraEditors.PanelControl PanelControl7;
        internal TableLayoutPanel TableLayoutPanel2;
        internal DevExpress.XtraEditors.PanelControl PanelControl8;
        internal TableLayoutPanel TableLayoutPanel3;
        internal TableLayoutPanel TableLayoutPanel4;
        internal DevExpress.XtraEditors.PanelControl PanelControl4;
        internal DevExpress.XtraBars.Bar BarReferenceSelection;
        internal DevExpress.XtraBars.Bar Bar15;
        internal DevExpress.XtraBars.StandaloneBarDockControl StandaloneBarDockControl1;
        internal TableLayoutPanel TLPmain;
        internal DevExpress.XtraEditors.PanelControl pnlGeneratePurchaseOrder;
        internal DevExpress.XtraEditors.LabelControl lblGeneratePO;
        internal DevExpress.XtraGrid.GridControl gcProcurementJobList;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvProcurementJobList;
        internal DevExpress.XtraEditors.TextEdit txtJobNo;
        internal DevExpress.XtraEditors.DateEdit dtFromDate;
        internal DevExpress.XtraEditors.SimpleButton btnSearch;
        internal DevExpress.XtraEditors.CheckEdit chkSelect;
        internal DevExpress.XtraEditors.DateEdit dtToDate;
        internal DevExpress.XtraEditors.RadioGroup rgProcurementType;
        internal DevExpress.XtraGrid.GridControl gcSelection;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvSelection;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbSupplier;
        internal DevExpress.XtraEditors.PanelControl pnlMainPOType;
        internal DevExpress.XtraEditors.LabelControl lblPoType;
        internal DevExpress.XtraEditors.PanelControl pnlMainSelection;
        internal DevExpress.XtraEditors.LabelControl lblSelection;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraBars.StandaloneBarDockControl StandaloneBarDockControl3;
        internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepSel;
        internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit JobProSel;
        internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit GenPOSel;
        internal DevExpress.XtraBars.BarEditItem BarEditItem15;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        internal DevExpress.XtraEditors.LookUpEdit LESupplier;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnDefaultsuppierApply;
        private DevExpress.XtraEditors.SimpleButton btnDefaultSupplierClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        public DevExpress.XtraEditors.PanelControl pnlDefaultSupplier;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.Utils.ImageCollection ImageCollection2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGrpDeliveryStatus;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup1;
        private LayoutControl layoutControl3;
        private LayoutControlGroup Root;
        private EmptySpaceItem emptySpaceItem4;
        private LayoutControlItem layoutControlItem5;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem9;
        private LayoutControlItem layoutControlItem10;
        private LayoutControlItem layoutControlItem11;
        private LayoutControlItem layoutControlItem12;
        private EmptySpaceItem emptySpaceItem5;
        private EmptySpaceItem emptySpaceItem6;
        private LayoutControlGroup layoutProcess;
        private EmptySpaceItem emptySpaceItem7;
        private EmptySpaceItem emptySpaceItem8;
        private EmptySpaceItem emptySpaceItem9;
    }
}
