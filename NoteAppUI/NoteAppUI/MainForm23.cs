using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{

    public partial class MainForm23 : Form
    {
        private Project _project;
        private Note _note = new Note();
        private Form1 F1 = new Form1();
        public MainForm23()
        {
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(NoteCategory));
            _project = ProjectManager.LoadFromFile(ProjectManager.FileName);
            if (_project == null)
                _project = new Project();
            UpdateNotesListBox();
            listBox1.DataSource = _project.Notes;
            listBox1.DisplayMember = "name";
            
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateNotesListBox()
        {
            listBox1.Items.Clear();
            if (_project != null)
            {
                for (int i = 0; i < _project.Notes.Count; i++)
                {
                    if (_project.Notes[i].Name != "")
                        listBox1.Items.Add(_project.Notes[i].Name);
                    else
                        listBox1.Items.Add("Без названия");
                }

            }
        }

        private void AddNote()
        {
            var addForm = new Form1();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                var addedNote = addForm.NoteData;

                _project.Notes.Add(addedNote);
                //listBox1.Items.Add(addedNote);
                UpdateNotesListBox();
            }
            else return;
        }

        private void EditNote()
        {
            var selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Не выбрана запись для редактирования", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedNote = _project.Notes[selectedIndex];

                var editForm = new Form1();
                editForm.NoteData = selectedNote;
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    var editedNote = editForm.NoteData;

                    _project.Notes.Insert(selectedIndex, editedNote);
                    listBox1.Items.Insert(selectedIndex, editedNote.Name);
                    _project.Notes.RemoveAt(selectedIndex + 1);
                    UpdateNotesListBox();
                    listBox1.SetSelected(selectedIndex, true);
                }
                else return;
            }
            catch
            {
                MessageBox.Show("Запись не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public MainForm23(string text) // <-- Новый конструктор формы
        {
            InitializeComponent();
            textBox1.Text = text;
        }
        
        private void MainForm23_Load(object sender, EventArgs e)
        
        {
            MessageBox.Show("Создайте свою заметку!", "Добро Пожаловать");
                

            ToolTip createTip = new ToolTip(); 
            createTip.SetToolTip(button5, "Создать заметку");

            ToolTip changeTip = new ToolTip(); 
            changeTip.SetToolTip(button6, "Изменить заметку");

            ToolTip deleteTip = new ToolTip(); 
            deleteTip.SetToolTip(button7, "Удалить заметку");

            ToolTip saveTip  = new ToolTip(); 
            saveTip.SetToolTip(button1, "Сохранить изменения в файл");


        }
        private void RemoveNote()
        {
            var selectedIdex = listBox1.SelectedIndex;
            if (selectedIdex == -1)
            {
                MessageBox.Show("Не выбрана запись для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Вы дейcтвительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                _project.Notes.RemoveAt(selectedIdex);
                UpdateNotesListBox();
            }

          
            ProjectManager.SaveToFile(_project, ProjectManager.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информацию о ваших проблемах вы можете найти на сайте http//...", "Help",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
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
            //F1.ShowDialog();
            
            AddNote();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            F1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           EditNote();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

           
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        

    

