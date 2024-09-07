namespace UnitConvertion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConvertButton = new Button();
            OutputLabel = new Label();
            OutputUnitsBox = new ComboBox();
            InputUnitsBox = new ComboBox();
            inputValueBox = new TextBox();
            label1 = new Label();
            Exponent = new Label();
            ExponentTextBox = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // ConvertButton
            // 
            ConvertButton.BackColor = Color.FromArgb(54, 50, 50);
            ConvertButton.FlatStyle = FlatStyle.Flat;
            ConvertButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConvertButton.ForeColor = Color.FromArgb(94, 189, 216);
            ConvertButton.Location = new Point(335, 16);
            ConvertButton.Margin = new Padding(0);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(94, 29);
            ConvertButton.TabIndex = 0;
            ConvertButton.Text = "-->";
            ConvertButton.TextAlign = ContentAlignment.TopCenter;
            ConvertButton.UseVisualStyleBackColor = false;
            ConvertButton.Click += Convert;
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.ForeColor = Color.FromArgb(94, 189, 216);
            OutputLabel.Location = new Point(445, 20);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(36, 20);
            OutputLabel.TabIndex = 1;
            OutputLabel.Text = "0.00";
            OutputLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OutputUnitsBox
            // 
            OutputUnitsBox.BackColor = Color.FromArgb(201, 201, 201);
            OutputUnitsBox.FlatStyle = FlatStyle.Flat;
            OutputUnitsBox.ForeColor = Color.FromArgb(14, 51, 79);
            OutputUnitsBox.FormattingEnabled = true;
            OutputUnitsBox.Location = new Point(538, 17);
            OutputUnitsBox.Name = "OutputUnitsBox";
            OutputUnitsBox.Size = new Size(105, 28);
            OutputUnitsBox.TabIndex = 2;
            // 
            // InputUnitsBox
            // 
            InputUnitsBox.BackColor = Color.FromArgb(201, 201, 201);
            InputUnitsBox.FlatStyle = FlatStyle.Flat;
            InputUnitsBox.ForeColor = Color.FromArgb(14, 51, 79);
            InputUnitsBox.FormattingEnabled = true;
            InputUnitsBox.Location = new Point(220, 16);
            InputUnitsBox.Name = "InputUnitsBox";
            InputUnitsBox.Size = new Size(105, 28);
            InputUnitsBox.TabIndex = 3;
            // 
            // inputValueBox
            // 
            inputValueBox.BackColor = Color.FromArgb(201, 201, 201);
            inputValueBox.ForeColor = Color.FromArgb(14, 51, 79);
            inputValueBox.Location = new Point(9, 17);
            inputValueBox.Margin = new Padding(0);
            inputValueBox.Name = "inputValueBox";
            inputValueBox.Size = new Size(125, 27);
            inputValueBox.TabIndex = 4;
            inputValueBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(94, 189, 216);
            label1.Location = new Point(510, 56);
            label1.Name = "label1";
            label1.Size = new Size(144, 17);
            label1.TabIndex = 5;
            label1.Text = "ТА-33_ОлійникДмитро";
            // 
            // Exponent
            // 
            Exponent.AutoSize = true;
            Exponent.ForeColor = Color.FromArgb(94, 189, 216);
            Exponent.Location = new Point(137, 20);
            Exponent.Name = "Exponent";
            Exponent.Size = new Size(45, 20);
            Exponent.TabIndex = 6;
            Exponent.Text = "×10^";
            Exponent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExponentTextBox
            // 
            ExponentTextBox.BackColor = Color.FromArgb(201, 201, 201);
            ExponentTextBox.ForeColor = Color.FromArgb(14, 51, 79);
            ExponentTextBox.Location = new Point(176, 17);
            ExponentTextBox.Margin = new Padding(0);
            ExponentTextBox.Name = "ExponentTextBox";
            ExponentTextBox.Size = new Size(41, 27);
            ExponentTextBox.TabIndex = 7;
            ExponentTextBox.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 189, 216);
            panel1.Location = new Point(13, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 1);
            panel1.TabIndex = 8;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 64, 66);
            ClientSize = new Size(654, 75);
            Controls.Add(panel1);
            Controls.Add(ExponentTextBox);
            Controls.Add(Exponent);
            Controls.Add(label1);
            Controls.Add(inputValueBox);
            Controls.Add(InputUnitsBox);
            Controls.Add(OutputUnitsBox);
            Controls.Add(OutputLabel);
            Controls.Add(ConvertButton);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConvertButton;
        private Label OutputLabel;
        private ComboBox OutputUnitsBox;
        private ComboBox InputUnitsBox;
        private TextBox inputValueBox;
        private Label label1;
        private Label Exponent;
        private TextBox ExponentTextBox;
        private Panel panel1;
    }
}
