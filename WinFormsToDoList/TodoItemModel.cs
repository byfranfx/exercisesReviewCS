using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsToDoList
{
    class TodoItemModel : INotifyPropertyChanged
    {
        private bool isComplete = false;
        private string todoText;
        private int positionNumber;

        public int PositionNumber
        {
            get => positionNumber;
            set
            {
                positionNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string TodoText
        {
            get => todoText; set
            {
                todoText = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsComplete
        {
            get => isComplete; set
            {
                isComplete = value;
                NotifyPropertyChanged();
            }
        }

        public string ToDoDisplay => $"{ PositionNumber }: { TodoText } (Complete: { IsComplete })";

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
