using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Nd20TemplateLib;
using System.IO;

namespace Nd20StatblockGenerator.CharacterClasses
{
    [XmlRoot]
    public class SummonMetadata
    {
        [XmlElement]
        public string ClassTitle = "";

        [XmlElement]
        public string CreatureType = "";

        [XmlElement]
        public XMLCharacterClass SummonClass = new XMLCharacterClass();

        [XmlElement]
        public List<XMLRace> RankList = new List<XMLRace>();

    }
}
