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
            Text = "���. 1 - ����� ���������";
            Width = 500;
            Height = 400;

            Label lblFirstName = new Label { Text = "���:", Left = 10, Top = 10, Width = 100 };
            txtFirstName = new TextBox { Left = 120, Top = 10, Width = 280 };

            Label lblLastName = new Label { Text = "�������:", Left = 10, Top = 40, Width = 100 };
            txtLastName = new TextBox { Left = 120, Top = 40, Width = 280 };

            Label lblYear = new Label { Text = "г� ����������:", Left = 10, Top = 70, Width = 100 };
            numYear = new NumericUpDown { Left = 120, Top = 70, Width = 80, Minimum = 1900, Maximum = DateTime.Now.Year };

            Label lblMonth = new Label { Text = "̳����:", Left = 210, Top = 70, Width = 50 };
            numMonth = new NumericUpDown { Left = 270, Top = 70, Width = 80, Minimum = 1, Maximum = 12 };

            Label lblDay = new Label { Text = "����:", Left = 10, Top = 100, Width = 100 };
            numDay = new NumericUpDown { Left = 120, Top = 100, Width = 80, Minimum = 1, Maximum = 31 };

            Label lblEmail = new Label { Text = "Email:", Left = 10, Top = 130, Width = 100 };
            txtEmail = new TextBox { Left = 120, Top = 130, Width = 280 };

            Label lblGender = new Label { Text = "�����:", Left = 10, Top = 160, Width = 100 };
            rbMale = new RadioButton { Text = "������", Left = 120, Top = 160 };
            rbFemale = new RadioButton { Text = "Ƴ���", Left = 220, Top = 160 };

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
            string gender = rbMale.Checked ? "������" : rbFemale.Checked ? "Ƴ���" : "�� �������";
            lblResult.Text = $"���:\n���: {txtFirstName.Text}\n�������: {txtLastName.Text}\n���� ����������: {numDay.Value}.{numMonth.Value}.{numYear.Value}\nEmail: {txtEmail.Text}\n�����: {gender}";
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
