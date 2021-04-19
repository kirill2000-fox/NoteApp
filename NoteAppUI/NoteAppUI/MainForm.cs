using System;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{

    public partial class MainForm : Form
    {
        private Project _project;
        private Note _note = new Note(NoteCategory.Documents);
        private NoteForm F1 = new NoteForm();
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
        /// <summary>
        /// Функция добавления заметки
        /// </summary>
        private void AddNote()
        {
            var addForm = new NoteForm();
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

        /// <summary>
        /// Функция редактирования заметки
        /// </summary>
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

                var editForm = new NoteForm();
                editForm.NoteData = selectedNote;
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    var editedNote = editForm.NoteData;

                    _project.Notes.RemoveAt(selectedIndex);
                    _project.Notes.Insert(selectedIndex, editedNote);
                    listBox1.Items.Insert(selectedIndex, editedNote.Name);
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

        /// <summary>
        /// Функция удаления заметки
        /// </summary>
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

        public MainForm(string text) // <-- Новый конструктор формы
        {
            InitializeComponent();
            
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        
        {
            ToolTip createTip = new ToolTip(); 
            createTip.SetToolTip(button5, "Создать заметку");

            ToolTip changeTip = new ToolTip(); 
            changeTip.SetToolTip(button6, "Изменить заметку");

            ToolTip deleteTip = new ToolTip();
            deleteTip.SetToolTip(button7, "Удалить заметку");
        }


        /// <summary>
        /// Кнопка "О заметки"
        /// </summary>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получение заметки
            var selectedNote = (Note)listBox1.SelectedItem;

            label4.Text = selectedNote.Name;
            label6.Text = selectedNote.Category.ToString();
            dateTimePicker1.Value = selectedNote.TimeCreated;
            dateTimePicker2.Value = selectedNote.TimeModified;
        }

        /// <summary>
        /// Кнопка добавления земетки
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Кнопка изменения земетки
        /// </summary>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Кнопка удаления земетки
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        //вывод значения
        private void Click_listBox1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox3.Text = _project.Notes[listBox1.SelectedIndex].Text;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
        

    

