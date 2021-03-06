using System;

namespace DependencyInjection_AutoFac
{
    // This TodayWriter is where it all comes together.
    // Notice it takes a constructor parameter of type
    // IOutput - that lets the writer write to anywhere
    // based on the implementation. Further, it implements
    // WriteDate such that today's date is written out;
    // you could have one that writes in a different format
    // or a different date.
    public class TodayWriter : IDateWriter
    {
        private readonly ISomeService someService;

        public TodayWriter(ISomeService someService)
        {
            this.someService = someService;
        }

        public IOutput Output { get; set; }

        public void WriteDate()
        {
            Output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
