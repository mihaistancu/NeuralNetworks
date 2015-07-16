using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeuralNetwork;

namespace DrawnDigitsClassifier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UpdateNetwork();
        }

        private Network network;

        private void GridConfigurationChanged(object sender, System.EventArgs e)
        {
            try
            {
                grid.Rows = Int32.Parse(rowsTextBox.Text);
                grid.Columns = Int32.Parse(columnsTextBox.Text);
                grid.CellSize = Int32.Parse(cellSizeTextBox.Text);

                UpdateNetwork();
            }
            catch
            {   
            }
        }
        
        private void UpdateNetwork()
        {
            var inputLayer = grid.Rows * grid.Columns;
            var hiddenLayer = Int32.Parse(hiddenLayerTextBox.Text);
            const int outputLayer = 10;

            network = new Network(new[] {inputLayer, hiddenLayer, outputLayer});
        }

        readonly List<TrainingRecord> trainingData = new List<TrainingRecord>();

        private void AddToTrainingData(object sender, EventArgs e)
        {
            trainingData.Add(new TrainingRecord
            {
                Input = grid.Input,
                Output = digit.Value
            });    

            grid.Clear();
            digit.Clear();
        }

        private void Train(object sender, EventArgs e)
        {
            var learnnigRate = double.Parse(learningRateTextBox.Text);
            var epochs = Int32.Parse(epochsTextBox.Text);
            const int miniBatchSize = 10;

            for (int epoch = 0; epoch < epochs; epoch++)
            {
                network.Train(trainingData.ToArray(), learnnigRate, miniBatchSize);
            }
        }
        
        private void Recognize(object sender, EventArgs e)
        {
            digit.Value = network.FeedForward(grid.Input);
        }
    }
}
