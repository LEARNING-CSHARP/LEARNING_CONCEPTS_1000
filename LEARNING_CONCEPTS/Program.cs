namespace LEARNING_CONCEPTS
{
	/// <summary>
	/// Startup Class
	/// </summary>
	internal static class Program
	{
		static Program()
		{
		}

		/// <summary>
		/// Startup Function
		/// </summary>
		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			// Form1 -> Startup Form
			System.Windows.Forms.Application.Run(new Form1());
			// **************************************************

			// **************************************************
			//Form1 startupForm = new Form1();
			////Form2 startupForm = new Form2();

			//System.Windows.Forms.Application.Run(startupForm);

			//if (startupForm != null)
			//{
			//	if (startupForm.IsDisposed == false)
			//	{
			//		startupForm.Dispose();
			//	}

			//	startupForm = null;
			//}
			// **************************************************

			// **************************************************
			//Dtx.Windows.Forms.MessageBox.Show(text: "Hello, World!");
			// **************************************************
		}
	}
}
