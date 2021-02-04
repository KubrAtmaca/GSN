using GSN.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Entities
{
    public class Gamer : IGamer

    {
        public int GamerId { get; set; }
        public long NationalityId { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }
        public DateTime DateOfBirth { get ; set ; }
        public string NickName { get ; set ; }
        public int Yas { get ; set ; }

    }
}
