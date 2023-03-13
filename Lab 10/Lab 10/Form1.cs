using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] arr=new int[15];
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            Random rand= new Random();
            txtArray.Text = "Массив: ";
            for (int i=0;i<arr.Length;i++)
            {
                arr[i]= rand.Next(20);
                sum += arr[i];
                txtArray.Text += arr[i].ToString() + " ";
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                
            }
            Array.Sort(arr);
            txtArray.Text += "\r\nSort: ";
          for (int i=0;i<arr.Length;i++)
          {
                txtArray.Text +=arr[i].ToString() + " ";
          }
            txtArray.Text += "\r\nMax: " + max;
            txtArray.Text += "\r\nMin: " + min;
            txtArray.Text += "\r\nСумма: "+sum.ToString();
            double average = (double)sum / arr.Length;
            txtArray.Text += "\r\nСреднее арифметическое: " + average.ToString();

        }
    }
}
