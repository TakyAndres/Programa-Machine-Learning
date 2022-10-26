using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;        
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\EstadoInicial.gif";
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R1.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R3.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\EstadoInicial.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R1C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion


        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R1.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R4.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R5.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R6.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R7.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R8.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R9.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R10.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R11.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R12.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R13.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R14.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R15.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R16.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R17.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R18.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\EstadoFinal.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\S1.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R2C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R3C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R4C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R5C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R6C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R7C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R8C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\R9C2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\EstadoFinal.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:\\Users\\ANDRES\\Desktop\\Proyecto Machine Learning\\PlayerUI\\Gifs\\S2.gif";
            //..
            //your codes
            //..
            hideSubMenu();
        }
    }
}
