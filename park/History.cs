using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace park
{
    public partial class History : Form

    
    {

        public string ko { get; set; }
        public string Mo { get; set; }

        public string Lo { get; set; }

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add(ko, Mo, Lo);
        }
    }
}
