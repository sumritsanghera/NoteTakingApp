namespace NoteTakingApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNotes = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            newNoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(304, 39);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(570, 27);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(304, 107);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(570, 391);
            noteBox.TabIndex = 1;
            noteBox.TextChanged += noteBox_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(570, 25);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(304, 76);
            label2.Name = "label2";
            label2.Size = new Size(570, 25);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = SystemColors.Control;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(9, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 51;
            previousNotes.RowTemplate.Height = 29;
            previousNotes.Size = new Size(286, 423);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(36, 476);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(94, 29);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(136, 476);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(136, 441);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.Location = new Point(36, 441);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(94, 29);
            newNoteButton.TabIndex = 8;
            newNoteButton.Text = "New";
            newNoteButton.UseVisualStyleBackColor = true;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(886, 510);
            Controls.Add(newNoteButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Name = "NoteTaker";
            Text = "Notes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button saveButton;
        private Button newNoteButton;
    }
}