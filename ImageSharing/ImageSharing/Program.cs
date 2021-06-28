using System;

namespace ImageSharing
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery mailshare = new ImageGallery(_mailAccount);
            mailshare.Share();

            Whatsup _messanger = new Whatsup();
            ImageGallery whatsupshare = new ImageGallery(_messanger);
            whatsupshare.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery bluetoothshare = new ImageGallery(_blueToothDevice);
            bluetoothshare.Share();
        }
    }
}
