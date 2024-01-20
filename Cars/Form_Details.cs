using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form_Details : Form
    {
        string muvelet;
        public Form_Details(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }
        private void Form_Details_Load(object sender, EventArgs e)
        {

            switch (muvelet)
            {
                case "new":
                    this.Text = "Add new Car";
                    button1.Text = "Add";
                    button1.BackColor = Color.Blue;
                    button1.ForeColor = Color.White;
                    button1.Click += new EventHandler(addCar);
                    break;
                case "update":
                    this.Text = "Update Car Data";
                    button1.Text = "Update";
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button1.Click += new EventHandler(updateCar);
                    updateFields();
                    break;
                case "delete":
                    this.Text = "Delete Car";
                    button1.Text = "Delete";
                    button1.BackColor = Color.Red;
                    button1.ForeColor = Color.White;
                    button1.Click += new EventHandler(addCar);
                    updateFields();
                    break;
            }
        }

        private void updateFields()
        {
            Car car = (Car)Program.form_Open.listBox_carList.SelectedItem;
            textBox_Marka.Text = car.Marka.ToString();
            textBox_Modell.Text = car.Modell.ToString();
            textBox_Rendszam.Text = car.Rendszam.ToString();
            numericUpDownHengerUrtartalom.Value = car.Hengerurtartalom;
            numericUpDown_GyartasiEv.Value = car.Gyartasiev;
            numericUpDown_KmAllas.Value = car.Kmallas;
            numericUpDown_Teljesitmeny.Value = car.Teljesitmeny;
            numericUpDown_Tomeg.Value = car.Tomeg;
            numericUpDown_Vetelar.Value = car.Vetelar;

        }

        private void updateCar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addCar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_forgalmiErvenyesseg_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
