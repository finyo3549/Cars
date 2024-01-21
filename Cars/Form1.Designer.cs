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
            menuStrip1 = new MenuStrip();
            carToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_carList
            // 
            listBox_carList.BackColor = SystemColors.Window;
            listBox_carList.FormattingEnabled = true;
            listBox_carList.ItemHeight = 21;
            listBox_carList.Location = new Point(2, 87);
            listBox_carList.Name = "listBox_carList";
            listBox_carList.Size = new Size(392, 550);
            listBox_carList.TabIndex = 0;
            listBox_carList.SelectedIndexChanged += listBox_carList_SelectedIndexChanged;
            // 
            // panel_checkBox
            // 
            panel_checkBox.Location = new Point(460, 87);
            panel_checkBox.Name = "panel_checkBox";
            panel_checkBox.Size = new Size(519, 539);
            panel_checkBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 2;
            label1.Text = "Available Cars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(681, 45);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 3;
            label2.Text = "Filter By Brand";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { carToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 24);
            menuStrip1.TabIndex = 4;
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(37, 20);
            carToolStripMenuItem.Text = "Car";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
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
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form_open";
            Text = "Form1";
            Load += Form_open_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox listBox_carList;
        private Panel panel_checkBox;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
