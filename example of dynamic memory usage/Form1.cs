namespace example_of_dynamic_memory_usage
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter a student name.");
                return;
            }

            Student student = new Student(txtStudentName.Text);
            students.Add(student);

            UpdateStudentList();

            txtStudentName.Clear();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student to remove.");
                return;
            }

            int selectedIndex = lstStudents.SelectedIndex;
            students.RemoveAt(selectedIndex);

            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            lstStudents.Items.Clear();
            foreach (Student student in students)
            {
                lstStudents.Items.Add(student.Name);
            }
        }
    }
}
