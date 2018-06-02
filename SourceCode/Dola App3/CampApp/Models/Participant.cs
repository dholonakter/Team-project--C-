﻿using CampApp.Models;
using CampReserVation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampReserVation.Models
{
 public  class Participant:Visitor
    {
        public ParticipantRole Role { get; set; }

        public string LeaderRFIDCode { get; set; }

        public Participant(string rfid,string fullname,double balance, ParticipantRole role,string leaderRFIDCode):base(fullname,rfid,balance)
        {
            Role = role;
            LeaderRFIDCode = leaderRFIDCode;
        }
        public Participant()
        {
                
        }
        public override string ToString()
        {
            return base.ToString() + " " + Role;

        }
    }
}