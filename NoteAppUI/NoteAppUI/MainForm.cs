using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создание переменной типа Project для работы с файлом
        /// </summary>
        private Project _project;

        /// <summary>
        /// Переменная для всех заметок
        /// </summary>
        private List<Note> _visibleNotes;

        /// <summary>
        /// Загрузка MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Загрузка заметок из файла
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            _visibleNotes = _project.TimeModifiedSort();
            _project.Notes = _visibleNotes;
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");

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
        /// Выбор первой заметки из списка
        /// </summary>
        private void SelectFirstNote()
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

        /// <summary>
        /// Обновление списка заметок после изменения списка.
        /// </summary>
        private void UpdateNotesListBoxAfterChange(Note note)
        {
            if (CategoryComboBox.SelectedItem != null && CategoryComboBox.SelectedItem != "All")
            {
                _visibleNotes = _project.TimeModifiedSortWithCategory((NoteCategory)CategoryComboBox.SelectedItem);
            }
            else
            {
                _visibleNotes = _project.TimeModifiedSort();
            }

            UpdateNotesListBox();

            if (CategoryComboBox.SelectedItem != null && CategoryComboBox.SelectedItem != "All")
            {
                if (note.Category.Equals((NoteCategory)CategoryComboBox.SelectedItem))
                {
                    var selectedNoteIndex = _visibleNotes.IndexOf(note);
                    NotesListBox.SelectedItem = NotesListBox.Items[selectedNoteIndex];
                }
                else
                {
                    SelectFirstNote();
                }
            }
            else
            {
                NotesListBox.SelectedItem = NotesListBox.Items[0];
            }
        }

        /// <summary>
        /// Очистка полей
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
                var addedNote = addForm.DefaultData;
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
                MessageBox.Show("No note selected for editing", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var realIndex = _project.Notes.IndexOf(selectedItem);

            try
            {
                var selectedNote = _project.Notes[realIndex];

                var editForm = new NoteForm();
                editForm.DefaultData = selectedNote.Clone() as Note;
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    var editedNote = editForm.DefaultData;

                    _project.Notes.RemoveAt(realIndex);
                    _project.Notes.Insert(realIndex, editedNote);
                    UpdateNotesListBoxAfterChange(editedNote);
                    ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                }
            }
            catch
            {
                MessageBox.Show("Note not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No note selected for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Do you really want to delete an note?", "Delete note ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                var selectedIndex = NotesListBox.SelectedIndex;
                var selectedNote = _visibleNotes[selectedIndex];
                var realIndex = _project.Notes.IndexOf(selectedNote);

                _project.Notes.RemoveAt(realIndex);

                if (CategoryComboBox.SelectedItem != null && CategoryComboBox.SelectedItem != "All")
                {
                    _visibleNotes = _project.TimeModifiedSortWithCategory((NoteCategory)CategoryComboBox.SelectedItem);
                }
                else
                {
                    _visibleNotes = _project.TimeModifiedSort();
                }

                UpdateNotesListBox();
                SelectFirstNote();
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
            createTip.SetToolTip(button5, "Add note");

            ToolTip changeTip = new ToolTip(); 
            changeTip.SetToolTip(button6, "Edit note");

            ToolTip deleteTip = new ToolTip();
            deleteTip.SetToolTip(button7, "Delete note");
        }

        /// <summary>
        /// Выбор заметки исходя из категории и названия
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получение заметки
            var selectedIndex = NotesListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            var selectedNote = _visibleNotes[selectedIndex];
            var realIndex = _project.Notes.IndexOf(selectedNote);
            //ДУБЛИРОВАНИЕ
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
        //ДУБЛИРОВАНИЕ
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null && CategoryComboBox.SelectedItem != "All")
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