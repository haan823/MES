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
using MetroFramework.Controls;

namespace MES_Project
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int crn; // 선택된 행 번호

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            groupBox1.Show();
            groupBox2.Hide();
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

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.출하_완료_제품TableAdapter.Fill(this.mESDataSet.출하_완료_제품);
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            this.생산_불량TableAdapter.Fill(this.mESDataSet.생산_불량);
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView3.Hide();
            dataGridView4.Hide();
            groupBox1.Hide();
            groupBox2.Show();
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            this.불량품TableAdapter.Fill(this.mESDataSet.불량품);
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Show();
            dataGridView4.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            this.생산_예정_제품TableAdapter.Fill(this.mESDataSet.생산_예정_제품);
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Show();
            groupBox1.Hide();
            groupBox2.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crn = e.RowIndex;
            metroTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            metroTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[2].Value) == true)
            {
                MessageBox.Show("이미 판정된 제품입니다.");
                groupBox2.Hide();
            }
            else
            {
                crn = e.RowIndex;
                groupBox2.Show();
                metroTextBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                metroTextBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = (int)dataGridView1.Rows[crn].Cells[0].Value;
                string pname = dataGridView1.Rows[crn].Cells[1].Value.ToString();
                this.생산_예정_제품TableAdapter.Delete(pid, pname);
                dataGridView1.Rows.RemoveAt(crn);
                this.생산_불량TableAdapter.Insert(pid, pname, false);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                MessageBox.Show("품질 검사 요청 처리되었습니다.");
            }
            catch {
                MessageBox.Show("품질 검사 요청 실패하였습니다.");
            }
         
        }

       
    }
}
