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
            // TODO: 이 코드는 데이터를 'mES2DataSet.생산완료제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.생산완료제품TableAdapter.Fill(this.mES2DataSet4.생산완료제품);
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            품질검사요청.Visible = true;
            불량판정등록.Visible = false;
            출하지시등록.Visible = false;
            출하후불량등록.Visible = false;
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mES2DataSet.생산완료제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.생산완료제품TableAdapter.Fill(this.mES2DataSet4.생산완료제품);
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            품질검사요청.Visible = true;
            불량판정등록.Visible = false;
            출하지시등록.Visible = false;
            출하후불량등록.Visible = false;
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mES2DataSet.검사대상제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.검사대상제품TableAdapter.Fill(this.mES2DataSet4.검사대상제품);
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            품질검사요청.Visible = false;
            불량판정등록.Visible = true;
            출하지시등록.Visible = false;
            출하후불량등록.Visible = false;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mES2DataSet.출하대기제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.출하대기제품TableAdapter.Fill(this.mES2DataSet4.출하대기제품);
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Show();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            품질검사요청.Visible = false;
            불량판정등록.Visible = false;
            출하지시등록.Visible = true;
            출하후불량등록.Visible = false;
        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mES2DataSet.출하후불량판정제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.출하후불량판정제품TableAdapter.Fill(this.mES2DataSet4.출하후불량판정제품);
            // TODO: 이 코드는 데이터를 'mES2DataSet.출하전불량판정제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.출하전불량판정제품TableAdapter.Fill(this.mES2DataSet4.출하전불량판정제품);
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Show();
            dataGridView5.Hide();
            dataGridView6.Show();
            품질검사요청.Visible = false;
            불량판정등록.Visible = false;
            출하지시등록.Visible = false;
            출하후불량등록.Visible = false;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mES2DataSet.출하등록제품' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.출하등록제품TableAdapter.Fill(this.mES2DataSet4.출하등록제품);
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Show();
            dataGridView6.Hide();
            품질검사요청.Visible = false;
            불량판정등록.Visible = false;
            출하지시등록.Visible = false;
            출하후불량등록.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crn = e.RowIndex;
            mtb1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            mtb2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtb3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtb4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtb5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = dataGridView1.Rows[crn].Cells[0].Value.ToString();
                string pname = dataGridView1.Rows[crn].Cells[1].Value.ToString();
                string psdate = dataGridView1.Rows[crn].Cells[2].Value.ToString();
                string pjdate = dataGridView1.Rows[crn].Cells[3].Value.ToString();
                string pndate = dataGridView1.Rows[crn].Cells[4].Value.ToString();
                string pmanager = mtb6.Text;
                string ppdate = DateTime.Now.ToString("yyyy-MM-dd");
                if (pmanager.Length == 0)
                {
                    MessageBox.Show("담당자를 입력해주세요.");
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(crn);

                    //this.mES2DataSet.생산완료제품.Rows[crn].Delete();
                    //this.mES2DataSet.생산완료제품.AcceptChanges();
                    BindingSource bs = (BindingSource)dataGridView1.DataSource;
                    MES2DataSet4 ds = bs.DataSource as MES2DataSet4;
                    
                    //this.생산완료제품TableAdapter.Update(this.mES2DataSet.생산완료제품);
                    this.생산완료제품TableAdapter.Update(ds.생산완료제품);
                    this.검사대상제품TableAdapter.Insert(pid, pname, ppdate, pmanager);

                    MessageBox.Show("품질 검사 요청 처리되었습니다.");
                }
            }
            catch
            {
                MessageBox.Show("품질 검사 요청 실패하였습니다.");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crn = e.RowIndex;
            if(Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[5].Value) == true)
            {
                MessageBox.Show("이미 검사한 제품입니다.");
                불량판정등록.Hide();
            }
            else
            {
                crn = e.RowIndex;
                불량판정등록.Show();
                mtb2_1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                mtb2_2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                mtb2_4.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = mtb2_1.Text;
                string pname = mtb2_2.Text;
                string pmanager = mtb2_3.Text;
                string ppdate = mtb2_4.Text;
                string ptype = mtb2_5.Text;
                string preason = mtb2_6.Text;
                if (pmanager.Length == 0)
                {
                    MessageBox.Show("담당자를 입력해주세요.");
                }
                else if (ptype.Length == 0)
                {
                    MessageBox.Show("불량 유형을 입력해주세요.");
                }
                else if(preason.Length == 0)
                {
                    MessageBox.Show("불량 사유를 입력해주세요.");
                }
                else
                {
                    Debug.WriteLine(crn);
                    dataGridView2.Rows[crn].Cells[5].Value = true;

                    BindingSource bs = (BindingSource)dataGridView2.DataSource;
                    MES2DataSet4 ds = bs.DataSource as MES2DataSet4;


                    this.검사대상제품TableAdapter.Update(ds.검사대상제품);
                    this.출하전불량판정제품TableAdapter.Insert(pid, pname, pmanager, ppdate, ptype, preason);

                    MessageBox.Show("불량 판정 등록 처리되었습니다.");
                }
            }
            catch
            {
                MessageBox.Show("불량 판정 등록 실패하였습니다.");
            }
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = mtb2_1.Text;
                string pname = mtb2_2.Text;
                string pmanager = mtb2_3.Text;
                string ppdate = mtb2_4.Text;
                if (pmanager.Length == 0)
                {
                    MessageBox.Show("담당자를 입력해주세요.");
                }
                else
                {
                    Debug.WriteLine(crn);
                    dataGridView2.Rows[crn].Cells[5].Value = true;

                    Debug.WriteLine("여기까지");
                    this.출하대기제품TableAdapter.Insert(pid, pname, ppdate, null, null, null , pmanager);

                    Debug.WriteLine("업데이트 완료");
                    MessageBox.Show("출하 대기 등록 처리되었습니다.");
                }
            }
            catch
            {
                MessageBox.Show("출하 대기 등록 실패하였습니다.");
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crn = e.RowIndex;
            출하지시등록.Show();
            mtb3_1.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtb3_2.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtb3_3.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = mtb3_1.Text;
                string pname = mtb3_2.Text;
                string pdate = mtb3_3.Text;
                string pmanager = mtb3_4.Text;
                if(pmanager.Length == 0)
                {
                    MessageBox.Show("담당자를 입력해주세요.");
                }
                else
                {
                    this.출하등록제품TableAdapter.Insert(pid, pname, pdate, pmanager, null);
                    MessageBox.Show("출하 등록 성공하였습니다.");
                }

            }
            catch
            {
                MessageBox.Show("출하 등록 실패하였습니다.");
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crn = e.RowIndex;
            출하후불량등록.Show();
            mtb4_1.Text = dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtb4_2.Text = dataGridView5.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtb4_3.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btn4_1_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = mtb4_1.Text;
                string pname = mtb4_2.Text;
                string pdate = mtb4_3.Text;
                string pwhere = mtb4_4.Text;
                string preason = mtb4_5.Text;
                if (pwhere.Length == 0)
                {
                    MessageBox.Show("불량처를 입력해주세요.");
                }
                else if(preason.Length == 0)
                {
                    MessageBox.Show("불량 사유를 입력해주세요.");
                }
                else
                {
                    this.출하후불량판정제품TableAdapter.Insert(preason, pwhere);
                    MessageBox.Show("출하 후 불량 등록 성공하였습니다.");
                }   

            }
            catch
            {
                MessageBox.Show("출하 후 불량 등록 실패하였습니다.");
            }
        }
    }
}
