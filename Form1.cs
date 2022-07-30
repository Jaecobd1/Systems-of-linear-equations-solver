using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.IO;

namespace Systems_of_linear_equations_solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '=', '\t' };
            //Call Variables
            int[] Equation1 =
            {
                Int32.Parse(xValue1.Text),
                Int32.Parse(yValue1.Text),
             };
            int[] Equation2 =
            {
                Int32.Parse(xValue2.Text),
                Int32.Parse(yValue2.Text),
            };

            int[][] matrix1 = new int[][]
            {
                Equation1,
                Equation2,
            };

            int[] matrixAnswers = new int[]
            {
                Int32.Parse(equals1.Text),
                Int32.Parse(Equals2.Text),
            };

            int[][] matrixB = new int[2][];
            matrixB[0] = new int[]
            {
                matrix1[1][1],
                (matrix1[0][1] * -1),
            };
            matrixB[1] = new int[]
            {
                (matrix1[1][0] * -1),
                matrix1[0][0],
            };

            String res = "nothing yet";
            int A;



            if (matrix1[0][1] == matrix1[1][1])
            {
                res = "Lines are Paralel";
            }
            else
            {
                int[][] InverseMatrix = new int[2][];

                InverseMatrix[0] = new int[2] { 0, 0 };
                InverseMatrix[1] = new int[2] { 0, 0 };
                A = ((matrix1[0][0] * matrix1[1][1]) - (matrix1[0][1] * matrix1[1][0]));
                for (int i = 0; i < matrixB.Length; i++)
                {
                    for (int j = 0; j < matrixB[i].Length; j++)
                    {
                        InverseMatrix[i][j] = (matrixB[i][j]);
                        //Solutions.Items.Add()

                        Console.WriteLine(InverseMatrix[i][j]);



                    }
                }
                int x = (((InverseMatrix[0][0] * matrixAnswers[0]) + (InverseMatrix[0][1] * matrixAnswers[1])) / A);
                int y = (((InverseMatrix[1][0] * matrixAnswers[0]) + (InverseMatrix[1][1] * matrixAnswers[1])) / A);
                res = $"{matrix1[0][0]}x + {matrix1[0][1]}y = {matrixAnswers[0]} & \n " +
                    $"{matrix1[1][0]}x + {matrix1[1][0]}y = {matrixAnswers[1]} | \n " +
                    $"x={x}, y={y}";

            }





            Solutions.Items.Add(res);





        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                    var fileStream = openFileDialog1.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        List<string> lines = File.ReadAllLines(filePath).ToList();
                       foreach(var line in lines)
                        {
                            string[] entries = line.Split(',');

                            xValue1.Text = entries[0];
                            yValue1.Text = entries[1];
                            equals1.Text = entries[2];
                            xValue2.Text = entries[3];
                            yValue2.Text = entries[4];
                            Equals2.Text = entries[5];

                        }

                    }


                }
                MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

            }

        }

    }

}
