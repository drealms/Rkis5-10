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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static ModelDB DB = new ModelDB();

        List<Table_Motorbike> motorbikes = DB.Table_Motorbike.ToList();
        
        int AccNumber = 0;

        private void Loading()
        {
            userControl11.Fill(motorbikes[AccNumber]);
        }

        private void Loading(bool Incr)
        {
            if (Incr == true && motorbikes.Count > AccNumber +1)
            {
                AccNumber++;
            }
            else if (Incr == false && AccNumber > 0)
            {
                AccNumber--;
            }
            else
            {
                return;
            }

            Loading();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Loading();

        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }
    }
}
