using System.Drawing;
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Color[] motive_colors =
        {
              // [Background, Main, Details]
              Color.White,
              Color.FromArgb(240,240,240),
              Color.Black
        };

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
            this.domyślnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciemnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zielonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylZegaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfrowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogClock1 = new WindowsFormsApp1.AnalogClock();
            this.digitalClock1 = new WindowsFormsApp1.DigitalClock();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(88, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 50);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(164, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 50);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 50);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(88, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 50);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(164, 389);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 50);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 333);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 50);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(88, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 50);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(164, 333);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 50);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(88, 501);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 50);
            this.button0.TabIndex = 9;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Button_Digit_Click);
            // 
            // button_comma
            // 
            this.button_comma.BackColor = System.Drawing.Color.White;
            this.button_comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_comma.Location = new System.Drawing.Point(12, 501);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(70, 50);
            this.button_comma.TabIndex = 10;
            this.button_comma.TabStop = false;
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = false;
            this.button_comma.Click += new System.EventHandler(this.Button_Comma_Click);
            // 
            // button_eq
            // 
            this.button_eq.BackColor = System.Drawing.Color.White;
            this.button_eq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_eq.Location = new System.Drawing.Point(164, 501);
            this.button_eq.Name = "button_eq";
            this.button_eq.Size = new System.Drawing.Size(70, 50);
            this.button_eq.TabIndex = 11;
            this.button_eq.TabStop = false;
            this.button_eq.Text = "=";
            this.button_eq.UseVisualStyleBackColor = false;
            this.button_eq.Click += new System.EventHandler(this.button_eq_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(240, 501);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(70, 50);
            this.button_add.TabIndex = 12;
            this.button_add.TabStop = false;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // button_sub
            // 
            this.button_sub.BackColor = System.Drawing.Color.White;
            this.button_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sub.Location = new System.Drawing.Point(240, 445);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(70, 50);
            this.button_sub.TabIndex = 13;
            this.button_sub.TabStop = false;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = false;
            this.button_sub.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.Color.White;
            this.button_mul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mul.Location = new System.Drawing.Point(240, 389);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(70, 50);
            this.button_mul.TabIndex = 14;
            this.button_mul.TabStop = false;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = false;
            this.button_mul.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // button_div
            // 
            this.button_div.BackColor = System.Drawing.Color.White;
            this.button_div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_div.Location = new System.Drawing.Point(240, 333);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(70, 50);
            this.button_div.TabIndex = 15;
            this.button_div.TabStop = false;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = false;
            this.button_div.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // label_disp
            // 
            this.label_disp.BackColor = System.Drawing.Color.White;
            this.label_disp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_disp.Location = new System.Drawing.Point(12, 280);
            this.label_disp.Name = "label_disp";
            this.label_disp.Size = new System.Drawing.Size(222, 50);
            this.label_disp.TabIndex = 16;
            this.label_disp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.Location = new System.Drawing.Point(240, 280);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 50);
            this.button_clear.TabIndex = 17;
            this.button_clear.TabStop = false;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.personalizacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
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
            this.motywToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domyślnyToolStripMenuItem,
            this.ciemnyToolStripMenuItem,
            this.zielonyToolStripMenuItem});
            this.motywToolStripMenuItem.Name = "motywToolStripMenuItem";
            this.motywToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.motywToolStripMenuItem.Text = "Motyw";
            // 
            // domyślnyToolStripMenuItem
            // 
            this.domyślnyToolStripMenuItem.Name = "domyślnyToolStripMenuItem";
            this.domyślnyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.domyślnyToolStripMenuItem.Text = "Domyślny";
            this.domyślnyToolStripMenuItem.Click += new System.EventHandler(this.domyślnyToolStripMenuItem_Click);
            // 
            // ciemnyToolStripMenuItem
            // 
            this.ciemnyToolStripMenuItem.Name = "ciemnyToolStripMenuItem";
            this.ciemnyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ciemnyToolStripMenuItem.Text = "Ciemny";
            this.ciemnyToolStripMenuItem.Click += new System.EventHandler(this.ciemnyToolStripMenuItem_Click);
            // 
            // zielonyToolStripMenuItem
            // 
            this.zielonyToolStripMenuItem.Name = "zielonyToolStripMenuItem";
            this.zielonyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zielonyToolStripMenuItem.Text = "Zielony";
            this.zielonyToolStripMenuItem.Click += new System.EventHandler(this.zielonyToolStripMenuItem_Click);
            // 
            // stylZegaruToolStripMenuItem
            // 
            this.stylZegaruToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analogowyToolStripMenuItem,
            this.cyfrowyToolStripMenuItem});
            this.stylZegaruToolStripMenuItem.Name = "stylZegaruToolStripMenuItem";
            this.stylZegaruToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stylZegaruToolStripMenuItem.Text = "Styl zegaru";
            // 
            // analogowyToolStripMenuItem
            // 
            this.analogowyToolStripMenuItem.Checked = true;
            this.analogowyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.analogowyToolStripMenuItem.Name = "analogowyToolStripMenuItem";
            this.analogowyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.analogowyToolStripMenuItem.Tag = "1";
            this.analogowyToolStripMenuItem.Text = "Analogowy";
            this.analogowyToolStripMenuItem.Click += new System.EventHandler(this.menu_clock_Click);
            // 
            // cyfrowyToolStripMenuItem
            // 
            this.cyfrowyToolStripMenuItem.Name = "cyfrowyToolStripMenuItem";
            this.cyfrowyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cyfrowyToolStripMenuItem.Tag = "2";
            this.cyfrowyToolStripMenuItem.Text = "Cyfrowy";
            this.cyfrowyToolStripMenuItem.Click += new System.EventHandler(this.menu_clock_Click);
            // 
            // analogClock1
            // 
            this.analogClock1.detail_color = System.Drawing.Color.Black;
            this.analogClock1.Location = new System.Drawing.Point(28, 27);
            this.analogClock1.main_color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.Size = new System.Drawing.Size(250, 250);
            this.analogClock1.TabIndex = 21;
            this.analogClock1.Text = "analogClock1";
            // 
            // digitalClock1
            // 
            this.digitalClock1.detail_color = System.Drawing.Color.Black;
            this.digitalClock1.Location = new System.Drawing.Point(55, 103);
            this.digitalClock1.main_color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(211, 89);
            this.digitalClock1.TabIndex = 20;
            this.digitalClock1.Text = "digitalClock1";
            this.digitalClock1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 563);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.digitalClock1);
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
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motywToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylZegaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfrowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domyślnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciemnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zielonyToolStripMenuItem;
        private DigitalClock digitalClock1;
        private AnalogClock analogClock1;
    }
}

