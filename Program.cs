using System;
using System.Windows.Forms;

namespace RegistrationForm
{
    public class RegistrationForm : Form
    {
        private TextBox txtFirstName, txtLastName, txtEmail;
        private NumericUpDown numYear, numMonth, numDay;
        private RadioButton rbMale, rbFemale;
        private Button btnOK, btnClose;
        private Label lblResult;

        public RegistrationForm()
        {
            Text = "Ëàá. 1 - Ôîðìà ðåºñòðàö³¿";
            Width = 500;
            Height = 400;

            Label lblFirstName = new Label { Text = "²ì’ÿ:", Left = 10, Top = 10, Width = 100 };
            txtFirstName = new TextBox { Left = 120, Top = 10, Width = 280 };

            Label lblLastName = new Label { Text = "Ïð³çâèùå:", Left = 10, Top = 40, Width = 100 };
            txtLastName = new TextBox { Left = 120, Top = 40, Width = 280 };

            Label lblYear = new Label { Text = "Ð³ê íàðîäæåííÿ:", Left = 10, Top = 70, Width = 100 };
            numYear = new NumericUpDown { Left = 120, Top = 70, Width = 80, Minimum = 1900, Maximum = DateTime.Now.Year };

            Label lblMonth = new Label { Text = "Ì³ñÿöü:", Left = 210, Top = 70, Width = 50 };
            numMonth = new NumericUpDown { Left = 270, Top = 70, Width = 80, Minimum = 1, Maximum = 12 };

            Label lblDay = new Label { Text = "Äåíü:", Left = 10, Top = 100, Width = 100 };
            numDay = new NumericUpDown { Left = 120, Top = 100, Width = 80, Minimum = 1, Maximum = 31 };

            Label lblEmail = new Label { Text = "Email:", Left = 10, Top = 130, Width = 100 };
            txtEmail = new TextBox { Left = 120, Top = 130, Width = 280 };

            Label lblGender = new Label { Text = "Ñòàòü:", Left = 10, Top = 160, Width = 100 };
            rbMale = new RadioButton { Text = "×îëîâ³ê", Left = 120, Top = 160 };
            rbFemale = new RadioButton { Text = "Æ³íêà", Left = 220, Top = 160 };

            btnOK = new Button { Text = "OK", Left = 120, Top = 200, Width = 90 };
            btnOK.Click += BtnOK_Click;
            btnOK.DialogResult = DialogResult.OK;

            btnClose = new Button { Text = "Close", Left = 230, Top = 200, Width = 90 };
            btnClose.Click += (sender, e) => Close();
            btnClose.DialogResult = DialogResult.Cancel;

            lblResult = new Label { Left = 10, Top = 240, Width = 460, Height = 100, BorderStyle = BorderStyle.FixedSingle, AutoSize = false };

            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblYear);
            Controls.Add(numYear);
            Controls.Add(lblMonth);
            Controls.Add(numMonth);
            Controls.Add(lblDay);
            Controls.Add(numDay);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGender);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(btnOK);
            Controls.Add(btnClose);
            Controls.Add(lblResult);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "×îëîâ³ê" : rbFemale.Checked ? "Æ³íêà" : "Íå âêàçàíî";
            lblResult.Text = $"Äàí³:\n²ì’ÿ: {txtFirstName.Text}\nÏð³çâèùå: {txtLastName.Text}\nÄàòà íàðîäæåííÿ: {numDay.Value}.{numMonth.Value}.{numYear.Value}\nEmail: {txtEmail.Text}\nÑòàòü: {gender}";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrationForm());
        }
    }
}

//Завдання 2 Завдання 2 Завдання 2 Завдання 2 Завдання 2 Завдання 2

using System;
using System.Windows.Forms;

namespace IceCreamOrder
{
    public partial class IceCreamOrderForm : Form
    {
        private const decimal VanillaPrice = 50.0m;
        private const decimal ChocolatePrice = 55.0m;
        private const decimal StrawberryPrice = 60.0m;
        private const decimal MintPrice = 65.0m;

        public IceCreamOrderForm()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new IceCreamOrderForm());
        }

        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.vanillaCheckBox = new System.Windows.Forms.CheckBox();
            this.chocolateCheckBox = new System.Windows.Forms.CheckBox();
            this.strawberryCheckBox = new System.Windows.Forms.CheckBox();
            this.mintCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            this.calculateButton.Location = new System.Drawing.Point(150, 250);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 30);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Розрахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculatePriceButton_Click);

            this.quantityTextBox.Location = new System.Drawing.Point(150, 40);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(120, 22);
            this.quantityTextBox.TabIndex = 1;

            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(50, 40);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(97, 16);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "кількість порцій:";

            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(150, 290);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 16);
            this.totalPriceLabel.TabIndex = 2;

            this.vanillaCheckBox.AutoSize = true;
            this.vanillaCheckBox.Location = new System.Drawing.Point(50, 80);
            this.vanillaCheckBox.Name = "vanillaCheckBox";
            this.vanillaCheckBox.Size = new System.Drawing.Size(85, 20);
            this.vanillaCheckBox.TabIndex = 3;
            this.vanillaCheckBox.Text = "Ванільне";
            this.vanillaCheckBox.UseVisualStyleBackColor = true;

            this.chocolateCheckBox.AutoSize = true;
            this.chocolateCheckBox.Location = new System.Drawing.Point(50, 110);
            this.chocolateCheckBox.Name = "chocolateCheckBox";
            this.chocolateCheckBox.Size = new System.Drawing.Size(99, 20);
            this.chocolateCheckBox.TabIndex = 4;
            this.chocolateCheckBox.Text = "Шоколадне";
            this.chocolateCheckBox.UseVisualStyleBackColor = true;

            this.strawberryCheckBox.AutoSize = true;
            this.strawberryCheckBox.Location = new System.Drawing.Point(50, 140);
            this.strawberryCheckBox.Name = "strawberryCheckBox";
            this.strawberryCheckBox.Size = new System.Drawing.Size(98, 20);
            this.strawberryCheckBox.TabIndex = 5;
            this.strawberryCheckBox.Text = "Полуничне";
            this.strawberryCheckBox.UseVisualStyleBackColor = true;

            this.mintCheckBox.AutoSize = true;
            this.mintCheckBox.Location = new System.Drawing.Point(50, 170);
            this.mintCheckBox.Name = "mintCheckBox";
            this.mintCheckBox.Size = new System.Drawing.Size(61, 20);
            this.mintCheckBox.TabIndex = 6;
            this.mintCheckBox.Text = "Мятне";
            this.mintCheckBox.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.mintCheckBox);
            this.Controls.Add(this.strawberryCheckBox);
            this.Controls.Add(this.chocolateCheckBox);
            this.Controls.Add(this.vanillaCheckBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quantityLabel);
            this.Name = "IceCreamOrderForm";
            this.Text = "Замовлення морозива";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CalculatePriceButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(quantityTextBox.Text, out int quantity) && quantity > 0)
            {
                decimal totalPrice = 0;
                decimal discount = 1.0m;

                if (vanillaCheckBox.Checked)
                    totalPrice += VanillaPrice;
                if (chocolateCheckBox.Checked)
                    totalPrice += ChocolatePrice;
                if (strawberryCheckBox.Checked)
                    totalPrice += StrawberryPrice;
                if (mintCheckBox.Checked)
                    totalPrice += MintPrice;

                totalPrice *= quantity;

                if (quantity > 20)
                    discount = 0.95m;

                totalPrice *= discount;

                totalPriceLabel.Text = $"Загальна вартість: {totalPrice:N2} грн";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильну кількість порцій.");
            }
        }

        private Button calculateButton;
        private TextBox quantityTextBox;
        private Label totalPriceLabel;
        private CheckBox vanillaCheckBox;
        private CheckBox chocolateCheckBox;
        private CheckBox strawberryCheckBox;
        private CheckBox mintCheckBox;
        private Label quantityLabel;
    }
}

