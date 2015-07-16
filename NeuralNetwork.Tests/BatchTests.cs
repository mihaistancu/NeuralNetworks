using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NeuralNetwork.Tests
{
    [TestClass]
    public class BatchTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            var b = Batch.Shuffle(a);

            var c = Batch.Split(b, 3);
        }

        
        [TestMethod]
        public void test()
        {
            var net = new Network(new[] {2, 2, 1});

            net.Weights[0][0][0] = .1;
            net.Weights[0][0][1] = .2;
            net.Weights[0][1][0] = .3;
            net.Weights[0][1][1] = .4;
            net.Weights[1][0][0] = .5;
            net.Weights[1][0][1] = .6;

            net.Biases[1][0] = .7;
            net.Biases[1][1] = .8;
            net.Biases[2][0] = .9;

            net.Train(new[]
            {
                new TrainingRecord
                {
                    Input = new[] {1.0, 1.0},
                    Output = new[] {0.0}
                }
                ,new TrainingRecord
                {
                    Input = new[] {0.0, 1.0},
                    Output = new[] {1.0}
                },
                new TrainingRecord
                {
                    Input = new[] {1.0, 0.0},
                    Output = new[] {1.0}
                }
                ,new TrainingRecord
                {
                    Input = new[] {0.0, 0.0},
                    Output = new[] {0.0}
                }
            }, 500, 10);

            var result = net.FeedForward(new[] {.1, .9});
            result = net.FeedForward(new[] { .9, .1 });
            result = net.FeedForward(new[] { .1, .1 });
            result = net.FeedForward(new[] { .9, .9 });
        }
    }
}
