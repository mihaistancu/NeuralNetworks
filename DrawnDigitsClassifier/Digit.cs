using System;
using System.Windows.Forms;

namespace DrawnDigitsClassifier
{
    public partial class Digit : UserControl
    {
        public Digit()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBox1.Text = "";
        }

        public double[] Value
        {
            get
            {
                var digit = Int32.Parse(textBox1.Text);
                var output = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                output[digit] = 1;
                return output;   
            }
            set
            {
                int maxIndex = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[maxIndex] < value[i])
                    {
                        maxIndex = i;
                    }
                }

                textBox1.Text = maxIndex.ToString();
            }
        }
    }
}
