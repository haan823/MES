namespace MES_Project
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mESDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESDataSet = new MES_Project.MESDataSet();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.생산예정제품BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.생산_예정_제품TableAdapter = new MES_Project.MESDataSetTableAdapters.생산_예정_제품TableAdapter();
            this.불량품BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.불량품TableAdapter = new MES_Project.MESDataSetTableAdapters.불량품TableAdapter();
            this.생산불량BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.생산_불량TableAdapter = new MES_Project.MESDataSetTableAdapters.생산_불량TableAdapter();
            this.출하완료제품BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.출하_완료_제품TableAdapter = new MES_Project.MESDataSetTableAdapters.출하_완료_제품TableAdapter();
            this.제품IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.생산예정제품BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.불량품BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.생산불량BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.출하완료제품BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 70);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(205, 69);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "생산팀";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.제품IDDataGridViewTextBoxColumn,
            this.제품명DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.생산예정제품BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 403);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mESDataSetBindingSource
            // 
            this.mESDataSetBindingSource.DataSource = this.mESDataSet;
            this.mESDataSetBindingSource.Position = 0;
            // 
            // mESDataSet
            // 
            this.mESDataSet.DataSetName = "MESDataSet";
            this.mESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(336, 70);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(205, 69);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "품질팀";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(655, 70);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(205, 69);
            this.metroTile3.TabIndex = 6;
            this.metroTile3.Text = "출하팀";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile4
            // 
            this.metroTile4.BackColor = System.Drawing.Color.Red;
            this.metroTile4.Location = new System.Drawing.Point(976, 70);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(205, 69);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 7;
            this.metroTile4.Text = "불량품 목록";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // 생산예정제품BindingSource
            // 
            this.생산예정제품BindingSource.DataMember = "생산 예정 제품";
            this.생산예정제품BindingSource.DataSource = this.mESDataSetBindingSource;
            // 
            // 생산_예정_제품TableAdapter
            // 
            this.생산_예정_제품TableAdapter.ClearBeforeFill = true;
            // 
            // 불량품BindingSource
            // 
            this.불량품BindingSource.DataMember = "불량품";
            this.불량품BindingSource.DataSource = this.mESDataSetBindingSource;
            // 
            // 불량품TableAdapter
            // 
            this.불량품TableAdapter.ClearBeforeFill = true;
            // 
            // 생산불량BindingSource
            // 
            this.생산불량BindingSource.DataMember = "생산_불량";
            this.생산불량BindingSource.DataSource = this.mESDataSetBindingSource;
            // 
            // 생산_불량TableAdapter
            // 
            this.생산_불량TableAdapter.ClearBeforeFill = true;
            // 
            // 출하완료제품BindingSource
            // 
            this.출하완료제품BindingSource.DataMember = "출하 완료 제품";
            this.출하완료제품BindingSource.DataSource = this.mESDataSetBindingSource;
            // 
            // 출하_완료_제품TableAdapter
            // 
            this.출하_완료_제품TableAdapter.ClearBeforeFill = true;
            // 
            // 제품IDDataGridViewTextBoxColumn
            // 
            this.제품IDDataGridViewTextBoxColumn.DataPropertyName = "제품ID";
            this.제품IDDataGridViewTextBoxColumn.HeaderText = "제품ID";
            this.제품IDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.제품IDDataGridViewTextBoxColumn.Name = "제품IDDataGridViewTextBoxColumn";
            this.제품IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.제품IDDataGridViewTextBoxColumn.Width = 125;
            // 
            // 제품명DataGridViewTextBoxColumn
            // 
            this.제품명DataGridViewTextBoxColumn.DataPropertyName = "제품명";
            this.제품명DataGridViewTextBoxColumn.HeaderText = "제품명";
            this.제품명DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.제품명DataGridViewTextBoxColumn.Name = "제품명DataGridViewTextBoxColumn";
            this.제품명DataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 577);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroTile1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "MES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.생산예정제품BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.불량품BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.생산불량BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.출하완료제품BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.BindingSource mESDataSetBindingSource;
        private MESDataSet mESDataSet;
        private System.Windows.Forms.BindingSource 생산예정제품BindingSource;
        private MESDataSetTableAdapters.생산_예정_제품TableAdapter 생산_예정_제품TableAdapter;
        private System.Windows.Forms.BindingSource 불량품BindingSource;
        private MESDataSetTableAdapters.불량품TableAdapter 불량품TableAdapter;
        private System.Windows.Forms.BindingSource 생산불량BindingSource;
        private MESDataSetTableAdapters.생산_불량TableAdapter 생산_불량TableAdapter;
        private System.Windows.Forms.BindingSource 출하완료제품BindingSource;
        private MESDataSetTableAdapters.출하_완료_제품TableAdapter 출하_완료_제품TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명DataGridViewTextBoxColumn;
    }
}

