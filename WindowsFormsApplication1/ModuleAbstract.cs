using System;

/// <summary>
/// Summary description for Class1
/// </summary>

public abstract class ModelAbstract1
{
    //Variables
    private checkerboard Checkerboard = new checkerboard();
    private string Text;
    private int ScoreA = 0;
    private int ScoreB = 0;
    private enum Mode
    {
        standardSetup, customSetup, Game
    };
    private Boolean Turn = 0;

    //Assignment 1
    //Private Services
    private void setText(String message);
    private void setMode(Mode mode);
    private Boolean checkLegalPlacement(Tuple position); 

    public void placePiece(Tuple position, Boolean king, enum Colour colour); , colour to be imported? //Tuple position, Boolean king, enum Colour colour
    public void customSetup();
    public void standardSetup();

    //Update
    public checkerboard getCheckerboard();
    public int getScoreA();
    public int getScoreB();
    public string getText();
    public Mode getMode();


    //Later Version
    private void removePiece(Tuple position); //in game logic
    private void changePosition(Tuple position1, Tuple position2);
    private void changeScoreA();
    private void changeScoreB();
    private void changeTurn(); //to be public?
    public Boolean getTurn();
    private Boolean coinToss();



}

public class ModelAbstract : ModuleAbstract1
{
	public ModelAbstract()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
