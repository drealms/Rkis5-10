using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labwork_9.ModelEF;

namespace labwork_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text) ||
                String.IsNullOrWhiteSpace(group_TextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            EDM model = new EDM();
            Student student = new Student();
            student.Name = nameTextBox.Text;
            student.Group_ = group_TextBox.Text;
            byte[] bImg = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[]));
            student.Photo = bImg;
            model.Student.Add(student);
            try
            {
                model.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }

            MessageBox.Show("Data saved successfully.");
            nameTextBox.Text = "";
            group_TextBox.Text = "";
            pictureBox1.Image = null;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image";
            ofd.Filter = "Image Files|*.jpg;*.png|allfiles (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

       
    }
}
