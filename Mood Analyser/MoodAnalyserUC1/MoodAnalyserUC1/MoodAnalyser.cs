﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC1
{
    public class moodAnalyser
    {
        string message;

        public moodAnalyser()
        {
        }

        public moodAnalyser(string message)
        {
                this.message = message;
        }

        public string AnalyzeMood()
        {
           if (message.ToLower().Contains("happy"))
           {
                return "happy";
           }
           else
           {
                return "sad";
           }
        }
     }
}

