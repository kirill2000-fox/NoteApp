using System;
using System.Windows.Forms;
using NoteApp;




namespace NoteAppUI
{

    public partial class MainForm23 : Form
    {
        public MainForm23()
        {

            InitializeComponent();

        }

        private void MainForm23_Load(object sender, EventArgs e)
        {
           
            


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            DateTime time1 = DateTime.Now;
            Note note = new Note("Pet", "All king`s horses", "Sport", time, time1);

            // Получает путь к особой системной папке.

            string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NoteApp/";
            
            Project serialize = new Project {Notes = {note}};
            ProjectManager.SaveToFile(serialize, ProjectManager.FileName);
            Project deserialize = ProjectManager.LoadFromFile(ProjectManager.FileName);
        }
    }
}
        

    

