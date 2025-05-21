using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string nameHotel = textBox1.Text;
            Hotel hotel = new Hotel(nameHotel);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string nameHotel = textBox1.Text;
            Hotel hotel = new Hotel(nameHotel);



            int roomNumber = int.Parse(textBox2.Text);
            string roomType = textBox3.Text;
            double roomPrice = double.Parse(textBox4.Text);

            hotel.AddRoom(new Room(roomNumber, roomType, roomPrice));
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string nameHotel = textBox1.Text;
            Hotel hotel = new Hotel(nameHotel);

            label5.Text = hotel.ShowAvailable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = textBox5.Text;
            string Email = textBox6.Text;

            Customer customer = new Customer(Name, Email);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string nameHotel = textBox1.Text;
            Hotel hotel = new Hotel(nameHotel);

            string Name = textBox5.Text;
            string Email = textBox6.Text;
            Customer customer = new Customer(Name, Email);




            int numberRoom = int.Parse(textBox7.Text);

            hotel.MakeReservation (customer, numberRoom, DateTime.Today, DateTime.Today.AddDays(3));
        }
    }
}
