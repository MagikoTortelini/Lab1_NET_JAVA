namespace GUI
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
            Liczbaprzedmiotow = new TextBox();
            uruchombutton = new Button();
            Seed = new TextBox();
            pojemnosc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Wynik = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Wartosc = new TextBox();
            SuspendLayout();
            // 
            // Liczbaprzedmiotow
            // 
            Liczbaprzedmiotow.Location = new Point(31, 46);
            Liczbaprzedmiotow.Multiline = true;
            Liczbaprzedmiotow.Name = "Liczbaprzedmiotow";
            Liczbaprzedmiotow.Size = new Size(247, 34);
            Liczbaprzedmiotow.TabIndex = 0;
            // 
            // uruchombutton
            // 
            uruchombutton.Location = new Point(31, 232);
            uruchombutton.Name = "uruchombutton";
            uruchombutton.Size = new Size(94, 29);
            uruchombutton.TabIndex = 1;
            uruchombutton.Text = "Uruchom";
            uruchombutton.UseVisualStyleBackColor = true;
            uruchombutton.Click += button1_Click;
            // 
            // Seed
            // 
            Seed.Location = new Point(31, 112);
            Seed.Multiline = true;
            Seed.Name = "Seed";
            Seed.Size = new Size(247, 34);
            Seed.TabIndex = 2;
            // 
            // pojemnosc
            // 
            pojemnosc.Location = new Point(30, 182);
            pojemnosc.Multiline = true;
            pojemnosc.Name = "pojemnosc";
            pojemnosc.Size = new Size(248, 34);
            pojemnosc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 4;
            label1.Text = "Liczba przedmiotow";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 159);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 6;
            label3.Text = "Pojemnosc";
            // 
            // Wynik
            // 
            Wynik.Location = new Point(31, 301);
            Wynik.Multiline = true;
            Wynik.Name = "Wynik";
            Wynik.ReadOnly = true;
            Wynik.Size = new Size(219, 240);
            Wynik.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 278);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Wynik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 20);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Wartosci";
            // 
            // Wartosc
            // 
            Wartosc.Location = new Point(316, 60);
            Wartosc.Multiline = true;
            Wartosc.Name = "Wartosc";
            Wartosc.ReadOnly = true;
            Wartosc.Size = new Size(464, 439);
            Wartosc.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(Wartosc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Wynik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pojemnosc);
            Controls.Add(Seed);
            Controls.Add(uruchombutton);
            Controls.Add(Liczbaprzedmiotow);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Liczbaprzedmiotow;
        private Button uruchombutton;
        private TextBox Seed;
        private TextBox pojemnosc;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Wynik;
        private Label label4;
        private Label label5;
        private TextBox Wartosc;
    }
}
