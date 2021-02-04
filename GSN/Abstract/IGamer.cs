using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public interface IGamer
    {
        int GamerId { get; set; }
        long NationalityId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string NickName { get; set; }
        int Yas { get; set; }
        
    }
}
