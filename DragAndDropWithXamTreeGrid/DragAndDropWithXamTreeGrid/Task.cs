using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lightningfall
{
    public class Task
    {
        private readonly List<Task> _tasks = new List<Task>();

        private static int _maxTaskId = 0;

        public Task(string name)
        {
            Name = name;
        }


        public int TaskId { get; } = _maxTaskId++;
        public string Name { get; }

        public IReadOnlyList<Task> Tasks => _tasks;

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }
    }
}