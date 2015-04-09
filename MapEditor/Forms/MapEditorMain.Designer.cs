using MapEditor.Components;

namespace MapEditor
{
	partial class MapEditorMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditorMain));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tsMap = new System.Windows.Forms.ToolStrip();
			this.tbSelectMap = new System.Windows.Forms.ToolStripButton();
			this.tbPaintMap = new System.Windows.Forms.ToolStripButton();
			this.tbMoveMap = new System.Windows.Forms.ToolStripButton();
			this.tbRotateMap = new System.Windows.Forms.ToolStripButton();
			this.tbDeleteMap = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbAdjustMap = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tbLayerDropDown = new System.Windows.Forms.ToolStripComboBox();
			this.tbLayerRoomEdit = new System.Windows.Forms.ToolStripButton();
			this.tbEnabledLayersDropdown = new System.Windows.Forms.ToolStripDropDownButton();
			this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tbGridEnabled = new System.Windows.Forms.ToolStripButton();
			this.tbZoomOut = new System.Windows.Forms.ToolStripButton();
			this.tbZoomReset = new System.Windows.Forms.ToolStripButton();
			this.tbZoomIn = new System.Windows.Forms.ToolStripButton();
			this.roomEditor1 = new MapEditor.Components.RoomEditor();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabRooms = new System.Windows.Forms.TabPage();
			this.tabControlRooms = new System.Windows.Forms.TabControl();
			this.tpRoomList = new System.Windows.Forms.TabPage();
			this.lbRooms = new MapEditor.Components.ListBoxEx();
			this.subMenuForEditables = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.useToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tpDefinitions = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lbPlaceables = new MapEditor.Components.ListBoxEx();
			this.panelPreviewTab = new System.Windows.Forms.Panel();
			this.brushPlaceableIncstanceProp = new System.Windows.Forms.Button();
			this.brushPlaceableRotationRandom = new System.Windows.Forms.CheckBox();
			this.brushPlaceable270dir = new System.Windows.Forms.Button();
			this.brushPlaceable180dir = new System.Windows.Forms.Button();
			this.brushPlaceable90dir = new System.Windows.Forms.Button();
			this.brushPlaceable0dir = new System.Windows.Forms.Button();
			this.brushPlaceableRotation = new System.Windows.Forms.TextBox();
			this.brushPlaceableScale = new System.Windows.Forms.TextBox();
			this.brushPlaceableY = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.brushPlaceableX = new System.Windows.Forms.TextBox();
			this.brushObjectLabel = new System.Windows.Forms.Label();
			this.tpBrushes = new System.Windows.Forms.TabPage();
			this.brushGroupList = new System.Windows.Forms.ListView();
			this.imageListObjects = new System.Windows.Forms.ImageList(this.components);
			this.tabPlaceables = new System.Windows.Forms.TabPage();
			this.tabControlEnv = new System.Windows.Forms.TabControl();
			this.tpInstances = new System.Windows.Forms.TabPage();
			this.lbInstances = new MapEditor.Components.ListBoxEx();
			this.tpRoomDataLayers = new System.Windows.Forms.TabPage();
			this.lbLayers = new MapEditor.Components.ListBoxEx();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.tsOptions = new System.Windows.Forms.ToolStrip();
			this.tbAddItem = new System.Windows.Forms.ToolStripButton();
			this.tbRemoveItem = new System.Windows.Forms.ToolStripButton();
			this.tbEditItem = new System.Windows.Forms.ToolStripButton();
			this.tbDuplicateItem = new System.Windows.Forms.ToolStripButton();
			this.tbSortItem = new System.Windows.Forms.ToolStripSplitButton();
			this.defaultSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsEditors = new System.Windows.Forms.ToolStrip();
			this.tbUsedResList = new System.Windows.Forms.ToolStripButton();
			this.tbRoomList = new System.Windows.Forms.ToolStripButton();
			this.tbLayerList = new System.Windows.Forms.ToolStripButton();
			this.tbEnvList = new System.Windows.Forms.ToolStripButton();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.tbSaveProject = new System.Windows.Forms.ToolStripButton();
			this.tbOpenProject = new System.Windows.Forms.ToolStripButton();
			this.tbNewProject = new System.Windows.Forms.ToolStripButton();
			this.imageListFolders = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabelPlaceables = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabelMousePos = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tmSaveProject = new System.Windows.Forms.ToolStripMenuItem();
			this.tmOpenProject = new System.Windows.Forms.ToolStripMenuItem();
			this.tmCreateProject = new System.Windows.Forms.ToolStripMenuItem();
			this.tmCloseProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.tmSaveProjectAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tmEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enviromentPlaceablesItemsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spawnPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instancePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.tsMap.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabRooms.SuspendLayout();
			this.tabControlRooms.SuspendLayout();
			this.tpRoomList.SuspendLayout();
			this.subMenuForEditables.SuspendLayout();
			this.tpDefinitions.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panelPreviewTab.SuspendLayout();
			this.tpBrushes.SuspendLayout();
			this.tabPlaceables.SuspendLayout();
			this.tabControlEnv.SuspendLayout();
			this.tpInstances.SuspendLayout();
			this.tpRoomDataLayers.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tsOptions.SuspendLayout();
			this.tsEditors.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tsMap, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.roomEditor1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tabControlMain, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 434);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tsMap
			// 
			this.tsMap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSelectMap,
            this.tbPaintMap,
            this.tbMoveMap,
            this.tbRotateMap,
            this.tbDeleteMap,
            this.toolStripSeparator4,
            this.tbAdjustMap,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tbLayerDropDown,
            this.tbLayerRoomEdit,
            this.tbEnabledLayersDropdown,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.tbGridEnabled,
            this.tbZoomOut,
            this.tbZoomReset,
            this.tbZoomIn});
			this.tsMap.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.tsMap.Location = new System.Drawing.Point(330, 0);
			this.tsMap.Name = "tsMap";
			this.tsMap.Size = new System.Drawing.Size(604, 23);
			this.tsMap.TabIndex = 5;
			this.tsMap.Text = "toolStrip3";
			// 
			// tbSelectMap
			// 
			this.tbSelectMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSelectMap.Image = global::MapEditor.Properties.Resources.cursor;
			this.tbSelectMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSelectMap.Name = "tbSelectMap";
			this.tbSelectMap.Size = new System.Drawing.Size(23, 20);
			this.tbSelectMap.Text = "Select";
			this.tbSelectMap.Click += new System.EventHandler(this.tbSelectMap_Click);
			// 
			// tbPaintMap
			// 
			this.tbPaintMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbPaintMap.Image = global::MapEditor.Properties.Resources.paint_can;
			this.tbPaintMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbPaintMap.Name = "tbPaintMap";
			this.tbPaintMap.Size = new System.Drawing.Size(23, 20);
			this.tbPaintMap.Text = "Paint";
			this.tbPaintMap.Click += new System.EventHandler(this.tbPaintMap_Click);
			// 
			// tbMoveMap
			// 
			this.tbMoveMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbMoveMap.Image = global::MapEditor.Properties.Resources.arrow_move;
			this.tbMoveMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbMoveMap.Name = "tbMoveMap";
			this.tbMoveMap.Size = new System.Drawing.Size(23, 20);
			this.tbMoveMap.Text = "Move";
			this.tbMoveMap.Click += new System.EventHandler(this.tbMoveMap_Click);
			// 
			// tbRotateMap
			// 
			this.tbRotateMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbRotateMap.Image = global::MapEditor.Properties.Resources.arrow_circle_135_left;
			this.tbRotateMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbRotateMap.Name = "tbRotateMap";
			this.tbRotateMap.Size = new System.Drawing.Size(23, 20);
			this.tbRotateMap.Text = "Rotate";
			this.tbRotateMap.Click += new System.EventHandler(this.tbRotateMap_Click);
			// 
			// tbDeleteMap
			// 
			this.tbDeleteMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbDeleteMap.Image = global::MapEditor.Properties.Resources.cross;
			this.tbDeleteMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbDeleteMap.Name = "tbDeleteMap";
			this.tbDeleteMap.Size = new System.Drawing.Size(23, 20);
			this.tbDeleteMap.Text = "toolStripButton2";
			this.tbDeleteMap.Click += new System.EventHandler(this.tbDeleteMap_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
			// 
			// tbAdjustMap
			// 
			this.tbAdjustMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbAdjustMap.Image = global::MapEditor.Properties.Resources.equalizer;
			this.tbAdjustMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbAdjustMap.Name = "tbAdjustMap";
			this.tbAdjustMap.Size = new System.Drawing.Size(23, 20);
			this.tbAdjustMap.Text = "Properties";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(35, 15);
			this.toolStripLabel1.Text = "Layer";
			// 
			// tbLayerDropDown
			// 
			this.tbLayerDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tbLayerDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tbLayerDropDown.Name = "tbLayerDropDown";
			this.tbLayerDropDown.Size = new System.Drawing.Size(121, 23);
			this.tbLayerDropDown.DropDownClosed += new System.EventHandler(this.tbLayerDropDown_DropDownClosed);
			// 
			// tbLayerRoomEdit
			// 
			this.tbLayerRoomEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbLayerRoomEdit.Image = global::MapEditor.Properties.Resources.layer__pencil;
			this.tbLayerRoomEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbLayerRoomEdit.Name = "tbLayerRoomEdit";
			this.tbLayerRoomEdit.Size = new System.Drawing.Size(23, 20);
			this.tbLayerRoomEdit.Text = "toolStripButton7";
			this.tbLayerRoomEdit.Click += new System.EventHandler(this.tbLayerRoomEdit_Click);
			// 
			// tbEnabledLayersDropdown
			// 
			this.tbEnabledLayersDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbEnabledLayersDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem});
			this.tbEnabledLayersDropdown.Image = global::MapEditor.Properties.Resources.layers_stack_arrange;
			this.tbEnabledLayersDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbEnabledLayersDropdown.Name = "tbEnabledLayersDropdown";
			this.tbEnabledLayersDropdown.Size = new System.Drawing.Size(29, 20);
			this.tbEnabledLayersDropdown.Text = "toolStripDropDownButton1";
			this.tbEnabledLayersDropdown.ToolTipText = "Visible layers";
			// 
			// tESTToolStripMenuItem
			// 
			this.tESTToolStripMenuItem.Checked = true;
			this.tESTToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
			this.tESTToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.tESTToolStripMenuItem.Text = "TEST";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::MapEditor.Properties.Resources.minus_button;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// tbGridEnabled
			// 
			this.tbGridEnabled.Checked = true;
			this.tbGridEnabled.CheckOnClick = true;
			this.tbGridEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tbGridEnabled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbGridEnabled.Image = global::MapEditor.Properties.Resources.grid;
			this.tbGridEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbGridEnabled.Name = "tbGridEnabled";
			this.tbGridEnabled.Size = new System.Drawing.Size(23, 20);
			this.tbGridEnabled.Text = "toolStripButton2";
			this.tbGridEnabled.Click += new System.EventHandler(this.tbGridEnabled_Click);
			// 
			// tbZoomOut
			// 
			this.tbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbZoomOut.Image = global::MapEditor.Properties.Resources.magnifier_zoom_out;
			this.tbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbZoomOut.Name = "tbZoomOut";
			this.tbZoomOut.Size = new System.Drawing.Size(23, 20);
			this.tbZoomOut.Text = "toolStripButton3";
			this.tbZoomOut.Click += new System.EventHandler(this.tbZoomOut_Click);
			// 
			// tbZoomReset
			// 
			this.tbZoomReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbZoomReset.Image = global::MapEditor.Properties.Resources.magnifier_zoom_actual;
			this.tbZoomReset.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbZoomReset.Name = "tbZoomReset";
			this.tbZoomReset.Size = new System.Drawing.Size(23, 20);
			this.tbZoomReset.Text = "toolStripButton4";
			this.tbZoomReset.Click += new System.EventHandler(this.tbZoomReset_Click);
			// 
			// tbZoomIn
			// 
			this.tbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbZoomIn.Image = global::MapEditor.Properties.Resources.magnifier_zoom_in;
			this.tbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbZoomIn.Name = "tbZoomIn";
			this.tbZoomIn.Size = new System.Drawing.Size(23, 20);
			this.tbZoomIn.Text = "toolStripButton5";
			this.tbZoomIn.Click += new System.EventHandler(this.tbZoomIn_Click);
			// 
			// roomEditor1
			// 
			this.roomEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
			this.roomEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.roomEditor1.Location = new System.Drawing.Point(333, 28);
			this.roomEditor1.Name = "roomEditor1";
			this.roomEditor1.Size = new System.Drawing.Size(598, 403);
			this.roomEditor1.TabIndex = 6;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabRooms);
			this.tabControlMain.Controls.Add(this.tabPlaceables);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.ImageList = this.imageList1;
			this.tabControlMain.Location = new System.Drawing.Point(3, 28);
			this.tabControlMain.Multiline = true;
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(324, 403);
			this.tabControlMain.TabIndex = 4;
			// 
			// tabRooms
			// 
			this.tabRooms.Controls.Add(this.tabControlRooms);
			this.tabRooms.ImageIndex = 0;
			this.tabRooms.Location = new System.Drawing.Point(4, 23);
			this.tabRooms.Name = "tabRooms";
			this.tabRooms.Size = new System.Drawing.Size(316, 376);
			this.tabRooms.TabIndex = 5;
			this.tabRooms.Text = "Rooms & Env";
			this.tabRooms.UseVisualStyleBackColor = true;
			// 
			// tabControlRooms
			// 
			this.tabControlRooms.Controls.Add(this.tpRoomList);
			this.tabControlRooms.Controls.Add(this.tpDefinitions);
			this.tabControlRooms.Controls.Add(this.tpBrushes);
			this.tabControlRooms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlRooms.Location = new System.Drawing.Point(0, 0);
			this.tabControlRooms.Name = "tabControlRooms";
			this.tabControlRooms.SelectedIndex = 0;
			this.tabControlRooms.Size = new System.Drawing.Size(316, 376);
			this.tabControlRooms.TabIndex = 1;
			// 
			// tpRoomList
			// 
			this.tpRoomList.Controls.Add(this.lbRooms);
			this.tpRoomList.Location = new System.Drawing.Point(4, 22);
			this.tpRoomList.Name = "tpRoomList";
			this.tpRoomList.Size = new System.Drawing.Size(308, 350);
			this.tpRoomList.TabIndex = 0;
			this.tpRoomList.Text = "Rooms";
			this.tpRoomList.UseVisualStyleBackColor = true;
			// 
			// lbRooms
			// 
			this.lbRooms.ContextMenuStrip = this.subMenuForEditables;
			this.lbRooms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lbRooms.FormattingEnabled = true;
			this.lbRooms.Location = new System.Drawing.Point(0, 0);
			this.lbRooms.Name = "lbRooms";
			this.lbRooms.Size = new System.Drawing.Size(308, 350);
			this.lbRooms.TabIndex = 0;
			this.lbRooms.Type = MapEditor.Components.ListBoxEx.ListType.Rooms;
			this.lbRooms.DoubleClick += new System.EventHandler(this.lbRooms_DoubleClick);
			// 
			// subMenuForEditables
			// 
			this.subMenuForEditables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.useToolStripMenuItem});
			this.subMenuForEditables.Name = "subMenuForEditables";
			this.subMenuForEditables.Size = new System.Drawing.Size(125, 92);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::MapEditor.Properties.Resources.pencil_button;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// duplicateToolStripMenuItem
			// 
			this.duplicateToolStripMenuItem.Image = global::MapEditor.Properties.Resources.ui_buttons;
			this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
			this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.duplicateToolStripMenuItem.Text = "Du&plicate";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::MapEditor.Properties.Resources.minus_button;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			// 
			// useToolStripMenuItem
			// 
			this.useToolStripMenuItem.Image = global::MapEditor.Properties.Resources.layer__pencil;
			this.useToolStripMenuItem.Name = "useToolStripMenuItem";
			this.useToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.useToolStripMenuItem.Text = "&Use";
			// 
			// tpDefinitions
			// 
			this.tpDefinitions.Controls.Add(this.tableLayoutPanel2);
			this.tpDefinitions.Location = new System.Drawing.Point(4, 22);
			this.tpDefinitions.Name = "tpDefinitions";
			this.tpDefinitions.Size = new System.Drawing.Size(308, 350);
			this.tpDefinitions.TabIndex = 1;
			this.tpDefinitions.Text = "Env Definitions";
			this.tpDefinitions.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.lbPlaceables, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panelPreviewTab, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 350);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// lbPlaceables
			// 
			this.lbPlaceables.ContextMenuStrip = this.subMenuForEditables;
			this.lbPlaceables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbPlaceables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lbPlaceables.FormattingEnabled = true;
			this.lbPlaceables.Location = new System.Drawing.Point(3, 3);
			this.lbPlaceables.Name = "lbPlaceables";
			this.lbPlaceables.Size = new System.Drawing.Size(302, 144);
			this.lbPlaceables.TabIndex = 0;
			this.lbPlaceables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPlaceables_MouseClick);
			this.lbPlaceables.DoubleClick += new System.EventHandler(this.lbPlaceables_DoubleClick);
			// 
			// panelPreviewTab
			// 
			this.panelPreviewTab.Controls.Add(this.brushPlaceableIncstanceProp);
			this.panelPreviewTab.Controls.Add(this.brushPlaceableRotationRandom);
			this.panelPreviewTab.Controls.Add(this.brushPlaceable270dir);
			this.panelPreviewTab.Controls.Add(this.brushPlaceable180dir);
			this.panelPreviewTab.Controls.Add(this.brushPlaceable90dir);
			this.panelPreviewTab.Controls.Add(this.brushPlaceable0dir);
			this.panelPreviewTab.Controls.Add(this.brushPlaceableRotation);
			this.panelPreviewTab.Controls.Add(this.brushPlaceableScale);
			this.panelPreviewTab.Controls.Add(this.brushPlaceableY);
			this.panelPreviewTab.Controls.Add(this.label4);
			this.panelPreviewTab.Controls.Add(this.label3);
			this.panelPreviewTab.Controls.Add(this.label2);
			this.panelPreviewTab.Controls.Add(this.label1);
			this.panelPreviewTab.Controls.Add(this.brushPlaceableX);
			this.panelPreviewTab.Controls.Add(this.brushObjectLabel);
			this.panelPreviewTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPreviewTab.Location = new System.Drawing.Point(3, 153);
			this.panelPreviewTab.Name = "panelPreviewTab";
			this.panelPreviewTab.Size = new System.Drawing.Size(302, 194);
			this.panelPreviewTab.TabIndex = 1;
			// 
			// brushPlaceableIncstanceProp
			// 
			this.brushPlaceableIncstanceProp.Location = new System.Drawing.Point(56, 138);
			this.brushPlaceableIncstanceProp.Name = "brushPlaceableIncstanceProp";
			this.brushPlaceableIncstanceProp.Size = new System.Drawing.Size(75, 23);
			this.brushPlaceableIncstanceProp.TabIndex = 15;
			this.brushPlaceableIncstanceProp.Text = "Instance Properties...";
			this.brushPlaceableIncstanceProp.UseVisualStyleBackColor = true;
			// 
			// brushPlaceableRotationRandom
			// 
			this.brushPlaceableRotationRandom.AutoSize = true;
			this.brushPlaceableRotationRandom.Location = new System.Drawing.Point(56, 115);
			this.brushPlaceableRotationRandom.Name = "brushPlaceableRotationRandom";
			this.brushPlaceableRotationRandom.Size = new System.Drawing.Size(183, 17);
			this.brushPlaceableRotationRandom.TabIndex = 14;
			this.brushPlaceableRotationRandom.Text = "randomize direction in paint mode";
			this.brushPlaceableRotationRandom.UseVisualStyleBackColor = true;
			// 
			// brushPlaceable270dir
			// 
			this.brushPlaceable270dir.Location = new System.Drawing.Point(255, 88);
			this.brushPlaceable270dir.Name = "brushPlaceable270dir";
			this.brushPlaceable270dir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.brushPlaceable270dir.Size = new System.Drawing.Size(35, 20);
			this.brushPlaceable270dir.TabIndex = 13;
			this.brushPlaceable270dir.Text = "270";
			this.brushPlaceable270dir.UseVisualStyleBackColor = true;
			this.brushPlaceable270dir.Click += new System.EventHandler(this.brushPlaceable270dir_Click);
			// 
			// brushPlaceable180dir
			// 
			this.brushPlaceable180dir.Location = new System.Drawing.Point(214, 89);
			this.brushPlaceable180dir.Name = "brushPlaceable180dir";
			this.brushPlaceable180dir.Size = new System.Drawing.Size(35, 20);
			this.brushPlaceable180dir.TabIndex = 12;
			this.brushPlaceable180dir.Text = "180";
			this.brushPlaceable180dir.UseVisualStyleBackColor = true;
			this.brushPlaceable180dir.Click += new System.EventHandler(this.brushPlaceable180dir_Click);
			// 
			// brushPlaceable90dir
			// 
			this.brushPlaceable90dir.Location = new System.Drawing.Point(178, 89);
			this.brushPlaceable90dir.Name = "brushPlaceable90dir";
			this.brushPlaceable90dir.Size = new System.Drawing.Size(30, 20);
			this.brushPlaceable90dir.TabIndex = 11;
			this.brushPlaceable90dir.Text = "90";
			this.brushPlaceable90dir.UseVisualStyleBackColor = true;
			this.brushPlaceable90dir.Click += new System.EventHandler(this.brushPlaceable90dir_Click);
			// 
			// brushPlaceable0dir
			// 
			this.brushPlaceable0dir.Location = new System.Drawing.Point(151, 89);
			this.brushPlaceable0dir.Name = "brushPlaceable0dir";
			this.brushPlaceable0dir.Size = new System.Drawing.Size(21, 20);
			this.brushPlaceable0dir.TabIndex = 10;
			this.brushPlaceable0dir.Text = "0";
			this.brushPlaceable0dir.UseVisualStyleBackColor = true;
			this.brushPlaceable0dir.Click += new System.EventHandler(this.brushPlaceable0dir_Click);
			// 
			// brushPlaceableRotation
			// 
			this.brushPlaceableRotation.Location = new System.Drawing.Point(56, 89);
			this.brushPlaceableRotation.Name = "brushPlaceableRotation";
			this.brushPlaceableRotation.Size = new System.Drawing.Size(89, 20);
			this.brushPlaceableRotation.TabIndex = 9;
			this.brushPlaceableRotation.Text = "0";
			// 
			// brushPlaceableScale
			// 
			this.brushPlaceableScale.Location = new System.Drawing.Point(56, 63);
			this.brushPlaceableScale.Name = "brushPlaceableScale";
			this.brushPlaceableScale.Size = new System.Drawing.Size(89, 20);
			this.brushPlaceableScale.TabIndex = 8;
			this.brushPlaceableScale.Text = "1";
			// 
			// brushPlaceableY
			// 
			this.brushPlaceableY.Location = new System.Drawing.Point(56, 37);
			this.brushPlaceableY.Name = "brushPlaceableY";
			this.brushPlaceableY.Size = new System.Drawing.Size(89, 20);
			this.brushPlaceableY.TabIndex = 7;
			this.brushPlaceableY.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Rotate:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Scale:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Y:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "X:";
			// 
			// brushPlaceableX
			// 
			this.brushPlaceableX.Location = new System.Drawing.Point(56, 11);
			this.brushPlaceableX.Name = "brushPlaceableX";
			this.brushPlaceableX.Size = new System.Drawing.Size(89, 20);
			this.brushPlaceableX.TabIndex = 2;
			this.brushPlaceableX.Text = "0";
			// 
			// brushObjectLabel
			// 
			this.brushObjectLabel.Location = new System.Drawing.Point(175, 14);
			this.brushObjectLabel.Name = "brushObjectLabel";
			this.brushObjectLabel.Size = new System.Drawing.Size(100, 15);
			this.brushObjectLabel.TabIndex = 1;
			this.brushObjectLabel.Text = "brushObjectLabel";
			this.brushObjectLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tpBrushes
			// 
			this.tpBrushes.Controls.Add(this.brushGroupList);
			this.tpBrushes.Location = new System.Drawing.Point(4, 22);
			this.tpBrushes.Name = "tpBrushes";
			this.tpBrushes.Padding = new System.Windows.Forms.Padding(3);
			this.tpBrushes.Size = new System.Drawing.Size(308, 350);
			this.tpBrushes.TabIndex = 2;
			this.tpBrushes.Text = "Brushes";
			this.tpBrushes.UseVisualStyleBackColor = true;
			// 
			// brushGroupList
			// 
			this.brushGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brushGroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushGroupList.LargeImageList = this.imageListObjects;
			this.brushGroupList.Location = new System.Drawing.Point(3, 3);
			this.brushGroupList.Name = "brushGroupList";
			this.brushGroupList.Size = new System.Drawing.Size(302, 344);
			this.brushGroupList.TabIndex = 0;
			this.brushGroupList.UseCompatibleStateImageBehavior = false;
			// 
			// imageListObjects
			// 
			this.imageListObjects.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListObjects.ImageStream")));
			this.imageListObjects.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListObjects.Images.SetKeyName(0, "<undefined>");
			// 
			// tabPlaceables
			// 
			this.tabPlaceables.Controls.Add(this.tabControlEnv);
			this.tabPlaceables.ImageIndex = 1;
			this.tabPlaceables.Location = new System.Drawing.Point(4, 23);
			this.tabPlaceables.Name = "tabPlaceables";
			this.tabPlaceables.Size = new System.Drawing.Size(316, 376);
			this.tabPlaceables.TabIndex = 0;
			this.tabPlaceables.Text = "Room Data";
			this.tabPlaceables.UseVisualStyleBackColor = true;
			// 
			// tabControlEnv
			// 
			this.tabControlEnv.Controls.Add(this.tpInstances);
			this.tabControlEnv.Controls.Add(this.tpRoomDataLayers);
			this.tabControlEnv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlEnv.Location = new System.Drawing.Point(0, 0);
			this.tabControlEnv.Name = "tabControlEnv";
			this.tabControlEnv.SelectedIndex = 0;
			this.tabControlEnv.Size = new System.Drawing.Size(316, 376);
			this.tabControlEnv.TabIndex = 2;
			// 
			// tpInstances
			// 
			this.tpInstances.Controls.Add(this.lbInstances);
			this.tpInstances.Location = new System.Drawing.Point(4, 22);
			this.tpInstances.Name = "tpInstances";
			this.tpInstances.Size = new System.Drawing.Size(308, 350);
			this.tpInstances.TabIndex = 1;
			this.tpInstances.Text = "Instances";
			this.tpInstances.UseVisualStyleBackColor = true;
			// 
			// lbInstances
			// 
			this.lbInstances.ContextMenuStrip = this.subMenuForEditables;
			this.lbInstances.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbInstances.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lbInstances.FormattingEnabled = true;
			this.lbInstances.Location = new System.Drawing.Point(0, 0);
			this.lbInstances.Name = "lbInstances";
			this.lbInstances.Size = new System.Drawing.Size(308, 350);
			this.lbInstances.TabIndex = 1;
			this.lbInstances.Type = MapEditor.Components.ListBoxEx.ListType.PlaceableInstances;
			// 
			// tpRoomDataLayers
			// 
			this.tpRoomDataLayers.Controls.Add(this.lbLayers);
			this.tpRoomDataLayers.Location = new System.Drawing.Point(4, 22);
			this.tpRoomDataLayers.Name = "tpRoomDataLayers";
			this.tpRoomDataLayers.Size = new System.Drawing.Size(308, 350);
			this.tpRoomDataLayers.TabIndex = 2;
			this.tpRoomDataLayers.Text = "Layers";
			this.tpRoomDataLayers.UseVisualStyleBackColor = true;
			// 
			// lbLayers
			// 
			this.lbLayers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbLayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lbLayers.Location = new System.Drawing.Point(0, 0);
			this.lbLayers.Name = "lbLayers";
			this.lbLayers.Size = new System.Drawing.Size(308, 350);
			this.lbLayers.TabIndex = 0;
			this.lbLayers.Type = MapEditor.Components.ListBoxEx.ListType.Layers;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "zone.png");
			this.imageList1.Images.SetKeyName(1, "leaf.png");
			this.imageList1.Images.SetKeyName(2, "home.png");
			this.imageList1.Images.SetKeyName(3, "user-silhouette-question.png");
			this.imageList1.Images.SetKeyName(4, "exclamation--frame.png");
			this.imageList1.Images.SetKeyName(5, "bug.png");
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tsOptions);
			this.panel2.Controls.Add(this.tsEditors);
			this.panel2.Controls.Add(this.tsMain);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(330, 25);
			this.panel2.TabIndex = 7;
			// 
			// tsOptions
			// 
			this.tsOptions.Dock = System.Windows.Forms.DockStyle.Left;
			this.tsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAddItem,
            this.tbRemoveItem,
            this.tbEditItem,
            this.tbDuplicateItem,
            this.tbSortItem});
			this.tsOptions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.tsOptions.Location = new System.Drawing.Point(163, 0);
			this.tsOptions.Name = "tsOptions";
			this.tsOptions.Size = new System.Drawing.Size(125, 25);
			this.tsOptions.TabIndex = 3;
			this.tsOptions.Text = "toolStrip2";
			// 
			// tbAddItem
			// 
			this.tbAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbAddItem.Image = global::MapEditor.Properties.Resources.plus_button;
			this.tbAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbAddItem.Name = "tbAddItem";
			this.tbAddItem.Size = new System.Drawing.Size(23, 20);
			this.tbAddItem.Text = "Paint";
			this.tbAddItem.Click += new System.EventHandler(this.tbAddItem_Click);
			// 
			// tbRemoveItem
			// 
			this.tbRemoveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbRemoveItem.Image = global::MapEditor.Properties.Resources.minus_button;
			this.tbRemoveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbRemoveItem.Name = "tbRemoveItem";
			this.tbRemoveItem.Size = new System.Drawing.Size(23, 20);
			this.tbRemoveItem.Text = "Remove";
			// 
			// tbEditItem
			// 
			this.tbEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbEditItem.Image = global::MapEditor.Properties.Resources.pencil_button;
			this.tbEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbEditItem.Name = "tbEditItem";
			this.tbEditItem.Size = new System.Drawing.Size(23, 20);
			this.tbEditItem.Text = "Edit";
			this.tbEditItem.Click += new System.EventHandler(this.tbEditItem_Click);
			// 
			// tbDuplicateItem
			// 
			this.tbDuplicateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbDuplicateItem.Enabled = false;
			this.tbDuplicateItem.Image = global::MapEditor.Properties.Resources.ui_buttons;
			this.tbDuplicateItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbDuplicateItem.Name = "tbDuplicateItem";
			this.tbDuplicateItem.Size = new System.Drawing.Size(23, 20);
			this.tbDuplicateItem.Text = "Duplicate";
			// 
			// tbSortItem
			// 
			this.tbSortItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSortItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultSortToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
			this.tbSortItem.Enabled = false;
			this.tbSortItem.Image = global::MapEditor.Properties.Resources.sort_rating;
			this.tbSortItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSortItem.Name = "tbSortItem";
			this.tbSortItem.Size = new System.Drawing.Size(32, 20);
			this.tbSortItem.Text = "toolStripSplitButton1";
			// 
			// defaultSortToolStripMenuItem
			// 
			this.defaultSortToolStripMenuItem.Checked = true;
			this.defaultSortToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.defaultSortToolStripMenuItem.Image = global::MapEditor.Properties.Resources.sort_rating;
			this.defaultSortToolStripMenuItem.Name = "defaultSortToolStripMenuItem";
			this.defaultSortToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.defaultSortToolStripMenuItem.Text = "Default Sort";
			// 
			// sortAZToolStripMenuItem
			// 
			this.sortAZToolStripMenuItem.Image = global::MapEditor.Properties.Resources.sort_quantity;
			this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
			this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.sortAZToolStripMenuItem.Text = "Sort A-Z";
			// 
			// sortZAToolStripMenuItem
			// 
			this.sortZAToolStripMenuItem.Image = global::MapEditor.Properties.Resources.sort_quantity_descending;
			this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
			this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.sortZAToolStripMenuItem.Text = "Sort Z-A";
			// 
			// tsEditors
			// 
			this.tsEditors.Dock = System.Windows.Forms.DockStyle.Left;
			this.tsEditors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbUsedResList,
            this.tbRoomList,
            this.tbLayerList,
            this.tbEnvList});
			this.tsEditors.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.tsEditors.Location = new System.Drawing.Point(70, 0);
			this.tsEditors.Name = "tsEditors";
			this.tsEditors.Size = new System.Drawing.Size(93, 25);
			this.tsEditors.TabIndex = 2;
			this.tsEditors.Text = "toolStrip1";
			// 
			// tbUsedResList
			// 
			this.tbUsedResList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbUsedResList.Image = global::MapEditor.Properties.Resources.gear;
			this.tbUsedResList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbUsedResList.Name = "tbUsedResList";
			this.tbUsedResList.Size = new System.Drawing.Size(23, 20);
			this.tbUsedResList.Text = "Res List";
			this.tbUsedResList.ToolTipText = "Linked Resource List";
			this.tbUsedResList.Click += new System.EventHandler(this.tbUsedResList_Click);
			// 
			// tbRoomList
			// 
			this.tbRoomList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbRoomList.Enabled = false;
			this.tbRoomList.Image = global::MapEditor.Properties.Resources.maps;
			this.tbRoomList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbRoomList.Name = "tbRoomList";
			this.tbRoomList.Size = new System.Drawing.Size(23, 20);
			this.tbRoomList.Text = "toolStripButton13";
			// 
			// tbLayerList
			// 
			this.tbLayerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbLayerList.Image = global::MapEditor.Properties.Resources.layers_stack_arrange;
			this.tbLayerList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbLayerList.Name = "tbLayerList";
			this.tbLayerList.Size = new System.Drawing.Size(23, 20);
			this.tbLayerList.Text = "toolStripButton9";
			this.tbLayerList.ToolTipText = "Layers List";
			this.tbLayerList.Click += new System.EventHandler(this.tbLayerList_Click);
			// 
			// tbEnvList
			// 
			this.tbEnvList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbEnvList.Image = global::MapEditor.Properties.Resources.tree;
			this.tbEnvList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbEnvList.Name = "tbEnvList";
			this.tbEnvList.Size = new System.Drawing.Size(23, 20);
			this.tbEnvList.Text = "toolStripButton10";
			this.tbEnvList.Click += new System.EventHandler(this.tbEnvList_Click);
			// 
			// tsMain
			// 
			this.tsMain.Dock = System.Windows.Forms.DockStyle.Left;
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSaveProject,
            this.tbOpenProject,
            this.tbNewProject});
			this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.tsMain.Location = new System.Drawing.Point(0, 0);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(70, 25);
			this.tsMain.TabIndex = 1;
			this.tsMain.Text = "toolStripMain";
			// 
			// tbSaveProject
			// 
			this.tbSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSaveProject.Image = global::MapEditor.Properties.Resources.disk;
			this.tbSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSaveProject.Name = "tbSaveProject";
			this.tbSaveProject.Size = new System.Drawing.Size(23, 20);
			this.tbSaveProject.Text = "toolStripButton2";
			this.tbSaveProject.Click += new System.EventHandler(this.tbSaveProject_Click);
			// 
			// tbOpenProject
			// 
			this.tbOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbOpenProject.Image = global::MapEditor.Properties.Resources.folder_horizontal_open;
			this.tbOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbOpenProject.Name = "tbOpenProject";
			this.tbOpenProject.Size = new System.Drawing.Size(23, 20);
			this.tbOpenProject.Text = "Open";
			this.tbOpenProject.Click += new System.EventHandler(this.tbOpenProject_Click);
			// 
			// tbNewProject
			// 
			this.tbNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbNewProject.Image = global::MapEditor.Properties.Resources.box;
			this.tbNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbNewProject.Name = "tbNewProject";
			this.tbNewProject.Size = new System.Drawing.Size(23, 20);
			this.tbNewProject.Text = "Create New Project";
			this.tbNewProject.Click += new System.EventHandler(this.tbNewProject_Click);
			// 
			// imageListFolders
			// 
			this.imageListFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFolders.ImageStream")));
			this.imageListFolders.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListFolders.Images.SetKeyName(0, "folder-horizontal.png");
			this.imageListFolders.Images.SetKeyName(1, "blue-folder-horizontal.png");
			this.imageListFolders.Images.SetKeyName(2, "folder-horizontal-open.png");
			this.imageListFolders.Images.SetKeyName(3, "document-attribute-g.png");
			this.imageListFolders.Images.SetKeyName(4, "document-binary.png");
			this.imageListFolders.Images.SetKeyName(5, "document-code.png");
			this.imageListFolders.Images.SetKeyName(6, "images.png");
			this.imageListFolders.Images.SetKeyName(7, "control-record-small.png");
			// 
			// statusStrip1
			// 
			this.statusStrip1.AllowMerge = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.statusLabelPlaceables,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.statusLabelMousePos});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 458);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(934, 24);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStripMain";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 19);
			this.toolStripStatusLabel1.Text = "Rooms:";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(17, 19);
			this.toolStripStatusLabel2.Text = "0";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(54, 19);
			this.toolStripStatusLabel3.Text = "Env defs:";
			// 
			// statusLabelPlaceables
			// 
			this.statusLabelPlaceables.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusLabelPlaceables.Name = "statusLabelPlaceables";
			this.statusLabelPlaceables.Size = new System.Drawing.Size(17, 19);
			this.statusLabelPlaceables.Text = "0";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(130, 19);
			this.toolStripStatusLabel5.Text = "NPC, Events && Spawns:";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(17, 19);
			this.toolStripStatusLabel6.Text = "0";
			// 
			// statusLabelMousePos
			// 
			this.statusLabelMousePos.Name = "statusLabelMousePos";
			this.statusLabelMousePos.Size = new System.Drawing.Size(12, 19);
			this.statusLabelMousePos.Text = "-";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tmEdit,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(934, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmSaveProject,
            this.tmOpenProject,
            this.tmCreateProject,
            this.tmCloseProject,
            this.toolStripMenuItem3,
            this.tmSaveProjectAs,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// tmSaveProject
			// 
			this.tmSaveProject.Image = global::MapEditor.Properties.Resources.disk;
			this.tmSaveProject.Name = "tmSaveProject";
			this.tmSaveProject.ShortcutKeyDisplayString = "Ctrl+S";
			this.tmSaveProject.Size = new System.Drawing.Size(262, 22);
			this.tmSaveProject.Text = "&Save ProjectData";
			this.tmSaveProject.Click += new System.EventHandler(this.tbSaveProject_Click);
			// 
			// tmOpenProject
			// 
			this.tmOpenProject.Image = global::MapEditor.Properties.Resources.folder_horizontal_open;
			this.tmOpenProject.Name = "tmOpenProject";
			this.tmOpenProject.ShortcutKeyDisplayString = "";
			this.tmOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.tmOpenProject.Size = new System.Drawing.Size(262, 22);
			this.tmOpenProject.Text = "&Open Existing ProjectData...";
			this.tmOpenProject.Click += new System.EventHandler(this.tbOpenProject_Click);
			// 
			// tmCreateProject
			// 
			this.tmCreateProject.Image = global::MapEditor.Properties.Resources.box;
			this.tmCreateProject.Name = "tmCreateProject";
			this.tmCreateProject.ShortcutKeyDisplayString = "";
			this.tmCreateProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.tmCreateProject.Size = new System.Drawing.Size(262, 22);
			this.tmCreateProject.Text = "&Create New ProjectData...";
			this.tmCreateProject.Click += new System.EventHandler(this.tbNewProject_Click);
			// 
			// tmCloseProject
			// 
			this.tmCloseProject.Image = global::MapEditor.Properties.Resources.cross;
			this.tmCloseProject.Name = "tmCloseProject";
			this.tmCloseProject.Size = new System.Drawing.Size(262, 22);
			this.tmCloseProject.Text = "C&lose Project";
			this.tmCloseProject.Click += new System.EventHandler(this.tmCloseProject_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(259, 6);
			// 
			// tmSaveProjectAs
			// 
			this.tmSaveProjectAs.Image = global::MapEditor.Properties.Resources.disks;
			this.tmSaveProjectAs.Name = "tmSaveProjectAs";
			this.tmSaveProjectAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
			this.tmSaveProjectAs.Size = new System.Drawing.Size(262, 22);
			this.tmSaveProjectAs.Text = "Save ProjectData &As...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(259, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::MapEditor.Properties.Resources.cross;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// tmEdit
			// 
			this.tmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.enviromentPlaceablesItemsListToolStripMenuItem,
            this.spawnPointsToolStripMenuItem,
            this.nPCsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectToolStripMenuItem,
            this.moverToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.instancePropertiesToolStripMenuItem});
			this.tmEdit.Name = "tmEdit";
			this.tmEdit.Size = new System.Drawing.Size(39, 20);
			this.tmEdit.Text = "&Edit";
			// 
			// roomsToolStripMenuItem
			// 
			this.roomsToolStripMenuItem.Image = global::MapEditor.Properties.Resources.maps;
			this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
			this.roomsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.roomsToolStripMenuItem.Text = "Rooms...";
			// 
			// enviromentPlaceablesItemsListToolStripMenuItem
			// 
			this.enviromentPlaceablesItemsListToolStripMenuItem.Image = global::MapEditor.Properties.Resources.tree;
			this.enviromentPlaceablesItemsListToolStripMenuItem.Name = "enviromentPlaceablesItemsListToolStripMenuItem";
			this.enviromentPlaceablesItemsListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.enviromentPlaceablesItemsListToolStripMenuItem.Text = "Placeables...";
			// 
			// spawnPointsToolStripMenuItem
			// 
			this.spawnPointsToolStripMenuItem.Image = global::MapEditor.Properties.Resources.animal_penguin;
			this.spawnPointsToolStripMenuItem.Name = "spawnPointsToolStripMenuItem";
			this.spawnPointsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.spawnPointsToolStripMenuItem.Text = "Spawn Points...";
			// 
			// nPCsToolStripMenuItem
			// 
			this.nPCsToolStripMenuItem.Image = global::MapEditor.Properties.Resources.user_silhouette_question;
			this.nPCsToolStripMenuItem.Name = "nPCsToolStripMenuItem";
			this.nPCsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.nPCsToolStripMenuItem.Text = "NPCs...";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
			// 
			// selectToolStripMenuItem
			// 
			this.selectToolStripMenuItem.Image = global::MapEditor.Properties.Resources.cursor;
			this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
			this.selectToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.selectToolStripMenuItem.Text = "Select";
			// 
			// moverToolStripMenuItem
			// 
			this.moverToolStripMenuItem.Image = global::MapEditor.Properties.Resources.arrow_move;
			this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
			this.moverToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.moverToolStripMenuItem.Text = "Move";
			// 
			// rotateToolStripMenuItem
			// 
			this.rotateToolStripMenuItem.Image = global::MapEditor.Properties.Resources.arrow_circle_135_left;
			this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
			this.rotateToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.rotateToolStripMenuItem.Text = "Rotate";
			// 
			// instancePropertiesToolStripMenuItem
			// 
			this.instancePropertiesToolStripMenuItem.Image = global::MapEditor.Properties.Resources.equalizer;
			this.instancePropertiesToolStripMenuItem.Name = "instancePropertiesToolStripMenuItem";
			this.instancePropertiesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.instancePropertiesToolStripMenuItem.Text = "Instance Properties...";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayGridToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// displayGridToolStripMenuItem
			// 
			this.displayGridToolStripMenuItem.Checked = true;
			this.displayGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.displayGridToolStripMenuItem.Image = global::MapEditor.Properties.Resources.grid;
			this.displayGridToolStripMenuItem.Name = "displayGridToolStripMenuItem";
			this.displayGridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.displayGridToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.displayGridToolStripMenuItem.Text = "Display Grid";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::MapEditor.Properties.Resources.skull_old;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 434);
			this.panel1.TabIndex = 7;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.project.gmx";
			this.openFileDialog1.Filter = "GM:S Projects|*.project.gmx";
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// MapEditorMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 482);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MapEditorMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Almora Map Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MapEditorMain_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapEditorMain_KeyDown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tsMap.ResumeLayout(false);
			this.tsMap.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabRooms.ResumeLayout(false);
			this.tabControlRooms.ResumeLayout(false);
			this.tpRoomList.ResumeLayout(false);
			this.subMenuForEditables.ResumeLayout(false);
			this.tpDefinitions.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panelPreviewTab.ResumeLayout(false);
			this.panelPreviewTab.PerformLayout();
			this.tpBrushes.ResumeLayout(false);
			this.tabPlaceables.ResumeLayout(false);
			this.tabControlEnv.ResumeLayout(false);
			this.tpInstances.ResumeLayout(false);
			this.tpRoomDataLayers.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tsOptions.ResumeLayout(false);
			this.tsOptions.PerformLayout();
			this.tsEditors.ResumeLayout(false);
			this.tsEditors.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tmOpenProject;
		private System.Windows.Forms.ToolStripMenuItem tmCreateProject;
		private System.Windows.Forms.ToolStripMenuItem tmSaveProject;
		private System.Windows.Forms.ToolStripMenuItem tmSaveProjectAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tmEdit;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip tsMap;
        private System.Windows.Forms.ToolStripButton tbSelectMap;
        private System.Windows.Forms.ToolStripButton tbMoveMap;
        private System.Windows.Forms.ToolStripButton tbRotateMap;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tbLayerRoomEdit;
        private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPlaceables;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviromentPlaceablesItemsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spawnPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbAdjustMap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem instancePropertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStrip tsOptions;
		private System.Windows.Forms.ToolStripButton tbAddItem;
		private System.Windows.Forms.ToolStripButton tbRemoveItem;
		private System.Windows.Forms.ToolStripButton tbEditItem;
		private System.Windows.Forms.ToolStripButton tbDuplicateItem;
		private System.Windows.Forms.ToolStripSplitButton tbSortItem;
		private System.Windows.Forms.ToolStripMenuItem defaultSortToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControlEnv;
        private System.Windows.Forms.TabPage tpInstances;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStrip tsEditors;
		private System.Windows.Forms.ToolStripButton tbRoomList;
		private System.Windows.Forms.ToolStripButton tbLayerList;
		private System.Windows.Forms.ToolStripButton tbEnvList;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton tbSaveProject;
		private System.Windows.Forms.ToolStripButton tbOpenProject;
		private System.Windows.Forms.ToolStripButton tbNewProject;
		private System.Windows.Forms.ToolStripButton tbUsedResList;
		private System.Windows.Forms.ToolStripMenuItem tmCloseProject;
		public ListBoxEx lbPlaceables;
		public System.Windows.Forms.ToolStripStatusLabel statusLabelPlaceables;
		private System.Windows.Forms.TabPage tabRooms;
		public ListBoxEx lbRooms;
		public System.Windows.Forms.ToolStripStatusLabel statusLabelMousePos;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ContextMenuStrip subMenuForEditables;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tbPaintMap;
		public ListBoxEx lbInstances;
		public System.Windows.Forms.ToolStripComboBox tbLayerDropDown;
		private System.Windows.Forms.TabPage tpRoomDataLayers;
		public ListBoxEx lbLayers;
		private System.Windows.Forms.TabControl tabControlRooms;
		private System.Windows.Forms.TabPage tpRoomList;
		private System.Windows.Forms.TabPage tpDefinitions;
		private System.Windows.Forms.ToolStripButton tbDeleteMap;
		public RoomEditor roomEditor1;
		public System.Windows.Forms.ToolStripDropDownButton tbEnabledLayersDropdown;
		private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tbGridEnabled;
		private System.Windows.Forms.ToolStripButton tbZoomOut;
		private System.Windows.Forms.ToolStripButton tbZoomReset;
		private System.Windows.Forms.ToolStripButton tbZoomIn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panelPreviewTab;
		private System.Windows.Forms.Label brushObjectLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox brushPlaceableRotation;
		public System.Windows.Forms.TextBox brushPlaceableScale;
		public System.Windows.Forms.TextBox brushPlaceableY;
		public System.Windows.Forms.TextBox brushPlaceableX;
		private System.Windows.Forms.Button brushPlaceable270dir;
		private System.Windows.Forms.Button brushPlaceable180dir;
		private System.Windows.Forms.Button brushPlaceable90dir;
		private System.Windows.Forms.Button brushPlaceable0dir;
		private System.Windows.Forms.Button brushPlaceableIncstanceProp;
		private System.Windows.Forms.CheckBox brushPlaceableRotationRandom;
		public System.Windows.Forms.ImageList imageListFolders;
		public System.Windows.Forms.ImageList imageListObjects;
		private System.Windows.Forms.TabPage tpBrushes;
		public System.Windows.Forms.ListView brushGroupList;
		public System.Windows.Forms.StatusStrip statusStrip1;
	}
}

