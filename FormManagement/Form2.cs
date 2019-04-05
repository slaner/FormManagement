using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamDEV.Utils.Forms;

namespace FormManagement {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FormTable.Get<Form1>().ChangeTitle("2번 폼에서 제목 변경 & 폼 띄우기");
            FormTable.Get<Form1>().Show();
        }

        private void Form2_Load(object sender, EventArgs e) {
            textBox1.Text = DateTime.Now.ToString();
        }
    }
}
