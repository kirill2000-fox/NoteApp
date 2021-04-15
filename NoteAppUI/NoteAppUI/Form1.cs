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
            try
            {
                _noteData.Name = textBox1.Text;
            }
            catch (Exception exceptionText)
            {
                MessageBox.Show(exceptionText.Message, "Превышение длины строки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = _noteData.Name;
            }
            
            _noteData.Text = textBox1.Text;
            
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

  
        }
    }
}
