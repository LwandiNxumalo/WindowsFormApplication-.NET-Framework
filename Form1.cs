using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical6
{
    public partial class frmAbahambeLift : Form
    {
        private decimal basicFee = 0M, additionalFee = 0M, liftFare = 0M, totalLiftFare = 0M, totalAfterDiscount = 0M;
        int numberOfTickets = 0;
        double discount = 0.8 * 2;


        public frmAbahambeLift()
        {
            InitializeComponent();
            lbxDestination.Items.Add("Durban");
            lbxDestination.Items.Add("Centurion");
            lbxDestination.Items.Add("Bloemfontein");
            lbxDestination.Items.Add("Capetown");
            rbtnIkageng.Checked = false;
            rbtnMohadin.Checked = false;
            rbtnPromosa.Checked = false;
        }

        private void cbxReturnTrip_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("We will book you a return ticket, if this box is checked \nYou will receive a 20% discount");
        }

        private void btnBookLift_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtBookLift.Text, out numberOfTickets))
                {
                    if (rbtnIkageng.Checked || rbtnMohadin.Checked || rbtnPromosa.Checked)
                    {
                        if (rbtnIkageng.Checked)
                        {
                            basicFee = 250M;
                        }
                        else if (rbtnPromosa.Checked)
                        {
                            basicFee = 220M;
                        }
                        else if (rbtnMohadin.Checked)
                        {
                            basicFee = 270M;
                        }
                    }

                    else
                    {
                        basicFee = 200M;
                    }

                    switch (lbxDestination.SelectedIndex)
                    {
                        case 0:
                            additionalFee = 200M;
                            break;

                        case 1:
                            additionalFee = 250M;
                            break;

                        case 2:
                            additionalFee = 150M;
                            break;
                        case 3:

                            additionalFee = 600M;
                            break;

                        case 4:
                            additionalFee = 250M;
                            break;

                        case 5:
                            additionalFee = 400M;
                            
                            break;

                        case 6:
                            additionalFee = 900M;
                            break;

                        default:
                            MessageBox.Show("Please choose a destination from the list");
                            return;
                    }
                    liftFare = basicFee + additionalFee;
                    totalLiftFare = liftFare * (decimal)numberOfTickets;

                    if (cbxReturnTrip.Checked)
                    {
                        totalAfterDiscount = totalLiftFare * (decimal)discount;
                    }

                    MessageBox.Show("Your " + numberOfTickets.ToString() + " have been booked to " + lbxDestination.SelectedItem.ToString() + " is Booked \nTotal payable is: " + totalAfterDiscount.ToString("c"));
                }
                else
                {
                    MessageBox.Show("Enter correct number of tickets");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
