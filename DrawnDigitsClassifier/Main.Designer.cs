namespace DrawnDigitsClassifier
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cellSizeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epochsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.learningRateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hiddenLayerTextBox = new System.Windows.Forms.TextBox();
            this.AddToTrainingSetButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RecognizeButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.digit = new DrawnDigitsClassifier.Digit();
            this.grid = new DrawnDigitsClassifier.Grid();
            this.SuspendLayout();
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(143, 43);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(100, 22);
            this.rowsTextBox.TabIndex = 1;
            this.rowsTextBox.Text = "7";
            this.rowsTextBox.TextChanged += new System.EventHandler(this.GridConfigurationChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columns";
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(143, 88);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(100, 22);
            this.columnsTextBox.TabIndex = 3;
            this.columnsTextBox.Text = "5";
            this.columnsTextBox.TextChanged += new System.EventHandler(this.GridConfigurationChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cell Size";
            // 
            // cellSizeTextBox
            // 
            this.cellSizeTextBox.Location = new System.Drawing.Point(143, 133);
            this.cellSizeTextBox.Name = "cellSizeTextBox";
            this.cellSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cellSizeTextBox.TabIndex = 5;
            this.cellSizeTextBox.Text = "30";
            this.cellSizeTextBox.TextChanged += new System.EventHandler(this.GridConfigurationChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Epochs";
            // 
            // epochsTextBox
            // 
            this.epochsTextBox.Location = new System.Drawing.Point(12, 133);
            this.epochsTextBox.Name = "epochsTextBox";
            this.epochsTextBox.Size = new System.Drawing.Size(100, 22);
            this.epochsTextBox.TabIndex = 11;
            this.epochsTextBox.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Learning Rate";
            // 
            // learningRateTextBox
            // 
            this.learningRateTextBox.Location = new System.Drawing.Point(12, 88);
            this.learningRateTextBox.Name = "learningRateTextBox";
            this.learningRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.learningRateTextBox.TabIndex = 9;
            this.learningRateTextBox.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hidden Layer";
            // 
            // hiddenLayerTextBox
            // 
            this.hiddenLayerTextBox.Location = new System.Drawing.Point(12, 43);
            this.hiddenLayerTextBox.Name = "hiddenLayerTextBox";
            this.hiddenLayerTextBox.Size = new System.Drawing.Size(100, 22);
            this.hiddenLayerTextBox.TabIndex = 7;
            this.hiddenLayerTextBox.Text = "40";
            // 
            // AddToTrainingSetButton
            // 
            this.AddToTrainingSetButton.Location = new System.Drawing.Point(143, 192);
            this.AddToTrainingSetButton.Name = "AddToTrainingSetButton";
            this.AddToTrainingSetButton.Size = new System.Drawing.Size(100, 53);
            this.AddToTrainingSetButton.TabIndex = 13;
            this.AddToTrainingSetButton.Text = "Add digit to training set";
            this.AddToTrainingSetButton.UseVisualStyleBackColor = true;
            this.AddToTrainingSetButton.Click += new System.EventHandler(this.AddToTrainingData);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(15, 270);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(228, 45);
            this.TrainButton.TabIndex = 14;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.Train);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Digit";
            // 
            // RecognizeButton
            // 
            this.RecognizeButton.Location = new System.Drawing.Point(15, 335);
            this.RecognizeButton.Name = "RecognizeButton";
            this.RecognizeButton.Size = new System.Drawing.Size(228, 45);
            this.RecognizeButton.TabIndex = 17;
            this.RecognizeButton.Text = "Recognize";
            this.RecognizeButton.UseVisualStyleBackColor = true;
            this.RecognizeButton.Click += new System.EventHandler(this.Recognize);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "20";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 88);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "10";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "30";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "30";
            this.textBox3.TextChanged += new System.EventHandler(this.GridConfigurationChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "5";
            this.textBox2.TextChanged += new System.EventHandler(this.GridConfigurationChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "7";
            this.textBox1.TextChanged += new System.EventHandler(this.GridConfigurationChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add digit to training set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddToTrainingData);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "Recognize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Recognize);
            // 
            // digit
            // 
            this.digit.Location = new System.Drawing.Point(15, 213);
            this.digit.Name = "digit";
            this.digit.Size = new System.Drawing.Size(110, 32);
            this.digit.TabIndex = 18;
            // 
            // grid
            // 
            this.grid.CellSize = 20;
            this.grid.Columns = 5;
            this.grid.Location = new System.Drawing.Point(265, 23);
            this.grid.Name = "grid";
            this.grid.Rows = 7;
            this.grid.Size = new System.Drawing.Size(100, 140);
            this.grid.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(388, 402);
            this.Controls.Add(this.digit);
            this.Controls.Add(this.RecognizeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.AddToTrainingSetButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.epochsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.learningRateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hiddenLayerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cellSizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.grid);
            this.Name = "Main";
            this.Text = "Digits Classifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid grid;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox columnsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cellSizeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epochsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox learningRateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hiddenLayerTextBox;
        private System.Windows.Forms.Button AddToTrainingSetButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RecognizeButton;
        private Digit digit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;



    }
}

