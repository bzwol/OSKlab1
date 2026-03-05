using System.Drawing;
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected Color[][] motive_colors = new Color[3][];
        //motive_colors[0] = new Color[] {SystemColors.Control,SystemColors.ControlText};

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.button_eq = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.label_disp = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motywToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylZegaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfrowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalClock1 = new WindowsFormsApp1.DigitalClock();
            this.analogClock1 = new WindowsFormsApp1.AnalogClock();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(88, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(164, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(88, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(164, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(88, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(164, 77);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(88, 245);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 50);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button_comma
            // 
            this.button_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_comma.Location = new System.Drawing.Point(12, 245);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(70, 50);
            this.button_comma.TabIndex = 10;
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = true;
            this.button_comma.Click += new System.EventHandler(this.Button_Comma_Click);
            // 
            // button_eq
            // 
            this.button_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_eq.Location = new System.Drawing.Point(164, 245);
            this.button_eq.Name = "button_eq";
            this.button_eq.Size = new System.Drawing.Size(70, 50);
            this.button_eq.TabIndex = 11;
            this.button_eq.Text = "=";
            this.button_eq.UseVisualStyleBackColor = true;
            this.button_eq.Click += new System.EventHandler(this.button_eq_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(240, 245);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(70, 50);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "-";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sub.Location = new System.Drawing.Point(240, 189);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(70, 50);
            this.button_sub.TabIndex = 13;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mul.Location = new System.Drawing.Point(240, 133);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(70, 50);
            this.button_mul.TabIndex = 14;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_div.Location = new System.Drawing.Point(240, 77);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(70, 50);
            this.button_div.TabIndex = 15;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // label_disp
            // 
            this.label_disp.BackColor = System.Drawing.SystemColors.Control;
            this.label_disp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_disp.Location = new System.Drawing.Point(12, 24);
            this.label_disp.Name = "label_disp";
            this.label_disp.Size = new System.Drawing.Size(222, 50);
            this.label_disp.TabIndex = 16;
            this.label_disp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.Location = new System.Drawing.Point(240, 24);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 50);
            this.button_clear.TabIndex = 17;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.personalizacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // personalizacjaToolStripMenuItem
            // 
            this.personalizacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motywToolStripMenuItem,
            this.stylZegaruToolStripMenuItem});
            this.personalizacjaToolStripMenuItem.Name = "personalizacjaToolStripMenuItem";
            this.personalizacjaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.personalizacjaToolStripMenuItem.Text = "Personalizacja";
            // 
            // motywToolStripMenuItem
            // 
            this.motywToolStripMenuItem.Name = "motywToolStripMenuItem";
            this.motywToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motywToolStripMenuItem.Text = "Motyw";
            // 
            // stylZegaruToolStripMenuItem
            // 
            this.stylZegaruToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analogowyToolStripMenuItem,
            this.cyfrowyToolStripMenuItem});
            this.stylZegaruToolStripMenuItem.Name = "stylZegaruToolStripMenuItem";
            this.stylZegaruToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stylZegaruToolStripMenuItem.Text = "Styl zegaru";
            // 
            // analogowyToolStripMenuItem
            // 
            this.analogowyToolStripMenuItem.Checked = true;
            this.analogowyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.analogowyToolStripMenuItem.Name = "analogowyToolStripMenuItem";
            this.analogowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analogowyToolStripMenuItem.Tag = "1";
            this.analogowyToolStripMenuItem.Text = "Analogowy";
            this.analogowyToolStripMenuItem.Click += new System.EventHandler(this.menu_clock_Click);
            // 
            // cyfrowyToolStripMenuItem
            // 
            this.cyfrowyToolStripMenuItem.Name = "cyfrowyToolStripMenuItem";
            this.cyfrowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cyfrowyToolStripMenuItem.Tag = "2";
            this.cyfrowyToolStripMenuItem.Text = "Cyfrowy";
            this.cyfrowyToolStripMenuItem.Click += new System.EventHandler(this.menu_clock_Click);
            // 
            // digitalClock1
            // 
            this.digitalClock1.Location = new System.Drawing.Point(342, 110);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(221, 88);
            this.digitalClock1.TabIndex = 20;
            this.digitalClock1.Tag = "";
            this.digitalClock1.Text = "digitalClock1";
            // 
            // analogClock1
            // 
            this.analogClock1.Location = new System.Drawing.Point(316, 24);
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.Size = new System.Drawing.Size(271, 271);
            this.analogClock1.TabIndex = 18;
            this.analogClock1.Tag = "";
            this.analogClock1.Text = "analogClock1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 311);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_disp);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_eq);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button button_eq;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Label label_disp;
        private System.Windows.Forms.Button button_clear;
        private AnalogClock analogClock1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motywToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylZegaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfrowyToolStripMenuItem;
        private DigitalClock digitalClock1;
    }
}

