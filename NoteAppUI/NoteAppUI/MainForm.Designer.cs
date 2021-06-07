
namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategory = new System.Windows.Forms.Label();
            this.AddNotebutton = new System.Windows.Forms.Button();
            this.EditNotebutton = new System.Windows.Forms.Button();
            this.DeleteNotebutton = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.TimeModifiedPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeCreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.Created = new System.Windows.Forms.Label();
            this.Modified = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LableCategory = new System.Windows.Forms.TextBox();
            this.LableName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(119, 2);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(236, 24);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategory
            // 
            this.ShowCategory.AutoSize = true;
            this.ShowCategory.Location = new System.Drawing.Point(4, 5);
            this.ShowCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowCategory.Name = "ShowCategory";
            this.ShowCategory.Size = new System.Drawing.Size(107, 17);
            this.ShowCategory.TabIndex = 10;
            this.ShowCategory.Text = "Show Category:";
            // 
            // AddNotebutton
            // 
            this.AddNotebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNotebutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddNotebutton.FlatAppearance.BorderSize = 0;
            this.AddNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNotebutton.Image = ((System.Drawing.Image)(resources.GetObject("AddNotebutton.Image")));
            this.AddNotebutton.Location = new System.Drawing.Point(7, 462);
            this.AddNotebutton.Margin = new System.Windows.Forms.Padding(4);
            this.AddNotebutton.Name = "AddNotebutton";
            this.AddNotebutton.Size = new System.Drawing.Size(50, 50);
            this.AddNotebutton.TabIndex = 11;
            this.AddNotebutton.UseVisualStyleBackColor = true;
            this.AddNotebutton.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // EditNotebutton
            // 
            this.EditNotebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNotebutton.FlatAppearance.BorderSize = 0;
            this.EditNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNotebutton.Image = ((System.Drawing.Image)(resources.GetObject("EditNotebutton.Image")));
            this.EditNotebutton.Location = new System.Drawing.Point(56, 462);
            this.EditNotebutton.Margin = new System.Windows.Forms.Padding(4);
            this.EditNotebutton.Name = "EditNotebutton";
            this.EditNotebutton.Size = new System.Drawing.Size(50, 50);
            this.EditNotebutton.TabIndex = 12;
            this.EditNotebutton.UseVisualStyleBackColor = true;
            this.EditNotebutton.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // DeleteNotebutton
            // 
            this.DeleteNotebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNotebutton.FlatAppearance.BorderSize = 0;
            this.DeleteNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNotebutton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteNotebutton.Image")));
            this.DeleteNotebutton.Location = new System.Drawing.Point(105, 462);
            this.DeleteNotebutton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteNotebutton.Name = "DeleteNotebutton";
            this.DeleteNotebutton.Size = new System.Drawing.Size(50, 50);
            this.DeleteNotebutton.TabIndex = 13;
            this.DeleteNotebutton.UseVisualStyleBackColor = true;
            this.DeleteNotebutton.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.Location = new System.Drawing.Point(8, 127);
            this.ContentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(681, 397);
            this.ContentTextBox.TabIndex = 17;
            // 
            // TimeModifiedPicker
            // 
            this.TimeModifiedPicker.CustomFormat = "dd.MM.yyyyy HH:mm";
            this.TimeModifiedPicker.Enabled = false;
            this.TimeModifiedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeModifiedPicker.Location = new System.Drawing.Point(290, 96);
            this.TimeModifiedPicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimeModifiedPicker.Name = "TimeModifiedPicker";
            this.TimeModifiedPicker.Size = new System.Drawing.Size(125, 22);
            this.TimeModifiedPicker.TabIndex = 19;
            // 
            // TimeCreatedPicker
            // 
            this.TimeCreatedPicker.CustomFormat = "dd.MM.yyyyy HH:mm";
            this.TimeCreatedPicker.Enabled = false;
            this.TimeCreatedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeCreatedPicker.Location = new System.Drawing.Point(75, 97);
            this.TimeCreatedPicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimeCreatedPicker.Name = "TimeCreatedPicker";
            this.TimeCreatedPicker.Size = new System.Drawing.Size(125, 22);
            this.TimeCreatedPicker.TabIndex = 18;
            // 
            // Created
            // 
            this.Created.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Created.AutoSize = true;
            this.Created.Location = new System.Drawing.Point(5, 101);
            this.Created.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(62, 17);
            this.Created.TabIndex = 21;
            this.Created.Text = "Created:";
            // 
            // Modified
            // 
            this.Modified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modified.AutoSize = true;
            this.Modified.Location = new System.Drawing.Point(217, 101);
            this.Modified.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modified.Name = "Modified";
            this.Modified.Size = new System.Drawing.Size(65, 17);
            this.Modified.TabIndex = 20;
            this.Modified.Text = "Modified:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 526);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NotesListBox);
            this.panel1.Controls.Add(this.DeleteNotebutton);
            this.panel1.Controls.Add(this.EditNotebutton);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Controls.Add(this.ShowCategory);
            this.panel1.Controls.Add(this.AddNotebutton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 517);
            this.panel1.TabIndex = 0;
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.HorizontalScrollbar = true;
            this.NotesListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NotesListBox.IntegralHeight = false;
            this.NotesListBox.ItemHeight = 18;
            this.NotesListBox.Location = new System.Drawing.Point(7, 31);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(349, 424);
            this.NotesListBox.TabIndex = 14;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LableCategory);
            this.panel2.Controls.Add(this.LableName);
            this.panel2.Controls.Add(this.Category);
            this.panel2.Controls.Add(this.ContentTextBox);
            this.panel2.Controls.Add(this.Modified);
            this.panel2.Controls.Add(this.TimeCreatedPicker);
            this.panel2.Controls.Add(this.Created);
            this.panel2.Controls.Add(this.TimeModifiedPicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 526);
            this.panel2.TabIndex = 0;
            // 
            // LableCategory
            // 
            this.LableCategory.BackColor = System.Drawing.SystemColors.Menu;
            this.LableCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LableCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableCategory.Location = new System.Drawing.Point(75, 70);
            this.LableCategory.Name = "LableCategory";
            this.LableCategory.Size = new System.Drawing.Size(105, 17);
            this.LableCategory.TabIndex = 26;
            // 
            // LableName
            // 
            this.LableName.BackColor = System.Drawing.SystemColors.Menu;
            this.LableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LableName.Enabled = false;
            this.LableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableName.Location = new System.Drawing.Point(8, 25);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(682, 30);
            this.LableName.TabIndex = 25;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(5, 73);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(69, 17);
            this.Category.TabIndex = 23;
            this.Category.Text = "Category:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowCategory;
        private System.Windows.Forms.Button AddNotebutton;
        private System.Windows.Forms.Button EditNotebutton;
        private System.Windows.Forms.Button DeleteNotebutton;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.DateTimePicker TimeModifiedPicker;
        private System.Windows.Forms.DateTimePicker TimeCreatedPicker;
        private System.Windows.Forms.Label Created;
        private System.Windows.Forms.Label Modified;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.TextBox LableName;
        private System.Windows.Forms.TextBox LableCategory;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

