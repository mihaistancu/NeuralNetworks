namespace NeuralNetwork
{
    public class Network
    {
        public readonly double[][][] Weights;
        public readonly double[][] Biases;

        public Network(int[] layerSizes)
        {
            Weights = new double[layerSizes.Length - 1][][];
            
            for (int i = 0; i < layerSizes.Length - 1; i++)
            {
                Weights[i] = Math.GetRandomMatrix(layerSizes[i + 1], layerSizes[i]);
            }

            Biases = new double[layerSizes.Length][];
            
            for (int i = 0; i < layerSizes.Length; i++)
            {
                Biases[i] = Math.GetRandomVector(layerSizes[i]);
            }
        }

        public double[] FeedForward(double[] input)
        {
            double[] activations = input;

            for (int layer = 0; layer < Weights.Length; layer++)
            {
                activations = Math.Sigmoid(Math.Add(
                    Math.Product(Weights[layer], activations),
                    Biases[layer + 1]));
            }

            return activations;
        }

        public void Train(TrainingRecord[] trainingData, int epochs, double learningRate)
        {
            for (int epoch = 0; epoch < epochs; epoch++)
            {
                var batches = Batch.Split(Batch.Shuffle(trainingData), 10);

                foreach (var batch in batches)
                {
                    Train(batch, learningRate);
                }
            }
        }

        private void Train(TrainingRecord[] batch, double learningRate)
        {
            var gradient = new Gradient
            {
                Weights = Math.EmptyClone(Weights),
                Biases = Math.EmptyClone(Biases)
            };

            foreach (var trainingRecord in batch)
            {
                var batchGradient = BackPropagate(trainingRecord);
                gradient.Weights = Math.Add(gradient.Weights, batchGradient.Weights);
                gradient.Biases = Math.Add(gradient.Biases, batchGradient.Biases);
            }

            for (int layer = 0; layer < Weights.Length; layer++)
            {
                Weights[layer] = Math.Subtract(
                    Weights[layer],
                    Math.Product(learningRate/batch.Length, gradient.Weights[layer]));
            }

            for (int layer = 0; layer < Biases.Length; layer++)
            {
                Biases[layer] = Math.Subtract(
                    Biases[layer],
                    Math.Product(learningRate/batch.Length, gradient.Biases[layer]));
            }
        }

        private Gradient BackPropagate(TrainingRecord record)
        {
            int layers = Weights.Length;

            //Feedforward
            double[][] a = new double[layers + 1][];
            double[][] z = new double[layers + 1][];
            a[0] = record.Input;

            for (int layer = 0; layer < layers; layer++)
            {
                z[layer + 1] = Math.Add(
                    Math.Product(Weights[layer], a[layer]),
                    Biases[layer + 1]);

                a[layer + 1] = Math.Sigmoid(z[layer + 1]);
            }

            //Backpropagate
            double[][] delta = Math.EmptyClone(Biases);

            delta[layers] = Math.HadamardProduct(
                Math.Subtract(a[layers], record.Output),
                Math.SigmoidPrime(z[layers]));

            for (int layer = layers - 1; layer > 0; layer--)
            {
                delta[layer] = Math.HadamardProduct(
                    Math.Product(Math.Transpose(Weights[layer]), delta[layer + 1]),
                    Math.SigmoidPrime(z[layer]));
            }

            //Gradient
            var gradient = new Gradient {Weights = Math.EmptyClone(Weights)};

            for (int layer = 0; layer < layers; layer++)
            {   
                for (int j = 0; j < Weights[layer].Length; j++)
                {
                    for (int k = 0; k < Weights[layer][j].Length; k++)
                    {
                        gradient.Weights[layer][j][k] = a[layer][k]*delta[layer + 1][j];
                    }
                }
            }

            gradient.Biases = delta;

            return gradient;
        }
    }
}
