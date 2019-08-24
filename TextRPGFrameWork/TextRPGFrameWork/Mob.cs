using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TextRPGFrameWork
{
    [DataContract]
    class Mob
    {
        [DataMember]
        public string MobName { get; set; }

        [DataMember]
        public int Health { get; set; }

        [DataMember]
        public int Damage { get; set; }

        [DataMember]
        public Loot Loot { get; set; }
    }
}
