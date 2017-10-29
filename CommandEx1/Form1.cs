using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEx1
{
    public partial class Form1 : Form
    {
        radioControl rrr;
        public Form1()
        {
            InitializeComponent();
            rrr = new radioControl();
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            
        }

              

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            turnOnRadio command2 = new turnOnRadio(rrr);
            turnOffRadio command4 = new turnOffRadio(rrr);
            this.button1.Text = (this.button1.Text=="ВКЛЮЧИТЬ") ? command2.execute() : command4.execute();
           switch (this.button1.Text)
           {
               case "Включаем радио":this.button2.Enabled = true;
                                     this.button3.Enabled = true;break;
               case "Выключаем радио":this.button2.Enabled = false;
                                      this.button3.Enabled = false;
                                      break;
               default: break;
           }
             
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tuneUpRadio command1 = new tuneUpRadio(rrr);
            this.button1.Text = command1.execute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tuneDownRadio command3 = new tuneDownRadio(rrr);
            this.button1.Text = command3.execute();
        }

        
    }
}

