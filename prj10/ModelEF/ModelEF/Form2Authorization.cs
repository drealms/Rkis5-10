using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelEF.FolderfForModel;

namespace ModelEF
{
    public partial class Form2Authorization : Form
    {
        public Form2Authorization()
        {
            InitializeComponent();
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            if(model.UsersHash.ToList().Any(x =>
            x.Login == loginTextBox.Text &&
            x.Password == SHA256Builder.ConvertToHash(passwordTextBox.Text)))

            {
                MessageBox.Show("user found");
                return;
            }
           
            MessageBox.Show("Неверный логин или пароль");
        }
    }
}
