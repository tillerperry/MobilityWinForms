namespace test
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.First_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstInput = new System.Windows.Forms.Label();
            this.secondGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.secondlable = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.secondGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.First_Button);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.firstInput);
            this.groupBox2.Location = new System.Drawing.Point(156, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(484, 671);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First View";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // First_Button
            // 
            this.First_Button.Location = new System.Drawing.Point(178, 540);
            this.First_Button.Margin = new System.Windows.Forms.Padding(6);
            this.First_Button.Name = "First_Button";
            this.First_Button.Size = new System.Drawing.Size(128, 44);
            this.First_Button.TabIndex = 2;
            this.First_Button.Text = "Submit First";
            this.First_Button.UseVisualStyleBackColor = true;
            this.First_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "View:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(86, 135);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(334, 337);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // firstInput
            // 
            this.firstInput.AutoSize = true;
            this.firstInput.Location = new System.Drawing.Point(12, 52);
            this.firstInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(65, 25);
            this.firstInput.TabIndex = 2;
            this.firstInput.Text = "Input:";
            this.firstInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondGroupBox
            // 
            this.secondGroupBox.Controls.Add(this.button2);
            this.secondGroupBox.Controls.Add(this.label3);
            this.secondGroupBox.Controls.Add(this.listView2);
            this.secondGroupBox.Controls.Add(this.textBox2);
            this.secondGroupBox.Controls.Add(this.secondlable);
            this.secondGroupBox.Location = new System.Drawing.Point(840, 85);
            this.secondGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.secondGroupBox.Name = "secondGroupBox";
            this.secondGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.secondGroupBox.Size = new System.Drawing.Size(484, 671);
            this.secondGroupBox.TabIndex = 2;
            this.secondGroupBox.TabStop = false;
            this.secondGroupBox.Text = "Second View";
            this.secondGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit Second";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "View:";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(86, 135);
            this.listView2.Margin = new System.Windows.Forms.Padding(6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(334, 337);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // secondlable
            // 
            this.secondlable.AutoSize = true;
            this.secondlable.Location = new System.Drawing.Point(12, 52);
            this.secondlable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.secondlable.Name = "secondlable";
            this.secondlable.Size = new System.Drawing.Size(65, 25);
            this.secondlable.TabIndex = 2;
            this.secondlable.Text = "Input:";
            this.secondlable.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.secondGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.secondGroupBox.ResumeLayout(false);
            this.secondGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label firstInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button First_Button;
        private System.Windows.Forms.GroupBox secondGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label secondlable;
        private System.Windows.Forms.Button button2;
    }
}

