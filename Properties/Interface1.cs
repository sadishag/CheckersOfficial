using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Must import checker and checkerboard types

namespace WindowsFormsApplication1
{

    interface ModelInterface
    {
        //Assignment 1
        //SETUP only
        ModelInterface();
        //void placePiece(int[][] position, Boolean kingStatus, enum Colour);
        void setPiece(int[][] position, checker piece); //See 4.2.1 - private?
        void removePiece(int[][] position); //See 4.2.2 - private?
        Boolean checkLegalPlacement(int[][] position); //See 4.2.3
        void customSetup(); //See 4.2.4
        void standardSetup(); //See 4.2.5

        int getScoreA();
        int getScoreB();
        string getText();
        void setMode(Mode mode); //private?
        Mode getMode();


        void changeTurn();
        Boolean getTurn();
        void changeScoreA();
        void changeScoreB();
        checkerboard getCheckerboard();
        void changePosition(int[][] position1, int[][] position2);
        void removePiece(int[][] position);
        Boolean coinToss();

        
        
    }

    enum Mode
        {
            standardSetup, customSetup, Game
        };
}
