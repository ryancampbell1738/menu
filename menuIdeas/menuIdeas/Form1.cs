using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuIdeas
{
    public partial class Form1 : Form
    {
        int noMenuItems = 0;
        Button[] mnuItems;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int temp = 0, top = 0;

            pnlMenu.BackColor = Color.Black;

            foreach(Control c in pnlMenu.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    noMenuItems += 1;
                }
            }

            mnuItems = new Button[noMenuItems];

            foreach (Control c in pnlMenu.Controls)
            {
                if(c.GetType() == typeof(Button))
                {
                    mnuItems[temp] = (Button)c;

                    if(c.Tag.Equals("M"))
                    {
                        c.BackColor = Color.Black;
                        c.ForeColor = Color.Gold;
                        c.Location = new Point(0, top);
                        top += 50;
                        c.Visible = true;
                        c.Tag = c.Tag + "V";
                    }
                    else
                    {
                        c.BackColor = Color.Gray;
                        c.ForeColor = Color.Orange;
                        c.Tag = c.Tag + "I";
                    }
                    c.Font = new Font(c.Font, FontStyle.Bold);
                    c.Tag = c.Tag + temp.ToString();
                    temp++;
                }           
            }
            rtbText.Font = new Font(FontFamily.GenericSansSerif, 11.0f, FontStyle.Bold);
            rtbText.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            int startIndex = 0, top = 0;
            Button btn = (Button)sender;

            rtbText.Font = new Font(FontFamily.GenericSansSerif, 11.0f, FontStyle.Bold);

            startIndex = Convert.ToInt32(btn.Tag.ToString().Substring(2, btn.Tag.ToString().Length - 2));

            if (btn.Tag.ToString().Substring(0,2).Equals("SV"))
            {
                switch(startIndex)
                {
                    case 1:
                        rtbText.Text = "1";
                        break;
                    case 2:
                        rtbText.Text = "2";
                        break;
                    case 3:
                        rtbText.Text = "3";
                        break;
                    case 4:
                        rtbText.Text = "4";
                        break;
                }
            }
            else
            {
                rtbText.Font = new Font(FontFamily.GenericSansSerif, 11.0f, FontStyle.Bold);
                rtbText.Text = "0";

                for(int i = startIndex + 1; i< noMenuItems; 1++)
                {
                    if(!mnuItems[i].Tag.ToString().Substring(0,1).Equals("M"))
                    {


                    }
                }
            }
        }
    }
}
