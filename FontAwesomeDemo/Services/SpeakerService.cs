using FontAwesomeDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontAwesomeDemo.Services
{
    public class SpeakerService
    {
        public List<Speaker> GetSpeakers()
        {
            return new List<Speaker>()
            {
                new Speaker
                {
                    Name = "Sekhar",
                    ShortDescription = "Sekah Sri (Microsfot)",
                    ImageUrl = "https://pluralsight.imgix.net/author/lg/sekhar-srivinas",
                    TwitterUrl = "https://www.twitter.com/sekharonline4u",
                    YoutubeUrl = "https://youtube.com/user/sekharonline4u",
                    FacebookUrl = "https://facebook.com/sekharonline"

                }
            };
        }
    }
}
