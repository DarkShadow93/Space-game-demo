﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizzAppServer.Models
{
    public static class Extentions
    {
        public static PlayerSession ToPlayerSession(this DBmanager.Session session)
        {
            return new PlayerSession(session.id, session.userId, session.identifyer, session.startTime, session.stopTime, session.shotsFired, session.shotsHit, session.kills, session.deaths);
        }

        public static List<PlayerSession> ToPlayerSession(this IList<DBmanager.Session> session)
        {
            return session.Select(s => s.ToPlayerSession()).ToList();
        }
    }
}