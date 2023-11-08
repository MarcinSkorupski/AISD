namespace Sortowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnInsertSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.cbSwitch = new System.Windows.Forms.CheckBox();
            this.nudInputRandom = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.lblTimeSeconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(90, 349);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.btnBubbleSort.TabIndex = 0;
            this.btnBubbleSort.Text = "BS";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(208, 349);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionSort.TabIndex = 1;
            this.btnSelectionSort.Text = "SS";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertSort
            // 
            this.btnInsertSort.Location = new System.Drawing.Point(331, 349);
            this.btnInsertSort.Name = "btnInsertSort";
            this.btnInsertSort.Size = new System.Drawing.Size(75, 23);
            this.btnInsertSort.TabIndex = 2;
            this.btnInsertSort.Text = "IS";
            this.btnInsertSort.UseVisualStyleBackColor = true;
            this.btnInsertSort.Click += new System.EventHandler(this.btnInsertSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(449, 349);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(75, 23);
            this.btnMergeSort.TabIndex = 3;
            this.btnMergeSort.Text = "MS";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(572, 349);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(75, 23);
            this.btnQuickSort.TabIndex = 4;
            this.btnQuickSort.Text = "QS";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(125, 71);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 5;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(125, 193);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(100, 20);
            this.tbOutput.TabIndex = 6;
            this.tbOutput.TextChanged += new System.EventHandler(this.tbOutput_TextChanged);
            // 
            // cbSwitch
            // 
            this.cbSwitch.AutoSize = true;
            this.cbSwitch.Location = new System.Drawing.Point(407, 74);
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Size = new System.Drawing.Size(15, 14);
            this.cbSwitch.TabIndex = 7;
            this.cbSwitch.UseVisualStyleBackColor = true;
            this.cbSwitch.CheckedChanged += new System.EventHandler(this.cbSwitch_CheckedChanged);
            // 
            // nudInputRandom
            // 
            this.nudInputRandom.Enabled = false;
            this.nudInputRandom.Location = new System.Drawing.Point(449, 71);
            this.nudInputRandom.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudInputRandom.Name = "nudInputRandom";
            this.nudInputRandom.Size = new System.Drawing.Size(120, 20);
            this.nudInputRandom.TabIndex = 8;
            this.nudInputRandom.ValueChanged += new System.EventHandler(this.nudInputRandom_ValueChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(469, 115);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTimeText
            // 
            this.lblTimeText.AutoSize = true;
            this.lblTimeText.Location = new System.Drawing.Point(452, 196);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(33, 13);
            this.lblTimeText.TabIndex = 10;
            this.lblTimeText.Text = "Czas:";
            // 
            // lblTimeSeconds
            // 
            this.lblTimeSeconds.AutoSize = true;
            this.lblTimeSeconds.Location = new System.Drawing.Point(491, 196);
            this.lblTimeSeconds.Name = "lblTimeSeconds";
            this.lblTimeSeconds.Size = new System.Drawing.Size(30, 13);
            this.lblTimeSeconds.TabIndex = 11;
            this.lblTimeSeconds.Text = "0.0 s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeSeconds);
            this.Controls.Add(this.lblTimeText);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.nudInputRandom);
            this.Controls.Add(this.cbSwitch);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnInsertSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudInputRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.CheckBox cbSwitch;
        private System.Windows.Forms.NumericUpDown nudInputRandom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTimeText;
        private System.Windows.Forms.Label lblTimeSeconds;
    }
}

