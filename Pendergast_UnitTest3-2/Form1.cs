using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendergast_UnitTest3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            this.radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            this.radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            this.radioButton4.CheckedChanged += new EventHandler(RadioButton4__CheckedChanged);
            this.radioButton5.CheckedChanged += new EventHandler(RadioButton5__CheckedChanged);
            this.radioButton6.CheckedChanged += new EventHandler(RadioButton6__CheckedChanged);
            this.radioButton7.CheckedChanged += new EventHandler(RadioButton7__CheckedChanged);
            this.radioButton8.CheckedChanged += new EventHandler(RadioButton8__CheckedChanged);
            this.radioButton9.CheckedChanged += new EventHandler(RadioButton9__CheckedChanged);
            this.radioButton10.CheckedChanged += new EventHandler(RadioButton10__CheckedChanged);
            this.radioButton11.CheckedChanged += new EventHandler(RadioButton11__CheckedChanged);
            this.radioButton12.CheckedChanged += new EventHandler(RadioButton12__CheckedChanged);
            this.radioButton13.CheckedChanged += new EventHandler(RadioButton13__CheckedChanged);
            this.radioButton14.CheckedChanged += new EventHandler(RadioButton14__CheckedChanged);
            this.radioButton15.CheckedChanged += new EventHandler(RadioButton15__CheckedChanged);
            this.radioButton16.CheckedChanged += new EventHandler(RadioButton16__CheckedChanged);
        }
        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
