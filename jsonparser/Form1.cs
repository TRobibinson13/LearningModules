using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDeserialize_Click(object sender, EventArgs e)
        {
            //txtDebugOutput.Text = txtInput.Text;
            //debugOutput(txtInput.Text);
            deserialzeJSON(txtInput.Text);
        }

        #region UI events
        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }
        #endregion

        #region json functions

        private void deserialzeJSON(string strJSON)
        {
            try
            {
                /*
                 * Various classes I called against to create the jPerson object while building/testing
                 */
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonSimple>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                var jPerson = JsonConvert.DeserializeObject<jsonPersonExtraComplex>(strJSON);

                debugOutput("The JSON Object is: " + jPerson.ToString());

                #region simpleJson
                debugOutput("First Name: " + jPerson.firstname);
                debugOutput("Last Name: " + jPerson.lastname);
                debugOutput("Age: " + jPerson.age);
                debugOutput("Is alive: " + jPerson.isAlive);
                #endregion

                #region complexJson
                debugOutput("street address: " + jPerson.address.streetAddress);
                debugOutput("city: " + jPerson.address.city);
                debugOutput("postal code: " + jPerson.address.postCode);
                debugOutput("phone number(s): ");

                foreach(var num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + " - " + num.number.ToString());
                }

                #endregion
            }
            catch (Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion

        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion

    }
}
