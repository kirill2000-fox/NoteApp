using System;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
    public partial class Form1 : Form
    {
        private Note _noteData = new Note();

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

        /// <summary>
        /// Отображение данных в заметке.
        /// </summary>
        public void DisplayNote()
        {

        }

        public Form1()
        {
            InitializeComponent();
            DisplayNote();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = NoteData.TimeCreated;
            dateTimePicker2.Value = NoteData.TimeModified;

        }

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _noteData.Name = textBox1.Text;
            dateTimePicker2.Value = _noteData.TimeModified;
        }
    }
}
