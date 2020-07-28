using FontAwesomeDemo.Model;
using FontAwesomeDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontAwesomeDemo.ViewModel
{
    
    public class SpeakerViewModel
    {
        public List<Speaker> Speakers { get; set; }

        public SpeakerViewModel()
        {
            Speakers = new SpeakerService().GetSpeakers();
        }
    }
}
