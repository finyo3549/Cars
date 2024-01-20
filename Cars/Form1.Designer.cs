namespace Cars
{
    partial class Form_open
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_open));
            listBox_carList = new ListBox();
            panel_checkBox = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox_carList
            // 
            listBox_carList.BackColor = SystemColors.Window;
            listBox_carList.FormattingEnabled = true;
            listBox_carList.ItemHeight = 21;
            listBox_carList.Location = new Point(2, 45);
            listBox_carList.Name = "listBox_carList";
            listBox_carList.Size = new Size(392, 592);
            listBox_carList.TabIndex = 0;
            // 
            // panel_checkBox
            // 
            panel_checkBox.Location = new Point(460, 45);
            panel_checkBox.Name = "panel_checkBox";
            panel_checkBox.Size = new Size(519, 581);
            panel_checkBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 2;
            label1.Text = "Available Cars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(680, 13);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 3;
            label2.Text = "Filter By Brand";
            // 
            // Form_open
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel_checkBox);
            Controls.Add(listBox_carList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form_open";
            Text = "Form1";
            Load += Form_open_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_carList;
        private Panel panel_checkBox;
        private Label label1;
        private Label label2;
    }
}
