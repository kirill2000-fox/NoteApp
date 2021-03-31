﻿using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{

    public partial class MainForm23 : Form
    {
        private Project _project;
        private Note _note = new Note();

        public MainForm23()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(NoteCategory));
            _project = ProjectManager.LoadFromFile(ProjectManager.FileName);
            listBox1.DataSource = _project.Notes;
            listBox1.DisplayMember = "name";
            
        }

        private void MainForm23_Load(object sender, EventArgs e)
        {

            ToolTip createTip = new ToolTip(); 
            createTip.SetToolTip(button5, "Создать заметку");

            ToolTip changeTip = new ToolTip(); 
            changeTip.SetToolTip(button6, "Изменить заметку");

            ToolTip deleteTip = new ToolTip(); 
            deleteTip.SetToolTip(button7, "Удалить заметку");

            ToolTip saveTip  = new ToolTip(); 
            saveTip.SetToolTip(button1, "Сохранить изменения в файл");


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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Note note = (Note)listBox1.SelectedItem;

            //textBox1.Text = note;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
        

    

