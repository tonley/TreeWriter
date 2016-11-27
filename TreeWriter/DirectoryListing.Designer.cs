﻿namespace TreeWriterWF
{
    partial class DirectoryListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryListing));
            this.DirectoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newManuscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicateViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectoryContextMenu.SuspendLayout();
            this.FileContextMenu.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirectoryContextMenu
            // 
            this.DirectoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.newFolderToolStripMenuItem,
            this.newManuscriptToolStripMenuItem,
            this.deleteFolderToolStripMenuItem,
            this.wordCountToolStripMenuItem1});
            this.DirectoryContextMenu.Name = "DirectoryContextMenu";
            this.DirectoryContextMenu.Size = new System.Drawing.Size(162, 114);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // newManuscriptToolStripMenuItem
            // 
            this.newManuscriptToolStripMenuItem.Name = "newManuscriptToolStripMenuItem";
            this.newManuscriptToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newManuscriptToolStripMenuItem.Text = "New Manuscript";
            this.newManuscriptToolStripMenuItem.Click += new System.EventHandler(this.newManuscriptToolStripMenuItem_Click);
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteFolderToolStripMenuItem.Text = "Delete Folder";
            this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.deleteFolderToolStripMenuItem_Click);
            // 
            // wordCountToolStripMenuItem1
            // 
            this.wordCountToolStripMenuItem1.Name = "wordCountToolStripMenuItem1";
            this.wordCountToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.wordCountToolStripMenuItem1.Text = "Word Count";
            this.wordCountToolStripMenuItem1.Click += new System.EventHandler(this.wordCountToolStripMenuItem1_Click);
            // 
            // FileContextMenu
            // 
            this.FileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.wordCountToolStripMenuItem,
            this.openAsTextToolStripMenuItem});
            this.FileContextMenu.Name = "FileContextMenu";
            this.FileContextMenu.Size = new System.Drawing.Size(145, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteToolStripMenuItem.Text = "Delete File";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // wordCountToolStripMenuItem
            // 
            this.wordCountToolStripMenuItem.Name = "wordCountToolStripMenuItem";
            this.wordCountToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.wordCountToolStripMenuItem.Text = "Word Count";
            this.wordCountToolStripMenuItem.Click += new System.EventHandler(this.wordCountToolStripMenuItem_Click);
            // 
            // openAsTextToolStripMenuItem
            // 
            this.openAsTextToolStripMenuItem.Name = "openAsTextToolStripMenuItem";
            this.openAsTextToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openAsTextToolStripMenuItem.Text = "Open As Text";
            this.openAsTextToolStripMenuItem.Click += new System.EventHandler(this.openAsTextToolStripMenuItem_Click);
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "trans.png");
            this.iconImageList.Images.SetKeyName(1, "folder_closed.png");
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.FullRowSelect = true;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.iconImageList;
            this.treeView.ItemHeight = 16;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(284, 262);
            this.treeView.TabIndex = 0;
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_AfterLabelEdit);
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateViewToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // duplicateViewToolStripMenuItem
            // 
            this.duplicateViewToolStripMenuItem.Name = "duplicateViewToolStripMenuItem";
            this.duplicateViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duplicateViewToolStripMenuItem.Text = "Duplicate View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // DirectoryListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.treeView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DirectoryListing";
            this.Text = "DirectoryListing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectoryListing_FormClosing);
            this.DirectoryContextMenu.ResumeLayout(false);
            this.FileContextMenu.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip DirectoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.ToolStripMenuItem wordCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordCountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newManuscriptToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem duplicateViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAsTextToolStripMenuItem;
    }
}