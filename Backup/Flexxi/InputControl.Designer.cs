﻿namespace ImageFrame
{
    partial class InputControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TreeViewInput = new System.Windows.Forms.TreeView();
            this.InputMenu = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelSize = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.InputMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TreeViewInput);
            this.panel1.Controls.Add(this.InputMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 385);
            this.panel1.TabIndex = 0;
            // 
            // TreeViewInput
            // 
            this.TreeViewInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewInput.Location = new System.Drawing.Point(0, 43);
            this.TreeViewInput.Name = "TreeViewInput";
            this.TreeViewInput.Size = new System.Drawing.Size(141, 342);
            this.TreeViewInput.TabIndex = 2;
            this.TreeViewInput.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewInput_AfterSelect);
            // 
            // InputMenu
            // 
            this.InputMenu.BackColor = System.Drawing.SystemColors.Control;
            this.InputMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.InputMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.InputMenu.Location = new System.Drawing.Point(0, 0);
            this.InputMenu.Name = "InputMenu";
            this.InputMenu.Size = new System.Drawing.Size(141, 43);
            this.InputMenu.TabIndex = 0;
            this.InputMenu.Text = "Add";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordnerToolStripMenuItem,
            this.dateienToolStripMenuItem});
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // ordnerToolStripMenuItem
            // 
            this.ordnerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordnerToolStripMenuItem.Image")));
            this.ordnerToolStripMenuItem.Name = "ordnerToolStripMenuItem";
            this.ordnerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordnerToolStripMenuItem.Text = "Folder";
            this.ordnerToolStripMenuItem.Click += new System.EventHandler(this.ordnerToolStripMenuItem_Click);
            // 
            // dateienToolStripMenuItem
            // 
            this.dateienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dateienToolStripMenuItem.Image")));
            this.dateienToolStripMenuItem.Name = "dateienToolStripMenuItem";
            this.dateienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dateienToolStripMenuItem.Text = "Files";
            this.dateienToolStripMenuItem.Click += new System.EventHandler(this.dateienToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem1,
            this.allToolStripMenuItem1});
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.deleteToolStripMenuItem.Text = "Remove";
            // 
            // selectedToolStripMenuItem1
            // 
            this.selectedToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.selectedToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("selectedToolStripMenuItem1.Image")));
            this.selectedToolStripMenuItem1.Name = "selectedToolStripMenuItem1";
            this.selectedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.selectedToolStripMenuItem1.Text = "Selected";
            this.selectedToolStripMenuItem1.Click += new System.EventHandler(this.selectedToolStripMenuItem1_Click);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.allToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("allToolStripMenuItem1.Image")));
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.allToolStripMenuItem1.Text = "All";
            this.allToolStripMenuItem1.Click += new System.EventHandler(this.allToolStripMenuItem1_Click);
            // 
            // PanelSize
            // 
            this.PanelSize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelSize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.PanelSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSize.Location = new System.Drawing.Point(139, 0);
            this.PanelSize.Name = "PanelSize";
            this.PanelSize.Size = new System.Drawing.Size(2, 385);
            this.PanelSize.TabIndex = 1;
            this.PanelSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSize_MouseMove);
            this.PanelSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSize_MouseDown);
            this.PanelSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelSize_MouseUp);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelSize);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 10000);
            this.MinimumSize = new System.Drawing.Size(80, 0);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(141, 385);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InputMenu.ResumeLayout(false);
            this.InputMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip InputMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private System.Windows.Forms.TreeView TreeViewInput;
        private System.Windows.Forms.Panel PanelSize;


    }
}
