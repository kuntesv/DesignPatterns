using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExample
{
    public class EditorState
    {
        public string Content { get; }

        public EditorState(string content)
        { 
            this.Content = content; 
        }
    }
}
