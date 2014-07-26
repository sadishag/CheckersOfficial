using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    public class Checker
    {
        //Variable
        private Boolean KingStatus = false;
        
        Colour checkerColour;

        public Checker(Boolean king, Colour colour)
        {
            if (king)
            {
                setKing();
            }
            checkerColour = colour;
        }

        public void setKing()
        {
            KingStatus = true;
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
