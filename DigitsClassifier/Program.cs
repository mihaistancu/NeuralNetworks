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
                
            while (true)
            {
                neuralNetwork.Train(trainingRecords, 1, .1);

                Console.WriteLine("Success rate: {0}", benchmark.AccuracyFor(testRecords));
            }
        }
    }
}
