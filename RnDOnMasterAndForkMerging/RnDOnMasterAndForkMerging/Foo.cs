using System;
using System.Collections.Generic;
using System.Text;

namespace RnDOnMasterAndForkMerging
{
    public class Foo
    {
        public string Id { get; set; }

        public void SayHi(string toHimHer)
        {
            if (!string.IsNullOrEmpty(toHimHer))
            {
                Console.WriteLine("Hi " + toHimHer + "!");
            }
            else
            {
                Console.WriteLine("Hi there!");
            }
        }
    }
}
