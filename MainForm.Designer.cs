namespace Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonEmptyMemory = new System.Windows.Forms.Button();
            this.buttonSaveValue = new System.Windows.Forms.Button();
            this.buttonGetValue = new System.Windows.Forms.Button();
            this.buttonAllClear = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonDesimal = new System.Windows.Forms.Button();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.labelScreen = new System.Windows.Forms.Label();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmptyMemory
            // 
            this.buttonEmptyMemory.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEmptyMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.buttonEmptyMemory.Location = new System.Drawing.Point(155, 89);
            this.buttonEmptyMemory.Name = "buttonEmptyMemory";
            this.buttonEmptyMemory.Size = new System.Drawing.Size(55, 55);
            this.buttonEmptyMemory.TabIndex = 1;
            this.buttonEmptyMemory.Text = "EM";
            this.buttonEmptyMemory.UseVisualStyleBackColor = false;
            this.buttonEmptyMemory.Click += new System.EventHandler(this.buttonEmptyMemory_onClick);
            // 
            // buttonSaveValue
            // 
            this.buttonSaveValue.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSaveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.buttonSaveValue.Location = new System.Drawing.Point(15, 91);
            this.buttonSaveValue.Name = "buttonSaveValue";
            this.buttonSaveValue.Size = new System.Drawing.Size(55, 55);
            this.buttonSaveValue.TabIndex = 2;
            this.buttonSaveValue.Text = "MC";
            this.buttonSaveValue.UseVisualStyleBackColor = false;
            this.buttonSaveValue.Click += new System.EventHandler(this.buttonSaveValue_onClick);
            // 
            // buttonGetValue
            // 
            this.buttonGetValue.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.buttonGetValue.Location = new System.Drawing.Point(85, 91);
            this.buttonGetValue.Name = "buttonGetValue";
            this.buttonGetValue.Size = new System.Drawing.Size(55, 55);
            this.buttonGetValue.TabIndex = 3;
            this.buttonGetValue.Text = "MR";
            this.buttonGetValue.UseVisualStyleBackColor = false;
            this.buttonGetValue.Click += new System.EventHandler(this.buttonGetValue_onClick);
            // 
            // buttonAllClear
            // 
            this.buttonAllClear.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.buttonAllClear.Location = new System.Drawing.Point(225, 91);
            this.buttonAllClear.Name = "buttonAllClear";
            this.buttonAllClear.Size = new System.Drawing.Size(55, 55);
            this.buttonAllClear.TabIndex = 4;
            this.buttonAllClear.Text = "AC";
            this.buttonAllClear.UseVisualStyleBackColor = false;
            this.buttonAllClear.Click += new System.EventHandler(this.buttonAllClear_onClick);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum7.Location = new System.Drawing.Point(15, 161);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(55, 55);
            this.buttonNum7.TabIndex = 5;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum7_onClick);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum8.Location = new System.Drawing.Point(85, 161);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(55, 55);
            this.buttonNum8.TabIndex = 6;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum8_onClick);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum9.Location = new System.Drawing.Point(155, 161);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(55, 55);
            this.buttonNum9.TabIndex = 7;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum9_onClick);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonSubtraction.Location = new System.Drawing.Point(225, 161);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(55, 55);
            this.buttonSubtraction.TabIndex = 8;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.buttonSubtraction_onClick);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum4.Location = new System.Drawing.Point(15, 231);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(55, 55);
            this.buttonNum4.TabIndex = 9;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum4_onClick);
            // 
            // buttonNum1
            // 
            this.buttonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum1.Location = new System.Drawing.Point(15, 301);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(55, 55);
            this.buttonNum1.TabIndex = 10;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum1_onClick);
            // 
            // buttonNum0
            // 
            this.buttonNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum0.Location = new System.Drawing.Point(15, 370);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(55, 55);
            this.buttonNum0.TabIndex = 11;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum0_onClick);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum5.Location = new System.Drawing.Point(85, 231);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(55, 55);
            this.buttonNum5.TabIndex = 12;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum5_onClick);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum6.Location = new System.Drawing.Point(155, 231);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(55, 55);
            this.buttonNum6.TabIndex = 13;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum6_onClick);
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonSum.Location = new System.Drawing.Point(225, 231);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(55, 55);
            this.buttonSum.TabIndex = 14;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_onClick);
            // 
            // buttonNum2
            // 
            this.buttonNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum2.Location = new System.Drawing.Point(85, 301);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(55, 55);
            this.buttonNum2.TabIndex = 15;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum2_onClick);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonNum3.Location = new System.Drawing.Point(155, 301);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(55, 55);
            this.buttonNum3.TabIndex = 16;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum3_onClick);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonRoot.Location = new System.Drawing.Point(225, 301);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(55, 55);
            this.buttonRoot.TabIndex = 17;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.buttonRoot_onClick);
            // 
            // buttonDesimal
            // 
            this.buttonDesimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.buttonDesimal.Location = new System.Drawing.Point(85, 370);
            this.buttonDesimal.Name = "buttonDesimal";
            this.buttonDesimal.Size = new System.Drawing.Size(55, 55);
            this.buttonDesimal.TabIndex = 18;
            this.buttonDesimal.Text = ".";
            this.buttonDesimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDesimal.UseVisualStyleBackColor = true;
            this.buttonDesimal.Click += new System.EventHandler(this.buttonDesimal_onClick);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAnswer.Location = new System.Drawing.Point(225, 370);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(55, 55);
            this.buttonAnswer.TabIndex = 19;
            this.buttonAnswer.Text = "Ans";
            this.buttonAnswer.UseVisualStyleBackColor = false;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_onClick);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonResult.Location = new System.Drawing.Point(298, 301);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(55, 125);
            this.buttonResult.TabIndex = 20;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_onClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(298, 89);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 55);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "DEL";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_onClick);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplication.Location = new System.Drawing.Point(298, 161);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(55, 55);
            this.buttonMultiplication.TabIndex = 22;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_onClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonDivision.Location = new System.Drawing.Point(298, 231);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(55, 55);
            this.buttonDivision.TabIndex = 23;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_onClick);
            // 
            // labelScreen
            // 
            this.labelScreen.BackColor = System.Drawing.Color.White;
            this.labelScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScreen.Enabled = false;
            this.labelScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelScreen.ForeColor = System.Drawing.Color.Black;
            this.labelScreen.Location = new System.Drawing.Point(15, 15);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(338, 55);
            this.labelScreen.TabIndex = 24;
            this.labelScreen.Text = "0";
            this.labelScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelScreen.UseWaitCursor = true;
            // 
            // buttonNegative
            // 
            this.buttonNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.buttonNegative.Location = new System.Drawing.Point(155, 370);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(55, 55);
            this.buttonNegative.TabIndex = 25;
            this.buttonNegative.Text = "+/-";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_onClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.labelScreen);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonDesimal);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonAllClear);
            this.Controls.Add(this.buttonGetValue);
            this.Controls.Add(this.buttonSaveValue);
            this.Controls.Add(this.buttonEmptyMemory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEmptyMemory;
        private System.Windows.Forms.Button buttonSaveValue;
        private System.Windows.Forms.Button buttonGetValue;
        private System.Windows.Forms.Button buttonAllClear;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonDesimal;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Button buttonNegative;
    }
}

