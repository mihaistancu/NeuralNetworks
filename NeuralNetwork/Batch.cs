using System;

namespace NeuralNetwork
{
    class Batch
    {
        private static readonly Random random = new Random();

        public static T[][] Split<T>(T[] batch, int size)
        {
            int batchCount = batch.Length/size;
            var batches = new T[batchCount][];

            for (int i = 0; i < batchCount; i++)
            {
                batches[i] = new T[size];
                for (int j = 0; j < size && i + j < batch.Length;j++)
                {
                    batches[i][j] = batch[i*j + j];
                }
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
