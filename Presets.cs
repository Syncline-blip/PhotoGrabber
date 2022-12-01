using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Log for a particular preset, so if the user just wants to load a particular settting for a particular subreddit or user
namespace PhotoGrabber
{
    internal class Presets
    {
        private string presetName;
        private string presetFilterType;
        private int mediaLimit;
        private string linkType;
        private string presetID;
        public Presets(string presetName, string presetFilterType, int mediaLimit, string linkType, string presetID)
        {
            this.presetName = presetName;
            this.presetFilterType = presetFilterType;
            this.mediaLimit = mediaLimit;
            this.linkType = linkType;
            this.presetID = presetID;
        }

        public string getPresetName()
        {
            return presetName;
        }

        public string getPresetFilterType()
        {
            return presetFilterType;
        }

        public int getMediaLimit()
        {
            return mediaLimit;
        }

        public string getLinkType()
        {
            return linkType;
        }

        public string getPresetID()
        {
            return presetID;
        }

        public void setPresetName(string presetName)
        {
           this.presetName = presetName;
        }

        public void setPresetFilterType(string presetFilterType)
        {
            this.presetFilterType = presetFilterType;
        }

        public void setPresetMediaLimit(int mediaLimit)
        {
            this.mediaLimit=mediaLimit;
        }

        public void setLinkType(string linkType)
        {
            this.linkType = linkType;
        }

        public void setPresetID(string presetID)
        {
            this.presetID = presetID;
        }
    }
}
