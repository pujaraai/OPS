using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Video
    {
        public bool PromotinalVideo(int VideoId,string VideoName)
        {
            // There is a Business Rule that Agent Commission Can not be more that 10 $
            bool isPromotinalVideo = false;
            if (VideoName.ToUpper() == "LEARNING TO SKI")
                isPromotinalVideo = true;
            else
                isPromotinalVideo = false;

            return isPromotinalVideo;
        }
    }
}
