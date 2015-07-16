using NeuralNetwork;

namespace DigitsClassifier
{
    class Benchmark
    {
        private readonly Network network;

        public Benchmark(Network network)
        {
            this.network = network;
        }

        public double AccuracyFor(TrainingRecord[] trainingRecords)
        {
            int success = 0;

            foreach (var trainingRecord in trainingRecords)
            {
                double[] result = network.FeedForward(trainingRecord.Input);
                success += System.Math.Abs(trainingRecord.Output[GetMaxIndex(result)] - 1) < .001 ? 1 : 0;
            }

            return (double) success/trainingRecords.Length;
        }

        private int GetMaxIndex(double[] vector)
        {
            int maxIndex = 0;
            
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > vector[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
