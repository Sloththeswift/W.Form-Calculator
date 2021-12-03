
namespace Form_calc
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.multiplybtn = new System.Windows.Forms.Button();
            this.Decibutton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.operatorbtn = new System.Windows.Forms.Button();
            this.minbtn = new System.Windows.Forms.Button();
            this.resultbtn = new System.Windows.Forms.Button();
            this.Calculatorscreen = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dividebtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.multiplybtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Decibutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.clearbtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.operatorbtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.minbtn, 3, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(76, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(3, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 79);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(76, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 79);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(149, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 79);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.Location = new System.Drawing.Point(3, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 73);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.Location = new System.Drawing.Point(76, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 73);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.Location = new System.Drawing.Point(149, 173);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 73);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(149, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // dividebtn
            // 
            this.dividebtn.BackColor = System.Drawing.Color.DimGray;
            this.dividebtn.Location = new System.Drawing.Point(225, 3);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(69, 79);
            this.dividebtn.TabIndex = 9;
            this.dividebtn.Text = "/";
            this.dividebtn.UseVisualStyleBackColor = false;
            this.dividebtn.Click += new System.EventHandler(this.dividebtn_Click);
            // 
            // multiplybtn
            // 
            this.multiplybtn.BackColor = System.Drawing.Color.DimGray;
            this.multiplybtn.Location = new System.Drawing.Point(225, 88);
            this.multiplybtn.Name = "multiplybtn";
            this.multiplybtn.Size = new System.Drawing.Size(69, 79);
            this.multiplybtn.TabIndex = 10;
            this.multiplybtn.Text = "*";
            this.multiplybtn.UseVisualStyleBackColor = false;
            this.multiplybtn.Click += new System.EventHandler(this.multiplybtn_Click);
            // 
            // Decibutton
            // 
            this.Decibutton.BackColor = System.Drawing.Color.DimGray;
            this.Decibutton.Location = new System.Drawing.Point(3, 252);
            this.Decibutton.Name = "Decibutton";
            this.Decibutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Decibutton.Size = new System.Drawing.Size(67, 75);
            this.Decibutton.TabIndex = 12;
            this.Decibutton.Text = ",";
            this.Decibutton.UseVisualStyleBackColor = false;
            this.Decibutton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.DimGray;
            this.button0.Location = new System.Drawing.Point(76, 252);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(67, 75);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DimGray;
            this.clearbtn.Location = new System.Drawing.Point(149, 252);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(70, 75);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "C";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // operatorbtn
            // 
            this.operatorbtn.BackColor = System.Drawing.Color.DimGray;
            this.operatorbtn.Location = new System.Drawing.Point(225, 252);
            this.operatorbtn.Name = "operatorbtn";
            this.operatorbtn.Size = new System.Drawing.Size(69, 75);
            this.operatorbtn.TabIndex = 15;
            this.operatorbtn.Text = "+";
            this.operatorbtn.UseVisualStyleBackColor = false;
            this.operatorbtn.Click += new System.EventHandler(this.Operatorbtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.DimGray;
            this.minbtn.Location = new System.Drawing.Point(225, 173);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(69, 73);
            this.minbtn.TabIndex = 11;
            this.minbtn.Text = "-";
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // resultbtn
            // 
            this.resultbtn.BackColor = System.Drawing.Color.DimGray;
            this.resultbtn.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultbtn.Location = new System.Drawing.Point(9, 440);
            this.resultbtn.Name = "resultbtn";
            this.resultbtn.Size = new System.Drawing.Size(294, 58);
            this.resultbtn.TabIndex = 1;
            this.resultbtn.Text = "=";
            this.resultbtn.UseVisualStyleBackColor = false;
            this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
            // 
            // Calculatorscreen
            // 
            this.Calculatorscreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Calculatorscreen.Enabled = false;
            this.Calculatorscreen.Font = new System.Drawing.Font("Rockwell", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculatorscreen.ForeColor = System.Drawing.Color.Black;
            this.Calculatorscreen.Location = new System.Drawing.Point(6, 16);
            this.Calculatorscreen.Multiline = true;
            this.Calculatorscreen.Name = "Calculatorscreen";
            this.Calculatorscreen.ReadOnly = true;
            this.Calculatorscreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Calculatorscreen.Size = new System.Drawing.Size(297, 88);
            this.Calculatorscreen.TabIndex = 2;
            this.Calculatorscreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(322, 513);
            this.Controls.Add(this.Calculatorscreen);
            this.Controls.Add(this.resultbtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button multiplybtn;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button Decibutton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button operatorbtn;
        private System.Windows.Forms.Button resultbtn;
        private System.Windows.Forms.TextBox Calculatorscreen;
    }
}

