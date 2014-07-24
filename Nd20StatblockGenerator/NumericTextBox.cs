using System;
using System.Windows.Forms;


namespace Nd20StatblockGenerator
{
	/// <summary>
	/// Summary description for NumericTextBox.
	/// </summary>
	public class NumericTextBox : TextBox
	{
		public NumericTextBox()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
		}
	}
}
