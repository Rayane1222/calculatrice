namespace calculatrice
{


    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int contenuTextBox1 = 0;
        private string signe = "";
        private int contenuTextBox2 = 0;
        private int result = 0;
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            buttonvide = new Button();
            buttoneffacetout = new Button();
            button_efface_dernier_caractére = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            buttonPlus_Click = new Button();
            button_sustraction = new Button();
            button_mult = new Button();
            button_div = new Button();
            buttonEquals_Click = new Button();
            buttonvirgule = new Button();
            button0 = new Button();
            buttonvide2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 62);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonvide
            // 
            buttonvide.Location = new Point(27, 98);
            buttonvide.Name = "buttonvide";
            buttonvide.Size = new Size(73, 80);
            buttonvide.TabIndex = 1;
            buttonvide.Text = "HI";
            buttonvide.UseVisualStyleBackColor = true;
            buttonvide.Click += button1_Click;
            // 
            // buttoneffacetout
            // 
            buttoneffacetout.Location = new Point(121, 98);
            buttoneffacetout.Name = "buttoneffacetout";
            buttoneffacetout.Size = new Size(73, 80);
            buttoneffacetout.TabIndex = 2;
            buttoneffacetout.Text = "C";
            buttoneffacetout.UseVisualStyleBackColor = true;
            buttoneffacetout.Click += buttoneffacetout_Click;
            // 
            // button_efface_dernier_caractére
            // 
            button_efface_dernier_caractére.Location = new Point(209, 98);
            button_efface_dernier_caractére.Name = "button_efface_dernier_caractére";
            button_efface_dernier_caractére.Size = new Size(73, 80);
            button_efface_dernier_caractére.TabIndex = 3;
            button_efface_dernier_caractére.Text = "<=";
            button_efface_dernier_caractére.UseVisualStyleBackColor = true;
            button_efface_dernier_caractére.Click += button_efface_dernier_caractére_Click;
            // 
            // button7
            // 
            button7.Location = new Point(27, 184);
            button7.Name = "button7";
            button7.Size = new Size(73, 80);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button4_Click;
            // 
            // button8
            // 
            button8.Location = new Point(121, 184);
            button8.Name = "button8";
            button8.Size = new Size(73, 80);
            button8.TabIndex = 5;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(209, 184);
            button9.Name = "button9";
            button9.Size = new Size(73, 80);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(27, 270);
            button4.Name = "button4";
            button4.Size = new Size(73, 80);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(121, 270);
            button5.Name = "button5";
            button5.Size = new Size(73, 80);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(209, 270);
            button6.Name = "button6";
            button6.Size = new Size(73, 80);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button9_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 356);
            button1.Name = "button1";
            button1.Size = new Size(73, 80);
            button1.TabIndex = 10;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(121, 356);
            button2.Name = "button2";
            button2.Size = new Size(73, 80);
            button2.TabIndex = 11;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button11_Click;
            // 
            // button3
            // 
            button3.Location = new Point(209, 356);
            button3.Name = "button3";
            button3.Size = new Size(73, 80);
            button3.TabIndex = 12;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button12_Click;
            // 
            // buttonPlus_Click
            // 
            buttonPlus_Click.Location = new Point(305, 356);
            buttonPlus_Click.Name = "buttonPlus_Click";
            buttonPlus_Click.Size = new Size(73, 80);
            buttonPlus_Click.TabIndex = 16;
            buttonPlus_Click.Text = "+";
            buttonPlus_Click.UseVisualStyleBackColor = true;
            buttonPlus_Click.Click += buttonPlus_Click_Click;
            // 
            // button_sustraction
            // 
            button_sustraction.Location = new Point(305, 270);
            button_sustraction.Name = "button_sustraction";
            button_sustraction.Size = new Size(73, 80);
            button_sustraction.TabIndex = 15;
            button_sustraction.Text = "-";
            button_sustraction.UseVisualStyleBackColor = true;
            button_sustraction.Click += button_sustraction_Click;
            // 
            // button_mult
            // 
            button_mult.Location = new Point(305, 184);
            button_mult.Name = "button_mult";
            button_mult.Size = new Size(73, 80);
            button_mult.TabIndex = 14;
            button_mult.Text = "*";
            button_mult.UseVisualStyleBackColor = true;
            button_mult.Click += button_mult_Click;
            // 
            // button_div
            // 
            button_div.Location = new Point(305, 98);
            button_div.Name = "button_div";
            button_div.Size = new Size(73, 80);
            button_div.TabIndex = 13;
            button_div.Text = "/";
            button_div.UseVisualStyleBackColor = true;
            button_div.Click += button_div_Click;
            // 
            // buttonEquals_Click
            // 
            buttonEquals_Click.Location = new Point(305, 442);
            buttonEquals_Click.Name = "buttonEquals_Click";
            buttonEquals_Click.Size = new Size(73, 80);
            buttonEquals_Click.TabIndex = 20;
            buttonEquals_Click.Text = "=";
            buttonEquals_Click.UseVisualStyleBackColor = true;
            buttonEquals_Click.Click += buttonEquals_Click_Click;
            // 
            // buttonvirgule
            // 
            buttonvirgule.Location = new Point(209, 442);
            buttonvirgule.Name = "buttonvirgule";
            buttonvirgule.Size = new Size(73, 80);
            buttonvirgule.TabIndex = 19;
            buttonvirgule.Text = ",";
            buttonvirgule.UseVisualStyleBackColor = true;
            buttonvirgule.Click += buttonvirgule_Click;
            // 
            // button0
            // 
            button0.Location = new Point(121, 442);
            button0.Name = "button0";
            button0.Size = new Size(73, 80);
            button0.TabIndex = 18;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonvide2
            // 
            buttonvide2.Location = new Point(27, 442);
            buttonvide2.Name = "buttonvide2";
            buttonvide2.Size = new Size(73, 80);
            buttonvide2.TabIndex = 17;
            buttonvide2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 543);
            Controls.Add(buttonEquals_Click);
            Controls.Add(buttonvirgule);
            Controls.Add(button0);
            Controls.Add(buttonvide2);
            Controls.Add(buttonPlus_Click);
            Controls.Add(button_sustraction);
            Controls.Add(button_mult);
            Controls.Add(button_div);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button_efface_dernier_caractére);
            Controls.Add(buttoneffacetout);
            Controls.Add(buttonvide);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonvide;
        private Button buttoneffacetout;
        private Button button_efface_dernier_caractére;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private BindingSource bindingSource1;
        private Button buttonPlus_Click;
        private Button button_sustraction;
        private Button button_mult;
        private Button button_div;
        private Button buttonEquals_Click;
        private Button buttonvirgule;
        private Button button0;
        private Button buttonvide2;
    }
}