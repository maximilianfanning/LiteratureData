namespace LiteratureWorkDataCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this.calculateAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.lettersOnlyCharacterCountCB = new System.Windows.Forms.CheckBox();
            this.characterCountOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your writing data finder!";
            // 
            // calculateAll
            // 
            this.calculateAll.Location = new System.Drawing.Point(928, 902);
            this.calculateAll.Name = "calculateAll";
            this.calculateAll.Size = new System.Drawing.Size(75, 23);
            this.calculateAll.TabIndex = 1;
            this.calculateAll.Text = "Calculate";
            this.calculateAll.UseVisualStyleBackColor = true;
            this.calculateAll.Click += new System.EventHandler(this.calculateAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character/Letter count";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(804, 31);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(289, 20);
            this.textInput.TabIndex = 4;
            // 
            // lettersOnlyCharacterCountCB
            // 
            this.lettersOnlyCharacterCountCB.AutoSize = true;
            this.lettersOnlyCharacterCountCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lettersOnlyCharacterCountCB.Location = new System.Drawing.Point(135, 8);
            this.lettersOnlyCharacterCountCB.Name = "lettersOnlyCharacterCountCB";
            this.lettersOnlyCharacterCountCB.Size = new System.Drawing.Size(83, 17);
            this.lettersOnlyCharacterCountCB.TabIndex = 5;
            this.lettersOnlyCharacterCountCB.Text = "Letters only:";
            this.lettersOnlyCharacterCountCB.UseVisualStyleBackColor = true;
            // 
            // characterCountOutput
            // 
            this.characterCountOutput.Location = new System.Drawing.Point(12, 30);
            this.characterCountOutput.Name = "characterCountOutput";
            this.characterCountOutput.Size = new System.Drawing.Size(206, 20);
            this.characterCountOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1955, 1001);
            this.Controls.Add(this.characterCountOutput);
            this.Controls.Add(this.lettersOnlyCharacterCountCB);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateAll);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.CheckBox lettersOnlyCharacterCountCB;
        private System.Windows.Forms.TextBox characterCountOutput;
    }
}

