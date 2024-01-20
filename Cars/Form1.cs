namespace Cars
{
    public partial class Form_open : Form
    {
        public Form_open()
        {
            InitializeComponent();
        }

        private void Form_open_Load(object sender, EventArgs e)
        {
            foreach(string marka in Program.cars.Select(a => a.Marka).Distinct())
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

        private void updateCarsList()
        {
            listBox_carList.Items.Clear();
            List<string> checkedbox = new List<string>();
            foreach(CheckBox item in panel_checkBox.Controls)
            {
                if(item.Checked)
                {
                    checkedbox.Add(item.Text);
                }
            }
            foreach(Car cars in Program.cars)
            {
                if (checkedbox.Contains(cars.Marka))
                {
                    listBox_carList.Items.Add(cars);
                }
            }
        }
    }
}
