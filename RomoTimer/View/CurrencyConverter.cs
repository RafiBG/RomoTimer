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
        public CurrencyConverter(MaterialForm parent)
        {
            InitializeComponent();
            _parent = parent;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //makes the program to thing that you use US keyboard

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;  //display Username
            lblResult.Text = ""; //hide lblResult
            SettingsController.SavedSettings();
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Enter a valid value number");
            }
            else if ("BGN" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)    //https://rapidapi.com/fyhao/api/currency-exchange/ The website for the API I used
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                        var bgn = txtNumber.Text;
                        var num = double.Parse(body);
                        double Double = 0;
                        var IsEmpty = double.TryParse(bgn, out Double);
                        var eur = Math.Round(double.Parse(bgn) * num, 2);
                        string eur1 = eur.ToString();
                        lblResult.Text = eur1 + " €";
                    }
            }

            else if ("EUR" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                        var eur = txtNumber.Text;
                        var num = double.Parse(body);
                        double Double = 0;
                        var IsEmpty = double.TryParse(eur, out Double);
                        var bgn = Math.Round(double.Parse(eur) * num, 2);
                        string bgn1 = bgn.ToString();
                        lblResult.Text = bgn1 + " Лв.";
                    }
            }
            else if ("USD" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                        var usd = txtNumber.Text;
                        var num = double.Parse(body);
                        double Double = 0;
                        var IsEmpty = double.TryParse(usd, out Double);
                        var bgn = Math.Round(double.Parse(usd) * num, 2);
                        string bgn1 = bgn.ToString();
                        lblResult.Text = bgn1 + " Лв.";
                    }
            }
            else if ("BGN" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                        var bgn = txtNumber.Text;
                        var num = double.Parse(body);
                        double Double = 0;
                        var IsEmpty = double.TryParse(bgn, out Double);
                        var usd = Math.Round(double.Parse(bgn) * num, 2);
                        string usd1 = usd.ToString();
                        lblResult.Text = usd1 + " $";
                    }
            }
            else if ("EUR" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var eur = txtNumber.Text;
                    var num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(eur, out Double);
                    var usd = Math.Round(double.Parse(eur) * num, 2);
                    string usd1 = usd.ToString();
                    lblResult.Text = usd1 + " $";
                }
            }
            else if ("USD" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var usd = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(usd, out Double);
                    var eur = Math.Round(double.Parse(usd) * num, 2);
                    string eur1 = eur.ToString();
                    lblResult.Text = eur1 + " €";
                }
            }
            else if ("EUR" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var eur = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(eur, out Double);
                    var cad = Math.Round(double.Parse(eur) * num, 2);
                    string cad1 = cad.ToString();
                    lblResult.Text = cad1 + " c$";
                }
            }
            else if ("BGN" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var bgn = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(bgn, out Double);
                    var cad = Math.Round(double.Parse(bgn) * num, 2);
                    string cad1 = cad.ToString();
                    lblResult.Text = cad1 + " c$";
                }
            }
            else if ("USD" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var usd = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(usd, out Double);
                    var cad = Math.Round(double.Parse(usd) * num, 2);
                    string cad1 = cad.ToString();
                    lblResult.Text = cad1 + " c$";
                }
            }
            else if ("CAD" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var cad = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(cad, out Double);
                    var eur = Math.Round(double.Parse(cad) * num, 2);
                    string eur1 = eur.ToString();
                    lblResult.Text = eur1 + " €";
                }
            }
            else if ("CAD" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var cad = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(cad, out Double);
                    var bgn = Math.Round(double.Parse(cad) * num, 2);
                    string bgn1 = bgn.ToString();
                    lblResult.Text = bgn1 + " Лв.";
                }
            }
            else if ("CAD" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var cad = txtNumber.Text;
                    double num = double.Parse(body);
                    double Double = 0;
                    var IsEmpty = double.TryParse(cad, out Double);
                    var usd = Math.Round(double.Parse(cad) * num, 2);
                    string usd1 = usd.ToString();
                    lblResult.Text = usd1 + " $";
                }
            }
            else if ("BGN" == cbFirstCurrency.Text && "BGN" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var bgn = txtNumber.Text;
                    lblResult.Text = bgn + " Лв.";
                }
            }
            else if ("USD" == cbFirstCurrency.Text && "USD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {

                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var usd = txtNumber.Text;
                    lblResult.Text = usd + " $";
                }
            }

            else if ("EUR" == cbFirstCurrency.Text && "EUR" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {

                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var eur = txtNumber.Text;
                    lblResult.Text = eur + " €";
                }
            }
            else if ("CAD" == cbFirstCurrency.Text && "CAD" == cbSecondCurrency.Text)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=" + cbFirstCurrency.Text + "&to=" + cbSecondCurrency.Text + "&q=1.0"),
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
                    var cad = txtNumber.Text;
                    lblResult.Text = cad + " c$";
                }
            }
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