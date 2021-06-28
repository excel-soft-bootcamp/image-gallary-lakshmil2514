using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSharing
{
    public class Whatsup : ISender
    {
        public void Send()
        {
            Console.WriteLine("Sharing through whatsup");
        }
    }
}
