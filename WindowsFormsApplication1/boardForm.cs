using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

//using

namespace WindowsFormsApplication1
{
   
    public partial class boardForm : Form
    {
        Model model1 = new Model(); //See 4.5.1a of documentation
        Image bKing = Image.FromFile("2AA4 pics\\BlackCheckerKing.png"); //See 4.5.1b of documentation
        Image wKing = Image.FromFile("2AA4 pics\\WhiteCheckerKing.png"); //See 4.5.1c of documentation
        Image bPiece = Image.FromFile("2AA4 pics\\BlackChecker.png"); //See 4.5.1d of documentation
        Image wPiece = Image.FromFile("2AA4 pics\\WhiteChecker.png"); //See 4.5.1e of documentation
        Image emptySpace = Image.FromFile("2AA4 pics\\Koala.jpg"); //See 4.5.1f of documentation
        Colour playerColour=Colour.white;

        String [] koalaQuotes= {"Eucalyptus makes me high.", "420blazeit", "It’s like I’m flying in clouds!", "I’m tripping so hard, you’re good.", "Pass the Doritos.", "Gots munchies!", "No you’re the cutest ever!", "Hands are such funny things.", "Anybody got more of that eucalyptus?", "Pass the green stuff."};
        String [] shaqQuotes = {"Man you’d be good at free throws!", "Git dunk’d!", "Ohh snap!", "Yo dawg, you got this!", "I’m better than Kobe", "I wrote my thesis on the value of humor in leadership because I’m a natural leader who loves to laugh!", "Still better than Kobe.", "Stay in school unless you get drafted!"};

        //sound player
        SoundPlayer finishSound = new SoundPlayer("Victor-E.wav");


        public boardForm()
        {
            InitializeComponent();
        }

        public string getQuote()
        {
            var num = new Random();
            if (playerColour!=Colour.white)
            {
                return koalaQuotes[num.Next(koalaQuotes.Length)];
            }
            else
            {
                return shaqQuotes[num.Next(shaqQuotes.Length)];
            }
        }

        private void update()
        {

            lblWhite.Text = "White Pieces: " + model1.getScoreA();
            lblBlack.Text = "Black Pieces: " + model1.getScoreB();
            lblMessage.BackColor = model1.getMessageColour();
            lblMessage.Text = model1.getText();

            if (model1.isUpdateRequired())
            {
                switch (model1.getMode())
                {
                    case Mode.game: 
                        resignButton.Visible = true;
                        grpBox.Visible = false;
                        finishSound.Stop();
                        break;
                    case Mode.standardSetup:
                        grpBox.Visible = false;
                        resignButton.Visible = false;
                        computerBox.Visible = false;
                        lblComputerMessage.Visible=false;
                        finishSound.Stop();
                        break;
                    case Mode.gameOver:
                        grpBox.Visible = true;
                        resignButton.Visible = false;
                        computerBox.Visible = false;
                        lblComputerMessage.Visible = false;
                        finishSound.Play();
                        break;
                    case Mode.customSetup:
                        resignButton.Visible = false;
                        computerBox.Visible = false;
                        lblComputerMessage.Visible=false;
                        grpBox.Visible = true;
                        finishSound.Stop();
                        break;
                }

                lblComputerMessage.Text = getQuote();
                
                foreach (Button btn in tableLayoutPanel1.Controls.OfType<Button>())
                {
                   
                    
                    Tuple<int, int> tempPos = new Tuple<int,int> (tableLayoutPanel1.GetRow(btn),tableLayoutPanel1.GetColumn(btn)) ;

                    Checker checkerTemp = model1.getPiece(tempPos);
                    if (checkerTemp.getColour() == Colour.black)
                    {
                        if (checkerTemp.getKing())
                        {
                            //button + n .text
                            btn.BackgroundImage = bKing;
                        }
                        else
                        {
                            btn.BackgroundImage = bPiece;
                        }
                    }
                    else if (checkerTemp.getColour() == Colour.white)
                    {
                        if (checkerTemp.getKing())
                        {
                            //button+n.text
                            btn.BackgroundImage = wKing;
                        }
                        else
                        {
                            btn.BackgroundImage = wPiece;
                        }
                    }
                    else
                    {
                        btn.BackgroundImage = null;
                    }
                    
                }
            }
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void squareClick(object sender, EventArgs e)
        {

            Button btnSomeButton = sender as Button;

            Colour Colour = Colour.white;
            if (btnBlack.Checked) 
            {
                Colour = Colour.black;
            }
            else if (btnWhite.Checked)
            {
                Colour = Colour.white;
            }
            else if (btnRemove.Checked)
            {
                Colour = Colour.clear;
            }

            model1.click(new Tuple <int,int> (tableLayoutPanel1.GetRow(btnSomeButton),tableLayoutPanel1.GetColumn(btnSomeButton)) , chkKing.Checked, Colour);
            update();
        }



        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("For 1 Player mode click Yes. For 2 Player mode click No.", "Player Mode.", MessageBoxButtons.YesNo);
            playerMode playerMode;
            if (result == DialogResult.Yes)
            {
                playerMode = playerMode.one;

                computerBox.Visible = true;
                lblComputerMessage.Visible = true;
                DialogResult ChoiceResult = MessageBox.Show("For White click Yes. For Black Click No.", "Player Colour.", MessageBoxButtons.YesNo);
                if (ChoiceResult == DialogResult.Yes)
                {
                    playerColour = Colour.white;
                    computerBox.BackgroundImage = Image.FromFile("2AA4 pics\\shaq.jpg");
                }
                else
                {
                    playerColour = Colour.black;
                    computerBox.BackgroundImage = Image.FromFile("2AA4 pics\\koalaBear.jpg");
                }

            }
            else
            {
                playerMode = playerMode.two;
            }


            model1.standardSetup(playerMode, playerColour); //change to start 
            update();
        }
        
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1 = new Model();
            update();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.customSetup();
            update();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.saveBoard();
            update();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1 = Model.loadBoard();
            update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you read 'Koala-T-Shaquers' it sounds like Quality Checkers", "About the Game");
        }

        private void resignButton_Click(object sender, EventArgs e)
        {
            model1.resign();
            update();
        }

    }
}
