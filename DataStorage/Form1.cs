using Newtonsoft.Json;
namespace DataStorage
{
    public partial class Form1 : Form
    {
        DataManager manager = new DataManager();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = manager.students;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "" || NameText.Text == "" || AgeText.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                manager.AddStudent(new Student(IDText.Text, NameText.Text, Convert.ToInt32(AgeText.Text))) ;
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager.GetStudents();
                History.DataSource = manager.students.ConvertAll(x => "ID : "+x.Id+ " Name : " + x.Name+ " Age : " + x.Age);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             manager.students.Clear();
            History.DataSource= manager.students;

        }
    }
}