using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.ReadCard
{
    public class CardInfo
    {
        public CardInfo()
        {
            this.Name = new byte[128];
            this.Sex = new byte[128];
            this.Nation = new byte[128];
            this.BirthDate = new byte[128];
            this.CardID = new byte[128];
            this.Address = new byte[128];
        }

        public byte[] Name;

        public byte[] Sex;

        public byte[] Nation;

        public byte[] BirthDate;

        public byte[] CardID;

        public byte[] Address;
    }
}
