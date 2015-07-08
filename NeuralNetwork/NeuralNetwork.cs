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
            double[] activations = null;

            for (int i = 0; i < weights.GetLength(0); i++)
            {
                activations = Math.Sigmoid(Math.Add(
                        Math.Product(weights[i], activations),
                        biases[i]));
            }

            return activations;
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
            var gradient = BackPropagate(batch);

            for (int i = 0; i < weights.GetLength(0); i++)
            {
                weights[i] = Math.Subtract(
                    weights[i],
                    Math.Product(learningRate/batch.Length, gradient.Weights[i]));

                biases[i] = Math.Subtract(
                    biases[i],
                    Math.Product(learningRate/batch.Length, gradient.Biases[i]));
            }
        }

        private Gradient BackPropagate(TrainingRecord[] records)
        {
            throw new NotImplementedException();
        }
    }
}
