using System;

namespace DependencyInjection_AutoFac
{
    // What happens when we have two IDateWriters?
    public class TomorrowWriter : IDateWriter
    {
        private readonly IOutput _output;
        public TomorrowWriter(IOutput output)
        {
            _output = output;
        }
        public void WriteDate()
        {
            _output.Write(DateTime.Today.AddDays(1).ToShortDateString());
        }
    }
}
