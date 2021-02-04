using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public class BaseRegisteryService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı üye silindi.");
        }

        public virtual void Registry(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı üye kaydedildi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı üyenin bilgileri güncellendi.");
        }
    }
}
