using System;
using Pracownicy_MVP.Models;
using Pracownicy_MVP.Views;

namespace Pracownicy_MVP.Presenters
{
    public class WorkerPresenter
    {
        private IWorkerView _workerView;
        private IWorkerRepozytorium _workerRepozytorium;

        public WorkerPresenter(IWorkerView workerView, IWorkerRepozytorium workerRepozytorium)
        {
            this._workerView = workerView;
            this._workerRepozytorium = workerRepozytorium;
            this._workerView.AddEvent += AddWorker;
            this._workerView.RemoveEvent += RemoveWorker;
            this._workerView.SaveEvent += SaveDatabase;
            this._workerView.LoadEvent += LoadDatabase;
            this._workerView.ListBoxEvent += ListBox_Click;
        }

        private void AddWorker(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemoveWorker(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void SaveDatabase(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void LoadDatabase(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ListBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
