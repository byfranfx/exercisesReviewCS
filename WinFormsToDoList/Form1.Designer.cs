namespace WinFormsToDoList
{
    partial class Form1
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
            this.todoListLabel = new System.Windows.Forms.Label();
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.todoText = new System.Windows.Forms.TextBox();
            this.todoLabel = new System.Windows.Forms.Label();
            this.addUpdateTodo = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListLabel
            // 
            this.todoListLabel.AutoSize = true;
            this.todoListLabel.Location = new System.Drawing.Point(37, 38);
            this.todoListLabel.Name = "todoListLabel";
            this.todoListLabel.Size = new System.Drawing.Size(53, 13);
            this.todoListLabel.TabIndex = 0;
            this.todoListLabel.Text = "ToDo List";
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.Location = new System.Drawing.Point(40, 68);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(238, 342);
            this.todoListBox.TabIndex = 1;
            this.todoListBox.DoubleClick += new System.EventHandler(this.todoListBox_DoubleClick);
            this.todoListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.todoListBox_KeyPress);
            this.todoListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.todoListBox_PreviewKeyDown);
            // 
            // todoText
            // 
            this.todoText.Location = new System.Drawing.Point(305, 107);
            this.todoText.Name = "todoText";
            this.todoText.Size = new System.Drawing.Size(162, 20);
            this.todoText.TabIndex = 2;
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Location = new System.Drawing.Point(302, 68);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(82, 13);
            this.todoLabel.TabIndex = 3;
            this.todoLabel.Text = "New ToDo Item";
            // 
            // addUpdateTodo
            // 
            this.addUpdateTodo.Location = new System.Drawing.Point(305, 185);
            this.addUpdateTodo.Name = "addUpdateTodo";
            this.addUpdateTodo.Size = new System.Drawing.Size(158, 23);
            this.addUpdateTodo.TabIndex = 4;
            this.addUpdateTodo.Text = "AddToDoItem";
            this.addUpdateTodo.UseVisualStyleBackColor = true;
            this.addUpdateTodo.Click += new System.EventHandler(this.addUpdateTodo_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(305, 147);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(392, 147);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addUpdateTodo);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.todoText);
            this.Controls.Add(this.todoListBox);
            this.Controls.Add(this.todoListLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todoListLabel;
        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.TextBox todoText;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Button addUpdateTodo;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

