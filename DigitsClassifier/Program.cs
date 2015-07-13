using System;
using NeuralNetwork;

namespace DigitsClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagesFile = "d:\\train-images";
            var labelsFile = "d:\\train-labels";

            var mnistDataParser = new MnistDataParser();
            var trainingRecords = mnistDataParser.Parse(imagesFile, labelsFile);
            
            var inputLayerLength = trainingRecords[0].Input.Length;

            var neuralNetwork = new Network(new[] {inputLayerLength, 30, 10});
            neuralNetwork.Train(trainingRecords, 1, 1);
            
            var benchmark = new Benchmark();
            double successRate = benchmark.ComputeAccuracy(neuralNetwork, trainingRecords);
            Console.WriteLine("Success rate: {0} %", successRate);
        }
    }
}
