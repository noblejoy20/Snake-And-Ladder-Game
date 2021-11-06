using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.Models
{
    public class Ladder
    {
        public Ladder(int first, int last)
        {
            StartPosition = first;
            EndPosition = last;
        }
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
    }
}
