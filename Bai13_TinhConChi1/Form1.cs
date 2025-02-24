using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13_TinhConChi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "canh ", "tân ", "Nhâm ", "quý ", "giáp ", "ất ", "bính ", "đinh ", "mậu ", "kỷ " };
            string[] chiArr = { "thân ", "dậu ", "tuất ", "hợi ", "tý ", "sửu ", "dần ", "mão ", "thìn ", "tị ", "ngọ ", "mùi " };
            string giatritrave = canArr[Convert.ToInt32(txtNam.Text) % 10] + "" + chiArr[Convert.ToInt32(txtNam.Text) % 12];
            txtKQ.Text = giatritrave;

            int startYear = 1900;
            int endYear = 2100;
            for (int i = startYear; i <= endYear; i++)
            {
                lstNam.Items.Add(i + " - " + canArr[i % 10] + " " + chiArr[i % 12]);
            }
        }
        

            
        
    }
}
