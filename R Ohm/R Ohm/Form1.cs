using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_Ohm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int line_num=0;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    form load
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            button6.Visible = false;

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;

            label8.Visible = false;
            label9.Visible = false;

            label8.Text = "";
            label9.Text = "";

        }

        //for lin1-3
       public string color_sum(string combo_tx)
        {
            string col_sum="";
            if (combo_tx=="black")
            { col_sum = "0"; }
            else if(combo_tx=="brown")
            { col_sum = "1"; }
            else if (combo_tx == "red")
            { col_sum = "2"; }
            else if (combo_tx == "orange")
            { col_sum = "3"; }
            else if (combo_tx == "yellow")
            { col_sum = "4"; }
            else if (combo_tx == "green")
            { col_sum = "5"; }
            else if (combo_tx == "blue")
            { col_sum = "6"; }
            else if (combo_tx == "purple")
            { col_sum = "7"; }
            else if (combo_tx == "white")
            { col_sum = "9"; }
            else if (combo_tx == "grey")
            { col_sum = "8"; }
            else { col_sum = ""; }
            return col_sum;
        }

        //for line 3-4
        public string  st_time(string st_t)
        {
            
            if (st_t == "black")
            { st_t = "1"; }
            else if (st_t == "brown")
            { st_t = "10"; }
            else if (st_t == "red")
            { st_t = "100"; }
            else if (st_t == "orange")
            { st_t = "1000"; }
            else if (st_t == "yellow")
            { st_t = "10000"; }
            else if (st_t == "green")
            { st_t = "100000"; }
            else if (st_t == "blue")
            { st_t = "1000000"; }
            else if (st_t == "purple")
            { st_t = "10000000"; }
            else if (st_t == "silver")
            { st_t = "0,01"; }
            else if (st_t == "gold")
            { st_t = "0,1"; }
            else { st_t = ""; }

            return st_t;
        }

        //for line 4-5
        public string st_err(string st_ero)
        {

            if (st_ero == "brown")
            { st_ero = "1%"; }
            else if (st_ero == "red")
            { st_ero = "2%"; }
            else if (st_ero == "green")
            { st_ero = "0.5%"; }
            else if (st_ero == "blue")
            { st_ero = "0.25%"; }
            else if (st_ero == "purple")
            { st_ero = "0.1%"; }
            else if (st_ero == "grey")
            { st_ero = "0.05%"; }
            else if (st_ero == "silver")
            { st_ero = "10%"; }
            else if (st_ero == "gold")
            { st_ero = "5%"; }
            else { st_ero = ""; }

            return st_ero;
        }

        public string st_tempr(string st_tem)
        {

            if (st_tem == "brown")
            { st_tem = "100ppm"; }
            else if (st_tem == "red")
            { st_tem = "50ppm"; }
            else if (st_tem == "orange")
            { st_tem = "15ppm"; }
            else if (st_tem == "yellow")
            { st_tem = "25ppm"; }
            else { st_tem = ""; }

            return st_tem;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //     retry button
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button6.Visible = false;
            line_num = 0;

            label8.Text = "";
            label9.Text = "";

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;

            label8.Visible = false;
            label9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //    4 line
            line_num = 4;
            label2.Visible = true;
            label3.Visible = true;            
            label5.Visible = true;
            label6.Visible = true;
            button6.Visible = true;
            
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            comboBox1.Visible = true;
            comboBox2.Visible = true;            
            comboBox4.Visible = true;
            comboBox5.Visible = true;

            label2.Text = "Line 1";
            label3.Text = "Line 2";
            label5.Text = "Line 3";
            label6.Text = "Line 4";

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    5 line
            line_num = 5;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button6.Visible = true;

            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";

            label2.Text = "Line 1";
            label3.Text = "Line 2";
            label4.Text = "Line 3";
            label5.Text = "Line 4";
            label6.Text = "Line 5";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //    6 line
            line_num = 6;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button6.Visible = true;

            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";

            label2.Text = "Line 1";
            label3.Text = "Line 2";
            label4.Text = "Line 3";
            label5.Text = "Line 4";
            label6.Text = "Line 5";
            label7.Text = "Line 6";
            button6.Visible = true;

        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ohm calculate

            label8.Visible = true;
            label9.Visible = true;
            label8.Text = "";
            label9.Text = "";
            string st_sum = "";
            string st_tim = "";
            string err = "";
            string tempr = "";

            if (line_num == 4)
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox4.Text != "" && comboBox5.Text != "")
                {
                    st_sum += color_sum(comboBox1.Text);
                    st_sum += color_sum(comboBox2.Text);
                    st_tim = st_time(comboBox4.Text);
                    err = st_err(comboBox5.Text);
                }
                else { label8.Text = "complete all textbox."; }
                
            }
            else if (line_num==5)
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "")
                {
                    st_sum += color_sum(comboBox1.Text);
                    st_sum += color_sum(comboBox2.Text);
                    st_sum += color_sum(comboBox3.Text);
                    st_tim = st_time(comboBox4.Text);
                    err = st_err(comboBox5.Text);
                }
                else { label8.Text = "complete all textbox."; }
            }
            else if (line_num==6)
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "" && comboBox6.Text != "")
                {
                    st_sum += color_sum(comboBox1.Text);
                    st_sum += color_sum(comboBox2.Text);
                    st_sum += color_sum(comboBox3.Text);
                    st_tim = st_time(comboBox4.Text);
                    err = st_err(comboBox5.Text);
                    tempr = st_tempr(comboBox6.Text);
                }
                else
                {
                    label8.Text = "complete all textbox.";
                }

            }

            if (st_sum.StartsWith("0")&& st_sum.Length>=3)
            {
                StringBuilder txt = new StringBuilder(st_sum);
                txt.Remove(0, 1);
                st_sum = txt.ToString();
                if (st_sum.StartsWith("0") && st_sum.Length >=2)
                {
                    StringBuilder txt00 = new StringBuilder(st_sum);
                    txt00.Remove(0, 1);
                    st_sum = txt00.ToString();
                }
                    /*int x = txt.Length - 1;
                    char [] txt0 = new char[x];
                    int j = 0;
                    for (int i = 1; i<txt.Length;i++)
                    {
                        j = i - 1;
                        txt0[j] = txt[i];
                    }
                    st_sum = Convert.ToString(txt0);
                    */
                }
            Int64 ohm = 0;
            Decimal oh;
            string lbl8_txt;
            if (st_sum!="")
            {
                ohm = Convert.ToInt64(st_sum);
            }
            
            if (st_tim != "" && st_tim != "0,1" && st_tim != "0,01")
            {
                ohm = ohm * Convert.ToInt64(st_tim);
                lbl8_txt = ohm.ToString();
                lbl8_txt += ", error: " + err;
                label8.Text = lbl8_txt;
            }
            if (st_tim == "0,1" || st_tim == "0,01")
            {
                //CultureInfo uscul = new CultureInfo("en_US");
                //NumberFormatInfo num = uscul.NumberFormat;
                Decimal t = Decimal.Parse(st_tim.Replace(',','.'),CultureInfo.InvariantCulture);
                //oh = Convert.ToDecimal(st_sum) * Convert.ToDecimal(st_tim);
                oh = Convert.ToDecimal(st_sum) * t;

                lbl8_txt = oh.ToString();
                lbl8_txt += ", error: " + err;
                label8.Text = lbl8_txt;
            }
            
            if (tempr!="")
            {
                label9.Text = tempr;
            }


            // check input not empty
            if (line_num == 4)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
                {
                    label8.Text = "complete all textbox.";
                }
            }
            else if (line_num == 5)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
                {
                    label8.Text = "complete all textbox.";
                }
            }
            else if (line_num == 6)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "")
                {
                    label8.Text = "complete all textbox.";
                    label9.Text = "";
                }
            }

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index>-1)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (Brush backgbrush = new SolidBrush(comboBox1.BackColor))
                    e.Graphics.FillRectangle(backgbrush, e.Bounds);
                using (Brush textbrush = new SolidBrush(comboBox1.ForeColor))
                    e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(),
                        e.Font, textbrush, e.Bounds.Height + 10, e.Bounds.Y,
                        StringFormat.GenericTypographic);
                e.Graphics.DrawImage(this.imageList1.Images[e.Index],
                    new Rectangle(e.Bounds.Location,
                    new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
            }
        }

        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (Brush backgbrush = new SolidBrush(comboBox2.BackColor))
                    e.Graphics.FillRectangle(backgbrush, e.Bounds);
                using (Brush textbrush = new SolidBrush(comboBox2.ForeColor))
                    e.Graphics.DrawString(comboBox2.Items[e.Index].ToString(),
                        e.Font, textbrush, e.Bounds.Height + 10, e.Bounds.Y,
                        StringFormat.GenericTypographic);
                e.Graphics.DrawImage(this.imageList1.Images[e.Index],
                    new Rectangle(e.Bounds.Location,
                    new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
            }
        }

        private void comboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (Brush backgbrush = new SolidBrush(comboBox3.BackColor))
                    e.Graphics.FillRectangle(backgbrush, e.Bounds);
                using (Brush textbrush = new SolidBrush(comboBox3.ForeColor))
                    e.Graphics.DrawString(comboBox3.Items[e.Index].ToString(),
                        e.Font, textbrush, e.Bounds.Height + 10, e.Bounds.Y,
                        StringFormat.GenericTypographic);
                e.Graphics.DrawImage(this.imageList1.Images[e.Index],
                    new Rectangle(e.Bounds.Location,
                    new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (Brush backgbrush = new SolidBrush(comboBox4.BackColor))
                    e.Graphics.FillRectangle(backgbrush, e.Bounds);
                using (Brush textbrush = new SolidBrush(comboBox4.ForeColor))
                    e.Graphics.DrawString(comboBox4.Items[e.Index].ToString(),
                        e.Font, textbrush, e.Bounds.Height + 10, e.Bounds.Y,
                        StringFormat.GenericTypographic);
                e.Graphics.DrawImage(this.imageList2.Images[e.Index],
                    new Rectangle(e.Bounds.Location,
                    new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
            }
        }

        private void comboBox5_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (Brush backgbrush = new SolidBrush(comboBox5.BackColor))
                    e.Graphics.FillRectangle(backgbrush, e.Bounds);
                using (Brush textbrush = new SolidBrush(comboBox5.ForeColor))
                    e.Graphics.DrawString(comboBox5.Items[e.Index].ToString(),
                        e.Font, textbrush, e.Bounds.Height + 10, e.Bounds.Y,
                        StringFormat.GenericTypographic);
                e.Graphics.DrawImage(this.imageList3.Images[e.Index],
                    new Rectangle(e.Bounds.Location,
                    new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
            }
        }

        private void comboBox6_DropDown(object sender, EventArgs e)
        {

        }

        private void comboBox6_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (Brush backgbrush = new SolidBrush(comboBox6.BackColor))
                    e.Graphics.FillRectangle(backgbrush, e.Bounds);
                using (Brush textbrush = new SolidBrush(comboBox6.ForeColor))
                    e.Graphics.DrawString(comboBox6.Items[e.Index].ToString(),
                        e.Font, textbrush, e.Bounds.Height + 10, e.Bounds.Y,
                        StringFormat.GenericTypographic);
                e.Graphics.DrawImage(this.imageList4.Images[e.Index],
                    new Rectangle(e.Bounds.Location,
                    new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
            }
        }
    }

}
