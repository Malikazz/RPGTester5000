using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TextRPGFrameWork
{
    [DataContract]
    class Questions
    {
        [DataMember]
        public string QuestionText { get; set; }

        [DataMember]
        public string Answer { get; set; }
    }
}
