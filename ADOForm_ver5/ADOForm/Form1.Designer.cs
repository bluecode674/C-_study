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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.DRBtn = new System.Windows.Forms.Button();
            this.DAOpenBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(76, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(622, 61);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(365, 197);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // DRBtn
            // 
            this.DRBtn.Location = new System.Drawing.Point(185, 307);
            this.DRBtn.Name = "DRBtn";
            this.DRBtn.Size = new System.Drawing.Size(185, 61);
            this.DRBtn.TabIndex = 2;
            this.DRBtn.Text = "DRBtn";
            this.DRBtn.UseVisualStyleBackColor = true;
            this.DRBtn.Click += new System.EventHandler(this.DRBtn_Click);
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(714, 307);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(185, 61);
            this.DAOpenBtn.TabIndex = 3;
            this.DAOpenBtn.Text = "DAOpenBtn";
            this.DAOpenBtn.UseVisualStyleBackColor = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "P.ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "R.ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "과목이름";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "과목번호";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "P.ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "이름";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "R.ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "과목이름";
            this.columnHeader9.Width = 85;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "과목번호";
            this.columnHeader10.Width = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.DRBtn);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button DRBtn;
        private System.Windows.Forms.Button DAOpenBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}