using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Message
    {
        string Content { get; set; }
        string Name { get; set; }
        DateTime TimeSent { get; set; }
        int Distance { get; set; }
        int x { get; set; }
        int y { get; set; }

        Message(string content,string name,DateTime timesent,int distance,int x,int y)
        {

        }
    }
}

