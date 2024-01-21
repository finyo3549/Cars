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
                    button1.Click += new EventHandler(deleteCar);
                    textBox_Marka.ReadOnly = true;
                    textBox_Modell.ReadOnly = true;
                    numericUpDownHengerUrtartalom.ReadOnly = true;
                    numericUpDown_GyartasiEv.ReadOnly = true;
                    numericUpDown_KmAllas.ReadOnly = true;
                    numericUpDown_Teljesitmeny.ReadOnly = true;
                    numericUpDown_Tomeg.ReadOnly = true;
                    numericUpDown_Vetelar.ReadOnly = true;
                    dateTimePicker_forgalmiErvenyesseg.Enabled = false;

                    updateFields();
                    break;
            }
        }

        private void deleteCar(object? sender, EventArgs e)
        {
            Car car = new Car();
            
            car.Modell = textBox_Modell.Text;
            car.Marka = textBox_Marka.Text;
            car.Rendszam = textBox_Rendszam.Text;
            car.Vetelar = (int)numericUpDown_Vetelar.Value;
            car.Hengerurtartalom = (int)numericUpDownHengerUrtartalom.Value;
            car.Teljesitmeny = (int)numericUpDown_Teljesitmeny.Value;
            car.Kmallas = (int)numericUpDown_KmAllas.Value;
            DateTime forgalmiErvenyessegDateTime = (DateTime)dateTimePicker_forgalmiErvenyesseg.Value;
            car.ForgalmiErvenyesseg = new DateOnly(forgalmiErvenyessegDateTime.Year, forgalmiErvenyessegDateTime.Month, forgalmiErvenyessegDateTime.Day);
            car.Gyartasiev = (int)numericUpDown_GyartasiEv.Value;
            car.Vetelar = (int)numericUpDown_Vetelar.Value;
            car.Tomeg = (int)numericUpDown_Tomeg.Value;
            Program.database.deleteCar(car);
            this.Close();
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
            dateTimePicker_forgalmiErvenyesseg.Value = new DateTime(car.ForgalmiErvenyesseg.Year, car.ForgalmiErvenyesseg.Month, car.ForgalmiErvenyesseg.Day);
            dateTimePicker_forgalmiErvenyesseg.CustomFormat = "yyyy-MM-dd";
            dateTimePicker_forgalmiErvenyesseg.Format = DateTimePickerFormat.Custom;


        }

        private void updateCar(object? sender, EventArgs e)
        {
            
            Car car = new Car();
            car.Modell = textBox_Modell.Text;
            car.Marka = textBox_Marka.Text;
            car.Rendszam = textBox_Rendszam.Text;
            car.Vetelar = (int)numericUpDown_Vetelar.Value;
            car.Hengerurtartalom = (int)numericUpDownHengerUrtartalom.Value;
            car.Teljesitmeny = (int)numericUpDown_Teljesitmeny.Value;
            car.Kmallas = (int)numericUpDown_KmAllas.Value;
            DateTime forgalmiErvenyessegDateTime = (DateTime)dateTimePicker_forgalmiErvenyesseg.Value;
            car.ForgalmiErvenyesseg = new DateOnly(forgalmiErvenyessegDateTime.Year, forgalmiErvenyessegDateTime.Month, forgalmiErvenyessegDateTime.Day);
            car.Gyartasiev = (int)numericUpDown_GyartasiEv.Value;
            car.Vetelar = (int)numericUpDown_Vetelar.Value;
            car.Tomeg = (int)numericUpDown_Tomeg.Value;
            Program.database.updateCar(car);
            this.Close();
        }

        private void addCar(object? sender, EventArgs e)
        {
            Car car = new Car();
            car.Marka = textBox_Marka.Text;
            car.Modell = textBox_Modell.Text;
            car.Rendszam = textBox_Rendszam.Text;
            car.Vetelar = (int)numericUpDown_Vetelar.Value;
            car.Hengerurtartalom = (int)numericUpDownHengerUrtartalom.Value;
            car.Teljesitmeny = (int)numericUpDown_Teljesitmeny.Value;
            car.Kmallas = (int)numericUpDown_KmAllas.Value;
            DateTime forgalmiErvenyessegDateTime = (DateTime)dateTimePicker_forgalmiErvenyesseg.Value;
            car.ForgalmiErvenyesseg = new DateOnly(forgalmiErvenyessegDateTime.Year, forgalmiErvenyessegDateTime.Month, forgalmiErvenyessegDateTime.Day);
            car.Gyartasiev = (int)numericUpDown_GyartasiEv.Value;
            car.Vetelar = (int)numericUpDown_Vetelar.Value;
            car.Tomeg = (int)numericUpDown_Tomeg.Value;
            Program.database.addCar(car);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_forgalmiErvenyesseg_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
