using System;
using System.Drawing;
using NeuralNetwork;
using Math = System.Math;

namespace DigitsClassifier
{
    class Benchmark
    {
        public double ComputeAccuracy(Network network, TrainingRecord[] trainingRecords)
        {
            var non_nines = 0;

            int success = 0;
            foreach (var trainingRecord in trainingRecords)
            {
                double[] result = network.FeedForward(trainingRecord.Input);
                success += AreEqual(result, trainingRecord.Output) ? 1 : 0;

                //SaveImageToDisk(trainingRecord, result);
            }

            return (double) success/trainingRecords.Length;
        }

        public void SaveImageToDisk(TrainingRecord record, double[] prediction)
        {
            var path = string.Format("d:\\{0}_{1}.bmp", Array.IndexOf(record.Output, 1), GetMaxIndex(prediction));

            var image = new Bitmap(28, 28);
            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    image.SetPixel(j,i,Color.FromArgb((int)record.Input[i*28+j], (int)record.Input[i*28+j], (int)record.Input[i*28+j]));
                }
            }

            image.Save(path);
        }

        public bool AreEqual(double[] expected, double[] actual)
        {
            return Math.Abs(GetMaxIndex(actual) - 1) < 0.01;
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
