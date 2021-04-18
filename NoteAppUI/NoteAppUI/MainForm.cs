using System;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{

    public partial class MainForm : Form
    {
        private Project _project;
        private Note _note = new Note();
        private Form1 F1 = new Form1();
        public MainForm()
        { 
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(NoteCategory));
            _project = ProjectManager.LoadFromFile(ProjectManager.FileName);
           
            UpdateNotesListBox();
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
                        listBox1.Items.Add(_project.Notes[i]);
                    else
                        listBox1.Items.Add("Без названия");
                }
                if (_project.Notes.Count != 0)
                {
                    listBox1.SelectedItem = listBox1.Items[0];
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
                listBox1.Items.Add(addedNote);
                UpdateNotesListBox();
            }
            else return;

            ProjectManager.SaveToFile(_project, ProjectManager.FileName);
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
                    ProjectManager.SaveToFile(_project, ProjectManager.FileName);
                }
                else return;
            }
            catch
            {
                MessageBox.Show("Запись не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public MainForm(string text) // <-- Новый конструктор формы
        {
            InitializeComponent();
            
        }
        
        private void MainForm23_Load(object sender, EventArgs e)
        
        {
            ToolTip createTip = new ToolTip(); 
            createTip.SetToolTip(button5, "Создать заметку");

            ToolTip changeTip = new ToolTip(); 
            changeTip.SetToolTip(button6, "Изменить заметку");

            ToolTip deleteTip = new ToolTip();
            deleteTip.SetToolTip(button7, "Удалить заметку");
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
            About frm = new About();
            frm.ShowDialog();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получение заметки
            var selectedNote = (Note)listBox1.SelectedItem;


            dateTimePicker1.Value = selectedNote.TimeCreated;
            dateTimePicker2.Value = selectedNote.TimeModified;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoveNote();
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

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
        }
        //вывод значения
        private void Click_listBox1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox3.Text = _project.Notes[listBox1.SelectedIndex].Text;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
       
    }
}
        

    

