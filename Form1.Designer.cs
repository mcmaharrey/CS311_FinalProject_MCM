namespace CS311_FinalProject_MCM
{
    partial class frmMain
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
            lblUnitConverter = new Label();
            lblValue = new Label();
            lblResult = new Label();
            txtValue = new TextBox();
            txtResult = new TextBox();
            grpSelectConversion = new GroupBox();
            rdoOzToGram = new RadioButton();
            rdoGramToOz = new RadioButton();
            rdoCelToFahren = new RadioButton();
            rdoFahrenToCel = new RadioButton();
            rdoKiloToPound = new RadioButton();
            rdoPoundToKilo = new RadioButton();
            rdoMilesToKilo = new RadioButton();
            rdoKiloToMiles = new RadioButton();
            rdoFeetToMeters = new RadioButton();
            rdoMetersToFeet = new RadioButton();
            btnConvert = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpSelectConversion.SuspendLayout();
            SuspendLayout();
            // 
            // lblUnitConverter
            // 
            lblUnitConverter.AutoSize = true;
            lblUnitConverter.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnitConverter.Location = new Point(279, 9);
            lblUnitConverter.Name = "lblUnitConverter";
            lblUnitConverter.Size = new Size(250, 45);
            lblUnitConverter.TabIndex = 0;
            lblUnitConverter.Text = "Unit Converter";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblValue.Location = new Point(105, 76);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(92, 17);
            lblValue.TabIndex = 1;
            lblValue.Text = "Enter a Value: ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(419, 76);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(51, 17);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result: ";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(105, 94);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(147, 23);
            txtValue.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(419, 94);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(147, 23);
            txtResult.TabIndex = 5;
            // 
            // grpSelectConversion
            // 
            grpSelectConversion.Controls.Add(rdoOzToGram);
            grpSelectConversion.Controls.Add(rdoGramToOz);
            grpSelectConversion.Controls.Add(rdoCelToFahren);
            grpSelectConversion.Controls.Add(rdoFahrenToCel);
            grpSelectConversion.Controls.Add(rdoKiloToPound);
            grpSelectConversion.Controls.Add(rdoPoundToKilo);
            grpSelectConversion.Controls.Add(rdoMilesToKilo);
            grpSelectConversion.Controls.Add(rdoKiloToMiles);
            grpSelectConversion.Controls.Add(rdoFeetToMeters);
            grpSelectConversion.Controls.Add(rdoMetersToFeet);
            grpSelectConversion.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpSelectConversion.Location = new Point(86, 166);
            grpSelectConversion.Name = "grpSelectConversion";
            grpSelectConversion.Size = new Size(314, 162);
            grpSelectConversion.TabIndex = 10;
            grpSelectConversion.TabStop = false;
            grpSelectConversion.Text = "Select Conversion: ";
            // 
            // rdoOzToGram
            // 
            rdoOzToGram.AutoSize = true;
            rdoOzToGram.Location = new Point(164, 122);
            rdoOzToGram.Name = "rdoOzToGram";
            rdoOzToGram.Size = new Size(120, 21);
            rdoOzToGram.TabIndex = 9;
            rdoOzToGram.TabStop = true;
            rdoOzToGram.Text = "Ounces to Grams";
            rdoOzToGram.UseVisualStyleBackColor = true;
            // 
            // rdoGramToOz
            // 
            rdoGramToOz.AutoSize = true;
            rdoGramToOz.Location = new Point(19, 122);
            rdoGramToOz.Name = "rdoGramToOz";
            rdoGramToOz.Size = new Size(120, 21);
            rdoGramToOz.TabIndex = 8;
            rdoGramToOz.TabStop = true;
            rdoGramToOz.Text = "Grams to Ounces";
            rdoGramToOz.UseVisualStyleBackColor = true;
            // 
            // rdoCelToFahren
            // 
            rdoCelToFahren.AutoSize = true;
            rdoCelToFahren.Location = new Point(19, 72);
            rdoCelToFahren.Name = "rdoCelToFahren";
            rdoCelToFahren.Size = new Size(144, 21);
            rdoCelToFahren.TabIndex = 7;
            rdoCelToFahren.TabStop = true;
            rdoCelToFahren.Text = "Celsius to Fahrenheit";
            rdoCelToFahren.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenToCel
            // 
            rdoFahrenToCel.AutoSize = true;
            rdoFahrenToCel.Location = new Point(164, 72);
            rdoFahrenToCel.Name = "rdoFahrenToCel";
            rdoFahrenToCel.Size = new Size(144, 21);
            rdoFahrenToCel.TabIndex = 6;
            rdoFahrenToCel.TabStop = true;
            rdoFahrenToCel.Text = "Fahrenheit to Celsius";
            rdoFahrenToCel.UseVisualStyleBackColor = true;
            // 
            // rdoKiloToPound
            // 
            rdoKiloToPound.AutoSize = true;
            rdoKiloToPound.Location = new Point(19, 97);
            rdoKiloToPound.Name = "rdoKiloToPound";
            rdoKiloToPound.Size = new Size(129, 21);
            rdoKiloToPound.TabIndex = 5;
            rdoKiloToPound.TabStop = true;
            rdoKiloToPound.Text = "Kilogram to Pounds";
            rdoKiloToPound.UseVisualStyleBackColor = true;
            // 
            // rdoPoundToKilo
            // 
            rdoPoundToKilo.AutoSize = true;
            rdoPoundToKilo.Location = new Point(164, 97);
            rdoPoundToKilo.Name = "rdoPoundToKilo";
            rdoPoundToKilo.Size = new Size(129, 21);
            rdoPoundToKilo.TabIndex = 4;
            rdoPoundToKilo.TabStop = true;
            rdoPoundToKilo.Text = "Pounds to Kilogram";
            rdoPoundToKilo.UseVisualStyleBackColor = true;
            // 
            // rdoMilesToKilo
            // 
            rdoMilesToKilo.AutoSize = true;
            rdoMilesToKilo.Location = new Point(164, 47);
            rdoMilesToKilo.Name = "rdoMilesToKilo";
            rdoMilesToKilo.Size = new Size(135, 21);
            rdoMilesToKilo.TabIndex = 3;
            rdoMilesToKilo.TabStop = true;
            rdoMilesToKilo.Text = "Miles to Kilometers";
            rdoMilesToKilo.UseVisualStyleBackColor = true;
            // 
            // rdoKiloToMiles
            // 
            rdoKiloToMiles.AutoSize = true;
            rdoKiloToMiles.Location = new Point(19, 47);
            rdoKiloToMiles.Name = "rdoKiloToMiles";
            rdoKiloToMiles.Size = new Size(135, 21);
            rdoKiloToMiles.TabIndex = 2;
            rdoKiloToMiles.TabStop = true;
            rdoKiloToMiles.Text = "Kilometers to Miles";
            rdoKiloToMiles.UseVisualStyleBackColor = true;
            // 
            // rdoFeetToMeters
            // 
            rdoFeetToMeters.AutoSize = true;
            rdoFeetToMeters.Location = new Point(164, 22);
            rdoFeetToMeters.Name = "rdoFeetToMeters";
            rdoFeetToMeters.Size = new Size(111, 21);
            rdoFeetToMeters.TabIndex = 1;
            rdoFeetToMeters.TabStop = true;
            rdoFeetToMeters.Text = "Feet to Meters";
            rdoFeetToMeters.UseVisualStyleBackColor = true;
            // 
            // rdoMetersToFeet
            // 
            rdoMetersToFeet.AutoSize = true;
            rdoMetersToFeet.Location = new Point(19, 22);
            rdoMetersToFeet.Name = "rdoMetersToFeet";
            rdoMetersToFeet.Size = new Size(111, 21);
            rdoMetersToFeet.TabIndex = 0;
            rdoMetersToFeet.TabStop = true;
            rdoMetersToFeet.Text = "Meters to Feet";
            rdoMetersToFeet.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(491, 166);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 11;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(491, 236);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(491, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnConvert);
            Controls.Add(grpSelectConversion);
            Controls.Add(txtResult);
            Controls.Add(txtValue);
            Controls.Add(lblResult);
            Controls.Add(lblValue);
            Controls.Add(lblUnitConverter);
            Name = "frmMain";
            Text = "Unit Converter";
            grpSelectConversion.ResumeLayout(false);
            grpSelectConversion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnitConverter;
        private Label lblValue;
        private Label lblResult;
        private TextBox txtValue;
        private TextBox txtResult;
        private GroupBox grpSelectConversion;
        private RadioButton rdoMilesToKilo;
        private RadioButton rdoKiloToMiles;
        private RadioButton rdoFeetToMeters;
        private RadioButton rdoMetersToFeet;
        private RadioButton rdoOzToGram;
        private RadioButton rdoGramToOz;
        private RadioButton rdoCelToFahren;
        private RadioButton rdoFahrenToCel;
        private RadioButton rdoKiloToPound;
        private RadioButton rdoPoundToKilo;
        private Button btnConvert;
        private Button btnReset;
        private Button btnExit;
    }
}