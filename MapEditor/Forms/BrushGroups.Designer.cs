namespace MapEditor.Forms
{
	partial class BrushGroups
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
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Objects");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Default",
            "0"}, -1);
			this.brushGroupsObjectTree = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.objectList = new System.Windows.Forms.ListView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupUp = new System.Windows.Forms.Button();
			this.groupEdit = new System.Windows.Forms.Button();
			this.groupRemove = new System.Windows.Forms.Button();
			this.groupAdd = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupDown = new System.Windows.Forms.Button();
			this.objectRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// brushGroupsObjectTree
			// 
			this.brushGroupsObjectTree.Location = new System.Drawing.Point(12, 25);
			this.brushGroupsObjectTree.Name = "brushGroupsObjectTree";
			treeNode5.Name = "Node0";
			treeNode5.Text = "Objects";
			this.brushGroupsObjectTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
			this.brushGroupsObjectTree.Size = new System.Drawing.Size(328, 526);
			this.brushGroupsObjectTree.TabIndex = 0;
			this.brushGroupsObjectTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.brushGroupsObjectTree_NodeMouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "GMX Project Objects:";
			// 
			// objectList
			// 
			this.objectList.Location = new System.Drawing.Point(346, 194);
			this.objectList.Name = "objectList";
			this.objectList.Size = new System.Drawing.Size(430, 293);
			this.objectList.TabIndex = 3;
			this.objectList.UseCompatibleStateImageBehavior = false;
			this.objectList.DoubleClick += new System.EventHandler(this.objectList_DoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(346, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Objects in group:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(346, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Groups:";
			// 
			// groupList
			// 
			this.groupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.groupList.FullRowSelect = true;
			this.groupList.GridLines = true;
			this.groupList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.groupList.HideSelection = false;
			this.groupList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
			this.groupList.Location = new System.Drawing.Point(346, 25);
			this.groupList.MultiSelect = false;
			this.groupList.Name = "groupList";
			this.groupList.ShowGroups = false;
			this.groupList.Size = new System.Drawing.Size(428, 134);
			this.groupList.TabIndex = 8;
			this.groupList.UseCompatibleStateImageBehavior = false;
			this.groupList.View = System.Windows.Forms.View.Details;
			this.groupList.DoubleClick += new System.EventHandler(this.groupList_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 275;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Total";
			this.columnHeader2.Width = 50;
			// 
			// groupUp
			// 
			this.groupUp.AutoSize = true;
			this.groupUp.Image = global::MapEditor.Properties.Resources.arrow_090;
			this.groupUp.Location = new System.Drawing.Point(531, 165);
			this.groupUp.Name = "groupUp";
			this.groupUp.Size = new System.Drawing.Size(51, 23);
			this.groupUp.TabIndex = 12;
			this.groupUp.Text = "Up";
			this.groupUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.groupUp.UseVisualStyleBackColor = true;
			// 
			// groupEdit
			// 
			this.groupEdit.AutoSize = true;
			this.groupEdit.Image = global::MapEditor.Properties.Resources.pencil_button;
			this.groupEdit.Location = new System.Drawing.Point(588, 165);
			this.groupEdit.Name = "groupEdit";
			this.groupEdit.Size = new System.Drawing.Size(51, 23);
			this.groupEdit.TabIndex = 11;
			this.groupEdit.Text = "Edit";
			this.groupEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.groupEdit.UseVisualStyleBackColor = true;
			// 
			// groupRemove
			// 
			this.groupRemove.AutoSize = true;
			this.groupRemove.Image = global::MapEditor.Properties.Resources.minus_button;
			this.groupRemove.Location = new System.Drawing.Point(645, 165);
			this.groupRemove.Name = "groupRemove";
			this.groupRemove.Size = new System.Drawing.Size(73, 23);
			this.groupRemove.TabIndex = 10;
			this.groupRemove.Text = "Remove";
			this.groupRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.groupRemove.UseVisualStyleBackColor = true;
			// 
			// groupAdd
			// 
			this.groupAdd.AutoSize = true;
			this.groupAdd.Image = global::MapEditor.Properties.Resources.plus_button;
			this.groupAdd.Location = new System.Drawing.Point(724, 165);
			this.groupAdd.Name = "groupAdd";
			this.groupAdd.Size = new System.Drawing.Size(52, 23);
			this.groupAdd.TabIndex = 9;
			this.groupAdd.Text = "Add";
			this.groupAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.groupAdd.UseVisualStyleBackColor = true;
			this.groupAdd.Click += new System.EventHandler(this.groupAdd_Click);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Image = global::MapEditor.Properties.Resources.cross;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point(609, 523);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 28);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Image = global::MapEditor.Properties.Resources.tick;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(701, 523);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 5;
			this.button1.Text = "OK";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupDown
			// 
			this.groupDown.AutoSize = true;
			this.groupDown.Image = global::MapEditor.Properties.Resources.arrow_270;
			this.groupDown.Location = new System.Drawing.Point(464, 165);
			this.groupDown.Name = "groupDown";
			this.groupDown.Size = new System.Drawing.Size(61, 23);
			this.groupDown.TabIndex = 13;
			this.groupDown.Text = "Down";
			this.groupDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.groupDown.UseVisualStyleBackColor = true;
			// 
			// objectRemove
			// 
			this.objectRemove.AutoSize = true;
			this.objectRemove.Image = global::MapEditor.Properties.Resources.minus_button;
			this.objectRemove.Location = new System.Drawing.Point(703, 493);
			this.objectRemove.Name = "objectRemove";
			this.objectRemove.Size = new System.Drawing.Size(73, 23);
			this.objectRemove.TabIndex = 14;
			this.objectRemove.Text = "Remove";
			this.objectRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.objectRemove.UseVisualStyleBackColor = true;
			// 
			// BrushGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 563);
			this.Controls.Add(this.objectRemove);
			this.Controls.Add(this.groupDown);
			this.Controls.Add(this.groupUp);
			this.Controls.Add(this.groupEdit);
			this.Controls.Add(this.groupRemove);
			this.Controls.Add(this.groupAdd);
			this.Controls.Add(this.groupList);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.objectList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.brushGroupsObjectTree);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "BrushGroups";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Brush Groups Properties";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView brushGroupsObjectTree;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView objectList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView groupList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button groupAdd;
		private System.Windows.Forms.Button groupRemove;
		private System.Windows.Forms.Button groupEdit;
		private System.Windows.Forms.Button groupUp;
		private System.Windows.Forms.Button groupDown;
		private System.Windows.Forms.Button objectRemove;

	}
}