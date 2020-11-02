using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixClassLibrary
{
    public class MatrixClassVisualizer
    {
        protected DataGridView DataGrid;
        protected DataGridView DataGrid_Mul;
        protected DataGridView DataGrid_Sum;
        protected DataGridView DataGrid_SumNeg;
        protected DataGridView DataGrid_Transposed;
        protected DataGridView DataGrid_MaxSumDiagon;
        protected DataGridView DataGrid_MinSumDiagon;

        public MatrixClassVisualizer (DataGridView dataGrid, DataGridView dataGridMul, DataGridView dataGridSum, DataGridView dataGridSumNeg, DataGridView dataGridTransposed, DataGridView dataGridMaxSumDiagon, DataGridView dataGridMinSumDiagon)
        {
            DataGrid = dataGrid;
            DataGrid_Mul = dataGridMul;
            DataGrid_Sum = dataGridSum;
            DataGrid_SumNeg = dataGridSumNeg;
            DataGrid_Transposed = dataGridTransposed;
            DataGrid_MaxSumDiagon = dataGridMaxSumDiagon;
            DataGrid_MinSumDiagon = dataGridMinSumDiagon;
        }


        public void Initialize(int rowsCount, int collsCount)
        {
            DataGrid.RowCount = rowsCount;
            DataGrid.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid.ColumnCount; i++)
            {
                DataGrid.Columns[i].Width = 80;
            }
            

        }
        public void InitializeMul(int rowsCount, int collsCount)
        {
            DataGrid_Mul.RowCount = rowsCount;
            DataGrid_Mul.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid_Mul.ColumnCount; i++)
            {
                DataGrid_Mul.Columns[i].Width = 80;
            }


        }
        public void InitializeSum(int rowsCount, int collsCount)
        {
            DataGrid_Sum.RowCount = rowsCount;
            DataGrid_Sum.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid_Sum.ColumnCount; i++)
            {
                DataGrid_Sum.Columns[i].Width = 80;
            }


        }
        public void InitializeSumNeg(int rowsCount, int collsCount)
        {
            DataGrid_SumNeg.RowCount = rowsCount;
            DataGrid_SumNeg.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid_SumNeg.ColumnCount; i++)
            {
                DataGrid_SumNeg.Columns[i].Width = 80;
            }


        }
        public void InitializeTransposed(int rowsCount, int collsCount)
        {
            DataGrid_Transposed.RowCount = rowsCount;
            DataGrid_Transposed.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid_Transposed.ColumnCount; i++)
            {
                DataGrid_Transposed.Columns[i].Width = 80;
            }


        }

        public void InitializeMaxSumDiagon(int rowsCount, int collsCount) {

            DataGrid_MaxSumDiagon.RowCount = rowsCount;
            DataGrid_MaxSumDiagon.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid_MaxSumDiagon.ColumnCount; i++)
            {
                DataGrid_MaxSumDiagon.Columns[i].Width = 80;
            }
        }

        public void InitializeMinSumDiagon(int rowsCount, int collsCount)
        {

            DataGrid_MinSumDiagon.RowCount = rowsCount;
            DataGrid_MinSumDiagon.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid_MinSumDiagon.ColumnCount; i++)
            {
                DataGrid_MinSumDiagon.Columns[i].Width = 80;
            }
        }

        public void NumerateRowsAndCols()
        {
            for (int i=0;i< DataGrid.ColumnCount; i++)
            {
                DataGrid.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                DataGrid.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid.RowHeadersWidth = 80;

        }
        public void NumerateRowsAndCols_Sum()
        {
            for (int i = 0; i < DataGrid_Sum.ColumnCount; i++)
            {
                DataGrid_Sum.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid_Sum.RowCount; i++)
            {
                DataGrid_Sum.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid_Sum.RowHeadersWidth = 80;

        }

        public void NumerateRowsAndCols_SumNeg()
        {
            for (int i = 0; i < DataGrid_SumNeg.ColumnCount; i++)
            {
                DataGrid_SumNeg.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid_SumNeg.RowCount; i++)
            {
                DataGrid_SumNeg.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid_SumNeg.RowHeadersWidth = 80;

        }

        public void NumerateRowsAndCols_Mul()
        {
            for (int i = 0; i < DataGrid_Mul.ColumnCount; i++)
            {
                DataGrid_Mul.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid_Mul.RowCount; i++)
            {
                DataGrid_Mul.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid_Mul.RowHeadersWidth = 80;

        }
        public void NumerateRowsAndCols_Transposed()
        {
            for (int i = 0; i < DataGrid_Transposed.ColumnCount; i++)
            {
                DataGrid_Transposed.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid_Transposed.RowCount; i++)
            {
                DataGrid_Transposed.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid_Transposed.RowHeadersWidth = 80;

        }

        public void NumerateRowsAndCols_MaxSumDiagon()
        {
            for (int i = 0; i < DataGrid_MaxSumDiagon.ColumnCount; i++)
            {
                DataGrid_MaxSumDiagon.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid_MaxSumDiagon.RowCount; i++)
            {
                DataGrid_MaxSumDiagon.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid_MaxSumDiagon.RowHeadersWidth = 80;
        }

        public void NumerateRowsAndCols_MinSumDiagon()
        {
            for (int i = 0; i < DataGrid_MinSumDiagon.ColumnCount; i++)
            {
                DataGrid_MinSumDiagon.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid_MaxSumDiagon.RowCount; i++)
            {
                DataGrid_MinSumDiagon.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid_MinSumDiagon.RowHeadersWidth = 80;
        }

        public void Fill(MatrixFunctionality matrix)
        {
            int [,] matr = matrix.GetMatrix();
            Initialize(matr.GetLength(0), matr.GetLength(1));
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    DataGrid[j, i].Value = matr[i, j];

                }
            }
        }
        
        public void MultiplyRowsElementsWithoutNegativeElements_Visualize()
        {
            
            double[] arrTempMul = MatrixFunctionality.MultiplyRowsElementsWithoutNegativeElements();
            
            InitializeMul( arrTempMul.Length, 1);
            NumerateRowsAndCols_Mul();
            for (int i = 0, j=1; i < arrTempMul.Length; i++, j++)
            {
                if (arrTempMul[i]==1) {
                    DataGrid_Mul[0, i].Value = "-";
                }
                else
                {
                    DataGrid_Mul[0, i].Value = arrTempMul[i];
                }

            }

        }

        public void SumColumnElementsPositive_Visualize()
        {
            
            int[] arrTempSum = MatrixFunctionality.SumColumnElementsPositive();
            
            InitializeSum(arrTempSum.Length, 1);
            NumerateRowsAndCols_Sum();
            
            for (int i = 0, j = 1; i < arrTempSum.Length; i++, j++)
            {
                if (arrTempSum[i] == 0)
                {
                    DataGrid_Sum[0, i].Value = "-";
                }
                else
                {
                    DataGrid_Sum[0, i].Value = arrTempSum[i];
                }

            }

        }

        public void SumColumnElementsNegative_Visualize()
        {
            
            int[] arrTempSum = MatrixFunctionality.SumColumnElementsNegative();
            
            InitializeSumNeg(arrTempSum.Length, 1);
            NumerateRowsAndCols_SumNeg();
            
            for (int i = 0, j = 1; i < arrTempSum.Length; i++, j++)
            {
                if (arrTempSum[i] == 0)
                {
                    DataGrid_SumNeg[0, i].Value = "-";
                }
                else
                {
                    DataGrid_SumNeg[0, i].Value = arrTempSum[i];
                }

            }
        }
        public void TransposedMatrix_Visualize()
        {
            int[,] arrResult = MatrixFunctionality.TransposedMatrix();
            InitializeTransposed(arrResult.GetLength(0), arrResult.GetLength(1));
            NumerateRowsAndCols_Transposed();

            for (int i = 0; i < arrResult.GetLength(0); i++)
            {
                for (int j = 0; j < arrResult.GetLength(1); j++)
                {
                    DataGrid_Transposed[j, i].Value = arrResult[i, j];
                }
            }
            
        }

        public void MaxSumDiagon_Visualize()
        {
            int[] arrResult = MatrixFunctionality.MaxSumDiagon();
            InitializeMaxSumDiagon(arrResult.Length, 1);
            NumerateRowsAndCols_MaxSumDiagon();

            for (int i = 0; i < arrResult.Length; i++)
            {
                DataGrid_MaxSumDiagon[0, i].Value = arrResult[i];

            }

        }

        public void MinSumDiagon_Visualize()
        {
            int[] arrResult = MatrixFunctionality.MinSumDiagon();
            InitializeMinSumDiagon(arrResult.Length, 1);
            NumerateRowsAndCols_MinSumDiagon();
            for (int i = 0; i < arrResult.Length; i++)
            {
                DataGrid_MinSumDiagon[0, i].Value = arrResult[i];

            }
        }
    }
}
