﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiddleWebApp.Models
{
    public class joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswwer { get; set; }

        public joke()
        {

        }
    }
}
