using System;
using DragAndDropWithXamDataGridOnFramework.Infrastructure;

namespace DragAndDropWithXamDataGridOnFramework.Model
{
    public class TaskItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Due { get; set; }
        public bool IsCompleted { get; set; }
    }
}
