using MatrixClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMDotNet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuildMatrix_Click(object sender, EventArgs e)
        {
            if (numericUpDownRows.Text == numericUpDownColls.Text && numericUpDownRows.Text != "1")
            {
                MatrixFunctionality matrix = new MatrixFunctionality(Convert.ToInt32(numericUpDownRows.Value), Convert.ToInt32(numericUpDownColls.Value));
                matrix.FillWithRandomNumbers();

                MatrixClassVisualizer matrixClassVisualizer = new MatrixClassVisualizer(dataGridViewMatrix, dataGridViewMulWithoutNeg, dataGridViewSumColumnElementsPositive, dataGridViewSumColumnElementsNegative, dataGridViewTransposedMatrix, dataGridViewMaxSumDiagon, dataGridViewMinSumAnotherDiag);
                matrixClassVisualizer.Fill(matrix);
                matrixClassVisualizer.NumerateRowsAndCols();

                matrixClassVisualizer.MultiplyRowsElementsWithoutNegativeElements_Visualize();
                matrixClassVisualizer.SumColumnElementsPositive_Visualize();
                matrixClassVisualizer.SumColumnElementsNegative_Visualize();
                matrixClassVisualizer.TransposedMatrix_Visualize();
                matrixClassVisualizer.MaxSumDiagon_Visualize();
                matrixClassVisualizer.MinSumDiagon_Visualize();

                textBoxPositiveElements.Text = matrix.CountPositiveMatrixElements().ToString();
                textBoxMaxElem.Text = matrix.MaxMatrixElement().ToString();
                if (textBoxMaxElem.Text == "0")
                {
                    textBoxMaxElem.Text = "відсутні";
                }
                textBoxCountWithputZeros.Text = matrix.CountRowsWithoutZeros().ToString();
                textBoxCountColsWithZero.Text = matrix.CountColsWithZeros().ToString();
                textBoxLongestRepeatedElementsSeria.Text = matrix.LongestRepeatedElementsSeria().ToString();
                if (textBoxLongestRepeatedElementsSeria.Text == "-1")
                {
                    textBoxLongestRepeatedElementsSeria.Text = "відсутній";
                }
                textBoxMaxElemSumDiag.Text = matrix.MaxElemSumDiagon().ToString();
                textBoxMinElemSumAnotherDiag.Text = matrix.MinElemSumDiagon().ToString();
            }
            else
            {
                MessageBox.Show("Програма виконує дії лише з квадратними матрицями від 2х2 і вище");
            }

        }
    }
}
