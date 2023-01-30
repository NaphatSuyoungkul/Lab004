namespace LAB004
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btGPA_Click(object sender, EventArgs e)
        {
            string input_name = this.Name.Text;
            string input_year = this.Year.Text;
            int iYear = Int32.Parse(input_year);
            
            Person person = new Person(input_name, iYear);
            this.classroom.addPerson2Class(person);
           
            this.listofperson.Text =
                this.classroom.showAllPersoninClass();
            
            this.total.Text = "";
        }
    }
}