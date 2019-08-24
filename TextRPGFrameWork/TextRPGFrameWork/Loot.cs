using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TextRPGFrameWork
{
    [DataContract]
    class Loot
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Inteligence { get; set; }

        [DataMember]
        public int Agility { get; set; }

        [DataMember]
        public int Constitution { get; set; }

        [DataMember]
        public int Strength { get; set; }
    }
}
