using System;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{

    public partial class MainForm : Form
    {
        private Project _project;
        private Note _note = new Note("Имя заметки", NoteCategory.Job, "Текст заметки");
        private NoteForm F1 = new NoteForm();
        public MainForm()
        {

            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(NoteCategory));
            _project = ProjectManager.LoadFromFile(ProjectManager.FileName);
            
            UpdateNotesListBox();
            NotelistBox.DisplayMember = "name";
            
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateNotesListBox()
        {
            NotelistBox.Items.Clear();
            if (_project != null)
            {
                for (int i = 0; i < _project.Notes.Count; i++)
                {
                    if (_project.Notes[i].Name != "")
                        NotelistBox.Items.Add(_project.Notes[i]);
                    else
                        NotelistBox.Items.Add("Без названия");
                }
                if (_project.Notes.Count != 0)
                {
                    NotelistBox.SelectedItem = NotelistBox.Items[0];
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
                NotelistBox.Items.Add(addedNote);
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
            var selectedIndex = NotelistBox.SelectedIndex;
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
                    NotelistBox.Items.Insert(selectedIndex, editedNote.Name);
                    UpdateNotesListBox();
                    NotelistBox.SetSelected(selectedIndex, true);
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
            var selectedIdex = NotelistBox.SelectedIndex;
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

        /// <summary>
        /// Текстовая метка
        /// </summary>
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
        
        private void NotelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получение заметки
            var selectedNote = (Note)NotelistBox.SelectedItem;

            LableName.Text = selectedNote.Name;
            LableCategory.Text = selectedNote.Category.ToString();
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
        private void Click_NotelistBox(object sender, EventArgs e)
        {
            if (NotelistBox.SelectedIndex != -1)
            {
                textBox3.Text = _project.Notes[NotelistBox.SelectedIndex].Text;
            }
        }
        /// <summary>
        /// Помощь и информация
        /// </summary>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }
    }
}
        

    

