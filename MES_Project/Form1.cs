using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_Project
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mESDataSet.출하_완료_제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.출하_완료_제품TableAdapter.Fill(this.mESDataSet.출하_완료_제품);
            // TODO: 이 코드는 데이터를 'mESDataSet.생산_불량' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.생산_불량TableAdapter.Fill(this.mESDataSet.생산_불량);
            // TODO: 이 코드는 데이터를 'mESDataSet.불량품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.불량품TableAdapter.Fill(this.mESDataSet.불량품);
            // TODO: 이 코드는 데이터를 'mESDataSet.생산_예정_제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.생산_예정_제품TableAdapter.Fill(this.mESDataSet.생산_예정_제품);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("metroTiel1 is Clicked");
            this.생산_예정_제품TableAdapter.Fill(this.mESDataSet.생산_예정_제품);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.생산_불량TableAdapter.Fill(this.mESDataSet.생산_불량);
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.출하_완료_제품TableAdapter.Fill(this.mESDataSet.출하_완료_제품);
        }
        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.불량품TableAdapter.Fill(this.mESDataSet.불량품);
        }
    }
}
