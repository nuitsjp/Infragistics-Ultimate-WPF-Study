using System.Collections.Generic;
using System.Linq;

namespace DotNetFramework
{
    public class MainWindowViewModel
    {
        private readonly List<Task> _tasks = new List<Task>();

        public MainWindowViewModel()
        {
            AddTask(new Task("業務分析"));
            AddTask(new Task("ドメイン分析"));
            AddTask(new Task("アーキテクチャ設計"));
            AddTask(new Task("プロダクト バックログ"));
            AddTask(new Task("スプリント ダッシュボード"));
            AddTask(new Task("プロジェクト スケジュール"));
            AddTask(new Task("プロジェクト カレンダー"));
            AddTask(new Task("プロジェクト リソース"));

            var task = Tasks.First();
            task.AddTask(new Task("ブレスト"));
            task.AddTask(new Task("業務モデル作成"));
            task.Tasks[1].AddTask(new Task("作成"));
            task.Tasks[1].AddTask(new Task("社内レビュー"));
            task.Tasks[1].AddTask(new Task("社内レビューバック"));
            task.Tasks[1].AddTask(new Task("社外レビュー"));
            task.Tasks[1].AddTask(new Task("社外レビューバック"));

        }

        public IReadOnlyList<Task> Tasks => _tasks;
        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }
    }
}