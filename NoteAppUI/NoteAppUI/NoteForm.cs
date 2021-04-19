using System;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _noteData = new Note(NoteCategory.Documents);

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
            comboBox1.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = _noteData.Category;
            textBox1.Text = _noteData.Name;
            textBox4.Text = _noteData.Text;
            dateTimePicker1.Value = NoteData.TimeCreated;
            dateTimePicker2.Value = NoteData.TimeModified;

        }

        /// <summary>
        /// Кнопка выхода из заметки
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            _noteData.Text = textBox4.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _noteData.Name = textBox1.Text;
            //dateTimePicker2.Value = _noteData.TimeModified;
        }

        /// <summary>
        /// Выбор категории
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _noteData.Category = (NoteCategory)comboBox1.SelectedItem;
        }
    }
}
