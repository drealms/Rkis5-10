using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl_pr1.FolderforModel;

namespace UserControl_pr1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Fill (Table_Motorbike motorbike)
        {
            labelIDData.Text = motorbike.ID.ToString();
            labelModelData.Text = motorbike.Model;
            labelBrandData.Text = motorbike.Brand;
            labelPriceData.Text = motorbike.Price.ToString();
            labelHorsepower.Text = motorbike.Horsepower.ToString();
            labelMileageData.Text = motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{motorbike.Picture}");
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
