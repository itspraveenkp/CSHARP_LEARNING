using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Real_time_example_of_queue_collection_class
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " Cutomers before you in the queue";

            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }
            int NextTokenNumberTobeIssued = (int)Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = NextTokenNumberTobeIssued;
            tokenQueue.Enqueue(NextTokenNumberTobeIssued);
            AddTokensToListbox(tokenQueue);
        }

        private void AddTokensToListbox(Queue<int> tokenQueue)
        {
            listToken.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listToken.Items.Add(token.ToString());
            }
        }

        private void ServedNextCustomer(TextBox textBox, int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count == 0)
            {
                textBox.Text = "No Customer in the Queue";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textBox.Text = tokenNumberToBeServed.ToString();
                txtDisplay.Text = "Token Number: " + tokenNumberToBeServed.ToString() + 
                    " Please go to Counter " + counterNumber;
                AddTokensToListbox(tokenQueue);
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServedNextCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServedNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServedNextCustomer(txtCounter3, 3);
        }
    }
}