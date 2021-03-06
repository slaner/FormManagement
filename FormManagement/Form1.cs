﻿using System;
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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ChangeTitle("1번 폼에서 제목 변경");
        }

        public void ChangeTitle(string title) {
            Text = title;
        }

        private void button2_Click(object sender, EventArgs e) {
            FormTable.Get<Form2>().Show();
        }
    }
}
