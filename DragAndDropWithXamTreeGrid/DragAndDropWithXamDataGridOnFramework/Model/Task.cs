using System;
using System.Collections.Generic;

namespace DragAndDropWithXamDataGridOnFramework.Model
{
    public class Task
    {
        private static int _maxTaskId = 0;

        public Task(string name)
        {
            Name = name;
        }


        public int TaskId { get; } = _maxTaskId++;
        public string Name { get; set; }

        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Due { get; set; }
        public bool IsCompleted { get; set; }
    }
}