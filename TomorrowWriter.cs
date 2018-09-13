using System;

namespace DependencyInjection_AutoFac
{
    // What happens when we have two IDateWriters?
    public class TomorrowWriter : IDateWriter
    {
        public TomorrowWriter()
        {
        }

        public IOutput Output { get; set; }
        public void WriteDate()
        {
            Output.Write(DateTime.Today.AddDays(1).ToShortDateString());
        }
    }
}
