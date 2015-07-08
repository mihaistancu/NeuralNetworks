using System;

namespace NeuralNetwork
{
    public class NeuralNetwork
    {
        private readonly double[][][] weights;
        private readonly double[][] biases;

        public NeuralNetwork(int[] layerSizes)
        {
            weights = new double[layerSizes.Length - 1][][];
            biases = new double[layerSizes.Length - 1][];

            for (int i = 0; i < layerSizes.Length - 1; i++)
            {
                weights[i] = Math.GetRandomMatrix(layerSizes[i], layerSizes[i + 1]);
                biases[i] = Math.GetRandomVector(layerSizes[i + 1]);
            }
        }

        public double[] FeedForward(double[] input)
        {
            double[] activations = input;

            for (int layer = 0; layer < weights.GetLength(0); layer++)
            {
                activations = GetActivations(layer, activations);
            }

            return activations;
        }

        private double[] GetActivations(int layer, double[] input)
        {
            return Math.Sigmoid(Math.Add(
                        Math.Product(weights[layer], input),
                        biases[layer]));
        }

        public void Train(TrainingRecord[] trainingData, int epochs, double learningRate)
        {
            for (int epoch = 0; epoch < epochs; epoch++)
            {
                var batches = Batch.Split(Batch.Shuffle(trainingData));

                foreach (var batch in batches)
                {
                    Train(batch, learningRate);
                }
            }
        }

        private void Train(TrainingRecord[] batch, double learningRate)
        {
            var gradient = new Gradient();

            foreach (var trainingRecord in batch)
            {
                var batchGradient = BackPropagate(trainingRecord);
                gradient.Weights = Math.Add(gradient.Weights, batchGradient.Weights);
                gradient.Biases = Math.Add(gradient.Biases, batchGradient.Biases);
            }

            for (int layer = 0; layer < weights.Length; layer++)
            {
                weights[layer] = Math.Subtract(
                    weights[layer],
                    Math.Product(learningRate/batch.Length, gradient.Weights[layer]));

                biases[layer] = Math.Subtract(
                    biases[layer],
                    Math.Product(learningRate/batch.Length, gradient.Biases[layer]));
            }
        }

        private Gradient BackPropagate(TrainingRecord record)
        {
            int layers = weights.Length;

            //Feedforward
            double[][] a = new double[layers][];
            double[][] z = new double[layers][];
            a[0] = record.Input;

            for (int layer = 1; layer < layers; layer++)
            {
                z[layer] = Math.Add(
                    Math.Product(weights[layer], a[layer - 1]),
                    biases[layer]);

                a[layer] = Math.Sigmoid(z[layer]);
            }

            //Backpropagate
            double[][] error = new double[layers][];

            error[0] = Math.HadamardProduct(
                Math.Subtract(a[layers - 1], record.Output),
                Math.SigmoidPrime(z[layers - 1]));

            for (int layer = layers - 1; layer > 1; layer++)
            {
                error[layer - 1] = Math.HadamardProduct(
                    Math.Product(weights[layer], error[layer]),
                    Math.SigmoidPrime(z[layer - 1]));
            }

            //Gradient
            var gradient = new Gradient();

            for (int layer = 1; layer < layers; layer++)
            {
                for (int j = 0; j < weights[layer].Length; j++)
                {
                    for (int k = 0; k < weights[layer][j].Length; k++)
                    {
                        gradient.Weights[layer][j][k] = a[layer - 1][k]*error[layer][j];
                    }
                }
            }

            gradient.Biases = error;

            return gradient;
        }
    }
}
