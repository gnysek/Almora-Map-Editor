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
            this.tbMoveMap = new System.Windows.Forms.ToolStripButton();
            this.tbRotateMap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAdjustMap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.treeViewGMX = new System.Windows.Forms.TreeView();
            this.imageListFolders = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage66 = new System.Windows.Forms.TabPage();
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
            this.tbEventsList = new System.Windows.Forms.ToolStripButton();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tbSaveProject = new System.Windows.Forms.ToolStripButton();
            this.tbOpenProject = new System.Windows.Forms.ToolStripButton();
            this.tbNewProject = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tmOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCreateProject = new System.Windows.Forms.ToolStripMenuItem();
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
            this.roomEditor1 = new MapEditor.Components.RoomEditor();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsMap.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tsMap
            // 
            this.tsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSelectMap,
            this.tbMoveMap,
            this.tbRotateMap,
            this.toolStripSeparator4,
            this.tbAdjustMap,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripButton7,
            this.toolStripDropDownButton1,
            this.toolStripSeparator3});
            this.tsMap.Location = new System.Drawing.Point(467, 0);
            this.tsMap.Name = "tsMap";
            this.tsMap.Size = new System.Drawing.Size(467, 25);
            this.tsMap.TabIndex = 5;
            this.tsMap.Text = "toolStrip3";
            // 
            // tbSelectMap
            // 
            this.tbSelectMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSelectMap.Image = global::MapEditor.Properties.Resources.cursor;
            this.tbSelectMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSelectMap.Name = "tbSelectMap";
            this.tbSelectMap.Size = new System.Drawing.Size(23, 22);
            this.tbSelectMap.Text = "Select";
            // 
            // tbMoveMap
            // 
            this.tbMoveMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMoveMap.Image = global::MapEditor.Properties.Resources.arrow_move;
            this.tbMoveMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMoveMap.Name = "tbMoveMap";
            this.tbMoveMap.Size = new System.Drawing.Size(23, 22);
            this.tbMoveMap.Text = "Move";
            // 
            // tbRotateMap
            // 
            this.tbRotateMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRotateMap.Image = global::MapEditor.Properties.Resources.arrow_circle_135_left;
            this.tbRotateMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRotateMap.Name = "tbRotateMap";
            this.tbRotateMap.Size = new System.Drawing.Size(23, 22);
            this.tbRotateMap.Text = "Rotate";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbAdjustMap
            // 
            this.tbAdjustMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAdjustMap.Image = global::MapEditor.Properties.Resources.equalizer;
            this.tbAdjustMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdjustMap.Name = "tbAdjustMap";
            this.tbAdjustMap.Size = new System.Drawing.Size(23, 22);
            this.tbAdjustMap.Text = "Properties";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Layer";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::MapEditor.Properties.Resources.layer__pencil;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = global::MapEditor.Properties.Resources.layers_stack_arrange;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage0);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(3, 28);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(461, 403);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.treeViewGMX);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(453, 377);
            this.tabPage0.TabIndex = 4;
            this.tabPage0.Text = "ProjectData";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // treeViewGMX
            // 
            this.treeViewGMX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGMX.ImageIndex = 0;
            this.treeViewGMX.ImageList = this.imageListFolders;
            this.treeViewGMX.Location = new System.Drawing.Point(3, 3);
            this.treeViewGMX.Name = "treeViewGMX";
            this.treeViewGMX.PathSeparator = "/";
            this.treeViewGMX.SelectedImageIndex = 0;
            this.treeViewGMX.Size = new System.Drawing.Size(447, 371);
            this.treeViewGMX.StateImageList = this.imageListFolders;
            this.treeViewGMX.TabIndex = 0;
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(453, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enviroment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(453, 377);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 351);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Definitions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(445, 351);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Instances";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(453, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NPCs / Events / Spawns";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage66);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(445, 351);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Definitions";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage66
            // 
            this.tabPage66.Location = new System.Drawing.Point(4, 22);
            this.tabPage66.Name = "tabPage66";
            this.tabPage66.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage66.Size = new System.Drawing.Size(445, 351);
            this.tabPage66.TabIndex = 1;
            this.tabPage66.Text = "Instances";
            this.tabPage66.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(467, 25);
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
            this.tsOptions.Location = new System.Drawing.Point(186, 0);
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
            this.tbAddItem.Text = "Add";
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
            // 
            // tbDuplicateItem
            // 
            this.tbDuplicateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.tbEnvList,
            this.tbEventsList});
            this.tsEditors.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsEditors.Location = new System.Drawing.Point(70, 0);
            this.tsEditors.Name = "tsEditors";
            this.tsEditors.Size = new System.Drawing.Size(116, 25);
            this.tsEditors.TabIndex = 2;
            this.tsEditors.Text = "toolStrip1";
            // 
            // tbUsedResList
            // 
            this.tbUsedResList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUsedResList.Image = global::MapEditor.Properties.Resources.chain;
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
            // 
            // tbEnvList
            // 
            this.tbEnvList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEnvList.Image = global::MapEditor.Properties.Resources.tree;
            this.tbEnvList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEnvList.Name = "tbEnvList";
            this.tbEnvList.Size = new System.Drawing.Size(23, 20);
            this.tbEnvList.Text = "toolStripButton10";
            // 
            // tbEventsList
            // 
            this.tbEventsList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEventsList.Image = global::MapEditor.Properties.Resources.animal_penguin;
            this.tbEventsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEventsList.Name = "tbEventsList";
            this.tbEventsList.Size = new System.Drawing.Size(23, 20);
            this.tbEventsList.Text = "toolStripButton11";
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
            // 
            // tbOpenProject
            // 
            this.tbOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpenProject.Image = global::MapEditor.Properties.Resources.folder_horizontal_open;
            this.tbOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenProject.Name = "tbOpenProject";
            this.tbOpenProject.Size = new System.Drawing.Size(23, 20);
            this.tbOpenProject.Text = "Open";
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
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
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
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(17, 19);
            this.toolStripStatusLabel4.Text = "0";
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
            // 
            // tmOpenProject
            // 
            this.tmOpenProject.Image = global::MapEditor.Properties.Resources.folder_horizontal_open;
            this.tmOpenProject.Name = "tmOpenProject";
            this.tmOpenProject.ShortcutKeyDisplayString = "";
            this.tmOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tmOpenProject.Size = new System.Drawing.Size(262, 22);
            this.tmOpenProject.Text = "&Open Existing ProjectData...";
            // 
            // tmCreateProject
            // 
            this.tmCreateProject.Image = global::MapEditor.Properties.Resources.box;
            this.tmCreateProject.Name = "tmCreateProject";
            this.tmCreateProject.ShortcutKeyDisplayString = "";
            this.tmCreateProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tmCreateProject.Size = new System.Drawing.Size(262, 22);
            this.tmCreateProject.Text = "&Create New ProjectData...";
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
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "GM:S Projects|*.project.gmx";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // roomEditor1
            // 
            this.roomEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomEditor1.Location = new System.Drawing.Point(470, 28);
            this.roomEditor1.Name = "roomEditor1";
            this.roomEditor1.Size = new System.Drawing.Size(461, 403);
            this.roomEditor1.TabIndex = 6;
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MapEditorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Almora Map Editor";
            this.Load += new System.EventHandler(this.MapEditorMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsMap.ResumeLayout(false);
            this.tsMap.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
		private System.Windows.Forms.StatusStrip statusStrip1;
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage66;
        private RoomEditor roomEditor1;
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
		private System.Windows.Forms.TabPage tabPage0;
		private System.Windows.Forms.TreeView treeViewGMX;
		private System.Windows.Forms.ImageList imageListFolders;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStrip tsEditors;
		private System.Windows.Forms.ToolStripButton tbRoomList;
		private System.Windows.Forms.ToolStripButton tbLayerList;
		private System.Windows.Forms.ToolStripButton tbEnvList;
		private System.Windows.Forms.ToolStripButton tbEventsList;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton tbSaveProject;
		private System.Windows.Forms.ToolStripButton tbOpenProject;
		private System.Windows.Forms.ToolStripButton tbNewProject;
		private System.Windows.Forms.ToolStripButton tbUsedResList;
	}
}

