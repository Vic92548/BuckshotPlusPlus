﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuckshotPlusPlus
{
    public class AnalyticTimedEvent
    {
        public string EventName { get; set; }
        public string EventTimestamp { get; set; }

        public AnalyticTimedEvent(string Event) { 
        
            EventName = Event;
            var Now = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            EventTimestamp = Now.ToString();
        }
    }
}