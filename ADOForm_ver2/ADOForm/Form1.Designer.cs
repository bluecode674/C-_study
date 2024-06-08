namespace ADOForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.DAOpenBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.UpBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.NameList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(19, 196);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(643, 236);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(159, 440);
            this.DAOpenBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(122, 38);
            this.DAOpenBtn.TabIndex = 4;
            this.DAOpenBtn.Text = "DAOpenBtn";
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(535, 88);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 38);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(406, 88);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(122, 38);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(277, 88);
            this.AppendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(122, 38);
            this.AppendBtn.TabIndex = 19;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(98, 146);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(157, 25);
            this.txtMail.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(98, 106);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 25);
            this.txtPhone.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 25);
            this.txtName.TabIndex = 16;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mailLabel.Location = new System.Drawing.Point(18, 146);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(60, 19);
            this.mailLabel.TabIndex = 15;
            this.mailLabel.Text = "E-Mail";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneLabel.Location = new System.Drawing.Point(18, 106);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(85, 19);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "전화번호";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(18, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 19);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(98, 22);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(157, 25);
            this.txtid.TabIndex = 23;
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(781, 360);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(87, 33);
            this.UpBtn.TabIndex = 25;
            this.UpBtn.Text = "위로";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(903, 360);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(98, 33);
            this.DownBtn.TabIndex = 26;
            this.DownBtn.Text = "아래로";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(925, 88);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(106, 41);
            this.SearchBtn.TabIndex = 27;
            this.SearchBtn.Text = "찾기";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(761, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 25);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 15;
            this.NameList.Location = new System.Drawing.Point(781, 158);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(198, 184);
            this.NameList.TabIndex = 29;
            this.NameList.SelectedIndexChanged += new System.EventHandler(this.NameList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 492);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.DBGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button DAOpenBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AppendBtn;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox NameList;
    }
}

