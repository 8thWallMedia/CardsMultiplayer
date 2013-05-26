/*  
 * Class: RichPassword.cs
 * Purpose: A copy of RichTextBox with password params not shown by default in .NET
 * Author: Cameron 
*/
using System;
using System.Windows.Forms;
namespace CardsMultiplayer
{
    class RichPassword : RichTextBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= 0x20;
                return cp;
            }
        }
    }
}
