using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Game
{
    public partial class Form1 : Form
    {
        int count;
        int percent;
        int i;
        int time;

        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        private void start_Click(object sender, EventArgs e)
        {
            time = (int)numericUpDown.Value;
            progressBar.Maximum = time;
            progressBar.Value = 0;
            progressBar.Step = 50;
            trackBar.Value = 0;
            trackBar.Maximum = 16;
            count++;
            Numbers();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            i = 0;
            listBox.Items.Clear();
        }

        public void Numbers()
        {
            Random r = new Random();
            btn1.Enabled = true;
            btn1.Text = r.Next(1, 101).ToString();
            btn2.Enabled = true;
            btn2.Text = r.Next(1, 101).ToString();
            btn3.Enabled = true;
            btn3.Text = r.Next(1, 101).ToString();
            btn4.Enabled = true;
            btn4.Text = r.Next(1, 101).ToString();
            btn5.Enabled = true;
            btn5.Text = r.Next(1, 101).ToString();
            btn6.Enabled = true;
            btn6.Text = r.Next(1, 101).ToString();
            btn7.Enabled = true;
            btn7.Text = r.Next(1, 101).ToString();
            btn8.Enabled = true;
            btn8.Text = r.Next(1, 101).ToString();
            btn9.Enabled = true;
            btn9.Text = r.Next(1, 101).ToString();
            btn10.Enabled = true;
            btn10.Text = r.Next(1, 101).ToString();
            btn11.Enabled = true;
            btn11.Text = r.Next(1, 101).ToString();
            btn12.Enabled = true;
            btn12.Text = r.Next(1, 101).ToString();
            btn13.Enabled = true;
            btn13.Text = r.Next(1, 101).ToString();
            btn14.Enabled = true;
            btn14.Text = r.Next(1, 101).ToString();
            btn15.Enabled = true;
            btn15.Text = r.Next(1, 101).ToString();
            btn16.Enabled = true;
            btn16.Text = r.Next(1, 101).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numericUpDown.Value--;
            progressBar.Value++;
            percent = (trackBar.Value * 100) / 16;
            if (numericUpDown.Value == 0)
            {
                GameOver();
            }
            if (percent == 100)
            {
                timer1.Enabled = false;
                progressBar.Enabled = false;
                MessageBox.Show("Ура!\nВи виграли!\n\nКількість спроб - " + count + "\n\nТривалість гри - " + (time - numericUpDown.Value) + " секунд", "Результат гри.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                numericUpDown.Value = 30;
            }
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            progressBar.Enabled = false;
            MessageBox.Show("Ви програли!\n\nКількість спроб - " + count + "\nВірно натиснутих кнопок - " + percent + "%", "Результат гри.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            numericUpDown.Value = 30;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Add(sender);
            if (Convert.ToInt32(sender) >= i)
            {
                i = Convert.ToInt32(sender);
            }
            else
            {
                GameOver();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            listBox_SelectedIndexChanged(((Button)sender).Text, null);
            ((Button)sender).Enabled = false;
            trackBar.Value++;
        }
    }
}
