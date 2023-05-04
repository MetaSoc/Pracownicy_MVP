namespace Pracownicy_MVP.Models
{
    public interface IWorkerRepozytorium
    {
        void Add(WorkerModel workerModel);
        void Remove(WorkerModel workerModel);
        void Save(WorkerModel workerModel);
        void Load(WorkerModel workerModel);
        void ListBox_Click(WorkerModel workerModel);
    }
}
