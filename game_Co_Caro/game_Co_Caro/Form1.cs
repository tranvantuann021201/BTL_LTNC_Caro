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
            if (btn_0_0.Text == "X" && btn_0_1.Text == "X" && btn_0_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;
                
                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text);
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_1_0.Text == "X" && btn_1_1.Text == "X" && btn_1_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text);
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_2_0.Text == "X" && btn_2_1.Text == "X" && btn_2_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text);
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "X" && btn_1_0.Text == "X" && btn_2_0.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text);
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "X" && btn_0_1.Text == "X" && btn_0_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text);
                tinhDiemX.Text = Convert.ToString(demTiSo);
                enable_false();
            }

            if (btn_0_0.Text == "X" && btn_0_1.Text == "X" && btn_0_2.Text == "X")
            {
                btn_0_0.BackColor = Color.Aqua;
                btn_0_1.BackColor = Color.Aqua;
                btn_0_2.BackColor = Color.Aqua;

                MessageBox.Show("Người chơi X giành chiến thắng", "Cờ Caro 3x3", MessageBoxButtons.OK, MessageBoxIcon.Information);

                demTiSo = int.Parse(tinhDiemX.Text);
                tinhDiemX.Text = Convert.ToString(demTiSo);
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
    }
}
