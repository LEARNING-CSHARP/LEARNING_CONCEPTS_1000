namespace System.Windows.Forms
{
	/// <summary>
	/// استاندارد شماره یک
	/// </summary>
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
	/// <summary>
	/// استاندارد شماره دو
	/// این استاندارد حرفه‌ای تر است
	/// </summary>
	public static class MessageBox
	{
		public static System.Windows.Forms.DialogResult Show(string text)
		{
			MessageBoxForm form = new MessageBoxForm();

			// راه‌حل ذیل حرفه‌ای نیست
			//form.textLabel.Text = text;

			form.Message = text;

			form.ShowDialog();

			return (System.Windows.Forms.DialogResult.OK);
		}
	}
}
