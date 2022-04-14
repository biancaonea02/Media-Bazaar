using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{[Serializable]
    public class Announcement
    {
        public string AnnouncementText { get; private set; }


        //constructor 
        public Announcement(String announcement)
        {
            this.AnnouncementText = announcement;
        }

        //methods

        public void updateAnnouncement(string newAnnouncement)
        {
            this.AnnouncementText = newAnnouncement;
        }

        public override string ToString()
        {
            return $"{this.AnnouncementText}";
        }
    }
}
