using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {

        private Note _defaultData = new Note("Note name", NoteCategory.Job, "Note text");

        private bool _isCorrectData = true;

        /// <summary>
        /// Возвращает и задает данные формы
        /// </summary>
        public Note Note
        {
            get
            {
                return _defaultData;
            }
            set
            {
                _defaultData = value;
            }
        }

        public NoteForm()
        {
            InitializeComponent();
            foreach (NoteCategory category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryBox.Items.Add(category);
            }
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            CategoryBox.SelectedItem = _defaultData.Category;
            NameBox.Text = _defaultData.Name;
            TextBox.Text = _defaultData.Text;
            TimeCreatedPicker.Value = Note.TimeCreated;
            TimeModifiedPicker.Value = Note.TimeModified;

        }

        /// <summary>
        /// Кнопка выхода из заметки
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Кнопка Ok, закрывающая изменения
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!_isCorrectData)
            {
                MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Поле текста заметки
        /// </summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            _defaultData.Text = TextBox.Text;
        }

        /// <summary>
        /// Поле названия заметки
        /// </summary>
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _defaultData.Name = NameBox.Text;
                NameBox.BackColor = Color.White;
                _isCorrectData = true;
                TimeModifiedPicker.Text = _defaultData.TimeModified.ToShortDateString();
            }

            catch (ArgumentException)
            {
                NameBox.BackColor = Color.Red;
                _isCorrectData = false;
            }
        }

        /// <summary>
        /// Выбор категории
        /// </summary>
        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _defaultData.Category = (NoteCategory)CategoryBox.SelectedItem;
        }
    }
}
