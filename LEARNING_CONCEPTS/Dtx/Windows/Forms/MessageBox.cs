namespace Dtx.Windows.Forms
{
	/// <summary>
	/// استاندارد شماره دو
	/// این استاندارد حرفه‌ای‌تر است
	/// </summary>
	public static class MessageBox
	{
		static MessageBox()
		{
		}

		public static System.Windows.Forms.DialogResult Show(string text)
		{
			// اگر وقت ندارید که در شروع کار فرم مناسب را ایجاد کنید
			//return System.Windows.Forms.MessageBox.Show(text: text);

			// بعد از اینکه فرم مناسب تولید شد
			MessageBoxForm form = new MessageBoxForm();

			// راه‌حل ذیل حرفه‌ای نیست
			//form.textLabel.Text = text;

			form.Message = text;

			form.ShowDialog();

			return System.Windows.Forms.DialogResult.OK;
		}

		public static System.Windows.Forms.DialogResult Show(string text, string caption)
		{
			MessageBoxForm form = new MessageBoxForm();

			form.Text = caption;
			form.Message = text;

			form.ShowDialog();

			return System.Windows.Forms.DialogResult.OK;
		}
	}
}
