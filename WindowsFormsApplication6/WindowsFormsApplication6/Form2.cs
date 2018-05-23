using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pnDish.MaximumSize = new Size(pnDish.Width, pnDish.Height);
            pnDish.AutoScroll = true;
            pnDrink.MaximumSize = new Size(pnDish.Width, pnDish.Height);
            pnDrink.AutoScroll = true;
            vegiaodien();
            vegiaodiendrink();
        }

        private void vegiaodien()
        {
            pnDish.Controls.Clear();
            for (int i = 0; i < pnDish.RowCount; i++)
            {
                for (int j = 0; j < pnDish.ColumnCount; j++)
                {
                    Panel pn = new Panel();
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile("C:/Users/thale/Desktop/images/01_preview.jpg");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = 120;
                    pb.Dock = DockStyle.Top;
                    pn.Dock = DockStyle.Fill;
                    Color color = System.Drawing.ColorTranslator.FromHtml("#017db4");
                    Color color1 = System.Drawing.ColorTranslator.FromHtml("#cb1732");
                   
                    Label lb = new Label();
                    lb.Text = "Pizza hải sản";
                    lb.Location = new Point(pb.Width/2 + 20,pb.Height + 2);
                    lb.ForeColor = Color.White;
                    lb.Font = new Font("Times New Roman",12.0F, FontStyle.Bold);
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.AutoSize = false;
                     NumericUpDown nd = new NumericUpDown();
                     nd.Location = new Point(pb.Width / 2 - 35, pb.Height + lb.Height + 4 + 6 + nd.Height);
                     nd.Width = 40;
                     Button btn = new Button();
                     btn.BackColor = color1;
                     btn.Location = new Point(20, 204);
                     btn.AutoSize = true;
                     btn.Width = 230 ;
                     btn.Height = 30;
                     btn.Text = "Đặt hàng";
                    btn.Font =  new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    ComboBox cb1 = new ComboBox();
                    cb1.Text = "Vỏ dày";             
                    cb1.Items.Add("Vỏ giòn");
                    cb1.Font = new Font("Times New Roman", 10.0F, FontStyle.Bold);
                    cb1.ForeColor = Color.Black;                
                    cb1.Location = new Point(pb.Width / 2 + nd.Width + 40 , pb.Height + lb.Height + 4);
                    ComboBox cb2 = new ComboBox();
                    cb2.Text = "Size nhỏ";
                    cb2.Items.Add("Size vừa");
                    cb2.Items.Add("Size lớn");
                    cb2.Font = new Font("Times New Roman", 10.0F, FontStyle.Bold);
                    cb2.ForeColor = Color.Black;
                    cb2.Location = new Point(pb.Width / 2 + nd.Width + 40, pb.Height + lb.Height + 4 + cb1.Height + 3);
                  
               
                    Label lbl2 = new Label();
                    lbl2.Location = new Point(pb.Width / 2 - 40, pb.Height + lb.Height + 4);
                    lbl2.Text = "Giá: 240,000đ";
                    lbl2.AutoSize = true;
                    lbl2.ForeColor = Color.White;
                    lbl2.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                
                    pn.BackColor = color;
                    pn.Controls.Add(pb);
                    pn.Controls.Add(lb);
                    pn.Controls.Add(nd);
                    pn.Controls.Add(cb1);
                    pn.Controls.Add(cb2);
                    pn.Controls.Add(lbl2);
                    pn.Controls.Add(btn);
                    pnDish.Controls.Add(pn, j, i);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        private void vegiaodiendrink()
        {
            pnDrink.Controls.Clear();
            for (int i = 0; i < pnDrink.RowCount; i++)
            {
                for (int j = 0; j < pnDrink.ColumnCount; j++)
                {
                    Panel pn = new Panel();
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile("C:/Users/thale/Desktop/images/103747166-PepsiCo-Diet-Cola-Portfolio.530x298.jpg");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = 120;
                    pb.Dock = DockStyle.Top;
                    pn.Dock = DockStyle.Fill;
                    Color color = System.Drawing.ColorTranslator.FromHtml("#017db4");
                    Color color1 = System.Drawing.ColorTranslator.FromHtml("#cb1732");

                    Label lb = new Label();
                    lb.Text = "Nước ngọt Pepsi";
                    lb.Location = new Point(pb.Width / 2 + 20, pb.Height + 2);
                    lb.ForeColor = Color.White;
                    lb.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.AutoSize = true;
                    Label lbl2 = new Label();
                    lbl2.Location = new Point(pb.Width / 2 + 20, pb.Height + lb.Height + 10);
                    lbl2.Text = "Giá: 20,000đ";
                    lbl2.AutoSize = false;
                    lbl2.ForeColor = Color.White;
                    lbl2.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    lbl2.Height = 60;
                    NumericUpDown nd = new NumericUpDown();
                    nd.Location = new Point((pb.Width / 2) + lbl2.Width + 40, pb.Height + lb.Height + 10);
                    nd.Width = 50;

                    Button btn = new Button();
                    btn.BackColor = color1;
                    btn.Location = new Point(20, 194);
                    btn.AutoSize = true;
                    btn.Width = 230;
                    btn.Height = 30;
                    btn.Text = "Đặt hàng";
                    btn.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    pn.BackColor = color;
                    pn.Controls.Add(pb);
                    pn.Controls.Add(lb);
                    pn.Controls.Add(nd);
                    pn.Controls.Add(btn);
                    pn.Controls.Add(lbl2);
                    pnDrink.Controls.Add(pn, j, i);
                }
            }
        }
        private void pnDrink_Paint(object sender, PaintEventArgs e)
        {
           // vegiaodiendrink();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnDish.Controls.Clear();
            for (int i = 0; i < pnDish.RowCount; i++)
            {
                for (int j = 0; j < pnDish.ColumnCount; j++)
                {
                    Panel pn = new Panel();
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile("C:/Users/thale/Desktop/images/103747166-PepsiCo-Diet-Cola-Portfolio.530x298.jpg");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = 120;
                    pb.Dock = DockStyle.Top;
                    pn.Dock = DockStyle.Fill;
                    Color color = System.Drawing.ColorTranslator.FromHtml("#017db4");
                    Color color1 = System.Drawing.ColorTranslator.FromHtml("#cb1732");

                    Label lb = new Label();
                    lb.Text = "Nước ngọt Pepsi";
                    lb.Location = new Point(pb.Width / 2 + 20, pb.Height + 2);
                    lb.ForeColor = Color.White;
                    lb.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.AutoSize = true;
                    Label lbl2 = new Label();
                    lbl2.Location = new Point(pb.Width / 2 + 20, pb.Height + lb.Height + 10);
                    lbl2.Text = "Giá: 20,000đ";
                    lbl2.AutoSize = false;
                    lbl2.ForeColor = Color.White;
                    lbl2.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    lbl2.Height = 60;
                    NumericUpDown nd = new NumericUpDown();
                    nd.Location = new Point((pb.Width / 2) + lbl2.Width + 40, pb.Height + lb.Height + 10);
                    nd.Width = 50;

                    Button btn = new Button();
                    btn.BackColor = color1;
                    btn.Location = new Point(20, 194);
                    btn.AutoSize = true;
                    btn.Width = 230;
                    btn.Height = 30;
                    btn.Text = "Đặt hàng";
                    btn.Font = new Font("Times New Roman", 12.0F, FontStyle.Bold);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    pn.BackColor = color;
                    pn.Controls.Add(pb);
                    pn.Controls.Add(lb);
                    pn.Controls.Add(nd);
                    pn.Controls.Add(btn);
                    pn.Controls.Add(lbl2);
                    pnDish.Controls.Add(pn, j, i);
                }
            }
        }
    }
}
