namespace System.Windows.Forms
{
	public static class DtxMessageBox
	{
		public static System.Windows.Forms.DialogResult Show(string text)
		{
			return (System.Windows.Forms.DialogResult.OK);
		}
	}
}

namespace Dtx.Windows.Forms
{
	public static class MessageBox
	{
		public static System.Windows.Forms.DialogResult Show(string text)
		{
			MessageBoxForm frm = new MessageBoxForm();

			frm.Message = text;

			frm.ShowDialog();

			return (System.Windows.Forms.DialogResult.OK);
		}
	}
}
