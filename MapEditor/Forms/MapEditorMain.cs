﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using MapEditor.Components;
using MapEditor.Forms;
using MapEditor.Common;
using MapEditor.Graphics;
using System.IO;
using System.Collections.ObjectModel;

namespace MapEditor
{
    public partial class MapEditorMain : Form
    {
        public MapEditorMain()
        {
            InitializeComponent();
            Manager.MainWindow = this;
            Manager.SetSpacing(this.brushGroupList, 48, 48);
            Manager.setup();
        }

        private void MapEditorMain_Load(object sender, EventArgs e)
        {
            ensureButtonsDisabled();

            _setRecentItems();

            foreach (string file in Manager.recentFiles)
            {
                if (File.Exists(file))
                {
                    _openSelectedProject(file);
                    break;
                }
            }
        }

        private void _setRecentItems()
        {
            int i = fileToolStripMenuItem.DropDownItems.IndexOf(tmRecent);
            for (int j = fileToolStripMenuItem.DropDownItems.Count - 1; j > i; j--)
            {
                fileToolStripMenuItem.DropDownItems.RemoveAt(j);
            }

            foreach (string path in Manager.recentFiles)
            {
                ToolStripItem itm = fileToolStripMenuItem.DropDownItems.Add(path);
                itm.Click += _loadRecentItem;
            }
        }

        private void _loadRecentItem(object sender, object e)
        {
            ToolStripItem t = sender as ToolStripItem;
            _openSelectedProject(t.Text);
        }

        public BrushMode CurrentBrush
        {
            get { return roomEditor1._rPanel.CurrentBrush; }
            set
            {
                if (Manager.Room != null)
                {
                    roomEditor1._rPanel.CurrentBrush = value;
                    tbSelectMap.Checked = (value == BrushMode.Select);
                    tbPaintMap.Checked = (value == BrushMode.Paint);
                    tbRotateMap.Checked = (value == BrushMode.Rotate);
                    tbMoveMap.Checked = (value == BrushMode.Move);
                    roomEditor1._rPanel.RefreshCursor();
                    roomEditor1._rPanel.Invalidate();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutWindow form = new AboutWindow())
            {
                form.ShowDialog();
            }
        }

        public void ensureButtonsDisabled()
        {
            if (Manager.Project == null)
            {
                tbSaveProject.Enabled = false;
                tsOptions.Enabled = tsEditors.Enabled = tsMap.Enabled = false;
                /*if (treeViewGMX.Nodes.Count > 0)
                {
                    treeViewGMX.Nodes.Clear();
                }*/
                tsMap.Enabled = false;
                tabControlMain.Visible = tabControlMain.Enabled = false;
            }
            else
            {
                tbSaveProject.Enabled = true;
                tsEditors.Enabled = true;
                tsOptions.Enabled = true;
                tsMap.Enabled = (Manager.Room != null);
                tabControlEnv.Enabled = (Manager.Room != null);
                tabControlMain.Visible = tabControlMain.Enabled = true;
            }

            _ensureMenusDisabled();
            ensureZoomButtons();
        }

        private void _ensureMenusDisabled()
        {
            tmCloseProject.Enabled = tmSaveProject.Enabled = tbSaveProject.Enabled;
            tmSaveProjectAs.Enabled = false;
            tmEdit.Enabled = (Manager.Project != null);
        }

        private void tbNewProject_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure to create new project?\nThis will save some additional *.ame files inside your project directory. This shouldn't affect your GM:S project, but remember - we take no responsibility for any damage caused!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            //    == DialogResult.Yes)
            //{
            // ok, create new project
            openFileDialog1.DefaultExt = ".project.gmx";
            openFileDialog1.Filter = "GM:S Project|*.project.gmx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Manager.newProject(openFileDialog1.FileName))
                {
                    //Manager.Project.renderItemsTree(treeViewGMX);
                    //treeViewGMX.Nodes[0].Expand();
                    ensureButtonsDisabled();
                }
            }
            //}
        }

        private void tbOpenProject_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".project.ame";
            openFileDialog1.Filter = "AME Project|*.project.ame";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _openSelectedProject(openFileDialog1.FileName);
            }
        }

        private void _openSelectedProject(string filename)
        {
            if (Manager.loadProject(filename))
            {
                if (Manager.Project != null)
                {
                    //Manager.Project.renderItemsTree(treeViewGMX);
                    //treeViewGMX.Nodes[0].Expand();
                }
                ensureButtonsDisabled();
                if (lbRooms.Items.Count > 0)
                {
                    lbRooms.SelectedIndex = 0;
                    lbRooms_DoubleClick(lbRooms, new EventArgs());
                }

                //GraphicsManager.LoadTexture(new Bitmap(Manager.Project.ProjectSource + "\\sprites\\images\\sprPlant2_0.png"), 0);
            }
        }

        private void tbUsedResList_Click(object sender, EventArgs e)
        {
            /*using (ResourceUsage form = new ResourceUsage())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Manager.Project.checkForRegisteredRes();
                    Manager.Project.renderItemsTree(treeViewGMX);
                    Manager.Project.regenerateTextureList();
                }
            }*/

            using (BrushGroups form = new BrushGroups())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void tbLayerList_Click(object sender, EventArgs e)
        {
            if (Manager.Room != null)
            {
                using (LayerForm form = new LayerForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Manager.Room.Layers.Add(new MapLayers() { LayerDepth = -Manager.Room.Layers.Count });
                    }
                }
            }
        }

        private void tbSaveProject_Click(object sender, EventArgs e)
        {
            Manager.Project.saveProjectToXML();
        }

        private void tmCloseProject_Click(object sender, EventArgs e)
        {
            Manager.dropProject();
            lbPlaceables.Items.Clear();
            lbRooms.Items.Clear();
            roomEditor1.Invalidate();
            ensureButtonsDisabled();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void addOrEditPlaceable(bool edit)
        {
            string defName = "Undefined Placeable " + lbPlaceables.Items.Count.ToString();

            if (edit)
            {
                if (lbPlaceables.Items.Count < 1 || lbPlaceables.SelectedIndex < 0) return;
            }

            using (PlaceableForm form = new PlaceableForm())
            {
                PlaceableElement elem;
                if (edit)
                {
                    elem = Manager.Project.PlaceableList[lbPlaceables.SelectedIndex];
                    form.Element = elem;
                    form.Text = "Edit Placeable Definition: " + elem.Name;
                }
                else
                {
                    elem = new PlaceableElement() { Name = defName };
                    form.Element = elem;
                    form.Text = "Create new Placeable Definition: " + defName;
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (edit)
                    {
                        //TODO: since elem is referenced, it shouldn't be changed that way
                        //elem = form.Element;
                    }
                    else
                    {
                        Manager.Project.PlaceableList.Add(form.Element);
                    }
                    Manager.Project.regenerateEnvDefList();
                }
            }

            statusLabelPlaceables.Text = Manager.Project.PlaceableList.Count.ToString();
        }*/

        private void addOrEditLayer(bool edit)
        {
            string defName = "Undefined Layer " + lbLayers.Items.Count.ToString();

            if (edit)
            {
                if (lbLayers.Items.Count < 1 || lbLayers.SelectedIndex < 0) return;
            }

            using (LayerForm form = new LayerForm())
            {
                MapLayers elem;
                if (edit)
                {
                    elem = Manager.Project.Room.Layers[lbLayers.SelectedIndex];
                    form.Element = elem;
                    form.Text = "Edit Layer Definition: " + elem.LayerName;
                }
                else
                {
                    int depth = 0;
                    if (lbLayers.Items.Count > 0)
                    {
                        depth = Manager.Project.Room.Layers[lbLayers.Items.Count - 1].LayerDepth + 1;
                    }
                    elem = new MapLayers() { LayerName = defName, LayerDepth = 1 };
                    form.Text = "Create new Layer Definition: " + defName;
                }

                form.Element = elem;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (edit)
                    {
                        //TODO: since elem is referenced, it shouldn't be changed that way
                        //elem = form.Element;
                    }
                    else
                    {
                        Manager.Project.Room.Layers.Add(form.Element);
                    }
                    Manager.Project.regenerateLayerList();
                }
            }
        }

        private void tbAddItem_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabRooms)
            {
                if (tabControlRooms.SelectedTab == tpRoomList)
                {
                    //addOrEditRoom(false);
                }
                else if (tabControlRooms.SelectedTab == tpDefinitions)
                {
                    //addOrEditPlaceable(false);
                }
            }
            else if (tabControlMain.SelectedTab == tabRooms)
            {
                /*if (tabControlEnv.SelectedIndex == 0)
                {
                    addOrEditPlaceable(false);
                }
                else */
                if (tabControlEnv.SelectedTab == tpRoomDataLayers)
                {
                    addOrEditLayer(false);
                }
            }
        }

        private void lbPlaceables_DoubleClick(object sender, EventArgs e)
        {
            tbEditItem_Click(sender, e);
        }

        private void lbPlaceables_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CurrentBrush == BrushMode.Paint && lbPlaceables.SelectedIndex > -1)
                {
                    if (Manager.Room != null)
                    {
                        Manager.Project.Instance = Manager.Project.GmsResourceObjectList[lbPlaceables.SelectedIndex];
                        CurrentBrush = BrushMode.Paint;
                        brushObjectLabel.Text = Manager.Project.Instance.name;
                        //brushObjectSprite.Image = GraphicsManager.Sprites[Manager.Project.Instance.textureId];
                    }
                }
            }
        }

        private void tbEditItem_Click(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                //case 1:
                //    switch (tabControlRooms.SelectedIndex)
                //    {
                //        //case 0: addOrEditRoom(true); break;
                //        //case 1: addOrEditPlaceable(true); break;
                //        case 1: Manager.Project.Instance = Manager.Project.GmsResourceObjectList[ lbPlaceables.SelectedIndex ]; break;
                //    }
                //    break;
                case 2:
                    switch (tabControlEnv.SelectedIndex)
                    {
                        case 1: addOrEditLayer(true); break;
                    }
                    break;
            }
        }

        private void lbRooms_DoubleClick(object sender, EventArgs e)
        {
            int select = lbRooms.SelectedIndex;

            if (select > -1)
            {
                if (Manager.Room != null)
                {
                    if (Manager.Project.GmsResourceRoomList[select] == Manager.Project.Room) return;
                    if (MessageBox.Show("Do you want to close current room?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                Manager.Project.Room = Manager.Project.GmsResourceRoomList[select];
                //if (Manager.Project.Room.LastUsedLayer > -1 && Manager.Project.Room.LastUsedLayer < tbLayerDropDown.Items.Count)
                //{
                Manager.Project.Room.LastUsedLayer = Math.Max(0, Math.Min(Manager.Project.Room.LastUsedLayer, tbLayerDropDown.Items.Count - 1));
                tbLayerDropDown.SelectedIndex = Manager.Project.Room.LastUsedLayer;

                //}

                if (Manager.Project.GmsResourceObjectList.Count > 0)
                {
                    Manager.Project.Instance = Manager.Project.GmsResourceObjectList[0];
                }
                roomEditor1.Invalidate();
                roomEditor1._rPanel.Invalidate();
                ensureButtonsDisabled();
                CurrentBrush = BrushMode.Select;
                Manager.Project.regenerateInstanceList();

                _afterRoomChange();
            }
        }

        private void _afterRoomChange()
        {
            roomInfoLabelName.Text = Manager.Project.Room.name;
            roomInfoLabelWidth.Text = Manager.Project.Room.width.ToString() + "px";
            roomInfoLabelHeight.Text = Manager.Project.Room.height.ToString() + "px";
            roomInfoLabelInstancesNumber.Text = Manager.Project.Room.instances.Count.ToString();

            Manager.Project.Room.reorderInstances();

            int total = Manager.Project.GmsResourceRoomList.Sum(r => r.instances.Count);

            int totalObjects = Manager.Project.GmsResourceObjectList.Count;

            roomInfoLabelOthers.Text =
                "Total rooms: " + Manager.Project.GmsResourceRoomList.Count.ToString() + Environment.NewLine +
                "Total instnaces in rooms: " + total.ToString() + Environment.NewLine +
                "Total objects: " + totalObjects.ToString();


            Manager.Project.RoomLayers = new ObservableCollection<MapLayers>();

            {
                MapLayers layer = new MapLayers() { LayerName = "_DEFAULT", LayerDepth = 0 };
                Manager.Project.RoomLayers.Add(layer);
            }

            foreach (GmsRoomInstance inst in Manager.Project.Room.instances)
            {
                if (Manager.Project.RoomLayers.Where(n => n.LayerName == inst.instance_of.name).Count() == 0)
                {
                    MapLayers layer = new MapLayers() { LayerName = inst.instance_of.name, LayerDepth = inst.instance_of.depth };
                    Manager.Project.RoomLayers.Add(layer);
                }
            }

            foreach (GmsObject obj in Manager.Project.GmsResourceObjectList)
            {
                string _name = "DEPTH " + obj.depth.ToString();
                if (Manager.Project.RoomLayers.Where(n => n.LayerName == _name).Count() == 0)
                {
                    MapLayers layer = new MapLayers() { LayerName = _name, LayerDepth = obj.depth };
                    Manager.Project.RoomLayers.Add(layer);
                }
            }

            Manager.Project.regenerateLayerList();
        }

        private void tbSelectMap_Click(object sender, EventArgs e)
        {
            CurrentBrush = BrushMode.Select;
        }

        private void tbPaintMap_Click(object sender, EventArgs e)
        {
            CurrentBrush = BrushMode.Paint;
        }

        private void tbMoveMap_Click(object sender, EventArgs e)
        {
            CurrentBrush = BrushMode.Move;
        }

        private void tbRotateMap_Click(object sender, EventArgs e)
        {
            CurrentBrush = BrushMode.Rotate;
        }

        private void tbLayerDropDown_DropDownClosed(object sender, EventArgs e)
        {
            if (Manager.Room != null)
            {
                Manager.Room.LastUsedLayer = tbLayerDropDown.SelectedIndex;
                ensureCurrentLayerEnabled();
            }
        }

        public void tbEnabledLayersDropdown_SubItemClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;

                if (item != null)
                {
                    int index = (item.OwnerItem as ToolStripDropDownButton).DropDownItems.IndexOf(item);
                    if (index > -1)
                    {
                        Manager.Project.Room.Layers[index].Active = item.Checked;
                    }

                    ensureCurrentLayerEnabled();
                }

            }
        }

        private void ensureCurrentLayerEnabled()
        {
            //TODO: indeterminate ?
            //ToolStripMenuItem item;
            //Manager.Project.Room.Layers[tbLayerDropDown.SelectedIndex].Active = true;
            //item = (ToolStripMenuItem)tbEnabledLayersDropdown.DropDownItems[tbLayerDropDown.SelectedIndex];
            //item.Checked = true;
        }

        private void MapEditorMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    CurrentBrush = BrushMode.Select;
                    break;
                case Keys.W:
                    CurrentBrush = BrushMode.Paint;
                    break;
                case Keys.E:
                    CurrentBrush = BrushMode.Move;
                    break;
                case Keys.R:
                    CurrentBrush = BrushMode.Rotate;
                    break;
                case Keys.D:
                    CurrentBrush = BrushMode.Delete;
                    break;
                case Keys.Escape:
                    Manager.Project.SelectedInstance = null;
                    break;
            }
        }

        private void tbDeleteMap_Click(object sender, EventArgs e)
        {
            if (Manager.Project.SelectedInstance != null)
            {
                Manager.Project.Room.instances.Remove(Manager.Project.SelectedInstance);
                Manager.Project.SelectedInstance = null;
            }
        }

        private void tbLayerRoomEdit_Click(object sender, EventArgs e)
        {
            lbLayers.SelectedIndex = tbLayerDropDown.SelectedIndex;
            addOrEditLayer(true);
        }

        private void tbZoomOut_Click(object sender, EventArgs e)
        {
            roomEditor1._rPanel.Zoom = +1;
            ensureZoomButtons();
        }

        private void tbZoomReset_Click(object sender, EventArgs e)
        {
            roomEditor1._rPanel.Zoom = 0;
            ensureZoomButtons();
        }

        private void tbZoomIn_Click(object sender, EventArgs e)
        {
            roomEditor1._rPanel.Zoom = -1;
            ensureZoomButtons();
        }

        public void ensureZoomButtons()
        {
            tbZoomIn.Enabled = roomEditor1._rPanel.Zoom > 1;
            tbZoomOut.Enabled = roomEditor1._rPanel.Zoom < 4;
            tbZoomReset.Enabled = roomEditor1._rPanel.Zoom != 1;
            roomEditor1.Invalidate();
        }

        private void tbGridEnabled_Click(object sender, EventArgs e)
        {
            roomEditor1._rPanel.GridEnabled = tbGridEnabled.Checked;
        }

        public void brushPlaceableUpdatePositionAndRotation()
        {
            if (Manager.Project.SelectedInstance != null)
            {
                panelPreviewTab.Enabled = true;
                Manager.MainWindow.brushPlaceableX.Text = Manager.Project.SelectedInstance.x.ToString();
                Manager.MainWindow.brushPlaceableY.Text = Manager.Project.SelectedInstance.y.ToString();
                Manager.MainWindow.brushPlaceableRotation.Text = Manager.Project.SelectedInstance.rotation.ToString();
            }
            else
            {
                panelPreviewTab.Enabled = false;
            }
        }

        #region Rotation text
        private void brushPlaceable0dir_Click(object sender, EventArgs e)
        {
            brushPlaceableRotation.Text = "0";
        }

        private void brushPlaceable90dir_Click(object sender, EventArgs e)
        {
            brushPlaceableRotation.Text = "90";
        }

        private void brushPlaceable180dir_Click(object sender, EventArgs e)
        {
            brushPlaceableRotation.Text = "180";
        }

        private void brushPlaceable270dir_Click(object sender, EventArgs e)
        {
            brushPlaceableRotation.Text = "270";
        }
        #endregion

        private void tbShowRoomBackground_Click(object sender, EventArgs e)
        {
            roomEditor1._rPanel.BackgroundDraw = ((ToolStripMenuItem)sender).Checked;
        }

    }
}
