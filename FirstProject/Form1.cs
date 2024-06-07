using System.Security.Cryptography.X509Certificates;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        int[,] XO = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblclick(object sender, MouseEventArgs e)
        {

            int i, j;
            i = int.Parse(((Label)sender).Name[3].ToString());
            j = int.Parse(((Label)sender).Name[4].ToString());

            if (e.Button == MouseButtons.Left)
            {

                ((Label)sender).Text = "*";
                XO[i, j] = 1;
                check(i, j, 1);
            }
            else
            {
                ((Label)sender).Text = "$";
                XO[i, j] = 2;
                check(i, j, 2);
            }


        }

        public void check(int i, int j, int person)
        {
            rowcheck(i, j, person);
            colcheck(i, j, person);
            ghotreaslicheck(person);
            ghotrefareicheck(person);



        }
        public void rowcheck(int i, int j, int person)
        {
            if (XO[i, 0] == person && XO[i, 1] == person && XO[i, 2] == person)
            {
                MessageBox.Show($"player number {person.ToString()}  win the game ");
            }
        }

        public void colcheck(int i, int j, int person)
        {
            if (XO[0, j] == person && XO[1, j] == person && XO[2, j] == person)
            {
                MessageBox.Show($"player number {person.ToString()}  win the game ");
            }

        }

        public void ghotreaslicheck(int person)
        {
            if (XO[0, 0] == person && XO[1, 1] == person && XO[2, 2] == person)
            {
                MessageBox.Show($"player number {person.ToString()}  win the game ");
            }

        }

        public void ghotrefareicheck(int person)
        {
            if (XO[2, 0] == person && XO[1, 1] == person && XO[0, 2] == person)
            {
                MessageBox.Show($"player number {person.ToString()}  win the game ");
            }

        }

        private void lbl00_Click(object sender, EventArgs e)
        {

        }
    }
}
