using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            Random randGen = new Random();

            int[] array1 = new int[10];

            double sum;

            //1. Generate random values for BOTH pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randGen.Next(0, 10);
            }
            //1. Generate random values for both pre-created arrays
            //2. Display array 1
            array1Output.Text = "";
            for (int i = 0; i < array1.Length; i++)
            {
                array1Output.Text += array1[i] + " ";
            }



            for (int i = 0; i < array1.Length; i++)
            {
                array1Output.Text += $"{array1[i]} ";
            }

            //3. Display array 2
            for (int i = 0; i < array2.Length; i++)
            {
                array2Output.Text += $"{array2[i]} ";
            }

            //4. Display array 1 in reverse order

            for (int i = array1.Length - 1; i >= 0; i--)
            {
                reverseOutput.Text += $"{array1[i]} ";
            }

            int max = 0;
            //5. Determine and display the largest value in array 1          

            double sum = 0;
            double average = 0;
            //6. Determine and display the average of all values in array 1

            //7. Determine and display the sum of all even values in array 1
            int sumEven = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    sumEven += array1[i];
                }
            }
            evenOutput.Text = sumEven + "";

            //8. Determine and display the number of 3s in array 1
            int numThrees = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 3)
                {
                    numThrees++;
                }
            }

            threeOutput.Text = numThrees + "";


            int samePosition = 0;



            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)
            int index = -1;
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                if (array1[i] == 0)
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                zeroOutput.Text = index + "";
            }
            else
            {
                zeroOutput.Text = "null";
            }

            //2. swap and display all values between array1 and array2
            int temp;

            for (int i = 0; i < array1.Length; i++)
            {
                temp = array1[i];
                array1[i] = array2[i];
                array2[i] = temp;
            }

            swap1Output.Text = "";
            for (int i = 0; i < array1.Length; i++)
            {
                swap1Output.Text += array1[i] + " ";
            }

            swap2Output.Text = "";
            for (int i = 0; i < array2.Length; i++)
            {
                swap2Output.Text += array2[i] + " ";
            }
        }
    }
}
