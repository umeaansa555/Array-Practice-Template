namespace ArrayPractice
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.runButton = new System.Windows.Forms.Button();
            this.array1Label = new System.Windows.Forms.Label();
            this.array1Output = new System.Windows.Forms.Label();
            this.array2Output = new System.Windows.Forms.Label();
            this.array2Label = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.array1Group = new System.Windows.Forms.GroupBox();
            this.matchOutput = new System.Windows.Forms.Label();
            this.matchLabel = new System.Windows.Forms.Label();
            this.threeOutput = new System.Windows.Forms.Label();
            this.threeLabel = new System.Windows.Forms.Label();
            this.evenOutput = new System.Windows.Forms.Label();
            this.evenLabel = new System.Windows.Forms.Label();
            this.averageOutput = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.zeroOutput = new System.Windows.Forms.Label();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.reverseOutput = new System.Windows.Forms.Label();
            this.reverseLabel = new System.Windows.Forms.Label();
            this.swap2Output = new System.Windows.Forms.Label();
            this.swap2Label = new System.Windows.Forms.Label();
            this.swap1Output = new System.Windows.Forms.Label();
            this.swap1Label = new System.Windows.Forms.Label();
            this.enrichmentBox = new System.Windows.Forms.GroupBox();
            this.array1Group.SuspendLayout();
            this.enrichmentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Goldenrod;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(29, 69);
            this.runButton.Margin = new System.Windows.Forms.Padding(2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(195, 25);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // array1Label
            // 
            this.array1Label.AutoSize = true;
            this.array1Label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.array1Label.ForeColor = System.Drawing.Color.White;
            this.array1Label.Location = new System.Drawing.Point(26, 105);
            this.array1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array1Label.Name = "array1Label";
            this.array1Label.Size = new System.Drawing.Size(42, 13);
            this.array1Label.TabIndex = 2;
            this.array1Label.Text = "Array 1";
            // 
            // array1Output
            // 
            this.array1Output.BackColor = System.Drawing.Color.White;
            this.array1Output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.array1Output.ForeColor = System.Drawing.Color.Black;
            this.array1Output.Location = new System.Drawing.Point(29, 126);
            this.array1Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array1Output.Name = "array1Output";
            this.array1Output.Size = new System.Drawing.Size(195, 20);
            this.array1Output.TabIndex = 3;
            this.array1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // array2Output
            // 
            this.array2Output.BackColor = System.Drawing.Color.White;
            this.array2Output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.array2Output.ForeColor = System.Drawing.Color.Black;
            this.array2Output.Location = new System.Drawing.Point(29, 171);
            this.array2Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array2Output.Name = "array2Output";
            this.array2Output.Size = new System.Drawing.Size(195, 20);
            this.array2Output.TabIndex = 5;
            this.array2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // array2Label
            // 
            this.array2Label.AutoSize = true;
            this.array2Label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.array2Label.ForeColor = System.Drawing.Color.White;
            this.array2Label.Location = new System.Drawing.Point(26, 153);
            this.array2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array2Label.Name = "array2Label";
            this.array2Label.Size = new System.Drawing.Size(42, 13);
            this.array2Label.TabIndex = 4;
            this.array2Label.Text = "Array 2";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Black;
            this.maxOutput.Location = new System.Drawing.Point(151, 29);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(43, 20);
            this.maxOutput.TabIndex = 7;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(109, 33);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(28, 13);
            this.maxLabel.TabIndex = 6;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-1, -3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(501, 52);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Fun With Arrays";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // array1Group
            // 
            this.array1Group.Controls.Add(this.matchOutput);
            this.array1Group.Controls.Add(this.matchLabel);
            this.array1Group.Controls.Add(this.threeOutput);
            this.array1Group.Controls.Add(this.threeLabel);
            this.array1Group.Controls.Add(this.evenOutput);
            this.array1Group.Controls.Add(this.evenLabel);
            this.array1Group.Controls.Add(this.averageOutput);
            this.array1Group.Controls.Add(this.averageLabel);
            this.array1Group.Controls.Add(this.maxLabel);
            this.array1Group.Controls.Add(this.maxOutput);
            this.array1Group.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.array1Group.ForeColor = System.Drawing.Color.White;
            this.array1Group.Location = new System.Drawing.Point(254, 63);
            this.array1Group.Margin = new System.Windows.Forms.Padding(2);
            this.array1Group.Name = "array1Group";
            this.array1Group.Padding = new System.Windows.Forms.Padding(2);
            this.array1Group.Size = new System.Drawing.Size(217, 183);
            this.array1Group.TabIndex = 11;
            this.array1Group.TabStop = false;
            this.array1Group.Text = "Array Stats";
            // 
            // matchOutput
            // 
            this.matchOutput.BackColor = System.Drawing.Color.White;
            this.matchOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchOutput.ForeColor = System.Drawing.Color.Black;
            this.matchOutput.Location = new System.Drawing.Point(151, 150);
            this.matchOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchOutput.Name = "matchOutput";
            this.matchOutput.Size = new System.Drawing.Size(43, 20);
            this.matchOutput.TabIndex = 21;
            this.matchOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchLabel
            // 
            this.matchLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchLabel.ForeColor = System.Drawing.Color.White;
            this.matchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.matchLabel.Location = new System.Drawing.Point(23, 144);
            this.matchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(115, 31);
            this.matchLabel.TabIndex = 20;
            this.matchLabel.Text = "Matching values in matching positions";
            this.matchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // threeOutput
            // 
            this.threeOutput.BackColor = System.Drawing.Color.White;
            this.threeOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOutput.ForeColor = System.Drawing.Color.Black;
            this.threeOutput.Location = new System.Drawing.Point(151, 119);
            this.threeOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threeOutput.Name = "threeOutput";
            this.threeOutput.Size = new System.Drawing.Size(43, 20);
            this.threeOutput.TabIndex = 19;
            this.threeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeLabel
            // 
            this.threeLabel.AutoSize = true;
            this.threeLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeLabel.ForeColor = System.Drawing.Color.White;
            this.threeLabel.Location = new System.Drawing.Point(43, 121);
            this.threeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threeLabel.Name = "threeLabel";
            this.threeLabel.Size = new System.Drawing.Size(106, 13);
            this.threeLabel.TabIndex = 18;
            this.threeLabel.Text = "Total number of 3\'s";
            this.threeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // evenOutput
            // 
            this.evenOutput.BackColor = System.Drawing.Color.White;
            this.evenOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenOutput.ForeColor = System.Drawing.Color.Black;
            this.evenOutput.Location = new System.Drawing.Point(151, 89);
            this.evenOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.evenOutput.Name = "evenOutput";
            this.evenOutput.Size = new System.Drawing.Size(43, 20);
            this.evenOutput.TabIndex = 13;
            this.evenOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evenLabel
            // 
            this.evenLabel.AutoSize = true;
            this.evenLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenLabel.ForeColor = System.Drawing.Color.White;
            this.evenLabel.Location = new System.Drawing.Point(27, 93);
            this.evenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.evenLabel.Name = "evenLabel";
            this.evenLabel.Size = new System.Drawing.Size(121, 13);
            this.evenLabel.TabIndex = 12;
            this.evenLabel.Text = "Sum of all Even Values";
            this.evenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // averageOutput
            // 
            this.averageOutput.BackColor = System.Drawing.Color.White;
            this.averageOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageOutput.ForeColor = System.Drawing.Color.Black;
            this.averageOutput.Location = new System.Drawing.Point(151, 60);
            this.averageOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageOutput.Name = "averageOutput";
            this.averageOutput.Size = new System.Drawing.Size(43, 20);
            this.averageOutput.TabIndex = 11;
            this.averageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.ForeColor = System.Drawing.Color.White;
            this.averageLabel.Location = new System.Drawing.Point(35, 63);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(113, 13);
            this.averageLabel.TabIndex = 10;
            this.averageLabel.Text = "Average of all Values";
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zeroOutput
            // 
            this.zeroOutput.BackColor = System.Drawing.Color.White;
            this.zeroOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroOutput.ForeColor = System.Drawing.Color.Black;
            this.zeroOutput.Location = new System.Drawing.Point(119, 49);
            this.zeroOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zeroOutput.Name = "zeroOutput";
            this.zeroOutput.Size = new System.Drawing.Size(43, 20);
            this.zeroOutput.TabIndex = 17;
            this.zeroOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroLabel.ForeColor = System.Drawing.Color.White;
            this.zeroLabel.Location = new System.Drawing.Point(31, 52);
            this.zeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(83, 13);
            this.zeroLabel.TabIndex = 16;
            this.zeroLabel.Text = "First Index of 0";
            this.zeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reverseOutput
            // 
            this.reverseOutput.BackColor = System.Drawing.Color.White;
            this.reverseOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseOutput.ForeColor = System.Drawing.Color.Black;
            this.reverseOutput.Location = new System.Drawing.Point(29, 226);
            this.reverseOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reverseOutput.Name = "reverseOutput";
            this.reverseOutput.Size = new System.Drawing.Size(195, 20);
            this.reverseOutput.TabIndex = 13;
            this.reverseOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reverseLabel
            // 
            this.reverseLabel.AutoSize = true;
            this.reverseLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseLabel.ForeColor = System.Drawing.Color.White;
            this.reverseLabel.Location = new System.Drawing.Point(26, 205);
            this.reverseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reverseLabel.Name = "reverseLabel";
            this.reverseLabel.Size = new System.Drawing.Size(117, 13);
            this.reverseLabel.TabIndex = 12;
            this.reverseLabel.Text = "Array 1 Reverse Order";
            // 
            // swap2Output
            // 
            this.swap2Output.BackColor = System.Drawing.Color.White;
            this.swap2Output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swap2Output.ForeColor = System.Drawing.Color.Black;
            this.swap2Output.Location = new System.Drawing.Point(241, 104);
            this.swap2Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swap2Output.Name = "swap2Output";
            this.swap2Output.Size = new System.Drawing.Size(178, 20);
            this.swap2Output.TabIndex = 17;
            this.swap2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // swap2Label
            // 
            this.swap2Label.AutoSize = true;
            this.swap2Label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swap2Label.ForeColor = System.Drawing.Color.White;
            this.swap2Label.Location = new System.Drawing.Point(238, 82);
            this.swap2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swap2Label.Name = "swap2Label";
            this.swap2Label.Size = new System.Drawing.Size(135, 13);
            this.swap2Label.TabIndex = 16;
            this.swap2Label.Text = "Array 2 swap with array 1";
            // 
            // swap1Output
            // 
            this.swap1Output.BackColor = System.Drawing.Color.White;
            this.swap1Output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swap1Output.ForeColor = System.Drawing.Color.Black;
            this.swap1Output.Location = new System.Drawing.Point(241, 52);
            this.swap1Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swap1Output.Name = "swap1Output";
            this.swap1Output.Size = new System.Drawing.Size(178, 20);
            this.swap1Output.TabIndex = 15;
            this.swap1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // swap1Label
            // 
            this.swap1Label.AutoSize = true;
            this.swap1Label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swap1Label.ForeColor = System.Drawing.Color.White;
            this.swap1Label.Location = new System.Drawing.Point(238, 29);
            this.swap1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swap1Label.Name = "swap1Label";
            this.swap1Label.Size = new System.Drawing.Size(135, 13);
            this.swap1Label.TabIndex = 14;
            this.swap1Label.Text = "Array 1 swap with array 2";
            // 
            // enrichmentBox
            // 
            this.enrichmentBox.Controls.Add(this.swap2Output);
            this.enrichmentBox.Controls.Add(this.zeroLabel);
            this.enrichmentBox.Controls.Add(this.swap2Label);
            this.enrichmentBox.Controls.Add(this.zeroOutput);
            this.enrichmentBox.Controls.Add(this.swap1Output);
            this.enrichmentBox.Controls.Add(this.swap1Label);
            this.enrichmentBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrichmentBox.ForeColor = System.Drawing.Color.White;
            this.enrichmentBox.Location = new System.Drawing.Point(29, 274);
            this.enrichmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.enrichmentBox.Name = "enrichmentBox";
            this.enrichmentBox.Padding = new System.Windows.Forms.Padding(2);
            this.enrichmentBox.Size = new System.Drawing.Size(442, 137);
            this.enrichmentBox.TabIndex = 18;
            this.enrichmentBox.TabStop = false;
            this.enrichmentBox.Text = "Enrichment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(499, 434);
            this.Controls.Add(this.enrichmentBox);
            this.Controls.Add(this.reverseOutput);
            this.Controls.Add(this.reverseLabel);
            this.Controls.Add(this.array1Group);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.array2Output);
            this.Controls.Add(this.array2Label);
            this.Controls.Add(this.array1Output);
            this.Controls.Add(this.array1Label);
            this.Controls.Add(this.runButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Arrays";
            this.array1Group.ResumeLayout(false);
            this.array1Group.PerformLayout();
            this.enrichmentBox.ResumeLayout(false);
            this.enrichmentBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label array1Label;
        private System.Windows.Forms.Label array1Output;
        private System.Windows.Forms.Label array2Output;
        private System.Windows.Forms.Label array2Label;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox array1Group;
        private System.Windows.Forms.Label matchOutput;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Label threeOutput;
        private System.Windows.Forms.Label threeLabel;
        private System.Windows.Forms.Label zeroOutput;
        private System.Windows.Forms.Label zeroLabel;
        private System.Windows.Forms.Label evenOutput;
        private System.Windows.Forms.Label evenLabel;
        private System.Windows.Forms.Label averageOutput;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label reverseOutput;
        private System.Windows.Forms.Label reverseLabel;
        private System.Windows.Forms.Label swap2Output;
        private System.Windows.Forms.Label swap2Label;
        private System.Windows.Forms.Label swap1Output;
        private System.Windows.Forms.Label swap1Label;
        private System.Windows.Forms.GroupBox enrichmentBox;
    }
}

