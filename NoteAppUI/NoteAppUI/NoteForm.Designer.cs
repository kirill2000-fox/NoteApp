
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
            this.labelName2 = new System.Windows.Forms.Label();
            this.TimeCreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeModifiedPicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelModified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(81, 6);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(712, 24);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(717, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Canсel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(635, 412);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(76, 25);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(9, 98);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(783, 310);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // labelName2
            // 
            this.labelName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(6, 9);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(49, 17);
            this.labelName2.TabIndex = 6;
            this.labelName2.Text = "Name:";
            // 
            // TimeCreatedPicker
            // 
            this.TimeCreatedPicker.CustomFormat = "dd.MM.yyyyy HH:mm";
            this.TimeCreatedPicker.Enabled = false;
            this.TimeCreatedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeCreatedPicker.Location = new System.Drawing.Point(81, 70);
            this.TimeCreatedPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeCreatedPicker.Name = "TimeCreatedPicker";
            this.TimeCreatedPicker.Size = new System.Drawing.Size(141, 22);
            this.TimeCreatedPicker.TabIndex = 7;
            // 
            // TimeModifiedPicker
            // 
            this.TimeModifiedPicker.CustomFormat = "dd.MM.yyyyy HH:mm";
            this.TimeModifiedPicker.Enabled = false;
            this.TimeModifiedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeModifiedPicker.Location = new System.Drawing.Point(315, 72);
            this.TimeModifiedPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeModifiedPicker.Name = "TimeModifiedPicker";
            this.TimeModifiedPicker.Size = new System.Drawing.Size(141, 22);
            this.TimeModifiedPicker.TabIndex = 8;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(81, 38);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(169, 24);
            this.CategoryBox.TabIndex = 9;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(6, 41);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 17);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Category:";
            // 
            // labelCreated
            // 
            this.labelCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCreated.AutoSize = true;
            this.labelCreated.Location = new System.Drawing.Point(6, 72);
            this.labelCreated.Margin = new System.Windows.Forms.Padding(3);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(62, 17);
            this.labelCreated.TabIndex = 11;
            this.labelCreated.Text = "Created:";
            // 
            // labelModified
            // 
            this.labelModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelModified.AutoSize = true;
            this.labelModified.Location = new System.Drawing.Point(240, 72);
            this.labelModified.Name = "labelModified";
            this.labelModified.Size = new System.Drawing.Size(65, 17);
            this.labelModified.TabIndex = 12;
            this.labelModified.Text = "Modified:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.labelModified);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.TimeModifiedPicker);
            this.Controls.Add(this.TimeCreatedPicker);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.DateTimePicker TimeCreatedPicker;
        private System.Windows.Forms.DateTimePicker TimeModifiedPicker;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelModified;
    }
}