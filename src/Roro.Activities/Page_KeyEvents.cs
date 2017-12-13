﻿using Roro.Activities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Roro.Workflow
{
    public partial class Page
    {
        private void KeyEvents(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteNode();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                this.SelectAllNodes();
            }
        }

        private void DeleteNode()
        {
            foreach (var selectedNode in this.SelectedNodes)
            {
                this.Nodes.Remove(selectedNode);
            }
            this.SelectedNodes.Clear();
            this.canvas.Invalidate();
        }

        private void SelectAllNodes()
        {
            this.SelectedNodes.Clear();
            foreach (var node in this.Nodes)
            {
                this.SelectedNodes.Add(node);
            }
            this.canvas.Invalidate();
        }
    }
}