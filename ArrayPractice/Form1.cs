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


            //1. Generate random values for BOTH pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randGen.Next(0, 10);
            }


            //2. Display array 1
            array1Output.Text = "";
            for (int i = 0; i < array1.Length; i++)
            {
                array1Output.Text += array1[i] + " ";
            }


            //3. Display array 2


            //4. Display array 1 in reverse order


            //5. Determine and display the largest value in array 1          
            int max = 0;


            //6. Determine and display the average of all values in array 1
            double sum = 0;
            double average = 0;


            //7. Determine and display the sum of all even values in array 1
            int sumEven = 0;



            //8. Determine and display the number of 3s in array 1
            int numThrees = 0;



            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are
            int samePosition = 0;



            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)



            //2. swap and display all values between array1 and array2



        }
    }
}
