using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prak11
{
    public partial class Form1 :Form
    {

        public Form1 ()
        {
            InitializeComponent();
        }

        public class Student
        {
            public string name;
            public double rost;
            private double ves = 40;
            public double GetEat(double vs)
            {
                ves = vs;
                return ves;
            }
            public double SetEat(double eda,double vs)
            {
                ves = vs + eda - 2000 / 1000;
                return ves;
            }
            public double SetRost(int eda, double rost)
            {
                if (eda >= 5 && eda <= 10)
                {
                    rost = rost - 1;
                    return rost;
                }
                else if (eda > 10)
                {
                    rost = rost - 2;
                    return rost;
                }
                else
                    return rost;
            }
            public double SetEat(int eda,double ves)
            {
                if (eda >= 5 | eda <= 10)
                {
                    ves = ves + (0.7 * (eda * 1000 - 1600)) / 1000;
                    return ves;
                }
                else if (eda < 10)
                {
                    ves = ves + (0.5 * (eda * 1000 - 1800)) / 1000;
                    return ves;
                }
                else
                    ves = ves + eda - 2800 / 1000;
                return ves;










            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = textBox1.Text;
            student1.rost = (double) (numericUpDown1.Value);
            MessageBox.Show(string.Format("Студент: {0} \nПервоначальный рост: {1} Первоначальный вес: {2}\nВес после еды: {3} Рост после еды: {4},student"));
        }
    }
}
