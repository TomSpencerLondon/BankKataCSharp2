using System;

namespace Bank
{
    public class Account
    {
        private OutputConsole _outputConsoleObject;

        public Account(OutputConsole outputConsoleObject)
        {
            _outputConsoleObject = outputConsoleObject;
        }

        public virtual void PrintStatement()
        {
            _outputConsoleObject.PrintLine();
        }
    }
}