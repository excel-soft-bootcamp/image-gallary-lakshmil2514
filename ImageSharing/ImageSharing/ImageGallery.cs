using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSharing
{
    
        public class ImageGallery 
        {
        ISender _share;
        public ImageGallery(ISender share)
        {
            this._share = share;
        }

        public void Share()
        {
            _share.Send();

        }
    }
 }

