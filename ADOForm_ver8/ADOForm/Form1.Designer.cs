namespace ADOForm
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
            this.components = new System.ComponentModel.Container();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.선택한행업데이트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.DBGrid.Location = new System.Drawing.Point(115, 108);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(541, 250);
            this.DBGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선택한행업데이트ToolStripMenuItem,
            this.새ToolStripMenuItem,
            this.로ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // 선택한행업데이트ToolStripMenuItem
            // 
            this.선택한행업데이트ToolStripMenuItem.Name = "선택한행업데이트ToolStripMenuItem";
            this.선택한행업데이트ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.선택한행업데이트ToolStripMenuItem.Text = "선택한 행 업데이트";
            this.선택한행업데이트ToolStripMenuItem.Click += new System.EventHandler(this.선택한행업데이트ToolStripMenuItem_Click);
            // 
            // 새ToolStripMenuItem
            // 
            this.새ToolStripMenuItem.Name = "새ToolStripMenuItem";
            this.새ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.새ToolStripMenuItem.Text = "새로운 데이터 추가";

            // 
            // 로ToolStripMenuItem
            // 
            this.로ToolStripMenuItem.Name = "로ToolStripMenuItem";
            this.로ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.로ToolStripMenuItem.Text = "선택한 행 삭제";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 선택한행업데이트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로ToolStripMenuItem;
    }
}