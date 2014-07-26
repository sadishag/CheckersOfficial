using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Model
    {
	//Variables
    private Checker[,] Checkerboard = new Checker[8, 8];
    private string Text;
    private int ScoreA = 0;
    private int ScoreB = 0;
    private int maxNumofCheckers = 12;
    private Mode appMode = Mode.standardSetup;
    private Boolean UpdateRequired = true;
    public enum Mode
    {
        standardSetup, customSetup, game
    };

    //Constructor
    public Model()
	{
        //Places the black and white checkers in the Checkerboard array
        for (int row = 0; row < 8; row++) //specifies row index
        {
            for (int col = 0; col < 8; col++) //specifies column index
            {
                if (((row + col + 1) % 2 == 0) && row < 3) 
                {
                    Checkerboard[row,col] = new Checker(false, Colour.black); //place a black checker in the Checkerboard array
                }
                else if (((row + col + 1) % 2 == 0) && row > 4)
                {
                    Checkerboard[row,col] = new Checker(false, Colour.white); //place a white checker in the Checkerboard array
                }
                else
                {
                    Checkerboard[row,col] = new Checker(false, Colour.clear); //empty position (rows 5 and 4 and white squares)
                }
            }
        }

        setText("Welcome to the Checkers Simulator!\nSelect 'Start' to start an American Checkers game in standard setup.\nSelect 'Custom' to specify a custom setup for an American Checkers game.");
        UpdateRequired = true;
    }

    //Private methods
    private void setText(String message)
    {
        Text = message;
    }

    private void setMode(Mode mode)
    {
        appMode = mode;
    }

    private Boolean checkLegalPlacement(Tuple<int, int> position)
    {
        if ((position.Item1 + position.Item2 + 1) % 2 == 0) //If the position is not a light square it is legal
        {
            return true;
        }
        return false;
    } 
    
    //Public methods
    
    public void placePiece(Tuple<int, int> position, Boolean king, Colour colour){ //type Colour!

        checkPieceCount();
        Boolean checkLegal = checkLegalPlacement(position);
        Boolean checkCustomSetup = appMode == Mode.customSetup;
        
        Boolean checkLegalCount = ((colour == Colour.black) && (ScoreB < maxNumofCheckers)) || ((colour == Colour.white) && (ScoreA < maxNumofCheckers)) || (colour == Colour.clear);

        if (checkCustomSetup && checkLegal && checkLegalCount)
        {
             //If legal position and position is empty, place checker at this position
                Checker piece = new Checker(king, colour);
                Checkerboard[position.Item1, position.Item2] = piece;
                UpdateRequired = true;
                //!#
                //setText(ScoreA.ToString());
                setText("Checker Placed.");
        }
        else//if placing a piece cannot be done go into this case to determine why placing a piece could not happen
        {
            if (checkCustomSetup == false) { setText("Not in Custom setup Mode, Cannot Place Piece"); }
            else if (checkLegal == false) { setText("That is an illegal placement"); }
            else if (checkLegalCount == false) { setText("Cannot add anymore pieces of that colour"); }
            UpdateRequired = false;
        }
    }

    //private void removePiece(Tuple<int, int> position){
     //    Checkerboard[position.Item1 , position.Item2] = null;
     //    UpdateRequired = true;
    //}

    private void checkPieceCount()
    {
        ScoreA = 0;
        ScoreB = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Checker temp = Checkerboard[i,j];
                if (temp.getColour() == Colour.white)
                {
                    ScoreA = ScoreA+1;
                }
                if (temp.getColour() == Colour.black)
                {
                    ScoreB = ScoreB+1 ;
                }
            }

        }
    }

    public void customSetup()
    {

        if (appMode != Mode.game)
        {
            setMode(Mode.customSetup);

            //Clears Checkerboard (empty array)
            for (int row = 0; row < 8; row++) //row index of Checkerboard array
            {
                for (int col = 0; col < 8; col++) //column index of Checkerboard array
                {
                    Checkerboard[row, col] = new Checker(false, Colour.clear); //makes position empty
                }
            }

            setText("Currently in Custom Setup mode.");
            UpdateRequired = true;
        }
        else
        {
            setText("Currently in Game mode. Press Restart before Custom setup.");
            UpdateRequired = false;
        }
    }

    public void standardSetup(){ //rename method to start
        if (appMode != Mode.game)
        {
            setMode(Mode.game);
            setText("The match has commenced!");
            UpdateRequired = true;
        }
        else
        {
            setText("You are already in game mode. Press Restart to return to the initial screen.");
            UpdateRequired = false;
        }

    }
    
    //Getters
    public Checker getPiece(Tuple<int,int> position)
    { 
        return Checkerboard[position.Item1, position.Item2];
    }

    public string getScoreA()
    {
        checkPieceCount();
        return ScoreA.ToString();
    }

    public string getScoreB()
    {
        checkPieceCount();
        return ScoreB.ToString();
    }
    
    public string getText()
    {
        return Text;
    }

    public Mode getMode()
    {
        return appMode;
    }

    public Boolean isUpdateRequired()
    {
        return UpdateRequired;
    }


    /* To Implement Later
    private Boolean Turn = 0;
    private void removePiece(Tuple position); //in game logic
    private void changePosition(Tuple position1, Tuple position2);
    private void changeScoreA();
    private void changeScoreB();
    private void changeTurn(); //to be public?
    public Boolean getTurn();
    private Boolean coinToss();    
     
     */ 

        //Have a check which checks that it is an invalid error, becomes true if an invalid error occurs (false otherwise).
        //if true will not update
}

        
    }

