using System;

namespace Pracownicy_MVP.Views
{
    public interface IWorkerView
    {
        // Properties
        string Name { get; set; }
        string Surname { get; set; }
        DateTime Date { get; set; }
        decimal Salary { get; set; }
        string Position { get; set; }
        string Contract { get; set; }

        // Events
        event EventHandler AddEvent;
        event EventHandler RemoveEvent;
        event EventHandler SaveEvent;
        event EventHandler LoadEvent;
        event EventHandler ListBoxEvent;
    }
}
