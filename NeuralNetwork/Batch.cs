using System;
using System.Linq;

namespace NeuralNetwork
{
    public class Batch
    {
        private static readonly Random random = new Random();

        public static T[][] Split<T>(T[] batch, int size)
        {
            var batchCount = (int) System.Math.Ceiling((double)batch.Length/size);

            var batches = new T[batchCount][];

            for (int i = 0; i < batchCount; i++)
            {
                batches[i] = batch.Skip(i*size).Take(size).ToArray();
            }

            return batches;
        }

        public static T[] Shuffle<T>(T[] batch)
        {
            for (int i = 0; i < batch.Length; i++)
            {
                int r = i + (int)(random.NextDouble() * (batch.Length - i));
                T t = batch[r];
                batch[r] = batch[i];
                batch[i] = t;
            }

            return batch;
        }
    }
}
