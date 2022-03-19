using System;
using System.Collections.Generic;
using System.Text;

namespace _2022Hackathon.DA.ADO
{
    public class Command
    {
        public string CommandText { get; }

        public Dictionary<string, object> Parameters { get; }

        public bool IsStoreProcedure { get; }

        public Command()
        {
            IsStoreProcedure = false;
            Parameters = new Dictionary<string, object>();
        }

        public Command(string commandText, bool isStoreProcedure)
        {
            CommandText = commandText;
            IsStoreProcedure = isStoreProcedure;
            Parameters = new Dictionary<string, object>();
        }

        public void AddParameter(string parameterName, object value)
        {
            Parameters.Add(parameterName, value);
        }
    }
}