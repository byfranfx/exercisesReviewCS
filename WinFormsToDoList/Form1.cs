using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsToDoList
{
    public partial class Form1 : Form
    {
        BindingList<TodoItemModel> TodoList = new BindingList<TodoItemModel>();
        TodoItemModel currentEdit = null;

        public Form1()
        {
            InitializeComponent();
            todoListBox.DataSource = TodoList;
            todoListBox.DisplayMember = nameof(TodoItemModel.TodoText);



        }

        private void AddTodo(string todoText)
        {
            TodoItemModel todo = new TodoItemModel
            {
                PositionNumber = TodoList.Count + 1,
                TodoText = todoText
            };
            TodoList.Add(todo);
        }
        private void ReorderTodos()
        {
            for(int i = 0; i < TodoList.Count; i++)
            {
                TodoList[i].PositionNumber = (i + 1);
            }
        }
        private void DeleteItem(TodoItemModel todo)
        {
            TodoList.Remove(todo);
            ReorderTodos();
        }
        private void StartEditingItem(TodoItemModel todo)
        {
            currentEdit = todo;
            todoLabel.Text = "Update ToDo Item";
            addUpdateTodo.Text = "Edit ToDo Item";
            todoText.Text = currentEdit.TodoText;
            
        }
        private void CompletedEditingItem()
        {
            currentEdit.TodoText = todoText.Text;
            currentEdit = null;
            todoLabel.Text = "New ToDo Item";
            addUpdateTodo.Text = "Add ToDo item";
        }
        private void CompletedItem(TodoItemModel todo)
        {
            todo.IsComplete = true;
        }
        private void addUpdateTodo_Click(object sender, EventArgs e)
        {
            if(currentEdit == null)
            {
                AddTodo(todoText.Text);
            } else
            {
                CompletedEditingItem();
            }
            todoText.Text = "";
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if(todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                StartEditingItem(todo);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                DeleteItem(todo);
            }
        }

        private void todoListBox_DoubleClick(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                CompletedItem(todo);
            }
        }
    }
}
