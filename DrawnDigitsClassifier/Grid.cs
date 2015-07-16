using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrawnDigitsClassifier
{
    public partial class Grid : UserControl
    {
        private int rows;

        public int Rows
        {
            get { return rows; }
            set
            {
                rows = value;
                Repopulate();
            }
        }

        private int columns;

        public int Columns
        {
            get { return columns; }
            set
            {
                columns = value;
                Repopulate();
            }
        }

        private int cellSize;

        public int CellSize
        {
            get { return cellSize; }
            set
            {
                cellSize = value;
                Repopulate();
            }
        }

        public void Repopulate()
        {
            Size = new Size(columns*cellSize, rows*cellSize);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var checkBox = new CheckBox
                    {
                        Appearance = Appearance.Button,
                        Location = new Point(j*cellSize, i*cellSize),
                        Size = new Size(cellSize, cellSize)
                    };

                    Controls.Add(checkBox);
                }
            }
        }

        public double[] Input
        {
            get
            {
                return (
                    from object control in Controls
                    select ((CheckBox) control).Checked ? 1.0 : 0.0)
                    .ToArray();
            }
        }

        public void Clear()
        {
            foreach (var control in Controls)
            {
                ((CheckBox) control).Checked = false;
            }
        }

        public Grid()
        {
            InitializeComponent();
        }
    }
}
