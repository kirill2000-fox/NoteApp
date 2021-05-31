using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _noteData = new Note("Имя заметки", NoteCategory.Job, "Текст заметки");
        private bool _isCorrectData = true;

        /// <summary>
        /// Возвращает и задает данные формы
        /// </summary>
        public Note NoteData
        {
            get
            {
                return _noteData;
            }
            set
            {
                _noteData = value;
            }
        }

        public NoteForm()
        {
            InitializeComponent();
            foreach (NoteCategory category in Enum.GetValues(typeof(NoteCategory)))
            {
                if (category != NoteCategory.All)
                {
                    CategoryBox.Items.Add(category);
                }
            }
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            CategoryBox.SelectedItem = _noteData.Category;
            NameBox.Text = _noteData.Name;
            TextBox.Text = _noteData.Text;
            TimeCreatedPicker.Value = NoteData.TimeCreated;
            TimeModifiedPicker.Value = NoteData.TimeModified;

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
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _noteData.Text = TextBox.Text;
        }

        /// <summary>
        /// Поле названия заметки
        /// </summary>
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteData.Name = NameBox.Text;
                NameBox.BackColor = Color.White;
                _isCorrectData = true;
                TimeModifiedPicker.Text = _noteData.TimeModified.ToShortDateString();
            }
            catch (ArgumentException exception)
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
            _noteData.Category = (NoteCategory)CategoryBox.SelectedItem;
        }
    }
}
