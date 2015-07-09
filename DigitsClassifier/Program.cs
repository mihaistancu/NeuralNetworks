using System;
using MnistDataParser;
using NeuralNetwork;

namespace DigitsClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagesFile = args[0];
            var labelsFile = args[1];

            var mnistDataParser = new Parser();
            var trainingRecords = mnistDataParser.Parse(imagesFile, labelsFile);
            
            var inputLayerLength = trainingRecords[0].Input.Length;

            var neuralNetwork = new Network(new[] {inputLayerLength, 25, 10});
            neuralNetwork.Train(trainingRecords, 25, 0.1);
            
            var benchmark = new Benchmark();
            double successRate = benchmark.ComputeAccuracy(neuralNetwork, trainingRecords);
            Console.WriteLine("Success rate: {0} %", successRate);
        }
    }
}
