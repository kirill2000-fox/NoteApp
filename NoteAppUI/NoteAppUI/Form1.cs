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
                DisplayNote();
            }
        }

        /// <summary>
        /// Отображение данных в заметке.
        /// </summary>
        public void DisplayNote()
        {
            if (_noteData == null)
            {
                textBox2.Text = DateTime.Now.ToString();
                textBox3.Text = DateTime.Now.ToString();
                return;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
