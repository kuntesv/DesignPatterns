using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExample
{
    public class Editor
    {
        public string content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void restore(EditorState state)
        {
            content = state.Content;
        }
    }
}
