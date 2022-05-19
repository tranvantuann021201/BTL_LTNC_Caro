using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_Co_Caro
{
    public partial class Form1 : Form
    {
        Boolean check;
        int demTiSo;

        private void enable_false()
        {
            btn_0_0.Enabled = false;
            btn_0_1.Enabled = false;
            btn_0_2.Enabled = false;
            btn_1_0.Enabled = false;
            btn_1_1.Enabled = false;
            btn_1_2.Enabled = false;
            btn_2_0.Enabled = false;
            btn_2_1.Enabled = false;
            btn_2_2.Enabled = false;
        }

        private void tinhDiem()
        {

            // Người chơi X
            if (btn_0_0.Text == "X" && btn_0_1.Text == "X" && btn_0_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;
                
                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) +1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_1_0.Text == "X" && btn_1_1.Text == "X" && btn_1_2.Text == "X")
            {
                btn_1_0.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_1_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) +1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_2_0.Text == "X" && btn_2_1.Text == "X" && btn_2_2.Text == "X")
            {
                btn_2_0.BackColor = Color.Aqua;
                btn_2_1.BackColor = Color.Aqua;
                btn_2_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) +1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "X" && btn_1_0.Text == "X" && btn_2_0.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_1_0.BackColor = Color.Aqua;
                btn_2_0.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) +1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_1.Text == "X" && btn_1_1.Text == "X" && btn_2_1.Text == "X")
            {
                btn_0_1.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_2_1.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) +1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_2.Text == "X" && btn_1_2.Text == "X" && btn_2_2.Text == "X")
            {
                btn_0_2.BackColor = Color.Aqua;
                btn_1_2.BackColor = Color.Aqua;
                btn_2_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) + 1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "X" && btn_1_1.Text == "X" && btn_2_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_2_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) + 1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_2.Text == "X" && btn_1_1.Text == "X" && btn_2_0.Text == "X")
            {
                btn_0_2.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_2_0.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text) + 1;
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            //Người chơi O
            if (btn_0_0.Text == "O" && btn_0_1.Text == "O" && btn_0_2.Text == "O")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_1_0.Text == "O" && btn_1_1.Text == "O" && btn_1_2.Text == "O")
            {
                btn_1_0.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_1_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_2_0.Text == "O" && btn_2_1.Text == "O" && btn_2_2.Text == "O")
            {
                btn_2_0.BackColor = Color.Aqua;
                btn_2_1.BackColor = Color.Aqua;
                btn_2_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "O" && btn_1_0.Text == "O" && btn_2_0.Text == "O")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_1_0.BackColor = Color.Aqua;
                btn_2_0.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_1.Text == "O" && btn_1_1.Text == "O" && btn_2_1.Text == "O")
            {
                btn_0_1.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_2_1.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_2.Text == "O" && btn_1_2.Text == "O" && btn_2_2.Text == "O")
            {
                btn_0_2.BackColor = Color.Aqua;
                btn_1_2.BackColor = Color.Aqua;
                btn_2_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "O" && btn_1_1.Text == "O" && btn_2_2.Text == "O")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_2_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_2.Text == "O" && btn_1_1.Text == "O" && btn_2_0.Text == "O")
            {
                btn_0_2.BackColor = Color.Aqua;
                btn_1_1.BackColor = Color.Aqua;
                btn_2_0.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi O giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemO.Text) + 1;
                tinhDiemO.Text = Convert.ToString(demTiSo);
                enable_false();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_0_Click(object sender, EventArgs e)
        {
            if(check==false)
            {
                ((Button)sender).Text = "X";
                check = true;
            }
            else
            {
                ((Button)sender).Text = "O";
                check = false;
            }
            tinhDiem();
            ((Button)sender).Enabled = false;
        }

        private void chơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //((Button)sender).Enabled = true;
            //((Button)sender).Text = "";
            resetBtn();

            tinhDiemX.Text = "0";
            tinhDiemO.Text = "0";

        }

        private void tínhLạiTỉSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetBtn();
        }

        private void resetBtn()
        {
            btn_0_0.Enabled = true;
            btn_0_1.Enabled = true;
            btn_0_2.Enabled = true;
            btn_1_0.Enabled = true;
            btn_1_1.Enabled = true;
            btn_1_2.Enabled = true;
            btn_2_0.Enabled = true;
            btn_2_1.Enabled = true;
            btn_2_2.Enabled = true;

            btn_0_0.Text = "";
            btn_0_1.Text = "";
            btn_0_2.Text = "";
            btn_1_0.Text = "";
            btn_1_1.Text = "";
            btn_1_2.Text = "";
            btn_2_0.Text = "";
            btn_2_1.Text = "";
            btn_2_2.Text = "";

            btn_0_0.BackColor = Color.Gainsboro;
            btn_0_1.BackColor = Color.Gainsboro;
            btn_0_2.BackColor = Color.Gainsboro;
            btn_1_0.BackColor = Color.Gainsboro;
            btn_1_1.BackColor = Color.Gainsboro;
            btn_1_2.BackColor = Color.Gainsboro;
            btn_2_0.BackColor = Color.Gainsboro;
            btn_2_1.BackColor = Color.Gainsboro;
            btn_2_2.BackColor = Color.Gainsboro;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
