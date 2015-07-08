using System;

namespace NeuralNetwork
{
    public class NeuralNetwork
    {
        readonly Random random = new Random();

        private double[][][] weights;
        private double[][] biases;

        public NeuralNetwork(int[] layerSizes)
        {
            weights = new double[layerSizes.Length - 1][][];

            for (int i = 0; i < layerSizes.Length - 1; i++)
            {
                weights[i] = GetRandomMatrix(layerSizes[i], layerSizes[i + 1]);
                biases[i] = GetRandomVector(layerSizes[i + 1]);
            }
        }

        private double[] GetRandomVector(int n)
        {
            var vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = random.NextDouble();
            }

            return vector;
        }

        private double[][] GetRandomMatrix(int m, int n)
        {
            var matrix = new double[m][];

            for (int i = 0; i < m; i++)
            {
                matrix[i] = GetRandomVector(n);
            }

            return matrix;
        }
    }
}
