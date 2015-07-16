using System;
using NeuralNetwork;

namespace DigitsClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var mnistDataParser = new MnistDataParser();
            var trainingRecords = mnistDataParser.Parse("d:\\train-images", "d:\\train-labels");
            var testRecords = mnistDataParser.Parse("d:\\test-images", "d:\\test-labels");

            var neuralNetwork = new Network(new[] {784, 30, 10});
            var benchmark = new Benchmark(neuralNetwork);

            for (double accuracy = 0; accuracy < .9;)
            {
                accuracy = benchmark.AccuracyFor(testRecords);
                Console.WriteLine("Success rate: {0} %", accuracy*100);

                neuralNetwork.Train(trainingRecords, .01, 10);
            }
        }
    }
}
