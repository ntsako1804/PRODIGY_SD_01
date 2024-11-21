namespace Tempearature_converter
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtInputTemperature = new TextBox();
            rbFahrenheit = new RadioButton();
            rbKelvin = new RadioButton();
            rbCelsius = new RadioButton();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            txtKelvin = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnClear = new Button();
            btnConvert = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 29);
            label1.Name = "label1";
            label1.Size = new Size(310, 40);
            label1.TabIndex = 0;
            label1.Text = "Temperature Converter";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInputTemperature);
            groupBox1.Controls.Add(rbFahrenheit);
            groupBox1.Controls.Add(rbKelvin);
            groupBox1.Controls.Add(rbCelsius);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(165, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            groupBox1.UseWaitCursor = true;
            // 
            // txtInputTemperature
            // 
            txtInputTemperature.Location = new Point(127, 44);
            txtInputTemperature.Name = "txtInputTemperature";
            txtInputTemperature.Size = new Size(232, 23);
            txtInputTemperature.TabIndex = 4;
            txtInputTemperature.UseWaitCursor = true;
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Location = new Point(146, 92);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(81, 19);
            rbFahrenheit.TabIndex = 3;
            rbFahrenheit.TabStop = true;
            rbFahrenheit.Text = "Fahrenheit";
            rbFahrenheit.UseVisualStyleBackColor = true;
            rbFahrenheit.UseWaitCursor = true;
            // 
            // rbKelvin
            // 
            rbKelvin.AutoSize = true;
            rbKelvin.Location = new Point(265, 92);
            rbKelvin.Name = "rbKelvin";
            rbKelvin.Size = new Size(57, 19);
            rbKelvin.TabIndex = 2;
            rbKelvin.TabStop = true;
            rbKelvin.Text = "Kelvin";
            rbKelvin.UseVisualStyleBackColor = true;
            rbKelvin.UseWaitCursor = true;
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Location = new Point(21, 92);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(62, 19);
            rbCelsius.TabIndex = 1;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celsius";
            rbCelsius.UseVisualStyleBackColor = true;
            rbCelsius.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 47);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Temperature";
            label2.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCelsius);
            groupBox2.Controls.Add(txtFahrenheit);
            groupBox2.Controls.Add(txtKelvin);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(165, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 152);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Convert";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(127, 35);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(232, 23);
            txtCelsius.TabIndex = 5;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(127, 76);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(232, 23);
            txtFahrenheit.TabIndex = 6;
            // 
            // txtKelvin
            // 
            txtKelvin.Location = new Point(127, 112);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.Size = new Size(232, 23);
            txtKelvin.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 84);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Fahrenheit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 123);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Kelvin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 43);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Celsius";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(202, 241);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 39);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(368, 241);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(132, 39);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(644, 450);
            Controls.Add(btnConvert);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbFahrenheit;
        private RadioButton rbKelvin;
        private RadioButton rbCelsius;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtInputTemperature;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private TextBox txtKelvin;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnClear;
        private Button btnConvert;
    }
}
