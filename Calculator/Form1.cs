using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ShowNumIn(Button selBut)
        {
            if (selBut != null)
            {
                if ("+-*/".Contains(selBut.Text) && LastCharacterIsOperator())
                {
                    MessageBox.Show("Cannot insert consecutive operators.");
                }
                else
                {
                    txtproc.Text += selBut.Text;
                }
            }
        }

        private void DeleteOneChar()
        {
            txtproc.Text = txtproc.Text.Remove(txtproc.TextLength - 1);
        }

        private void ClearData()
        {
            txtproc.Clear();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            ShowNumIn((Button)sender);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private bool LastCharacterIsOperator()
        {
            if (string.IsNullOrWhiteSpace(txtproc.Text))
                return false;

            char lastChar = txtproc.Text[txtproc.Text.Length - 1];
            return lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/';
        }


        private void answer_Click(object sender, EventArgs e)
        {
            if (LastCharacterIsOperator())
            {
                MessageBox.Show(" Please complete the expression or remove the operator.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string input = txtproc.Text;
                    var result = new DataTable().Compute(input, null);
                    txtproc.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    txtproc.Text = "Error: " + ex.Message;
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            DeleteOneChar();
        }
    }
}
