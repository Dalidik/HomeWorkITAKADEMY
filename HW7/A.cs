using System.Xml.Linq;


    public class A
    {
        private string _letter;
        public string Letter
        {
            get { return _letter; }
            set { _letter = value;}
        }
        public A (string letter)
        {
            Letter = letter;
        }

        public void EmptyMessage()
        {
            if (Letter == "")
                throw (new NullReferenceException("Empty Message!!! Please write something"));
            else
            {
                Console.WriteLine(Letter);
            }
        }

        public void LetterWithBrace()
        {
            if (_letter[_letter.Length -1 ] != ']')
                throw (new LetterWithBraceException("Message cant be with a curly brace"));
            else
            {
                Console.WriteLine(Letter);
            }
        }
    }

