using System;
using System.Linq;

namespace NeuralNetwork
{
    public class Math
    {
        private static readonly Random random = new Random();

        public static double[][] EmptyClone(double[][] matrix)
        {
            var result = new double[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new double[matrix[i].Length];
            }

            return result;
        }

        public static double[][][] EmptyClone(double[][][] matrix)
        {
            var result = new double[matrix.Length][][];

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new double[matrix[i].Length][];

                for (int j= 0; j< matrix[i].Length; j++)
                {
                    result[i][j] = new double[matrix[i][j].Length];
                }
            }

            return result;
        }

        public static double[] GetRandomVector(int n)
        {
            var vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = random.NextDouble() - .5;
            }

            return vector;
        }

        public static double[][] GetRandomMatrix(int m, int n)
        {
            var matrix = new double[m][];

            for (int i = 0; i < m; i++)
            {
                matrix[i] = GetRandomVector(n);
            }

            return matrix;
        }

        public static double[][] Transpose(double[][] matrix)
        {
            int matrixRows = matrix.Length;
            int matrixColumns = matrix[0].Length;
            
            var result = new double[matrixColumns][];

            for (int i = 0; i < matrixColumns; i++)
            {
                result[i] = new double[matrixRows];

                for (int j = 0; j < matrixRows; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;
        }

        public static double[] Product(double[][] matrix, double[] vector)
        {
            double[] result = new double[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = 0;

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result[i] += matrix[i][j]*vector[j];
                }
            }

            return result;
        }

        public static double[] Product(double scalar, double[] vector)
        {
            double[] result = new double[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = scalar * vector[i];
            }

            return result;
        }

        public static double[][] Product(double scalar, double[][] matrix)
        {
            double[][] result = new double[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new double[matrix[i].Length];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result[i][j] = scalar * matrix[i][j];
                }
            }

            return result;
        }

        public static double[][][] Product(double scalar, double[][][] matrix)
        {
            double[][][] result = new double[matrix.Length][][];

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new double[matrix[i].Length][];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result[i][j] = new double[matrix[i][j].Length];

                    for (int k = 0; k < matrix[i][j].Length; k++)
                    {
                        result[i][j][k] = scalar*matrix[i][j][k];
                    }
                }
            }

            return result;
        }

        public static double[] Subtract(double[] a, double[] b)
        {
            double[] result = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] - b[i];
            }

            return result;
        }

        public static double[][] Subtract(double[][] a, double[][] b)
        {
            double[][] result = new double[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = new double[a[i].Length];

                for (int j = 0; j < a[i].Length; j++)
                {
                    result[i][j] = a[i][j] - b[i][j];
                }
            }

            return result;
        }

        public static double[][][] Subtract(double[][][] a, double[][][] b)
        {
            double[][][] result = new double[a.Length][][];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = new double[a[i].Length][];

                for (int j = 0; j < a[i].Length; j++)
                {
                    result[i][j] = new double[a[i][j].Length];

                    for (int k = 0; k < a[i][j].Length; k++)
                    {
                        result[i][j][k] = a[i][j][k] - b[i][j][k];
                    }
                }
            }

            return result;
        }

        public static double[] Add(double[] a, double[] b)
        {
            double[] result = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] + b[i];
            }

            return result;
        }

        public static double[][] Add(double[][] a, double[][] b)
        {
            double[][] result = new double[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = new double[a[i].Length];

                for (int j = 0; j < a[i].Length; j++)
                {
                    result[i][j] = a[i][j] + b[i][j];
                }
            }

            return result;
        }

        public static double[][][] Add(double[][][] a, double[][][] b)
        {
            double[][][] result = new double[a.Length][][];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = new double[a[i].Length][];

                for (int j = 0; j < a[i].Length; j++)
                {
                    result[i][j] = new double[a[i][j].Length];

                    for (int k = 0; k < a[i][j].Length; k++)
                    {
                        result[i][j][k] = a[i][j][k] + b[i][j][k];
                    }
                }
            }

            return result;
        }

        public static double Sigmoid(double z)
        {
            return 1.0/(1.0 + System.Math.Exp(-z));
        }

        public static double SigmoidPrime(double z)
        {
            return Sigmoid(z) * (1 - Sigmoid(z));
        }

        public static double[] Sigmoid(double[] x)
        {
            return x.Select(Sigmoid).ToArray();
        }

        public static double[] SigmoidPrime(double[] x)
        {
            return x.Select(SigmoidPrime).ToArray();
        }

        public static double[] HadamardProduct(double[] a, double[] b)
        {
            double[] result = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] * b[i];
            }

            return result;
        }
    }
}
