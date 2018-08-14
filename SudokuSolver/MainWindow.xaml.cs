using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Variables

        bool bIsEmpty = true;


        string[,] arrOriginalPuzzle;

        string[,] arrEditedPuzzle = new string[9, 9];


        string[] arrRow1;
        string[] arrRow2;
        string[] arrRow3;
        string[] arrRow4;
        string[] arrRow5;
        string[] arrRow6;
        string[] arrRow7;
        string[] arrRow8;
        string[] arrRow9;
        string[] arrEditedRow = new string[9];


        string[] arrColumn1;
        string[] arrColumn2;
        string[] arrColumn3;
        string[] arrColumn4;
        string[] arrColumn5;
        string[] arrColumn6;
        string[] arrColumn7;
        string[] arrColumn8;
        string[] arrColumn9;
        string[] arrEditedColumn = new string[9];

        string[] arrBlock1;
        string[] arrBlock2;
        string[] arrBlock3;
        string[] arrBlock4;
        string[] arrBlock5;
        string[] arrBlock6;
        string[] arrBlock7;
        string[] arrBlock8;
        string[] arrBlock9;
        string[] arrEditedBlock = new string[9];


        #endregion

        private void PopulateArrays()
        {
            if (bIsEmpty)
            {
                arrOriginalPuzzle = new string[9, 9] { { txtC1R1.Text, txtC2R1.Text, txtC3R1.Text, txtC4R1.Text, txtC5R1.Text, txtC6R1.Text, txtC7R1.Text, txtC8R1.Text, txtC9R1.Text },
                { txtC1R2.Text, txtC2R2.Text, txtC3R2.Text, txtC4R2.Text, txtC5R2.Text, txtC6R2.Text, txtC7R2.Text, txtC8R2.Text, txtC9R2.Text },
                { txtC1R3.Text, txtC2R3.Text, txtC3R3.Text, txtC4R3.Text, txtC5R3.Text, txtC6R3.Text, txtC7R3.Text, txtC8R3.Text, txtC9R3.Text },
                { txtC1R4.Text, txtC2R4.Text, txtC3R4.Text, txtC4R4.Text, txtC5R4.Text, txtC6R4.Text, txtC7R4.Text, txtC8R4.Text, txtC9R4.Text },
                { txtC1R5.Text, txtC2R5.Text, txtC3R5.Text, txtC4R5.Text, txtC5R5.Text, txtC6R5.Text, txtC7R5.Text, txtC8R5.Text, txtC9R5.Text },
                { txtC1R6.Text, txtC2R6.Text, txtC3R6.Text, txtC4R6.Text, txtC5R6.Text, txtC6R6.Text, txtC7R6.Text, txtC8R6.Text, txtC9R6.Text },
                { txtC1R7.Text, txtC2R7.Text, txtC3R7.Text, txtC4R7.Text, txtC5R7.Text, txtC6R7.Text, txtC7R7.Text, txtC8R7.Text, txtC9R7.Text },
                { txtC1R8.Text, txtC2R8.Text, txtC3R8.Text, txtC4R8.Text, txtC5R8.Text, txtC6R8.Text, txtC7R8.Text, txtC8R8.Text, txtC9R8.Text },
                { txtC1R9.Text, txtC2R9.Text, txtC3R9.Text, txtC4R9.Text, txtC5R9.Text, txtC6R9.Text, txtC7R9.Text, txtC8R9.Text, txtC9R9.Text } };

                Array.Copy(arrOriginalPuzzle, 0, arrEditedPuzzle, 0, 81);
            }


            


            arrRow1 = new string[9] { arrEditedPuzzle[0, 0], arrEditedPuzzle[0, 1], arrEditedPuzzle[0, 2], arrEditedPuzzle[0, 3], arrEditedPuzzle[0, 4], arrEditedPuzzle[0, 5], arrEditedPuzzle[0, 6], arrEditedPuzzle[0, 7], arrEditedPuzzle[0, 8] };
            arrRow2 = new string[9] { arrEditedPuzzle[1, 0], arrEditedPuzzle[1, 1], arrEditedPuzzle[1, 2], arrEditedPuzzle[1, 3], arrEditedPuzzle[1, 4], arrEditedPuzzle[1, 5], arrEditedPuzzle[1, 6], arrEditedPuzzle[1, 7], arrEditedPuzzle[1, 8] };
            arrRow3 = new string[9] { arrEditedPuzzle[2, 0], arrEditedPuzzle[2, 1], arrEditedPuzzle[2, 2], arrEditedPuzzle[2, 3], arrEditedPuzzle[2, 4], arrEditedPuzzle[2, 5], arrEditedPuzzle[2, 6], arrEditedPuzzle[2, 7], arrEditedPuzzle[2, 8] };
            arrRow4 = new string[9] { arrEditedPuzzle[3, 0], arrEditedPuzzle[3, 1], arrEditedPuzzle[3, 2], arrEditedPuzzle[3, 3], arrEditedPuzzle[3, 4], arrEditedPuzzle[3, 5], arrEditedPuzzle[3, 6], arrEditedPuzzle[3, 7], arrEditedPuzzle[3, 8] };
            arrRow5 = new string[9] { arrEditedPuzzle[4, 0], arrEditedPuzzle[4, 1], arrEditedPuzzle[4, 2], arrEditedPuzzle[4, 3], arrEditedPuzzle[4, 4], arrEditedPuzzle[4, 5], arrEditedPuzzle[4, 6], arrEditedPuzzle[4, 7], arrEditedPuzzle[4, 8] };
            arrRow6 = new string[9] { arrEditedPuzzle[5, 0], arrEditedPuzzle[5, 1], arrEditedPuzzle[5, 2], arrEditedPuzzle[5, 3], arrEditedPuzzle[5, 4], arrEditedPuzzle[5, 5], arrEditedPuzzle[5, 6], arrEditedPuzzle[5, 7], arrEditedPuzzle[5, 8] };
            arrRow7 = new string[9] { arrEditedPuzzle[6, 0], arrEditedPuzzle[6, 1], arrEditedPuzzle[6, 2], arrEditedPuzzle[6, 3], arrEditedPuzzle[6, 4], arrEditedPuzzle[6, 5], arrEditedPuzzle[6, 6], arrEditedPuzzle[6, 7], arrEditedPuzzle[6, 8] };
            arrRow8 = new string[9] { arrEditedPuzzle[7, 0], arrEditedPuzzle[7, 1], arrEditedPuzzle[7, 2], arrEditedPuzzle[7, 3], arrEditedPuzzle[7, 4], arrEditedPuzzle[7, 5], arrEditedPuzzle[7, 6], arrEditedPuzzle[7, 7], arrEditedPuzzle[7, 8] };
            arrRow9 = new string[9] { arrEditedPuzzle[8, 0], arrEditedPuzzle[8, 1], arrEditedPuzzle[8, 2], arrEditedPuzzle[8, 3], arrEditedPuzzle[8, 4], arrEditedPuzzle[8, 5], arrEditedPuzzle[8, 6], arrEditedPuzzle[8, 7], arrEditedPuzzle[8, 8] };
            


            arrColumn1 = new string[9] { arrEditedPuzzle[0, 0], arrEditedPuzzle[1, 0], arrEditedPuzzle[2, 0], arrEditedPuzzle[3, 0], arrEditedPuzzle[4, 0], arrEditedPuzzle[5, 0], arrEditedPuzzle[6, 0], arrEditedPuzzle[7, 0], arrEditedPuzzle[8, 0] };
            arrColumn2 = new string[9] { arrEditedPuzzle[0, 1], arrEditedPuzzle[1, 1], arrEditedPuzzle[2, 1], arrEditedPuzzle[3, 1], arrEditedPuzzle[4, 1], arrEditedPuzzle[5, 1], arrEditedPuzzle[6, 1], arrEditedPuzzle[7, 1], arrEditedPuzzle[8, 1] };
            arrColumn3 = new string[9] { arrEditedPuzzle[0, 2], arrEditedPuzzle[1, 2], arrEditedPuzzle[2, 2], arrEditedPuzzle[3, 2], arrEditedPuzzle[4, 2], arrEditedPuzzle[5, 2], arrEditedPuzzle[6, 2], arrEditedPuzzle[7, 2], arrEditedPuzzle[8, 2] };
            arrColumn4 = new string[9] { arrEditedPuzzle[0, 3], arrEditedPuzzle[1, 3], arrEditedPuzzle[2, 3], arrEditedPuzzle[3, 3], arrEditedPuzzle[4, 3], arrEditedPuzzle[5, 3], arrEditedPuzzle[6, 3], arrEditedPuzzle[7, 3], arrEditedPuzzle[8, 3] };
            arrColumn5 = new string[9] { arrEditedPuzzle[0, 4], arrEditedPuzzle[1, 4], arrEditedPuzzle[2, 4], arrEditedPuzzle[3, 4], arrEditedPuzzle[4, 4], arrEditedPuzzle[5, 4], arrEditedPuzzle[6, 4], arrEditedPuzzle[7, 4], arrEditedPuzzle[8, 4] };
            arrColumn6 = new string[9] { arrEditedPuzzle[0, 5], arrEditedPuzzle[1, 5], arrEditedPuzzle[2, 5], arrEditedPuzzle[3, 5], arrEditedPuzzle[4, 5], arrEditedPuzzle[5, 5], arrEditedPuzzle[6, 5], arrEditedPuzzle[7, 5], arrEditedPuzzle[8, 5] };
            arrColumn7 = new string[9] { arrEditedPuzzle[0, 6], arrEditedPuzzle[1, 6], arrEditedPuzzle[2, 6], arrEditedPuzzle[3, 6], arrEditedPuzzle[4, 6], arrEditedPuzzle[5, 6], arrEditedPuzzle[6, 6], arrEditedPuzzle[7, 6], arrEditedPuzzle[8, 6] };
            arrColumn8 = new string[9] { arrEditedPuzzle[0, 7], arrEditedPuzzle[1, 7], arrEditedPuzzle[2, 7], arrEditedPuzzle[3, 7], arrEditedPuzzle[4, 7], arrEditedPuzzle[5, 7], arrEditedPuzzle[6, 7], arrEditedPuzzle[7, 7], arrEditedPuzzle[8, 7] };
            arrColumn9 = new string[9] { arrEditedPuzzle[0, 8], arrEditedPuzzle[1, 8], arrEditedPuzzle[2, 8], arrEditedPuzzle[3, 8], arrEditedPuzzle[4, 8], arrEditedPuzzle[5, 8], arrEditedPuzzle[6, 8], arrEditedPuzzle[7, 8], arrEditedPuzzle[8, 8] };
            


            arrBlock1 = new string[9] { arrEditedPuzzle[0, 0], arrEditedPuzzle[1, 0], arrEditedPuzzle[2, 0], arrEditedPuzzle[0, 1], arrEditedPuzzle[1, 1], arrEditedPuzzle[2, 1], arrEditedPuzzle[0, 2], arrEditedPuzzle[1, 2], arrEditedPuzzle[2, 1] };
            arrBlock2 = new string[9] { arrEditedPuzzle[0, 3], arrEditedPuzzle[1, 3], arrEditedPuzzle[2, 3], arrEditedPuzzle[0, 4], arrEditedPuzzle[1, 4], arrEditedPuzzle[2, 4], arrEditedPuzzle[0, 5], arrEditedPuzzle[1, 5], arrEditedPuzzle[2, 5] };
            arrBlock3 = new string[9] { arrEditedPuzzle[0, 6], arrEditedPuzzle[1, 6], arrEditedPuzzle[2, 6], arrEditedPuzzle[0, 7], arrEditedPuzzle[1, 7], arrEditedPuzzle[2, 7], arrEditedPuzzle[0, 8], arrEditedPuzzle[1, 8], arrEditedPuzzle[2, 8] };
            arrBlock4 = new string[9] { arrEditedPuzzle[3, 0], arrEditedPuzzle[4, 0], arrEditedPuzzle[5, 0], arrEditedPuzzle[3, 1], arrEditedPuzzle[4, 1], arrEditedPuzzle[5, 1], arrEditedPuzzle[3, 2], arrEditedPuzzle[4, 2], arrEditedPuzzle[5, 1] };
            arrBlock5 = new string[9] { arrEditedPuzzle[3, 3], arrEditedPuzzle[4, 3], arrEditedPuzzle[5, 3], arrEditedPuzzle[3, 4], arrEditedPuzzle[4, 4], arrEditedPuzzle[5, 4], arrEditedPuzzle[3, 5], arrEditedPuzzle[4, 5], arrEditedPuzzle[5, 5] };
            arrBlock6 = new string[9] { arrEditedPuzzle[3, 6], arrEditedPuzzle[4, 6], arrEditedPuzzle[5, 6], arrEditedPuzzle[3, 7], arrEditedPuzzle[4, 7], arrEditedPuzzle[5, 7], arrEditedPuzzle[3, 8], arrEditedPuzzle[4, 8], arrEditedPuzzle[5, 8] };
            arrBlock7 = new string[9] { arrEditedPuzzle[6, 0], arrEditedPuzzle[7, 0], arrEditedPuzzle[8, 0], arrEditedPuzzle[6, 1], arrEditedPuzzle[7, 1], arrEditedPuzzle[8, 1], arrEditedPuzzle[6, 2], arrEditedPuzzle[7, 2], arrEditedPuzzle[8, 1] };
            arrBlock8 = new string[9] { arrEditedPuzzle[6, 3], arrEditedPuzzle[7, 3], arrEditedPuzzle[8, 3], arrEditedPuzzle[6, 4], arrEditedPuzzle[7, 4], arrEditedPuzzle[8, 4], arrEditedPuzzle[6, 5], arrEditedPuzzle[7, 5], arrEditedPuzzle[8, 5] };
            arrBlock9 = new string[9] { arrEditedPuzzle[6, 6], arrEditedPuzzle[7, 6], arrEditedPuzzle[8, 6], arrEditedPuzzle[6, 7], arrEditedPuzzle[7, 7], arrEditedPuzzle[8, 7], arrEditedPuzzle[6, 8], arrEditedPuzzle[7, 8], arrEditedPuzzle[8, 8] };
            
        }

        #region Textbox text changes

        // Checks if the input values are valid integers from 1-9

        private void TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox) sender;

            if (String.IsNullOrEmpty(textbox.Text) != true)
            {
                try
                {
                    Convert.ToInt32(textbox.Text);
                    if (Convert.ToInt32(textbox.Text) >= 0 && Convert.ToInt32(textbox.Text) <= 9)
                    {
                        lblOutput.Content = String.Empty;
                    }
                    else
                    {
                        lblOutput.Content = "Please ensure to only use numbers from 1 to 9 as input values.";
                        textbox.Text = String.Empty;
                    }
                }
                catch (Exception)
                {
                    lblOutput.Content = "Please ensure to only use numbers from 1 to 9 as input values.";
                    textbox.Text = String.Empty;
                }
            }
        }

        #endregion

        // Used to clear all the textboxes, as well as the content of the label

        private void ResetTextboxColours()
        {
            //Column 1 of textboxes
            txtC1R1.Foreground = Brushes.Black;
            txtC1R2.Foreground = Brushes.Black;
            txtC1R3.Foreground = Brushes.Black;
            txtC1R4.Foreground = Brushes.Black;
            txtC1R5.Foreground = Brushes.Black;
            txtC1R6.Foreground = Brushes.Black;
            txtC1R7.Foreground = Brushes.Black;
            txtC1R8.Foreground = Brushes.Black;
            txtC1R9.Foreground = Brushes.Black;


            //Column 2 of textboxes
            txtC2R1.Foreground = Brushes.Black;
            txtC2R2.Foreground = Brushes.Black;
            txtC2R3.Foreground = Brushes.Black;
            txtC2R4.Foreground = Brushes.Black;
            txtC2R5.Foreground = Brushes.Black;
            txtC2R6.Foreground = Brushes.Black;
            txtC2R7.Foreground = Brushes.Black;
            txtC2R8.Foreground = Brushes.Black;
            txtC2R9.Foreground = Brushes.Black;


            //Column 3 of textboxes
            txtC3R1.Foreground = Brushes.Black;
            txtC3R2.Foreground = Brushes.Black;
            txtC3R3.Foreground = Brushes.Black;
            txtC3R4.Foreground = Brushes.Black;
            txtC3R5.Foreground = Brushes.Black;
            txtC3R6.Foreground = Brushes.Black;
            txtC3R7.Foreground = Brushes.Black;
            txtC3R8.Foreground = Brushes.Black;
            txtC3R9.Foreground = Brushes.Black;


            //Column 4 of textboxes
            txtC4R1.Foreground = Brushes.Black;
            txtC4R2.Foreground = Brushes.Black;
            txtC4R3.Foreground = Brushes.Black;
            txtC4R4.Foreground = Brushes.Black;
            txtC4R5.Foreground = Brushes.Black;
            txtC4R6.Foreground = Brushes.Black;
            txtC4R7.Foreground = Brushes.Black;
            txtC4R8.Foreground = Brushes.Black;
            txtC4R9.Foreground = Brushes.Black;


            //Column 5 of textboxes
            txtC5R1.Foreground = Brushes.Black;
            txtC5R2.Foreground = Brushes.Black;
            txtC5R3.Foreground = Brushes.Black;
            txtC5R4.Foreground = Brushes.Black;
            txtC5R5.Foreground = Brushes.Black;
            txtC5R6.Foreground = Brushes.Black;
            txtC5R7.Foreground = Brushes.Black;
            txtC5R8.Foreground = Brushes.Black;
            txtC5R9.Foreground = Brushes.Black;


            //Column 6 of textboxes
            txtC6R1.Foreground = Brushes.Black;
            txtC6R2.Foreground = Brushes.Black;
            txtC6R3.Foreground = Brushes.Black;
            txtC6R4.Foreground = Brushes.Black;
            txtC6R5.Foreground = Brushes.Black;
            txtC6R6.Foreground = Brushes.Black;
            txtC6R7.Foreground = Brushes.Black;
            txtC6R8.Foreground = Brushes.Black;
            txtC6R9.Foreground = Brushes.Black;


            //Column 7 of textboxes
            txtC7R1.Foreground = Brushes.Black;
            txtC7R2.Foreground = Brushes.Black;
            txtC7R3.Foreground = Brushes.Black;
            txtC7R4.Foreground = Brushes.Black;
            txtC7R5.Foreground = Brushes.Black;
            txtC7R6.Foreground = Brushes.Black;
            txtC7R7.Foreground = Brushes.Black;
            txtC7R8.Foreground = Brushes.Black;
            txtC7R9.Foreground = Brushes.Black;


            //Column 8 of textboxes
            txtC8R1.Foreground = Brushes.Black;
            txtC8R2.Foreground = Brushes.Black;
            txtC8R3.Foreground = Brushes.Black;
            txtC8R4.Foreground = Brushes.Black;
            txtC8R5.Foreground = Brushes.Black;
            txtC8R6.Foreground = Brushes.Black;
            txtC8R7.Foreground = Brushes.Black;
            txtC8R8.Foreground = Brushes.Black;
            txtC8R9.Foreground = Brushes.Black;


            //Column 9 of textboxes
            txtC9R1.Foreground = Brushes.Black;
            txtC9R2.Foreground = Brushes.Black;
            txtC9R3.Foreground = Brushes.Black;
            txtC9R4.Foreground = Brushes.Black;
            txtC9R5.Foreground = Brushes.Black;
            txtC9R6.Foreground = Brushes.Black;
            txtC9R7.Foreground = Brushes.Black;
            txtC9R8.Foreground = Brushes.Black;
            txtC9R9.Foreground = Brushes.Black;

        }
        private void Reset()
        {

            ResetTextboxColours();


            //Column 1 of textboxes
            txtC1R1.Text = String.Empty;
            txtC1R2.Text = String.Empty;
            txtC1R3.Text = String.Empty;
            txtC1R4.Text = String.Empty;
            txtC1R5.Text = String.Empty;
            txtC1R6.Text = String.Empty;
            txtC1R7.Text = String.Empty;
            txtC1R8.Text = String.Empty;
            txtC1R9.Text = String.Empty;


            //Column 2 of textboxes
            txtC2R1.Text = String.Empty;
            txtC2R2.Text = String.Empty;
            txtC2R3.Text = String.Empty;
            txtC2R4.Text = String.Empty;
            txtC2R5.Text = String.Empty;
            txtC2R6.Text = String.Empty;
            txtC2R7.Text = String.Empty;
            txtC2R8.Text = String.Empty;
            txtC2R9.Text = String.Empty;


            //Column 3 of textboxes
            txtC3R1.Text = String.Empty;
            txtC3R2.Text = String.Empty;
            txtC3R3.Text = String.Empty;
            txtC3R4.Text = String.Empty;
            txtC3R5.Text = String.Empty;
            txtC3R6.Text = String.Empty;
            txtC3R7.Text = String.Empty;
            txtC3R8.Text = String.Empty;
            txtC3R9.Text = String.Empty;


            //Column 4 of textboxes
            txtC4R1.Text = String.Empty;
            txtC4R2.Text = String.Empty;
            txtC4R3.Text = String.Empty;
            txtC4R4.Text = String.Empty;
            txtC4R5.Text = String.Empty;
            txtC4R6.Text = String.Empty;
            txtC4R7.Text = String.Empty;
            txtC4R8.Text = String.Empty;
            txtC4R9.Text = String.Empty;


            //Column 5 of textboxes
            txtC5R1.Text = String.Empty;
            txtC5R2.Text = String.Empty;
            txtC5R3.Text = String.Empty;
            txtC5R4.Text = String.Empty;
            txtC5R5.Text = String.Empty;
            txtC5R6.Text = String.Empty;
            txtC5R7.Text = String.Empty;
            txtC5R8.Text = String.Empty;
            txtC5R9.Text = String.Empty;


            //Column 6 of textboxes
            txtC6R1.Text = String.Empty;
            txtC6R2.Text = String.Empty;
            txtC6R3.Text = String.Empty;
            txtC6R4.Text = String.Empty;
            txtC6R5.Text = String.Empty;
            txtC6R6.Text = String.Empty;
            txtC6R7.Text = String.Empty;
            txtC6R8.Text = String.Empty;
            txtC6R9.Text = String.Empty;


            //Column 7 of textboxes
            txtC7R1.Text = String.Empty;
            txtC7R2.Text = String.Empty;
            txtC7R3.Text = String.Empty;
            txtC7R4.Text = String.Empty;
            txtC7R5.Text = String.Empty;
            txtC7R6.Text = String.Empty;
            txtC7R7.Text = String.Empty;
            txtC7R8.Text = String.Empty;
            txtC7R9.Text = String.Empty;


            //Column 8 of textboxes
            txtC8R1.Text = String.Empty;
            txtC8R2.Text = String.Empty;
            txtC8R3.Text = String.Empty;
            txtC8R4.Text = String.Empty;
            txtC8R5.Text = String.Empty;
            txtC8R6.Text = String.Empty;
            txtC8R7.Text = String.Empty;
            txtC8R8.Text = String.Empty;
            txtC8R9.Text = String.Empty;


            //Column 9 of textboxes
            txtC9R1.Text = String.Empty;
            txtC9R2.Text = String.Empty;
            txtC9R3.Text = String.Empty;
            txtC9R4.Text = String.Empty;
            txtC9R5.Text = String.Empty;
            txtC9R6.Text = String.Empty;
            txtC9R7.Text = String.Empty;
            txtC9R8.Text = String.Empty;
            txtC9R9.Text = String.Empty;


            PopulateArrays();


            // Label used for output
            lblOutput.Content = String.Empty;
            lblOutput.Foreground = Brushes.Red;


            bIsEmpty = true;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void TextboxColourChanger()
        {
            // Changing empty textboxes' font-color

            // Row 1
            if (String.IsNullOrEmpty(txtC1R1.Text))
            {
                txtC1R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R1.Text))
            {
                txtC2R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R1.Text))
            {
                txtC3R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R1.Text))
            {
                txtC4R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R1.Text))
            {
                txtC5R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R1.Text))
            {
                txtC6R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R1.Text))
            {
                txtC7R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R1.Text))
            {
                txtC8R1.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R1.Text))
            {
                txtC9R1.Foreground = Brushes.Orange;
            }

            // Row 2
            if (String.IsNullOrEmpty(txtC1R2.Text))
            {
                txtC1R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R2.Text))
            {
                txtC2R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R2.Text))
            {
                txtC3R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R2.Text))
            {
                txtC4R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R2.Text))
            {
                txtC5R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R2.Text))
            {
                txtC6R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R2.Text))
            {
                txtC7R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R2.Text))
            {
                txtC8R2.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R2.Text))
            {
                txtC9R2.Foreground = Brushes.Orange;
            }

            // Row 3
            if (String.IsNullOrEmpty(txtC1R3.Text))
            {
                txtC1R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R3.Text))
            {
                txtC2R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R3.Text))
            {
                txtC3R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R3.Text))
            {
                txtC4R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R3.Text))
            {
                txtC5R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R3.Text))
            {
                txtC6R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R3.Text))
            {
                txtC7R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R3.Text))
            {
                txtC8R3.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R3.Text))
            {
                txtC9R3.Foreground = Brushes.Orange;
            }

            // Row 4
            if (String.IsNullOrEmpty(txtC1R4.Text))
            {
                txtC1R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R4.Text))
            {
                txtC2R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R4.Text))
            {
                txtC3R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R4.Text))
            {
                txtC4R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R4.Text))
            {
                txtC5R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R4.Text))
            {
                txtC6R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R4.Text))
            {
                txtC7R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R4.Text))
            {
                txtC8R4.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R4.Text))
            {
                txtC9R4.Foreground = Brushes.Orange;
            }

            // Row 5
            if (String.IsNullOrEmpty(txtC1R5.Text))
            {
                txtC1R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R5.Text))
            {
                txtC2R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R5.Text))
            {
                txtC3R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R5.Text))
            {
                txtC4R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R5.Text))
            {
                txtC5R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R5.Text))
            {
                txtC6R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R5.Text))
            {
                txtC7R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R5.Text))
            {
                txtC8R5.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R5.Text))
            {
                txtC9R5.Foreground = Brushes.Orange;
            }

            // Row 6
            if (String.IsNullOrEmpty(txtC1R6.Text))
            {
                txtC1R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R6.Text))
            {
                txtC2R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R6.Text))
            {
                txtC3R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R6.Text))
            {
                txtC4R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R6.Text))
            {
                txtC5R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R6.Text))
            {
                txtC6R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R6.Text))
            {
                txtC7R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R6.Text))
            {
                txtC8R6.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R6.Text))
            {
                txtC9R6.Foreground = Brushes.Orange;
            }

            // Row 7
            if (String.IsNullOrEmpty(txtC1R7.Text))
            {
                txtC1R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R7.Text))
            {
                txtC2R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R7.Text))
            {
                txtC3R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R7.Text))
            {
                txtC4R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R7.Text))
            {
                txtC5R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R7.Text))
            {
                txtC6R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R7.Text))
            {
                txtC7R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R7.Text))
            {
                txtC8R7.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R7.Text))
            {
                txtC9R7.Foreground = Brushes.Orange;
            }

            // Row 8
            if (String.IsNullOrEmpty(txtC1R8.Text))
            {
                txtC1R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R8.Text))
            {
                txtC2R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R8.Text))
            {
                txtC3R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R8.Text))
            {
                txtC4R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R8.Text))
            {
                txtC5R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R8.Text))
            {
                txtC6R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R8.Text))
            {
                txtC7R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R8.Text))
            {
                txtC8R8.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R8.Text))
            {
                txtC9R8.Foreground = Brushes.Orange;
            }

            // Row 9
            if (String.IsNullOrEmpty(txtC1R9.Text))
            {
                txtC1R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC2R9.Text))
            {
                txtC2R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC3R9.Text))
            {
                txtC3R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC4R9.Text))
            {
                txtC4R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC5R9.Text))
            {
                txtC5R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC6R9.Text))
            {
                txtC6R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC7R9.Text))
            {
                txtC7R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC8R9.Text))
            {
                txtC8R9.Foreground = Brushes.Orange;
            }
            if (String.IsNullOrEmpty(txtC9R9.Text))
            {
                txtC9R9.Foreground = Brushes.Orange;
            }
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            // Variables

            // Add the puzzles starting values into an array

            PopulateArrays();


            bool bIsSolvable = true;
            

            for (int x = 0; x <= 8; x++)
            {
                if (bIsEmpty == false)
                {
                    break;
                }

                for (int y = 0; y <= 8; y++)
                {
                    if (String.IsNullOrEmpty(arrOriginalPuzzle[x, y]))
                    {
                        bIsEmpty = true;
                    }
                    else
                    {
                        bIsEmpty = false;
                        break;
                    }
                }
            }

            if (bIsEmpty)
            {
                lblOutput.Content = "Please ensure to input at least one starting value for the puzzle.";
                return;
            }




            TextboxColourChanger();


            // Solving the Sudoku Puzzle

            for (int R = 0; R <= 8; R++)
            {
                int iLastEditedColumn = 0;

                if (bIsSolvable == false)
                {
                    break;
                }

                for (int C = 0; C <= 8; C++)
                {
                    if (bIsSolvable == false)
                    {
                        break;
                    }

                    switch (C)
                    {
                        case 0:
                            Array.Copy(arrColumn1, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 1:
                            Array.Copy(arrColumn2, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 2:
                            Array.Copy(arrColumn3, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock1, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock4, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock7, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 3:
                            Array.Copy(arrColumn4, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 4:
                            Array.Copy(arrColumn5, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 5:
                            Array.Copy(arrColumn6, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock2, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock5, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock8, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 6:
                            Array.Copy(arrColumn7, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 7:
                            Array.Copy(arrColumn8, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        case 8:
                            Array.Copy(arrColumn9, 0, arrEditedColumn, 0, 9);
                            switch (R)
                            {
                                case 0:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow1, 0, arrEditedRow, 0, 9);
                                    break;
                                case 1:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow2, 0, arrEditedRow, 0, 9);
                                    break;
                                case 2:
                                    Array.Copy(arrBlock3, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow3, 0, arrEditedRow, 0, 9);
                                    break;
                                case 3:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow4, 0, arrEditedRow, 0, 9);
                                    break;
                                case 4:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow5, 0, arrEditedRow, 0, 9);
                                    break;
                                case 5:
                                    Array.Copy(arrBlock6, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow6, 0, arrEditedRow, 0, 9);
                                    break;
                                case 6:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow7, 0, arrEditedRow, 0, 9);
                                    break;
                                case 7:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow8, 0, arrEditedRow, 0, 9);
                                    break;
                                case 8:
                                    Array.Copy(arrBlock9, 0, arrEditedBlock, 0, 9);
                                    Array.Copy(arrRow9, 0, arrEditedRow, 0, 9);
                                    break;
                                default:
                                    lblOutput.Content = "An unexpected error has occured.";
                                    break;
                            }
                            break;
                        default:
                            lblOutput.Content = "An unexpected error has occured.";
                            break;
                    }


                    if (String.IsNullOrEmpty(arrOriginalPuzzle[R, C])) // Checks if the current block exists as part of the given Sudoku (to ensure that the application does not change this value then)
                    {

                        for (int n = 1; n <= 9; n++) // "n" for number (the current number value of the textblock)
                        {
                            //if (String.IsNullOrEmpty(arrEditedPuzzle[R, C]) != true) // Checks if the edited puzzle already has a number in that block and sets "n" to that value + 1 if it already does have a value there (for backtracking)
                            //{
                                //if (Convert.ToInt16(arrEditedPuzzle[R, C]) + 1 == 10) // This part might not work properly
                                //{
                                //    bIsSolvable = false;
                                //    break;
                                //}

                                //n = (Convert.ToInt16(arrEditedPuzzle[R, C])) + 1;

                            //}
                            if ((arrEditedRow.Contains(n.ToString()) != true) && (arrEditedColumn.Contains(n.ToString()) != true) && (arrEditedBlock.Contains(n.ToString()) != true) && (n <= 9) && (n >= 1) ) // Check columns/rows/blocks for rules
                            {
                                arrEditedPuzzle[R, C] = n.ToString();
                                //MessageBox.Show(arrEditedPuzzle[R, C]);
                                PopulateArrays();
                                iLastEditedColumn = C;
                                break;

                            }
                            else
                            {
                                if (n == 9) // Checks if the current textblock has failed the last possible value to check (failed the number 9 check)
                                {

                                    arrEditedPuzzle[R, C] = String.Empty; // Replaces that specific block's value in the Sudoku with an "empty" value if it has already been 9 and failed the checks
                                    PopulateArrays();

                                    if (C == 0 && R != 0)
                                    {
                                        C = iLastEditedColumn; // This allows us to backtrack to a previous row, 
                                        R--;   // the last column thereof
                                    }
                                    else if (C > 1)
                                    {
                                        iLastEditedColumn = C - 1;
                                        C = C - 2; // Decreases Column value by 2 since it will auto-increment by one when the n-loop comes to an end (it needs to backtrack a column)
                                    }
                                }
                            }
                        }

                    }

                }

            }

            if (bIsSolvable == false)
            {
                lblOutput.Content = "The puzzle appears to be unsolvable, please ensure that all numbers are input correctly.";
                ResetTextboxColours();


            }
            else
            {
                lblOutput.Content = "The puzzle has been successfully solved.";
                lblOutput.Foreground = Brushes.Green;


                // Set textboxes to the solution

                //Column 1 of textboxes
                txtC1R1.Text = arrEditedPuzzle[0, 0];
                txtC1R2.Text = arrEditedPuzzle[1, 0];
                txtC1R3.Text = arrEditedPuzzle[2, 0];
                txtC1R4.Text = arrEditedPuzzle[3, 0];
                txtC1R5.Text = arrEditedPuzzle[4, 0];
                txtC1R6.Text = arrEditedPuzzle[5, 0];
                txtC1R7.Text = arrEditedPuzzle[6, 0];
                txtC1R8.Text = arrEditedPuzzle[7, 0];
                txtC1R9.Text = arrEditedPuzzle[8, 0];


                //Column 2 of textboxes
                txtC2R1.Text = arrEditedPuzzle[0, 1];
                txtC2R2.Text = arrEditedPuzzle[1, 1];
                txtC2R3.Text = arrEditedPuzzle[2, 1];
                txtC2R4.Text = arrEditedPuzzle[3, 1];
                txtC2R5.Text = arrEditedPuzzle[4, 1];
                txtC2R6.Text = arrEditedPuzzle[5, 1];
                txtC2R7.Text = arrEditedPuzzle[6, 1];
                txtC2R8.Text = arrEditedPuzzle[7, 1];
                txtC2R9.Text = arrEditedPuzzle[8, 1];


                //Column 3 of textboxes
                txtC3R1.Text = arrEditedPuzzle[0, 2];
                txtC3R2.Text = arrEditedPuzzle[1, 2];
                txtC3R3.Text = arrEditedPuzzle[2, 2];
                txtC3R4.Text = arrEditedPuzzle[3, 2];
                txtC3R5.Text = arrEditedPuzzle[4, 2];
                txtC3R6.Text = arrEditedPuzzle[5, 2];
                txtC3R7.Text = arrEditedPuzzle[6, 2];
                txtC3R8.Text = arrEditedPuzzle[7, 2];
                txtC3R9.Text = arrEditedPuzzle[8, 2];


                //Column 4 of textboxes
                txtC4R1.Text = arrEditedPuzzle[0, 3];
                txtC4R2.Text = arrEditedPuzzle[1, 3];
                txtC4R3.Text = arrEditedPuzzle[2, 3];
                txtC4R4.Text = arrEditedPuzzle[3, 3];
                txtC4R5.Text = arrEditedPuzzle[4, 3];
                txtC4R6.Text = arrEditedPuzzle[5, 3];
                txtC4R7.Text = arrEditedPuzzle[6, 3];
                txtC4R8.Text = arrEditedPuzzle[7, 3];
                txtC4R9.Text = arrEditedPuzzle[8, 3];


                //Column 5 of textboxes
                txtC5R1.Text = arrEditedPuzzle[0, 4];
                txtC5R2.Text = arrEditedPuzzle[1, 4];
                txtC5R3.Text = arrEditedPuzzle[2, 4];
                txtC5R4.Text = arrEditedPuzzle[3, 4];
                txtC5R5.Text = arrEditedPuzzle[4, 4];
                txtC5R6.Text = arrEditedPuzzle[5, 4];
                txtC5R7.Text = arrEditedPuzzle[6, 4];
                txtC5R8.Text = arrEditedPuzzle[7, 4];
                txtC5R9.Text = arrEditedPuzzle[8, 4];


                //Column 6 of textboxes
                txtC6R1.Text = arrEditedPuzzle[0, 5];
                txtC6R2.Text = arrEditedPuzzle[1, 5];
                txtC6R3.Text = arrEditedPuzzle[2, 5];
                txtC6R4.Text = arrEditedPuzzle[3, 5];
                txtC6R5.Text = arrEditedPuzzle[4, 5];
                txtC6R6.Text = arrEditedPuzzle[5, 5];
                txtC6R7.Text = arrEditedPuzzle[6, 5];
                txtC6R8.Text = arrEditedPuzzle[7, 5];
                txtC6R9.Text = arrEditedPuzzle[8, 5];


                //Column 7 of textboxes
                txtC7R1.Text = arrEditedPuzzle[0, 6];
                txtC7R2.Text = arrEditedPuzzle[1, 6];
                txtC7R3.Text = arrEditedPuzzle[2, 6];
                txtC7R4.Text = arrEditedPuzzle[3, 6];
                txtC7R5.Text = arrEditedPuzzle[4, 6];
                txtC7R6.Text = arrEditedPuzzle[5, 6];
                txtC7R7.Text = arrEditedPuzzle[6, 6];
                txtC7R8.Text = arrEditedPuzzle[7, 6];
                txtC7R9.Text = arrEditedPuzzle[8, 6];


                //Column 8 of textboxes
                txtC8R1.Text = arrEditedPuzzle[0, 7];
                txtC8R2.Text = arrEditedPuzzle[1, 7];
                txtC8R3.Text = arrEditedPuzzle[2, 7];
                txtC8R4.Text = arrEditedPuzzle[3, 7];
                txtC8R5.Text = arrEditedPuzzle[4, 7];
                txtC8R6.Text = arrEditedPuzzle[5, 7];
                txtC8R7.Text = arrEditedPuzzle[6, 7];
                txtC8R8.Text = arrEditedPuzzle[7, 7];
                txtC8R9.Text = arrEditedPuzzle[8, 7];


                //Column 9 of textboxes
                txtC9R1.Text = arrEditedPuzzle[0, 8];
                txtC9R2.Text = arrEditedPuzzle[1, 8];
                txtC9R3.Text = arrEditedPuzzle[2, 8];
                txtC9R4.Text = arrEditedPuzzle[3, 8];
                txtC9R5.Text = arrEditedPuzzle[4, 8];
                txtC9R6.Text = arrEditedPuzzle[5, 8];
                txtC9R7.Text = arrEditedPuzzle[6, 8];
                txtC9R8.Text = arrEditedPuzzle[7, 8];
                txtC9R9.Text = arrEditedPuzzle[8, 8];
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            // Exits the application (shutdown)
            Application.Current.Shutdown();
        }
    }
}
