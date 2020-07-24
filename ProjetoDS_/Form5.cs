using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace ProjetoDS_EAD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(DTO_Usuario usuario)
        {
            InitializeComponent();
            label2.Text = usuario.Nome;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

    }
}
