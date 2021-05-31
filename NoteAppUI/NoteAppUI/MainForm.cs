using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{

    public partial class MainForm : Form
    {
        private Project _project;
        private Note _note = new Note("Имя заметки", NoteCategory.Job, "Текст заметки");
        private List<Note> _visibleNotes;
        private NoteForm F1 = new NoteForm();
        public MainForm()
        {

            InitializeComponent();

            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            _visibleNotes = _project.TimeModifiedSort();
            _project.Notes = _visibleNotes;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            CategoryComboBox.SelectedItem = NoteCategory.All;

            UpdateNotesListBox();
            if (_project.SelectedNote != null)
            {
                var selectedIndex = _project.Notes.IndexOf(_project.SelectedNote);
                NotesListBox.SelectedItem = NotesListBox.Items[selectedIndex];
            }

        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateNotesListBox()
        {
            NotesListBox.Items.Clear();

            foreach (var note in _visibleNotes)
            {
                NotesListBox.Items.Add(note.Name);
            }
        }

        /// <summary>
        /// Обновление списка заметок после изменения списка.
        /// </summary>
        private void UpdateNotesListBoxAfterChange(Note note)
        {
            if ((NoteCategory)CategoryComboBox.SelectedItem != NoteCategory.All)
            {
                _visibleNotes = _project.TimeModifiedSortWithCategory((NoteCategory)CategoryComboBox.SelectedItem);
            }
            else
            {
                _visibleNotes = _project.TimeModifiedSort();
            }

            UpdateNotesListBox();

            if ((NoteCategory)CategoryComboBox.SelectedItem != NoteCategory.All)
            {
                if (note.Category.Equals((NoteCategory)CategoryComboBox.SelectedItem))
                {
                    var selectedNoteIndex = _visibleNotes.IndexOf(note);
                    NotesListBox.SelectedItem = NotesListBox.Items[selectedNoteIndex];
                }
                else
                {
                    if (NotesListBox.Items.Count > 0)
                    {
                        NotesListBox.SelectedItem = NotesListBox.Items[0];
                    }
                    else
                    {
                        _project.SelectedNote = null;
                        ClearAll();
                    }
                }
            }
            else
            {
                NotesListBox.SelectedItem = NotesListBox.Items[0];
            }
        }

        /// <summary>
        /// Очитстка полей
        /// </summary>
        private void ClearAll()
        {
            LableName.Text = "";
            LableCategory.Text = "";
            TimeCreatedPicker.Text = DateTime.Now.ToString();
            TimeModifiedPicker.Text = DateTime.Now.ToString();
            ContentTextBox.Clear();
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
                UpdateNotesListBoxAfterChange(addedNote);
            }
            else return;
            
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
        }

        /// <summary>
        /// Функция редактирования заметки
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = NotesListBox.SelectedIndex;
            var selectedItem = _visibleNotes[selectedIndex];
            if (selectedItem == null)
            {
                MessageBox.Show("Не выбрана запись для редактирования", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var realIndex = _project.Notes.IndexOf(selectedItem);

            try
            {
                var selectedNote = _project.Notes[realIndex];

                var editForm = new NoteForm();
                editForm.NoteData = selectedNote.Clone() as Note;
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    var editedNote = editForm.NoteData;

                    _project.Notes.RemoveAt(realIndex);
                    _project.Notes.Insert(realIndex, editedNote);
                    UpdateNotesListBoxAfterChange(editedNote);
                    ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
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
            var selectedIdex = NotesListBox.SelectedIndex;
            if (selectedIdex == -1)
            {
                MessageBox.Show("Не выбрана запись для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Вы дейcтвительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                var selectedIndex = NotesListBox.SelectedIndex;
                var selectedNote = _visibleNotes[selectedIndex];
                var realIndex = _project.Notes.IndexOf(selectedNote);

                var copyNote = (Note)selectedNote.Clone();
                _project.Notes.RemoveAt(realIndex);

                if ((NoteCategory)CategoryComboBox.SelectedItem != NoteCategory.All)
                {
                    _visibleNotes = _project.TimeModifiedSortWithCategory((NoteCategory)CategoryComboBox.SelectedItem);
                }
                else
                {
                    _visibleNotes = _project.TimeModifiedSort();
                }

                UpdateNotesListBox();

                if (NotesListBox.Items.Count > 0)
                {
                    NotesListBox.SelectedItem = NotesListBox.Items[0];
                }
                else
                {
                    _project.SelectedNote = null;
                    ClearAll();
                }
            }


            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
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
        /// Выбор заметки исходя из категории и названия
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получение заметки
            var selectedIndex = NotesListBox.SelectedIndex;
            var selectedNote = _visibleNotes[selectedIndex];
            var realIndex = _project.Notes.IndexOf(selectedNote);

            LableName.Text = selectedNote.Name;
            LableCategory.Text = selectedNote.Category.ToString();
            ContentTextBox.Text = selectedNote.Text;
            TimeCreatedPicker.Value = selectedNote.TimeCreated;
            TimeModifiedPicker.Value = selectedNote.TimeModified;

            _project.SelectedNote = _project.Notes[realIndex];
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

        /// <summary>
        /// Помощь и информация
        /// </summary>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((NoteCategory)CategoryComboBox.SelectedItem != NoteCategory.All)
            {
                _visibleNotes = _project.TimeModifiedSortWithCategory((NoteCategory)CategoryComboBox.SelectedIndex);
            }
            else
            {
                _visibleNotes = _project.TimeModifiedSort();
            }

            NotesListBox.Items.Clear();

            foreach (var note in _visibleNotes)
            {
                NotesListBox.Items.Add(note.Name);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            Close();
        }

    }
}