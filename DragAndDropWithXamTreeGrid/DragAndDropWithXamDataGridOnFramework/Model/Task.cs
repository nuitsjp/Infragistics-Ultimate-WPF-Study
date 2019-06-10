using System;
using System.Collections.Generic;

namespace DragAndDropWithXamDataGridOnFramework.Model
{
    public class Task
    {
        public Task(string title)
        {
            Title = title;
        }

        public int ID { get; set; }
        public string Title { get;}
        public DateTime Due { get; set; }
        public bool IsCompleted { get; set; }
    }
}