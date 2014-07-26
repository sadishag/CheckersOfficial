using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.Fields)]
    public class Model : ModelInterface
    {
        //Variables
        private Checker[,] Checkerboard = new Checker[8, 8];
        private string Text;
        private Color messageColour = Color.Silver;
        private int ScoreA = 0;
        private int ScoreB = 0;
        private int maxNumofCheckers = 12;
        private Mode appMode = Mode.standardSetup;
        private Boolean UpdateRequired = true;
        private Tuple<int, int> pieceSelected = null;
        private Turn currentTurn = Turn.white;
        private playerMode players;
        private Colour playerOneColour = Colour.white;
        private Colour playerTwoColour = Colour.black;  //added for assignment 3
        public List<Tuple<int, Tuple<int, int>, Boolean, Boolean, Tuple<int, int>>> AImoves;
        private Boolean jumpcheck = false;//used to keep track if a jump was made as an action

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
                        Checkerboard[row, col] = new Checker(false, Colour.black); //place a black checker in the Checkerboard array
                    }
                    else if (((row + col + 1) % 2 == 0) && row > 4)
                    {
                        Checkerboard[row, col] = new Checker(false, Colour.white); //place a white checker in the Checkerboard array
                    }
                    else
                    {
                        Checkerboard[row, col] = new Checker(false, Colour.clear); //empty position (rows 5 and 4 and white squares)
                    }
                }
            }

            setText("Welcome to the Checkers Simulator!\nSelect 'Start' to start an American Checkers game in standard setup.\nSelect 'Custom' to specify a custom setup for an American Checkers game.");
            setMessageColour(Color.Transparent);
            UpdateRequired = true;
        }

        //Private methods
        private void convertToKing(Tuple<int, int> pos)
        {
            Checker check = Checkerboard[pos.Item1, pos.Item2];

            if (check.getColour() == Colour.white && pos.Item1 == 0)
            { check.setKing(true); }

            else if (check.getColour() == Colour.black && pos.Item1 == 7)
            { check.setKing(true); }

            else
            {
                //do nothing 
            }
        }

        private void setMessageColour(Color color)
        {
            this.messageColour = color;
        }

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

        private Boolean checkLegalMovement(Tuple<int, int> positionB)
        {
            Tuple<int, int> positionA = this.pieceSelected;
            Colour colourA = Checkerboard[positionA.Item1, positionA.Item2].getColour();
            Colour opA = colourA;
            switch (colourA)
            {
                case Colour.white:
                    opA = Colour.black;
                    break;
                case Colour.black:
                    opA = Colour.white;
                    break;
            }
            Colour colourB = Checkerboard[positionB.Item1, positionB.Item2].getColour();
            Boolean kingA = Checkerboard[positionA.Item1, positionA.Item2].getKing();
            Boolean ALegal = checkLegalPlacement(positionA);
            Boolean BLegal = checkLegalPlacement(positionB);

            //row and column of the current position of the piece we want to move
            int rowA = positionA.Item1;
            int colA = positionA.Item2;

            //row and column of the place we want to move the piece
            int rowB = positionB.Item1;
            int colB = positionB.Item2;

            if (colourA == Colour.clear || colourB != Colour.clear || !ALegal || !BLegal)
            {
                return false;
            }

            if (positionA.Item1 == positionB.Item1 && positionA.Item2 == positionB.Item2) //if they are the same position
            {
                return false;
            }

            //Check to see if the action is a valid one by testing for all possible cases. if a case returns true that indicates the action is a legal one//
            if (jumpAvailable() == false)//a piece can only make a move if there are no jumps available to that player
            {
                //check to see if action is a legal move
                if ((kingA || colourA == Colour.white) && rowA > 0)//valid moves for kings and white pieces
                {
                    if (colA > 0 && (rowA - 1 == rowB) && (colA - 1 == colB) && colourB == Colour.clear)// northwest move
                    {
                        jumpcheck = false;
                        return true;
                    }
                    if (colA < 7 && (rowA - 1 == rowB) && (colA + 1 == colB) && colourB == Colour.clear)//northeast move
                    {
                        jumpcheck = false;
                        return true;
                    }
                }

                if ((kingA || colourA == Colour.black) && rowA < 7)//valid moves for kigns and black pieces
                {
                    if (colA > 0 && (rowA + 1 == rowB) && (colA - 1 == colB) && colourB == Colour.clear)//southwest move
                    {
                        jumpcheck = false;
                        return true;
                    }
                    if (colA < 7 && (rowA + 1 == rowB) && (colA + 1 == colB) && colourB == Colour.clear)//southeast move
                    {
                        jumpcheck = false;
                        return true;

                    }
                }
            }

            //check to see if action is a legal jump
            if ((kingA || colourA == Colour.white) && rowA > 1)//valid jumps for kings and white pieces
            {
                if (colA > 1 && (Checkerboard[rowA - 1, colA - 1].getColour() == opA) && ((rowA - 2 == rowB) && (colA - 2 == colB) && colourB == Colour.clear))// northwest jump
                {
                    removePiece(new Tuple<int, int>(rowA - 1, colA - 1));
                    jumpcheck = true;
                    return true;
                }
                if (colA < 6 && (Checkerboard[rowA - 1, colA + 1].getColour() == opA) && ((rowA - 2 == rowB) && (colA + 2 == colB) && colourB == Colour.clear))// northwest jump
                {
                    removePiece(new Tuple<int, int>(rowA - 1, colA + 1));
                    jumpcheck = true;
                    return true;
                }
            }

            if ((kingA || colourA == Colour.black) && rowA < 6)//valid jumps for kings and black pieces
            {
                if (colA > 1 && (Checkerboard[rowA + 1, colA - 1].getColour() == opA) && ((rowA + 2 == rowB) && (colA - 2 == colB) && colourB == Colour.clear)) //southwest jump
                {
                    removePiece(new Tuple<int, int>(rowA + 1, colA - 1));
                    jumpcheck = true;
                    return true;
                }
                if (colA < 6 && (Checkerboard[rowA + 1, colA + 1].getColour() == opA) && ((rowA + 2 == rowB) && (colA + 2 == colB) && colourB == Colour.clear)) //southeast jump
                {
                    removePiece(new Tuple<int, int>(rowA + 1, colA + 1));
                    jumpcheck = true;
                    return true;
                }
            }

            //if we get to this value that means that the action was not one of the 8 possible moves a checker can make therfore the action is not legal. return false
            return false;

        }

        private Boolean jumpAvailable()
        {
            //determine what colour of checkers were looking for
            Colour checkColour = Colour.black;
            if (currentTurn == Turn.white || currentTurn == Turn.whiteAgain)
            {
                checkColour = Colour.white;
            }

            //go through the entire board looking for checkers of the specified colour. Check to see if any of them are able to make a move
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Checker temp = Checkerboard[i, j];
                    if (temp.getColour() == checkColour)//if the checker matches the colour we are looking for
                    {
                        //check to see if the checker is able to make a jump
                        if (canJump(new Tuple<int, int>(i, j)))
                        {
                            return true;
                        }
                    }
                }
            }
            //if we manage to go through the entire board without finding a checker that can make a jump then return "false" to indicate that there are no jumps available for that colour
            return false;
        }

        private void removePiece(Tuple<int, int> position)
        {
            Checkerboard[position.Item1, position.Item2].setColour(Colour.clear);
            UpdateRequired = true;
        }

        private void checkPieceCount()
        {
            ScoreA = 0;
            ScoreB = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Checker temp = Checkerboard[i, j];
                    if (temp.getColour() == Colour.white)
                    {
                        ScoreA = ScoreA + 1;
                    }
                    if (temp.getColour() == Colour.black)
                    {
                        ScoreB = ScoreB + 1;
                    }
                }

            }
        }

        private Boolean ActionsAvailable()
        {
            //determine what colour of checkers were looking for
            Colour checkColour = Colour.black;
            if (currentTurn == Turn.white || currentTurn == Turn.whiteAgain)
            {
                checkColour = Colour.white;
            }

            //go through the entire board looking for checkers of the specified colour. Check to see if any of them are able to make a move
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Checker temp = Checkerboard[i, j];
                    if (temp.getColour() == checkColour)//if the checker matches the colour we are looking for
                    {
                        //check to see if the checker is able to make a jump
                        if (canJump(new Tuple<int, int>(i, j)))
                        {
                            return true;
                        }
                        //check to see if the checker is able to make a move
                        if (canMove(new Tuple<int, int>(i, j)))
                        {
                            return true;
                        }
                    }
                }
            }
            //if we manage to go through the entire board without finding a checker that can make a move then return "true" to indicate that colour can not make anymoves and must resign
            return false;
        }


        private Boolean canMove(Tuple<int, int> position)//method used to check to see if a checker at a specified position is able to make a move
        {
            Colour currentColour = Colour.white;
            if (this.currentTurn == Turn.black || this.currentTurn == Turn.blackAgain) //specifies current players colour
            {
                currentColour = Colour.black;
            }

            int row = position.Item1;
            int col = position.Item2;
            Checker temp = Checkerboard[position.Item1, position.Item2];

            if ((temp.getKing() || currentColour == Colour.white) && row > 0)
            {
                if (col > 0 && Checkerboard[row - 1, col - 1].getColour() == Colour.clear) //northwest move
                {
                    return true;
                }
                if (col < 7 && Checkerboard[row - 1, col + 1].getColour() == Colour.clear) //northeast move
                {
                    return true;
                }
            }

            if ((temp.getKing() || currentColour == Colour.black) && row < 7)
            {
                if (col > 0 && Checkerboard[row + 1, col - 1].getColour() == Colour.clear) //southwest move
                {
                    return true;
                }
                if (col < 7 && Checkerboard[row + 1, col + 1].getColour() == Colour.clear) //southeast move
                {
                    return true;
                }
            }
            return false;
        }


        private Boolean canJump(Tuple<int, int> position)//method used to check if a checker at a specified position is able to make a jump
        {
            Colour currentColour = Colour.white;
            Colour oppositeColour = Colour.black;
            if (this.currentTurn == Turn.black || this.currentTurn == Turn.blackAgain) //specifies current players colour
            {
                currentColour = Colour.black;
                oppositeColour = Colour.white;
            }

            int row = position.Item1;
            int col = position.Item2;
            Checker temp = Checkerboard[position.Item1, position.Item2];


            if ((temp.getKing() || currentColour == Colour.white) && row > 1)
            {
                if (col > 1 && Checkerboard[row - 1, col - 1].getColour() == oppositeColour && Checkerboard[row - 2, col - 2].getColour() == Colour.clear) //northwest jump
                {
                    return true;
                }
                if (col < 6 && Checkerboard[row - 1, col + 1].getColour() == oppositeColour && Checkerboard[row - 2, col + 2].getColour() == Colour.clear) //northeast jump
                {
                    return true;
                }
            }

            if ((temp.getKing() || currentColour == Colour.black) && row < 6)
            {
                if (col > 1 && Checkerboard[row + 1, col - 1].getColour() == oppositeColour && Checkerboard[row + 2, col - 2].getColour() == Colour.clear) //southwest jump
                {
                    return true;
                }
                if (col < 6 && Checkerboard[row + 1, col + 1].getColour() == oppositeColour && Checkerboard[row + 2, col + 2].getColour() == Colour.clear) //southeast jump
                {
                    return true;
                }
            }
            return false;
        }

        //Public methods
        public void resign()
        {
            this.appMode = Mode.gameOver;

            //PlayerOne quits
            if ((playerOneColour == Colour.white) && (currentTurn == Turn.white || currentTurn == Turn.whiteAgain) || (playerOneColour == Colour.black) && (currentTurn == Turn.black || currentTurn == Turn.blackAgain))
            {
                setText("Game over! Player one quit! Player two wins!");
                setMessageColour(Color.PeachPuff);
            }
            //PlayerTwo quits
            else
            {
                setText("Game over! Player two quit! Player one wins!");
                setMessageColour(Color.PeachPuff);
            }

            this.UpdateRequired = true;
        }

        public void saveBoard()
        {
            try
            {
                string gameData = "";
                gameData = Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\saves.txt", gameData);
                setText("Save Sucessful!");
                setMessageColour(Color.LimeGreen);
            }
            catch (Exception ex)
            {
                setText(ex.Message);
                setMessageColour(Color.Red);
            }
        }

        public static Model loadBoard()
        {
            string gameData = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\saves.txt");
            Model model = Newtonsoft.Json.JsonConvert.DeserializeObject<Model>(gameData);
            return model;
        }

        public void click(Tuple<int, int> position, Boolean king, Colour colour)
        {
            Colour currentTurnColour = Colour.white;

            switch (appMode)
            {
                case Mode.customSetup:
                    placePiece(position, king, colour);//place a piece on the checker board
                    break;
                case Mode.game:
                    if (Checkerboard[position.Item1, position.Item2].getColour() != Colour.clear)
                    {

                        //selectPiece(position);
                        if (currentTurn == Turn.black || currentTurn == Turn.blackAgain)
                        {
                            currentTurnColour = Colour.black;
                        }
                        else if (currentTurn == Turn.white || currentTurn == Turn.whiteAgain)
                        {
                            currentTurnColour = Colour.white;
                        }

                        if (Checkerboard[position.Item1, position.Item2].getColour() == currentTurnColour)
                        {
                            //Stops an AI from selecting a piece on their turn 
                            if (players == playerMode.one && currentTurnColour == playerOneColour)
                            {
                                selectPiece(position);
                            }
                            else if (players == playerMode.two)
                            {
                                selectPiece(position);
                            }
                            //What if its AI's turn

                        }

                    }
                    else
                    {
                        movePiece(position);//second click
                    }
                    break;
                case Mode.gameOver:
                    setText("The game is over! No moves can be made. Please restart if you wish to continue playing.");
                    setMessageColour(Color.Yellow);
                    break;
            }
        }





        //Selected Checker becomes Square Clicked
        //maybe remove these parameters...specifically king and colour
        private void selectPiece(Tuple<int, int> position)
        {
            UpdateRequired = false;
            //ass3 change
            //if the selected checkers colour matches the turn colour then this is a valid selection
            if (((currentTurn == Turn.white) && Checkerboard[position.Item1, position.Item2].getColour() == Colour.white) || ((currentTurn == Turn.black) && Checkerboard[position.Item1, position.Item2].getColour() == Colour.black))
            {
                //remember this position as the first click position, this is the checker that we are going to moves original position
                pieceSelected = position;
            }
            else
            {
                if (currentTurn == Turn.blackAgain || currentTurn == Turn.whiteAgain)
                {
                    setText("Piece is already selected");
                    setMessageColour(Color.Yellow);
                }
                else
                {
                    setText("Error: The current player's turn and the piece selected do not match up!!");
                    setMessageColour(Color.Red);
                }
                //board.highlight(position)
            }
        }

        private void movePiece(Tuple<int, int> position)
        {
            if (pieceSelected == null)
            {
                setText("Please select a piece first");
                setMessageColour(Color.Red);
            }
            else
            {
                //position is second position
                if (checkLegalMovement(position))// check to see if the move is a valid one 
                {
                    Checker temp = Checkerboard[pieceSelected.Item1, pieceSelected.Item2];
                    Colour tempColour = temp.getColour();
                    Boolean tempKing = temp.getKing();

                    removePiece(pieceSelected); //- at pieceSelected
                    placePiece(position, tempKing, tempColour); //- at position
                    pieceSelected = null;

                    if (canJump(position) && this.jumpcheck == true)// if the piece that just jumped is able to jump again do not swtich turns
                    {
                        pieceSelected = position;
                        setText("You must jump! Again!");
                        setMessageColour(Color.Blue);
                        if (currentTurn == Turn.black || currentTurn == Turn.blackAgain)
                        {
                            currentTurn = Turn.blackAgain;
                        }
                        else
                        {
                            currentTurn = Turn.whiteAgain;
                        }

                    }
                    else// change turns
                    {
                        if (currentTurn == Turn.black || currentTurn == Turn.blackAgain)
                        {
                            currentTurn = Turn.white;
                        }
                        else
                        {
                            currentTurn = Turn.black;
                        }

                        if (ActionsAvailable() == false)
                        {
                            this.appMode = Mode.gameOver;
                            setText("Game Over!");
                        }
                    }
                }
                else
                {
                    // do nothing
                }
                if (players == playerMode.one)
                {
                    if (((currentTurn == Turn.black || currentTurn == Turn.blackAgain) && playerTwoColour == Colour.black) || ((currentTurn == Turn.white || currentTurn == Turn.whiteAgain) && (playerTwoColour == Colour.white)))
                    {
                        AIcalculate();
                    }
                }
            }
            UpdateRequired = true;
        }

        private void placePiece(Tuple<int, int> position, Boolean king, Colour colour) //CHANGE TO PRIVATE - CHANGE INTERFACE
        { //type Colour!

            checkPieceCount();

            Boolean checkLegal = checkLegalPlacement(position);//check to see if spot checker is being placed on is a dark square
            Boolean checkLegalCount = ((colour == Colour.black) && (ScoreB < maxNumofCheckers)) || ((colour == Colour.white) && (ScoreA < maxNumofCheckers)) || (colour == Colour.clear);// make sure we don't go over the checker limit for checkers of specified colour

            if (checkLegal && checkLegalCount)
            {
                //If legal position and position is empty, place checker at this position
                Checker piece = new Checker(king, colour);
                Checkerboard[position.Item1, position.Item2] = piece;
                convertToKing(position);//automatically turns a placed piece into a king if it is at the end of the board
                UpdateRequired = true;
                setText("Checker Placed.");
                setMessageColour(Color.LimeGreen);
            }
            else//if placing a piece cannot be done go into this case to determine why placing a piece could not happen
            {
                if (checkLegal == false) { setText("That is an illegal placement"); }
                else if (checkLegalCount == false) { setText("Cannot add anymore pieces of that colour"); }
                setMessageColour(Color.Red);
                UpdateRequired = false;
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
                setMessageColour(Color.Yellow);
                UpdateRequired = true;
            }
            else
            {
                setText("Currently in Game mode. Press Restart before Custom setup.");
                setMessageColour(Color.Red);
                UpdateRequired = false;
            }
        }

        public void standardSetup(playerMode playerMode, Colour playerColour)
        { //rename method to start
            if (appMode != Mode.game)
            {
                players = playerMode;
                if (playerMode == playerMode.one)
                {
                    this.playerOneColour = playerColour;

                    if (playerColour == Colour.black)
                    {
                        this.playerTwoColour = Colour.white;
                    }
                    else
                    {
                        this.playerTwoColour = Colour.black;
                    }
                    if (((currentTurn == Turn.black || currentTurn == Turn.blackAgain) && playerTwoColour == Colour.black) || ((currentTurn == Turn.white || currentTurn == Turn.whiteAgain) && (playerTwoColour == Colour.white)))
                    {
                        AIcalculate();
                    }
                }
                System.Windows.Forms.MessageBox.Show("The player's colour is " + playerOneColour.ToString());
                setMode(Mode.game);
                setText("The match has commenced!");
                setMessageColour(Color.Yellow);
                UpdateRequired = true;
            }
            else
            {
                setText("You are already in game mode. Press Restart to return to the initial screen.");
                setMessageColour(Color.Red);
                UpdateRequired = false;
            }
        }

        //Getters
        public Checker getPiece(Tuple<int, int> position)
        {
            return Checkerboard[position.Item1, position.Item2];
        }

        public Color getMessageColour()
        {
            return this.messageColour;
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

        //#!
        private void AIcalculate()
        {
            SortedQueue AImoves = new SortedQueue();

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Checker temp = Checkerboard[row, col];
                    if (temp.getColour() == playerTwoColour)
                    {
                        Tuple<int, int> initPos = new Tuple<int, int>(row, col);

                        if ((temp.getKing() || playerTwoColour == Colour.white) && row > 1)
                        {
                            if (col > 1 && Checkerboard[row - 1, col - 1].getColour() == playerOneColour && Checkerboard[row - 2, col - 2].getColour() == Colour.clear) //northwest jump
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row - 2, col - 2);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(1, initPos, temp.getKing(), temp.getColour(), finalPos));

                            }
                            if (col < 6 && Checkerboard[row - 1, col + 1].getColour() == playerOneColour && Checkerboard[row - 2, col + 2].getColour() == Colour.clear) //northeast jump
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row - 2, col + 2);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(1, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }
                        }

                        if ((temp.getKing() || playerTwoColour == Colour.black) && row < 6)
                        {
                            if (col > 1 && Checkerboard[row + 1, col - 1].getColour() == playerOneColour && Checkerboard[row + 2, col - 2].getColour() == Colour.clear) //southwest jump
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row + 2, col - 2);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(1, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }

                            if (col < 6 && Checkerboard[row + 1, col + 1].getColour() == playerOneColour && Checkerboard[row + 2, col + 2].getColour() == Colour.clear) //southeast jump
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row + 2, col + 2);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(1, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }

                        }

                        if ((temp.getKing() || playerTwoColour == Colour.white) && row > 0)
                        {
                            if (col > 0 && Checkerboard[row - 1, col - 1].getColour() == Colour.clear) //northwest move
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row - 1, col - 1);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(2, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }

                            if (col < 7 && Checkerboard[row - 1, col + 1].getColour() == Colour.clear) //northeast move
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row - 1, col + 1);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(2, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }
                        }

                        if ((temp.getKing() || playerTwoColour == Colour.black) && row < 7)
                        {
                            if (col > 0 && Checkerboard[row + 1, col - 1].getColour() == Colour.clear) //southwest move
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row + 1, col - 1);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(2, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }

                            if (col < 7 && Checkerboard[row + 1, col + 1].getColour() == Colour.clear) //southeast move
                            {
                                Tuple<int, int> finalPos = new Tuple<int, int>(row + 1, col + 1);
                                AImoves.enqueue(new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>>(2, initPos, temp.getKing(), temp.getColour(), finalPos));
                            }
                        }
                    }
                }
            }

            if (!AImoves.isEmpty())
            {
                AImoves.sort();
                Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>> greedyChoice = AImoves.top();
                selectPiece(greedyChoice.Item2);
                movePiece(greedyChoice.Item5);
            }
            else
            {
                resign();
            }
        }

    }
}

