using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using RomoTimerForm.View;
using RomoTimerForm.Controller;

namespace RomoTimer.View
{
    public partial class CurrencyConverter : MaterialForm
    {
        private MaterialForm _parent;
        
        public string result = "";

        public CurrencyConverter(MaterialForm parent)
        {
            InitializeComponent();
            _parent = parent;
            MaterialSkinManager TManager = MaterialSkinManager.Instance;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //makes the program to thing that you use US keyboard

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;  //display Username
            lblResult.Text = ""; //hide lblResult
            SettingsController.SavedSettings();
        }

        public async void Convert()
        {
            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Enter a valid value number");
            }
            else
            {
                var client = new HttpClient();          //https://rapidapi.com/fyhao/api/currency-exchange/ The website for the API I used
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" +
                    cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
                    Headers =
                    {
                        {"x-rapidapi-host", "currency-exchange.p.rapidapi.com"},
                        {"x-rapidapi-key", "93ea2c64b7msh277a67b3960a414p19b2e7jsncfcc5913efbd"},
                    }
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    //lblResult.Text = body;
                    var firstC = txtNumber.Text;
                    var num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(firstC, out Double);
                    var secondC = Math.Round(double.Parse(firstC) * num, 2);
                    result = secondC.ToString();
                }
                if ("BGN" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text) 
                {
                    lblResult.Text = result + " €";
                }
                else if ("EUR" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " Лв.";
                }
                else if ("USD" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " Лв.";
                }
                else if ("BGN" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " $";
                }
                else if ("EUR" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " $";
                }
                else if ("USD" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " €";
                }
                else if ("EUR" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " c$";
                }
                else if ("BGN" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " c$";
                }
                else if ("USD" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " c$";
                }
                else if ("CAD" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " €";
                }
                else if ("CAD" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " Лв.";
                }
                else if ("CAD" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " $";
                }
                else if ("BGN" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " Лв.";
                }
                else if ("USD" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " $";
                }
                else if ("EUR" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " €";
                }
                else if ("CAD" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
                {
                    lblResult.Text = result + " c$";
                }
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void btnMoreTools_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void CurrencyConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                 e.Handled = true;
            }
        }
    }
}