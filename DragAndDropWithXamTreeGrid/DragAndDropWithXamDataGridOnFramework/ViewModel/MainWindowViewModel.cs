using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DragAndDropWithXamDataGridOnFramework.Model;

namespace DragAndDropWithXamDataGridOnFramework.ViewModel
{
    public class MainWindowViewModel
    {
        //public List<Task> Tasks { get; } = new List<Task>();

        //public MainWindowViewModel()
        //{
        //    Tasks.Add(new Task("業務分析"));
        //    Tasks.Add(new Task("ドメイン分析"));
        //    Tasks.Add(new Task("アーキテクチャ設計"));
        //    Tasks.Add(new Task("プロダクト バックログ"));
        //    Tasks.Add(new Task("スプリント ダッシュボード"));
        //    Tasks.Add(new Task("プロジェクト スケジュール"));
        //    Tasks.Add(new Task("プロジェクト カレンダー"));
        //    Tasks.Add(new Task("プロジェクト リソース"));

        //    //var task = Tasks.First();
        //    //task.Tasks.Add(new Task("ブレスト"));
        //    //task.Tasks.Add(new Task("業務モデル作成"));
        //    //task.Tasks[1].Tasks.Add(new Task("作成"));
        //    //task.Tasks[1].Tasks.Add(new Task("社内レビュー"));
        //    //task.Tasks[1].Tasks.Add(new Task("社内レビューバック"));
        //    //task.Tasks[1].Tasks.Add(new Task("社外レビュー"));
        //    //task.Tasks[1].Tasks.Add(new Task("社外レビューバック"));

        //}
        public ObservableCollection<Task> Tasks { get; } = new ObservableCollection<Task>();

        public MainWindowViewModel()
        {
            #region タスク作成
            for (int i = 0; i < 20; i++)
            {
                var task = new Task("Title" + i);
                task.ID = i;
                task.Due = DateTime.Today.AddDays(i);
                task.IsCompleted = false;
                Tasks.Add(task);
            }
            //Tasks.Add(new Task("業務分析"));
            //Tasks.Add(new Task("ドメイン分析"));
            //Tasks.Add(new Task("アーキテクチャ設計"));
            //Tasks.Add(new Task("プロダクト バックログ"));
            //Tasks.Add(new Task("スプリント ダッシュボード"));
            //Tasks.Add(new Task("プロジェクト スケジュール"));
            //Tasks.Add(new Task("プロジェクト カレンダー"));
            //Tasks.Add(new Task("プロジェクト リソース"));
            //for (int i = 0; i < 20; i++)
            //{
            //    TaskItem task = new TaskItem();
            //    task.ID = i;
            //    task.Title = "Title" + i.ToString();
            //    task.Due = DateTime.Today.AddDays(i);
            //    task.IsCompleted = false;
            //    Tasks.Add(task);
            //}
            #endregion
        }
    }
}