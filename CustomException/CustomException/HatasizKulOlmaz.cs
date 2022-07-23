using System;

namespace CustomException
{
    internal class HatasizKulOlmaz : Exception
    {
        private string _message;

        public HatasizKulOlmaz(string message) : base(message)
        {
           
        }
    }
}