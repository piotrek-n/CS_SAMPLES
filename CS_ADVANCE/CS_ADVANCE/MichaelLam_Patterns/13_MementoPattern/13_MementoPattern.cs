using System.Collections.Generic;
namespace CS_ADVANCE.MichaelLam_Patterns._13_MementoPattern
{
    public static class _13_MementoPattern
    {
        /// <summary>
        /// CareTaker
        /// </summary>
        public static void Caller()
        {
            IList<Memento> undos = new List<Memento>();
            Notepad notepad = new Notepad();
            Memento undo;

            //First Revision
            undo = notepad.SetText("Cool!");
            undos.Add(undo);

            //Second Revision
            undo = notepad.SetText("Hello!");
            undos.Add(undo);

            //Currently int the notepad
            notepad.GetText();

            //Issue undo command
            notepad.UnDo(undos[1]);

            //Currently int the notepad (after undo)
            notepad.GetText();



        }
    }
}