namespace DependencyInjection_AutoFac
{
    // This interface decouples the notion of writing
    // a date from the actual mechanism that performs
    // the writing. Like with IOutput, the process
    // is abstracted behind an interface.
    public interface IDateWriter
    {
        IOutput Output { get; set; }
        void WriteDate();
    }
}
