using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._13_MementoPattern
{
    class Notepad
    {
        private string _text;
        public Memento SetText(string text)
        {
            Memento me = new Memento(text);
            _text = text;
            return me;
        }
        public string GetText()
        {
            return _text;
        }

        public void UnDo(Memento pMemento)
        {
            _text = pMemento.GetText();
        }
    }


}
