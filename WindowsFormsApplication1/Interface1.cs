using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Must import checker and checkerboard types

//using

namespace WindowsFormsApplication1
{
    public enum Mode
    {
        standardSetup, customSetup, game, gameOver
    };

    //ass3 change
    public enum Turn { 
        white, whiteAgain, black, blackAgain 
    };

    public enum playerMode
    {
        one, two
    };

    interface ModelInterface
    {
        //This method corresponds to the requirement set in section 2.4 of the requirements document,
        //this method takes the model 
        void saveBoard();

        //This method corresponds to the requirements set in section 3.1 and 3.2 of the requirements document,
        //it determines what happens when the user clicks a button on the tableLayoutPanel
        void click(Tuple<int, int> position, Boolean king, Colour colour);

        //This method corresponds to the requirement set in section 2.1 of the requirements document, 
        //it is used to tell the game that the user wants to setup a custom game mode
        void customSetup();

        //This method corresponds to the requirement set in section 2.1 of the requirements document, 
        //it is used to tell the game that the user wants to setup a standard game mode
        void standardSetup(playerMode playerMode, Colour playerColour);

        //This method corresponds to the requirement set in section 1.2 of the requirements document,
        //it is used to access the checker peice at the specified location
        Checker getPiece(Tuple<int, int> position);

        //This method corresponds to the requirement set in section 1.4 of the requirements document,
        //this method returns the score of player A
        string getScoreA();

        //This method corresponds to the requirement set in section 1.4 of the requirements document,
        //this method returns the score of player B
        string getScoreB();

        //This method corresponds to the requirement set in section 1.3 of the requirements document,
        //this method returns the text of the message field that is used to communicate with the user
        string getText();

        //This method corresponds to the requirement set in section 3.1 of the requirements document,
        //this method returns the current game mode and is used to determine what game mode the game 
        //is currently in
        Mode getMode();

        //This method corresponds to the requirement set in section 1.1 of the requirements document,
        //this method is used to determine if the view needs to be updated based on the underlaying 
        //board representation
        Boolean isUpdateRequired();

    }

}
