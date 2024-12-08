namespace VisaSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USACitizen citizenUSA = new USACitizen();
            citizenUSA.NameSurname = "Alexander Richita";
            citizenUSA.Language = "English";
            citizenUSA.birthday = Convert.ToDateTime("1985-01-01");
            MessageBox.Show(citizenUSA.age.ToString()); //We convert value int to string.

        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            human human1 = new human();
            human1.NameSurname = "Arthur Morgan";
            human1.aliveornot = false;
            human human2 = new human();
            human2.NameSurname = "Dutch Van Der Linde";
            human2.aliveornot = true;
            human human3 = new human("Sadie Adler");
            human human4 = new human("Haytham Kenway");
            human human5 = new human()
            {
                NameSurname = "Micah Bell",
                aliveornot = true,

            };
            MessageBox.Show(human2.NameAnnounce());
            MessageBox.Show(human.Hello());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TurkeyCitizen citizentc = new TurkeyCitizen();
            citizentc.birthday =Convert.ToDateTime("1989-05-05");
            MessageBox.Show(citizentc.takevisa());
        }
    }
}
