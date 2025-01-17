using BestOIL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOIL
{
    public partial class Form1 : Form
    {
        double _totalMoney_fuel = 0;
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Helpers.GetFuels())
            {
                cmbx_fuels.Items.Add(item.Name);
            }
            txt_cocacola_price.Text = Helpers.GetCafeePrice("Coca-cola").ToString();
            txt_gumburger_price.Text = Helpers.GetCafeePrice("Гамбургер").ToString();
            txt_hotdog_price.Text = Helpers.GetCafeePrice("Хот-дог").ToString();
            txt_kartoha_price.Text = Helpers.GetCafeePrice("Картопля-фрі").ToString();
        }

        private void rdb_count_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_count.Checked)
            {
                txt_fuel_volume.ReadOnly = false;
                txt_fuel_money.ReadOnly = true;
                txt_fuel_volume.Text = "0";
            }
            else
            {
                txt_fuel_volume.ReadOnly = true;
                txt_fuel_money.ReadOnly = false;
                txt_fuel_money.Text = "0";
            }
        }

        private void cmbx_fuels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameFuel = cmbx_fuels.SelectedItem.ToString();
            double? price = Helpers.GetFuelPrice(nameFuel);
            if (price != null)
            {
                txt_price.Text = price.ToString();
            }
            else
            {
                MessageBox.Show("Такого палива не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_fuel_volume_TextChanged(object sender, EventArgs e)
        {
            lbl_fuel_total.Text = "";
            try
            {
                if (txt_fuel_volume.Text.Length > 0)
                {
                    double price = Convert.ToDouble(txt_price.Text);
                    double count = Convert.ToDouble(txt_fuel_volume.Text);
                    _totalMoney_fuel = price * count;
                    lbl_fuel_total.Text = _totalMoney_fuel.ToString()+" грн.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть коректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_fuel_money_TextChanged(object sender, EventArgs e)
        {
            lbl_fuel_total.Text = "";
            try
            {
                if (txt_fuel_money.Text.Length > 0)
                {
                    double price = Convert.ToDouble(txt_price.Text);
                    _totalMoney_fuel = Convert.ToDouble(txt_fuel_money.Text);
                    double total_volume = Math.Round(_totalMoney_fuel / price, 2);
                    lbl_fuel_total.Text = _totalMoney_fuel.ToString()+" грн." + total_volume.ToString()+" літри";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть коректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_hotdog_count.ReadOnly = false;
            }
            else
            {
                txt_hotdog_count.ReadOnly = true;
                txt_hotdog_count.Text = "0";
            }
        }
    }
}
