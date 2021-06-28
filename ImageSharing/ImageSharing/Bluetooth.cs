using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSharing
{
    class Bluetooth : ISender
    {
        public void Send()
        {
            Console.WriteLine("Sharing through Bluetooth");
        }
    }
}
