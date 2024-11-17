using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExample
{
    public class History
    {
        public List<EditorState> stateList = new List<EditorState>();

        public void push(EditorState state)
        { 
         stateList.Add(state);
        }

        public EditorState pop()
        {
            int lastIndex = stateList.Count - 1;

            EditorState state = stateList[lastIndex];

            stateList.RemoveAt(lastIndex);
            return state;
        }
    }
}
