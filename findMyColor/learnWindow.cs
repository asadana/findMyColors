/* learnWindow.cs
 * 
 * This form's object is called everytime colorString is changed.
 * It let's user scroll through the colors before playing the game.
 * 
 * Created By: Ankit Sadana
 * Created On: 11/29/2014
 * Last Modified By: Ankit Sadana
 * Last Modified On: 12/11/2014
 * 
 * IU Username: asadana
 * 
 * Final Project for A590
 * Part of: findMyColor Project
 */

// Libraries being used in this form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of the project: findMyColor
namespace findMyColor
{
    // Main class for this form
    public partial class learnWindow : Form
    {
        // A string array is defined to store all the colors
        String[] colorString;
        // An int variable is defined to keep track of colorString index
        int index = 0;
        
        // Constructor function for this form, takes an argument of string array
        public learnWindow(String[] colors)
        {
            // String array recieved is stored into colorString
            colorString = colors;
            // Initializes the form
            InitializeComponent();
            // Disables all buttons in the Control bar to ensure user doesn't close the window before learning
            this.ControlBox = false;

        }

        // Function called when the form is loaded
        private void learnWindow_Load(object sender, EventArgs e)
        {
            // Changes the label on top to the first color
            lblColor.Text = colorString[index];
            // Changes the color of the pictureBox to the first color
            dispColor.BackColor = Color.FromName(colorString[index]);
            // btnPrev is hidden on start
            btnPrev.Visible = false;
            // btnLetsStart is hidden by default
            btnLetsStart.Visible = false;
        }

        // Function called when 'Let's get started' is clicked
        private void btnLetsStart_Click(object sender, EventArgs e)
        {
            // Closes the window
            this.Close();
        }

        // Function called when the '<' button is clicked
        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Moving index to the previous element
            index--;
            // When btnPrev button is clicked, btnNext is made available
            btnNext.Visible = true;

            // If statement checks if index is at 0
            if (index == 0)
            {
                // When colorString[0] (is at beginning), btnPrev is disabled
                btnPrev.Visible = false;
            }

            // Changes the label on top to the index-th color
            lblColor.Text = colorString[index];
            // Changes the color of the pictureBox to the index-th color
            dispColor.BackColor = Color.FromName(colorString[index]);
        }

        // Function called when the '>' button is clicked
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Moving index to the next element
            index++;
            // When btnNext is clicked, btnPrev is made available
            btnPrev.Visible = true;

            // If statement checks if index is at 4
            if (index == 3)
            {
                // When colorString[3] (is at end), btnPrev is disabled
                btnNext.Visible = false;
                // When the user finishes going through the colors atleast once, "Let's Start" is made available
                btnLetsStart.Visible = true;
            }
            // Changes the label on top to the index-th color
            lblColor.Text = colorString[index];
            // Changes the color of the pictureBox to the index-th color
            dispColor.BackColor = Color.FromName(colorString[index]);
        }

        // Function called when the mouse is moved over btnLetsStart
        private void btnLetsStart_MouseEnter(object sender, EventArgs e)
        {
            // Width and Height of the button is increased by 4
            btnLetsStart.Width += 4;
            btnLetsStart.Height += 4;
        }

        // Function called when the mouse is moved off the btnLetsStart
        private void btnLetsStart_MouseLeave(object sender, EventArgs e)
        {
            // Width and Height of the button is decreased by 4
            btnLetsStart.Width -= 4;
            btnLetsStart.Height -= 4;
        }

        // Function called when the mouse is moved over btnNext
        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            // Width of the button is increased by 4
            btnNext.Width += 4;
        }

        // Function called when the mouse is moved off the btnNext
        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            // Width of the button is decreased by 4
            btnNext.Width -= 4;
        }

        // Function called when the mouse is moved over btnPrev
        private void btnPrev_MouseEnter(object sender, EventArgs e)
        {
            // btnPrev is given a new starting point x-4,y to account for button width increase
            btnPrev.Location = new System.Drawing.Point(btnPrev.Location.X-4, btnPrev.Location.Y);
            // Width of the button is increased by 4
            btnPrev.Width += 4;
        }

        // Function called when the mouse is moved off the btnPrev
        private void btnPrev_MouseLeave(object sender, EventArgs e)
        {
            // btnPrev is given a new starting point x+4,y, i.e., original location
            btnPrev.Location = new System.Drawing.Point(btnPrev.Location.X + 4, btnPrev.Location.Y);
            // Width of the button decreased by 4
            btnPrev.Width -= 4;
        }
    }
}
