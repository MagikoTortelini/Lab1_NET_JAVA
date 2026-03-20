using Lab1;

namespace GUI
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<TextBox> pola = new List<TextBox>() { Liczbaprzedmiotow, Seed, pojemnosc };
            Wartosc.Clear();
            Wynik.Clear();
            int temp = 0;

            foreach (TextBox tb in pola)
            {

                int parse;
                if (string.IsNullOrEmpty(tb.Text) || !(int.TryParse(tb.Text, out parse)))
                {
                    tb.BackColor = Color.PaleVioletRed;
                    tb.Text = "Pole jest puste lub jest napisem";
                }
                else
                {
                    if (int.Parse(tb.Text) <= 0)
                    {
                        tb.BackColor = Color.PaleVioletRed;
                        tb.Text = "Wartosc wynosi 0 lub jest ujemna";
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                        temp += 1;
                    }

                }
            }


            if (temp == 3)
            {

                Problem problem = new Problem(int.Parse(Liczbaprzedmiotow.Text), int.Parse(Seed.Text));
                var result = problem.Solve(int.Parse(pojemnosc.Text));
                Wynik.Text = result.ToString();
                List<string> list = new List<string>();
                for (int i = 0; i < int.Parse(Liczbaprzedmiotow.Text); i++)
                {
                    list.Add(problem.print_numbers(i));
                }

                Wartosc.Lines = list.ToArray();


            }

        }
    }
}
