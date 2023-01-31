namespace Calculate
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.FirstDigit = new System.Windows.Forms.TextBox();
            this.SecondDigit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelRes = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(129, 138);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(45, 46);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Tag = "+";
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // FirstDigit
            // 
            this.FirstDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDigit.Location = new System.Drawing.Point(30, 73);
            this.FirstDigit.Multiline = true;
            this.FirstDigit.Name = "FirstDigit";
            this.FirstDigit.Size = new System.Drawing.Size(91, 41);
            this.FirstDigit.TabIndex = 1;
            // 
            // SecondDigit
            // 
            this.SecondDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondDigit.Location = new System.Drawing.Point(189, 73);
            this.SecondDigit.Multiline = true;
            this.SecondDigit.Name = "SecondDigit";
            this.SecondDigit.Size = new System.Drawing.Size(91, 41);
            this.SecondDigit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(186, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Второе число";
            // 
            // LabelRes
            // 
            this.LabelRes.AutoSize = true;
            this.LabelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRes.Location = new System.Drawing.Point(26, 208);
            this.LabelRes.Name = "LabelRes";
            this.LabelRes.Size = new System.Drawing.Size(78, 24);
            this.LabelRes.TabIndex = 5;
            this.LabelRes.Text = "Ответ:";
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(180, 138);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(45, 46);
            this.buttonSub.TabIndex = 6;
            this.buttonSub.Tag = "-";
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(78, 138);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(45, 46);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Tag = "/";
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 266);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.LabelRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondDigit);
            this.Controls.Add(this.FirstDigit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "КалькуляторГит";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox FirstDigit;
        private System.Windows.Forms.TextBox SecondDigit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelRes;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonDiv;
    }
}

