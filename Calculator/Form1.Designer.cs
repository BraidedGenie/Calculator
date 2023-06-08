namespace Calculator
{
    partial class Form1
    {
        private string currentCalculation = "";
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
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMulti = new Button();
            buttonDivison = new Button();
            buttonLBracket = new Button();
            buttonRBracket = new Button();
            buttonEquals = new Button();
            button3 = new Button();
            button6 = new Button();
            button9 = new Button();
            buttonDeci = new Button();
            button2 = new Button();
            button5 = new Button();
            button8 = new Button();
            buttonClearEntry = new Button();
            button0 = new Button();
            button1 = new Button();
            button4 = new Button();
            button7 = new Button();
            buttonClear = new Button();
            panel1 = new Panel();
            textBoxOutput = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ActiveBorder;
            buttonAdd.Location = new Point(180, 133);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = SystemColors.ActiveBorder;
            buttonSub.Location = new Point(180, 189);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(50, 50);
            buttonSub.TabIndex = 1;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = false;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = SystemColors.ActiveBorder;
            buttonMulti.Location = new Point(180, 245);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(50, 50);
            buttonMulti.TabIndex = 2;
            buttonMulti.Text = "x";
            buttonMulti.UseVisualStyleBackColor = false;
            // 
            // buttonDivison
            // 
            buttonDivison.BackColor = SystemColors.ActiveBorder;
            buttonDivison.Location = new Point(180, 301);
            buttonDivison.Name = "buttonDivison";
            buttonDivison.Size = new Size(50, 50);
            buttonDivison.TabIndex = 3;
            buttonDivison.Text = "/";
            buttonDivison.UseVisualStyleBackColor = false;
            // 
            // buttonLBracket
            // 
            buttonLBracket.BackColor = SystemColors.ActiveBorder;
            buttonLBracket.Location = new Point(124, 77);
            buttonLBracket.Name = "buttonLBracket";
            buttonLBracket.Size = new Size(50, 50);
            buttonLBracket.TabIndex = 4;
            buttonLBracket.Text = "(";
            buttonLBracket.UseVisualStyleBackColor = false;
            // 
            // buttonRBracket
            // 
            buttonRBracket.BackColor = SystemColors.ActiveBorder;
            buttonRBracket.Location = new Point(180, 77);
            buttonRBracket.Name = "buttonRBracket";
            buttonRBracket.Size = new Size(50, 50);
            buttonRBracket.TabIndex = 5;
            buttonRBracket.Text = ")";
            buttonRBracket.UseVisualStyleBackColor = false;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(124, 301);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 50);
            buttonEquals.TabIndex = 9;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(124, 245);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(124, 189);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(124, 133);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonDeci
            // 
            buttonDeci.Location = new Point(68, 301);
            buttonDeci.Name = "buttonDeci";
            buttonDeci.Size = new Size(50, 50);
            buttonDeci.TabIndex = 14;
            buttonDeci.Text = ".";
            buttonDeci.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(68, 245);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(68, 189);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 12;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(68, 133);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 11;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.BackColor = SystemColors.GradientActiveCaption;
            buttonClearEntry.Location = new Point(68, 77);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(50, 50);
            buttonClearEntry.TabIndex = 10;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            button0.Location = new Point(12, 301);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 19;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 245);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 18;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 189);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 17;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 133);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 16;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.GradientActiveCaption;
            buttonClear.Location = new Point(12, 77);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 50);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(textBoxOutput);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 59);
            panel1.TabIndex = 20;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = SystemColors.ControlLightLight;
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(81, 20);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(125, 20);
            textBoxOutput.TabIndex = 0;
            textBoxOutput.Text = "0";
            textBoxOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 386);
            Controls.Add(panel1);
            Controls.Add(button0);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(buttonClear);
            Controls.Add(buttonDeci);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(buttonClearEntry);
            Controls.Add(buttonEquals);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(buttonRBracket);
            Controls.Add(buttonLBracket);
            Controls.Add(buttonDivison);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMulti;
        private Button buttonDivison;
        private Button buttonLBracket;
        private Button buttonRBracket;
        private Button buttonEquals;
        private Button button3;
        private Button button6;
        private Button button9;
        private Button buttonDeci;
        private Button button2;
        private Button button5;
        private Button button8;
        private Button buttonClearEntry;
        private Button button0;
        private Button button1;
        private Button button4;
        private Button button7;
        private Button buttonClear;
        private Panel panel1;
        private MaskedTextBox textBoxOutput;

    // Functions
        // Executes when any number or operation is pressed
        private void button_Click(object sender, EventArgs e)
        {
            // Adds the number or operator to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }
    }
}