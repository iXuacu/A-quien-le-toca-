using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace A_quien_le_toca_
{
    public partial class MainPage : ContentPage
    {
        float saldoXuacu = 1;
        float saldoToni = 0;
        float incrementoSaldo = 0;
        string aQuienLeToca;
        public MainPage()
        {
            InitializeComponent();
            lblSaldoToni.Text = "Saldo Toni: " + saldoToni.ToString();
            lblSaldoXuacu.Text = "Saldo Xuacu: " + saldoXuacu.ToString();
            CalculaPago();
        }

        private void CalculaPago()
        {
            if (saldoXuacu < saldoToni)
            {
                aQuienLeToca = "Paga Xuacu";
                saldoXuacu += incrementoSaldo;
                lblSaldoXuacu.Text = "Saldo Xuacu: " + saldoXuacu.ToString();            
            }
            else
            {
                aQuienLeToca = "Paga Toni";
                saldoToni += incrementoSaldo;
                lblSaldoToni.Text = "Saldo Toni: " + saldoToni.ToString();
            }
            entCantidad.Text = "";
            lblPaga.Text = aQuienLeToca;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            incrementoSaldo = float.Parse(entCantidad.Text);
            CalculaPago();
            
        }
    }
}
