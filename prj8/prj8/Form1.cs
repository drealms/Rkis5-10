using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj8.FolderModel;

namespace prj8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ModelEF database = new ModelEF();

        List<Pavilion> pavilions = new List<Pavilion>();

        List<Pavilion> PavilionChange = new List<Pavilion>();

        List<string> pavilionsProp = new List<string>();

        private void loadStartData()
        {
            pavilionBindingSource.DataSource = PavilionChange;
        }
        
        private void LoadDataComboBox()
        {
            pavilionsProp = typeof(Pavilion).GetProperties().Select(x => x.Name).ToList();

            pavilionsProp.RemoveRange(pavilionsProp.Count -2, 2);

            comboBox1.DataSource = pavilionsProp;

            comboBox1.SelectedIndex = 0;


        }

        private void LoadOrder()
        {
            PavilionChange = checkBox1.Checked ? 
                PavilionChange.OrderByDescending(p => p.GetType().GetProperties
                ().First(x => x.Name == comboBox1.SelectedItem.ToString()).GetValue
                (p)).ToList()

                : PavilionChange.OrderBy(p => p.GetType().GetProperties
                ().First(x => x.Name == comboBox1.SelectedItem.ToString())
                .GetValue(p)).ToList();
            loadStartData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PavilionChange = pavilions = database.Pavilion.ToList();

            loadStartData();
            LoadDataComboBox();
        }

        private void Data_changes(object sender, EventArgs e)
        {
            LoadOrder();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            PavilionChange = pavilions.Where(x => x.Status.Contains(textBox1.Text)).ToList();

            LoadOrder();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
