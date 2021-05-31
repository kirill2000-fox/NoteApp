
namespace NoteAppUI
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeCreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeModifiedPicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(11, 24);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(583, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Canсel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(476, 343);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(57, 20);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(7, 98);
            this.TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(588, 243);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название заметки";
            // 
            // TimeCreatedPicker
            // 
            this.TimeCreatedPicker.CustomFormat = "dd.MM.yyyyy HH:mm";
            this.TimeCreatedPicker.Enabled = false;
            this.TimeCreatedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeCreatedPicker.Location = new System.Drawing.Point(223, 75);
            this.TimeCreatedPicker.Margin = new System.Windows.Forms.Padding(2);
            this.TimeCreatedPicker.Name = "TimeCreatedPicker";
            this.TimeCreatedPicker.Size = new System.Drawing.Size(151, 20);
            this.TimeCreatedPicker.TabIndex = 7;
            // 
            // TimeModifiedPicker
            // 
            this.TimeModifiedPicker.CustomFormat = "dd.MM.yyyyy HH:mm";
            this.TimeModifiedPicker.Enabled = false;
            this.TimeModifiedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeModifiedPicker.Location = new System.Drawing.Point(443, 75);
            this.TimeModifiedPicker.Margin = new System.Windows.Forms.Padding(2);
            this.TimeModifiedPicker.Name = "TimeModifiedPicker";
            this.TimeModifiedPicker.Size = new System.Drawing.Size(151, 20);
            this.TimeModifiedPicker.TabIndex = 8;
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(66, 58);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(92, 21);
            this.CategoryBox.TabIndex = 9;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modified:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.TimeModifiedPicker);
            this.Controls.Add(this.TimeCreatedPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimeCreatedPicker;
        private System.Windows.Forms.DateTimePicker TimeModifiedPicker;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}