using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimerForm.Controller;
using RomoTimerForm.View;
using System;
using System.Windows.Forms;

namespace RomoTimerForm
{
    public partial class Calculator : MaterialForm
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;

        private MaterialForm _parent;

        public Calculator(MaterialForm parent)
        {
            InitializeComponent();
            _parent = parent;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void Calculator_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName; //Display logged user
            lblCalculation.Text = ""; //Hide lblCalculation - . dot
            SettingsController.SavedSettings();
        }

        private void btnMoreToolsCalculator_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if(txtBox.Text == "0" || operandPerformed )
                txtBox.Clear();

            Button btn = (Button)sender;
            txtBox.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lblCalculation.Text = lblCalculation.Text + " " + txtBox.Text + " " + newOperand;

            switch (operand)
            {
                case "+": txtBox.Text = (result + Double.Parse(txtBox.Text)).ToString(); break;
                case "-": txtBox.Text = (result - Double.Parse(txtBox.Text)).ToString(); break;
                case "/": txtBox.Text = (result / Double.Parse(txtBox.Text)).ToString(); break;
                case "*": txtBox.Text = (result * Double.Parse(txtBox.Text)).ToString(); break;
                default:break;
            }
            result = Double.Parse(txtBox.Text);
            operand = newOperand;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            lblCalculation.Text = "";
            result = 0;
            operand = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblCalculation.Text = "";
            operandPerformed= true;
            switch (operand)
            {
                case "+": txtBox.Text = (result + Double.Parse(txtBox.Text)).ToString(); break;
                case "-": txtBox.Text = (result - Double.Parse(txtBox.Text)).ToString(); break;
                case "/": txtBox.Text = (result / Double.Parse(txtBox.Text)).ToString(); break;
                case "*": txtBox.Text = (result * Double.Parse(txtBox.Text)).ToString(); break;
                default: break;
            }
            result = Double.Parse(txtBox.Text);
            txtBox.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(!operandPerformed && !txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
            else if (operandPerformed)
            {
                txtBox.Text = "0";
            }
            if (!operandPerformed && !txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
            operandPerformed = false;
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }
    }
}
