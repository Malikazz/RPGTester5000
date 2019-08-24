using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TextRPGFrameWork
{
    /// <summary>
    /// Only going to use Name and Health for now other tracked stats are for later use 
    /// </summary>
    [DataContract]
    class Player
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Health { get; set; }

        [DataMember]
        public string Score { get; set; }

        [DataMember]
        public int Inteligence { get; set; }

        [DataMember]
        public int Agility { get; set; }

        [DataMember]
        public int Strength { get; set; }

        [DataMember]
        public int Constitution { get; set; }

        Player(string name)
        {
            Name = name;
            Health = 10;
        }
    }
}
