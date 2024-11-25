namespace Scitacka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSectiStr = new Button();
            btnSectiInt = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSectiStr
            // 
            btnSectiStr.Location = new Point(197, 121);
            btnSectiStr.Name = "btnSectiStr";
            btnSectiStr.Size = new Size(125, 50);
            btnSectiStr.TabIndex = 0;
            btnSectiStr.Text = "+ (String)";
            btnSectiStr.UseVisualStyleBackColor = true;
            btnSectiStr.Click += btnSectiStr_Click;
            // 
            // btnSectiInt
            // 
            btnSectiInt.Location = new Point(373, 121);
            btnSectiInt.Name = "btnSectiInt";
            btnSectiInt.Size = new Size(125, 50);
            btnSectiInt.TabIndex = 1;
            btnSectiInt.Text = "+ (Int)";
            btnSectiInt.UseVisualStyleBackColor = true;
            btnSectiInt.Click += btnSectiInt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 208);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(301, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 211);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Výsledek:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(614, 271);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSectiInt);
            Controls.Add(btnSectiStr);
            Name = "Form1";
            Text = "Sčítačka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSectiStr;
        private Button btnSectiInt;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
    }
}
