﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSocial.Models
{
    public class Comment
    {
        
        public string Name { get; set; }
        
        public string Text { get; set; }
        public Comment(string name, string text)
        {
            Name = name; Text = text;
        }
    }
}
