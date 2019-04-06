﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Divide_Click(object sender, EventArgs e) {
            Answer.Text = (int.Parse(Op1.Text) / int.Parse(Op2.Text)).ToString();
        }

        private void Minus_Click(object sender, EventArgs e) {
            Answer.Text = (int.Parse(Op1.Text) - int.Parse(Op2.Text)).ToString();
        }

        private void Times_Click(object sender, EventArgs e) {
            Answer.Text = (int.Parse(Op1.Text) * int.Parse(Op2.Text)).ToString();
        }

        private void Plus_Click(object sender, EventArgs e) {
            Answer.Text = (int.Parse(Op1.Text) + int.Parse(Op2.Text)).ToString();
        }

        private void Modulus_Click(object sender, EventArgs e) {
            Answer.Text = (int.Parse(Op1.Text) % int.Parse(Op2.Text)).ToString();
        }
    }
}
