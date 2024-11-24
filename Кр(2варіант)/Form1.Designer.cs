using System;
using System.Windows.Forms;

namespace Кр_2варіант_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddRoute = new System.Windows.Forms.ToolStripButton();
            this.btnEditRoute = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteRoute = new System.Windows.Forms.ToolStripButton();
            this.btnSearchRoute = new System.Windows.Forms.ToolStripButton();
            this.btnSellTicket = new System.Windows.Forms.ToolStripButton();
            this.btnReturnTicket = new System.Windows.Forms.ToolStripButton();
            this.btnSaveToFile = new System.Windows.Forms.ToolStripButton();
            this.btnLoadFromFile = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRoute,
            this.btnEditRoute,
            this.btnDeleteRoute,
            this.btnSearchRoute,
            this.btnSellTicket,
            this.btnReturnTicket,
            this.btnSaveToFile,
            this.btnLoadFromFile,
            this.toolStripSeparator1,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1005, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Додати рейс";
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoute.Image")));
            this.btnAddRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(23, 22);
            this.btnAddRoute.Text = "Додати рейс";
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoute.Image")));
            this.btnEditRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(23, 22);
            this.btnEditRoute.Text = "Редагувати рейс";
            this.btnEditRoute.Click += new System.EventHandler(this.btnEditRoute_Click);
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoute.Image")));
            this.btnDeleteRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteRoute.Text = "Видалити рейс";
            this.btnDeleteRoute.Click += new System.EventHandler(this.btnDeleteRoute_Click);
            // 
            // btnSearchRoute
            // 
            this.btnSearchRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRoute.Image")));
            this.btnSearchRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchRoute.Name = "btnSearchRoute";
            this.btnSearchRoute.Size = new System.Drawing.Size(23, 22);
            this.btnSearchRoute.Text = "Пошук рейсу";
            this.btnSearchRoute.Click += new System.EventHandler(this.btnSearchRoute_Click);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSellTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnSellTicket.Image")));
            this.btnSellTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(23, 22);
            this.btnSellTicket.Text = "Продаж квитків";
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // btnReturnTicket
            // 
            this.btnReturnTicket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturnTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnTicket.Image")));
            this.btnReturnTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturnTicket.Name = "btnReturnTicket";
            this.btnReturnTicket.Size = new System.Drawing.Size(23, 22);
            this.btnReturnTicket.Text = "Повернення квитків";
            this.btnReturnTicket.Click += new System.EventHandler(this.btnReturnTicket_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveToFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToFile.Image")));
            this.btnSaveToFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(23, 22);
            this.btnSaveToFile.Text = "Зберегти до файлу";
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadFromFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFromFile.Image")));
            this.btnLoadFromFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(23, 22);
            this.btnLoadFromFile.Text = "Завантажити з файлу";
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "Вихід";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Location = new System.Drawing.Point(0, 28);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.Size = new System.Drawing.Size(1005, 561);
            this.dgvRoutes.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 585);
            this.Controls.Add(this.dgvRoutes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddRoute;
        private System.Windows.Forms.ToolStripButton btnEditRoute;
        private System.Windows.Forms.ToolStripButton btnDeleteRoute;
        private System.Windows.Forms.ToolStripButton btnSearchRoute;
        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.ToolStripButton btnSellTicket;
        private System.Windows.Forms.ToolStripButton btnReturnTicket;
        private System.Windows.Forms.ToolStripButton btnSaveToFile;
        private System.Windows.Forms.ToolStripButton btnLoadFromFile;
        private System.Windows.Forms.ToolStripButton btnExit;
        private ToolStripSeparator toolStripSeparator1;
    }
}

