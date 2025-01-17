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
    public partial class MainForm : Form
    {
        ClientAmount clientAmount = new ClientAmount();
        
        public MainForm()
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
                clientAmount.Fuel = new Fuel { Name = nameFuel, Price = Convert.ToDouble(price) };
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
                    clientAmount.FuelAmount = price * count;
                    lbl_fuel_total.Text = clientAmount.FuelAmount.ToString() + " грн.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Введіть коректні дані\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    clientAmount.FuelAmount = Convert.ToDouble(txt_fuel_money.Text);
                    double total_volume = Math.Round(clientAmount.FuelAmount / price, 2);
                    lbl_fuel_total.Text = clientAmount.FuelAmount.ToString() + " грн." + total_volume.ToString() + " літри";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Введіть коректні дані\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CafeeCountChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                switch (textBox.Name)
                {
                    case "txt_hotdog_count":
                        RemoveCaffeFromAmount("Хот-дог");
                        clientAmount.Cafees.Add(new Cafee { Name = "Хот-дог", Price = Convert.ToDouble(txt_hotdog_price.Text), Count = Convert.ToInt32(txt_hotdog_count.Text)});
                        break;
                    case "txt_gumburger_count":
                        RemoveCaffeFromAmount("Гамбургер");
                        clientAmount.Cafees.Add(new Cafee { Name = "Гамбургер", Price = Convert.ToDouble(txt_gumburger_price.Text), Count = Convert.ToInt32(txt_gumburger_count.Text) });
                        break;
                    case "txt_kartoha_count":
                        RemoveCaffeFromAmount("Картопля-фрі");
                        clientAmount.Cafees.Add(new Cafee { Name = "Картопля-фрі", Price = Convert.ToDouble(txt_kartoha_price.Text), Count = Convert.ToInt32(txt_kartoha_count.Text)});
                        break;
                    case "txt_cocacola_count":
                        RemoveCaffeFromAmount("Coca-cola");
                        clientAmount.Cafees.Add(new Cafee { Name = "Coca-cola", Price = Convert.ToDouble(txt_cocacola_price.Text), Count = Convert.ToInt32(txt_cocacola_count.Text)});
                        break;
                    default:
                        break;
                }
                lbl_kafe_total.Text = clientAmount.CaffeAmount.ToString() + " грн.";
            }
            catch (Exception ex)
            {
                clientAmount.Cafees.Clear();
                lbl_kafe_total.Text = "0 грн.";
                MessageBox.Show($"Введіть коректні дані\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RemoveCaffeFromAmount(string CaffeName)
        {
            for (int i = 0; i < clientAmount.Cafees.Count; i++)
            {
                if (clientAmount.Cafees[i].Name == CaffeName)
                { 
                    clientAmount.Cafees.RemoveAt(i);
                }
            }
        }
        private void CafeCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "chk_hotDog":
                    if (chk_hotDog.Checked)
                    {
                        txt_hotdog_count.ReadOnly = false;
                    }
                    else
                    {
                        txt_hotdog_count.ReadOnly = true;
                        txt_hotdog_count.Text = "0";
                        RemoveCaffeFromAmount("Хот-дог");
                    }
                    break;
                case "chk_Gamburger":
                    if (chk_Gamburger.Checked)
                    {
                        txt_gumburger_count.ReadOnly = false;
                    }
                    else
                    {
                        txt_gumburger_count.ReadOnly = true;
                        txt_gumburger_count.Text = "0";
                        RemoveCaffeFromAmount("Гамбургер");
                    }
                    break;
                case "chk_kartohaFree":
                    if (chk_kartohaFree.Checked)
                    {
                        txt_kartoha_count.ReadOnly = false;
                    }
                    else
                    {
                        txt_kartoha_count.ReadOnly = true;
                        txt_kartoha_count.Text = "0";
                        RemoveCaffeFromAmount("Картопля-фрі");
                    }
                    break;
                case "chk_cocaCola":
                    if (chk_cocaCola.Checked)
                    {
                        txt_cocacola_count.ReadOnly = false;
                    }
                    else
                    { 
                        txt_cocacola_count.ReadOnly = true;
                        txt_cocacola_count.Text = "0";
                        RemoveCaffeFromAmount("Coca-cola");
                    }
                    break;
                default:
                    MessageBox.Show("Такого продукту не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            lbl_kafe_total.Text = clientAmount.CaffeAmount.ToString() + " грн.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_totalAmount.Text = clientAmount.TotalAmount.ToString() + " грн.";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
