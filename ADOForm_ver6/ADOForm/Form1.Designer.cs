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
            this.searchB1 = new System.Windows.Forms.Button();
            this.searchB2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchB1
            // 
            this.searchB1.Location = new System.Drawing.Point(155, 293);
            this.searchB1.Name = "searchB1";
            this.searchB1.Size = new System.Drawing.Size(120, 64);
            this.searchB1.TabIndex = 0;
            this.searchB1.Text = "연결찾기";
            this.searchB1.UseVisualStyleBackColor = true;
            this.searchB1.Click += new System.EventHandler(this.searchB1_Click);
            // 
            // searchB2
            // 
            this.searchB2.Location = new System.Drawing.Point(572, 306);
            this.searchB2.Name = "searchB2";
            this.searchB2.Size = new System.Drawing.Size(107, 63);
            this.searchB2.TabIndex = 1;
            this.searchB2.Text = "비연결 찾기";
            this.searchB2.UseVisualStyleBackColor = true;
            this.searchB2.Click += new System.EventHandler(this.searchB2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(53, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 199);
            this.listBox1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 25);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(398, 88);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(442, 188);
            this.DBGrid.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 393);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchB2);
            this.Controls.Add(this.searchB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchB1;
        private System.Windows.Forms.Button searchB2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DBGrid;
    }
}