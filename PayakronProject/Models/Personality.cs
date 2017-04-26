using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayakronProject.Models
{
    public class Personality
    {
        public string date { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string Identity { get; set; }

        public string findIdentity(string date, string month, string year)
        {
            //Investigate date month year which have in what star zodiac and return personality.
            return this.Identity;
        }
    }
}