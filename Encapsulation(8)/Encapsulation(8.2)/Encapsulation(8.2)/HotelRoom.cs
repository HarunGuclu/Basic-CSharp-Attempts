using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_8._2_
{
    public class HotelRoom
    {
        private int RoomNumber;
        private bool Reserved = false;
        private string RoomType;
        public int RoomNumber_
        {
            get
            {
                return RoomNumber;
            }
            set
            {
                RoomNumber = value;
            }
        }
        public bool IsReserved()
        {
            return Reserved;
        }
        public void SetReserved(bool value)
        {
            Reserved = value;
        }
        public string RoomType_
        {
            get
            {
                return RoomType;
            }
            set
            {
                RoomType = value;
            }
        }
    }
}
