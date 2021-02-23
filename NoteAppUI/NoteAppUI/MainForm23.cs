using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NoteApp;




namespace NoteAppUI
{

    public partial class MainForm23 : Form
    {
        public MainForm23()
        {

            InitializeComponent();

        }

        private void MainForm23_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Метод Описание заметок
        /// </summary>
        public void Description()
        {
            
                var note = new Note();
                note.Name = new string[]
                    {"Название"};
                note.Text = new string[]
                {
                    "Напомнить завтра Юле в 7 утра"
                };
                note.CategoryNotes = new string[]
                {
                    "Работа",
                    "Дом",
                    "Здоровье и спорт",
                    "Люди",
                    "Документы",
                    " Финансы",
                    "Разное"
                };
                
                note.TimeCreation = 11;
                note.TimeChange = 12;

        }



    }
}
        

    

