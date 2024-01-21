namespace Cars
{
    public partial class Form_open : Form
    {
        public Form_open()
        {
            InitializeComponent();
        }

        public object SelectedCar
        {
            get { return listBox_carList.SelectedItem; }
        }
        private void Form_open_Load(object sender, EventArgs e)
        {
            foreach (string marka in Program.cars.Select(a => a.Marka).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = marka;
                cb.Checked = true;
                cb.Location = new Point(10, panel_checkBox.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(marka_changed);
                panel_checkBox.Controls.Add(cb);
            }
            updateCarsList();
        }

        private void marka_changed(object? sender, EventArgs e)
        {
            updateCarsList();
        }

        public void updateCarsList()
        {
            listBox_carList.Items.Clear();
            List<string> checkedbox = new List<string>();
            foreach (CheckBox item in panel_checkBox.Controls)
            {
                if (item.Checked)
                {
                    checkedbox.Add(item.Text);
                }
            }
            foreach (Car cars in Program.cars)
            {
                if (checkedbox.Contains(cars.Marka))
                {
                    listBox_carList.Items.Add(cars);
                }
            }
        }

        private void listBox_carList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBox_carList.SelectedItem;
            Console.WriteLine(selectedItem);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Details formDetails = new Form_Details("new");
            formDetails.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.form_Open.SelectedCar == null)
            {
                MessageBox.Show("No car selected");
                return;
            }
            else
            {
                Form_Details formDetails = new Form_Details("update");
                formDetails.ShowDialog();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.form_Open.SelectedCar == null)
            {
                MessageBox.Show("No car selected");
                return;
            }
            else
            {
                Form_Details formDetails = new Form_Details("delete");
                formDetails.ShowDialog();
            }
        }
    }
}
