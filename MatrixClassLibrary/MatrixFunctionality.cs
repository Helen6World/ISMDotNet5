using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClassLibrary
{
    public class MatrixFunctionality
    {
        public static int[,] Matrix;

        public MatrixFunctionality(int rowsCount = 1, int collsCount = 1)
        {
            Matrix = new int[rowsCount, collsCount];
        }
        public void FillWithRandomNumbers(int min = -50, int max = 50)
        {
            Random rnd = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = rnd.Next(min, max);
                }
            }
        }

        public int[,] GetMatrix()
        {
            return Matrix;
        }

        public int CountPositiveMatrixElements()
        {
            int count = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int MaxMatrixElement()
        {
            int max = 0;
            int[] array = new int[Matrix.GetLength(0) * Matrix.GetLength(1)];
            for (int i = 0, m = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    array[m] = Matrix[i, j];
                    m++;
                }
            }


            for (int i = 0, temp = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == array.Length - 1)
                {
                    if (array[i] == array[i - 1])
                    {
                        max = array[i];
                        break;
                    }
                }
                else if (!(i - 1 < 0))
                {
                    if (array[i] == array[i - 1])
                    {
                        max = array[i];
                        break;
                    }
                }
            }
            return max;
        }

        public int CountRowsWithoutZeros()
        {
            int count = 0;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 0)
                    {

                        count++;
                        break;
                    }


                }

            }
            return Matrix.GetLength(0) - count;
        }

        public int CountColsWithZeros()
        {
            int count = 0;
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (Matrix[j, i] == 0)
                    {

                        count++;
                        break;
                    }
                }
            }
            return count;
        }

        public int LongestRepeatedElementsSeria() {
            int[] arr = new int[Matrix.GetLength(0)];
            int temp = 0, max = Int32.MinValue;
            int rowNumber = -1;
            for (int i = 0, i_temp = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    for (int k = 1; k < Matrix.GetLength(1); k++) { 
                        if (Matrix[i,j] == Matrix[i, k])
                        {
                            temp++;
                        }
                    }


                }
                arr[i_temp] = temp;
                i_temp++;
                temp = 0;
            }
            max = arr[0];
            for (int i=0; i < arr.Length; i++)
            {
                
                if (arr[i] > max)
                {
                    max = arr[i];
                    rowNumber = i;
                }   
            }

            return rowNumber;
        }

        public  static double[] MultiplyRowsElementsWithoutNegativeElements()
        {
            bool flag = true;
            double[] arrResult = new double[Matrix.GetLength(0)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                arrResult[i] = 1;
            }

            for (int i = 0, i_temp = 0; i < Matrix.GetLength(0); i++, i_temp++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        arrResult[i_temp] *= Matrix[i, j];
                    }
                }
                flag = true;
            }
            return arrResult;
        }

        public static int[] SumColumnElementsPositive()
        {
            bool flag = true;
            int[] arrResult = new int[Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                arrResult[i] = 0;
            }

            for (int i = 0, i_temp = 0; i < Matrix.GetLength(1); i++, i_temp++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (Matrix[j, i] < 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        arrResult[i_temp] += Matrix[j, i];
                    }
                }
                flag = true;
                
            }
            return arrResult;
        }

        public static int[] SumColumnElementsNegative()
        {
            bool flag = false;
            int[] arrResult = new int[Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                arrResult[i] = 0;
            }

            for (int i = 0, i_temp = 0; i < Matrix.GetLength(1); i++, i_temp++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (Matrix[j, i] < 0)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        arrResult[i_temp] += Matrix[j, i];
                    }
                }
                flag = false;

            }
            return arrResult;
        }

        public static int[,] TransposedMatrix()
        {
            
            int[,] arrResult = new int[Matrix.GetLength(0), Matrix.GetLength(1)];
            

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    arrResult[i, j] = Matrix[j,i];
                }
                   

            }
            return arrResult;
        }

        public  int MaxElemSumDiagon() {
            int[] arrResult = MaxSumDiagon();
            int max = arrResult[0];
            for (int i=1; i< arrResult.Length; i++)
            {
                if (arrResult[i] > max)
                {
                    max = arrResult[i];
                }
            }
            return max;
        }

        public static int[] MaxSumDiagon()
        {

            int[] arrResult = new int[2*(Matrix.GetLength(0)-1)];
            int sum = 0;

            for (int i = 1, i_temp = Matrix.GetLength(0)-1; i < Matrix.GetLength(0); i++, i_temp++)
            {
                for (int l = i, m=0; l < Matrix.GetLength(1); l++, m++)
                {
                    sum += Matrix[l, m];
                }
                arrResult[i_temp] = sum;
                sum = 0;


            }
            sum = 0;
            for (int i = 1, i_temp = Matrix.GetLength(0) - 2; i_temp!=-1; i++, i_temp--)
            {
                for (int l = 0, m = i; m < Matrix.GetLength(1); l++, m++)
                {
                    sum += Matrix[l, m];
                }
                arrResult[i_temp] = sum;
                sum = 0;


            }
            return arrResult;

         
        }

        public int MinElemSumDiagon()
        {
            int[] arrResult = MinSumDiagon();
            int min = Math.Abs(arrResult[0]);
            for (int i = 1; i < arrResult.Length; i++)
            {
                if (Math.Abs(arrResult[i]) < min)
                {
                    min = Math.Abs(arrResult[i]);
                }
            }
            return min;
        }

        public static int[] MinSumDiagon()
        {

            int[] arrResult = new int[2 * (Matrix.GetLength(0) - 1)];
            int sum = 0, flag = 0;

            for (int i = 1, i_temp = 1; i < Matrix.GetLength(0)-1; i++, i_temp++)
            {
                for (int l = 0, m = i; m != -1; l++, m--)
                {
                    if (flag==0)
                    {
                        arrResult[0] = Matrix[0, 0];
                        flag++;
                    }
                    
                    sum += Matrix[l, m];
                    
                    
                }
                arrResult[i_temp] = sum;
                sum = 0;


            }
            sum = 0;
            flag = 0;
            for (int i = Matrix.GetLength(0) - 2, i_temp = arrResult.Length - 2; i != 0; i--, i_temp--)
            {
                for (int l = i, m = Matrix.GetLength(0) - 1; l != Matrix.GetLength(0); l++, m--)
                {
                    if (flag == 0)
                    {
                        arrResult[arrResult.Length-1] = Matrix[Matrix.GetLength(0) - 1, Matrix.GetLength(1) - 1];
                        flag++;
                    }

                    sum += Matrix[l, m];

                }
                arrResult[i_temp] = sum;
                sum = 0;
            }

            return arrResult;
        }
    }
}
