using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using
namespace WindowsFormsApplication1
{
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.Fields)]
    public class Checker
    {
        //Variable
        private Boolean KingStatus = false; //See 4.5.3a

        Colour checkerColour; //See 4.2.3a

        public Checker(Boolean king, Colour Colour)
        {
            if (king)
            {
                setKing(true);
            }
            checkerColour = Colour;
        }

        //Change
        //public void setKing()
        //{
        //    KingStatus = true;
        //}

        public void setKing(bool k)
        {
            KingStatus = k;
        }

        public void setColour(Colour Colour)
        {
            checkerColour = Colour;
        }
        public Boolean getKing()
        {
            return KingStatus;
        }

        public Colour getColour()
        {
            return checkerColour;
        }
    }

    public enum Colour { white, black, clear };
    
}
