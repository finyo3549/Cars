namespace Cars
{
    partial class Form_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Details));
            label_1 = new Label();
            textBox_Marka = new TextBox();
            textBox_Modell = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown_GyartasiEv = new NumericUpDown();
            textBox_Rendszam = new TextBox();
            label3 = new Label();
            dateTimePicker_forgalmiErvenyesseg = new DateTimePicker();
            numericUpDown_Vetelar = new NumericUpDown();
            label4 = new Label();
            numericUpDown_KmAllas = new NumericUpDown();
            label5 = new Label();
            numericUpDownHengerUrtartalom = new NumericUpDown();
            label6 = new Label();
            numericUpDown_Tomeg = new NumericUpDown();
            label7 = new Label();
            numericUpDown_Teljesitmeny = new NumericUpDown();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_GyartasiEv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Vetelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_KmAllas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHengerUrtartalom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Tomeg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Teljesitmeny).BeginInit();
            SuspendLayout();
            // 
            // label_1
            // 
            label_1.AutoSize = true;
            label_1.Location = new Point(97, 118);
            label_1.Margin = new Padding(4, 0, 4, 0);
            label_1.Name = "label_1";
            label_1.Size = new Size(54, 21);
            label_1.TabIndex = 0;
            label_1.Text = "Márka";
            // 
            // textBox_Marka
            // 
            textBox_Marka.Location = new Point(31, 155);
            textBox_Marka.Name = "textBox_Marka";
            textBox_Marka.Size = new Size(183, 29);
            textBox_Marka.TabIndex = 1;
            // 
            // textBox_Modell
            // 
            textBox_Modell.Location = new Point(31, 254);
            textBox_Modell.Name = "textBox_Modell";
            textBox_Modell.Size = new Size(176, 29);
            textBox_Modell.TabIndex = 3;
            textBox_Modell.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 218);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "Modell";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 328);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Gyártási Év";
            // 
            // numericUpDown_GyartasiEv
            // 
            numericUpDown_GyartasiEv.Location = new Point(31, 370);
            numericUpDown_GyartasiEv.Name = "numericUpDown_GyartasiEv";
            numericUpDown_GyartasiEv.Size = new Size(176, 29);
            numericUpDown_GyartasiEv.TabIndex = 5;
            numericUpDown_GyartasiEv.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox_Rendszam
            // 
            textBox_Rendszam.Location = new Point(31, 67);
            textBox_Rendszam.Name = "textBox_Rendszam";
            textBox_Rendszam.Size = new Size(183, 29);
            textBox_Rendszam.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 6;
            label3.Text = "Rendszám";
            // 
            // dateTimePicker_forgalmiErvenyesseg
            // 
            dateTimePicker_forgalmiErvenyesseg.Format = DateTimePickerFormat.Custom;
            dateTimePicker_forgalmiErvenyesseg.Location = new Point(31, 465);
            dateTimePicker_forgalmiErvenyesseg.Name = "dateTimePicker_forgalmiErvenyesseg";
            dateTimePicker_forgalmiErvenyesseg.Size = new Size(176, 29);
            dateTimePicker_forgalmiErvenyesseg.TabIndex = 8;
            dateTimePicker_forgalmiErvenyesseg.ValueChanged += dateTimePicker_forgalmiErvenyesseg_ValueChanged;
            // 
            // numericUpDown_Vetelar
            // 
            numericUpDown_Vetelar.Location = new Point(318, 72);
            numericUpDown_Vetelar.Name = "numericUpDown_Vetelar";
            numericUpDown_Vetelar.Size = new Size(176, 29);
            numericUpDown_Vetelar.TabIndex = 10;
            numericUpDown_Vetelar.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 9;
            label4.Text = "Vételár";
            // 
            // numericUpDown_KmAllas
            // 
            numericUpDown_KmAllas.Location = new Point(318, 160);
            numericUpDown_KmAllas.Name = "numericUpDown_KmAllas";
            numericUpDown_KmAllas.Size = new Size(176, 29);
            numericUpDown_KmAllas.TabIndex = 12;
            numericUpDown_KmAllas.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 118);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 11;
            label5.Text = "KM állás";
            // 
            // numericUpDownHengerUrtartalom
            // 
            numericUpDownHengerUrtartalom.Location = new Point(318, 255);
            numericUpDownHengerUrtartalom.Name = "numericUpDownHengerUrtartalom";
            numericUpDownHengerUrtartalom.Size = new Size(176, 29);
            numericUpDownHengerUrtartalom.TabIndex = 14;
            numericUpDownHengerUrtartalom.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 218);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 13;
            label6.Text = "Hengerűrtartalom";
            // 
            // numericUpDown_Tomeg
            // 
            numericUpDown_Tomeg.Location = new Point(318, 370);
            numericUpDown_Tomeg.Name = "numericUpDown_Tomeg";
            numericUpDown_Tomeg.Size = new Size(176, 29);
            numericUpDown_Tomeg.TabIndex = 16;
            numericUpDown_Tomeg.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 328);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 15;
            label7.Text = "Tömeg";
            // 
            // numericUpDown_Teljesitmeny
            // 
            numericUpDown_Teljesitmeny.Location = new Point(318, 469);
            numericUpDown_Teljesitmeny.Name = "numericUpDown_Teljesitmeny";
            numericUpDown_Teljesitmeny.Size = new Size(176, 29);
            numericUpDown_Teljesitmeny.TabIndex = 18;
            numericUpDown_Teljesitmeny.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 427);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 17;
            label8.Text = "Teljesítmény";
            // 
            // button1
            // 
            button1.Location = new Point(702, 262);
            button1.Name = "button1";
            button1.Size = new Size(224, 104);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_Details
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(button1);
            Controls.Add(numericUpDown_Teljesitmeny);
            Controls.Add(label8);
            Controls.Add(numericUpDown_Tomeg);
            Controls.Add(label7);
            Controls.Add(numericUpDownHengerUrtartalom);
            Controls.Add(label6);
            Controls.Add(numericUpDown_KmAllas);
            Controls.Add(label5);
            Controls.Add(numericUpDown_Vetelar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker_forgalmiErvenyesseg);
            Controls.Add(textBox_Rendszam);
            Controls.Add(label3);
            Controls.Add(numericUpDown_GyartasiEv);
            Controls.Add(label2);
            Controls.Add(textBox_Modell);
            Controls.Add(label1);
            Controls.Add(textBox_Marka);
            Controls.Add(label_1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form_Details";
            Text = "Form_Details";
            Load += Form_Details_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_GyartasiEv).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Vetelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_KmAllas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHengerUrtartalom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Tomeg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Teljesitmeny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_1;
        private TextBox textBox_Marka;
        private TextBox textBox_Modell;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown_GyartasiEv;
        private TextBox textBox_Rendszam;
        private Label label3;
        private DateTimePicker dateTimePicker_forgalmiErvenyesseg;
        private NumericUpDown numericUpDown_Vetelar;
        private Label label4;
        private NumericUpDown numericUpDown_KmAllas;
        private Label label5;
        private NumericUpDown numericUpDownHengerUrtartalom;
        private Label label6;
        private NumericUpDown numericUpDown_Tomeg;
        private Label label7;
        private NumericUpDown numericUpDown_Teljesitmeny;
        private Label label8;
        private Button button1;
    }
   
}