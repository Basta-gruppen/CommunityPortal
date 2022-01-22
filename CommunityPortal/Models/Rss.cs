using System;
using System.Xml.Serialization;

namespace CommunityPortal.Models
{
    [XmlRoot(ElementName = "rss"), Serializable]
    public class Rss
    {
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "channel")] public RssChannel Channel { get; set; }
    }
}