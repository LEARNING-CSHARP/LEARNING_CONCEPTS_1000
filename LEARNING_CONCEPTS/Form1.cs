namespace LEARNING_CONCEPTS
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Form2 form = new Form2();

			form.MyForm1 = this;

			form.Show();

			int intTemp = 1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Form2 form = new Form2();

			form.MyForm1 = this;

			form.ShowDialog();

			int intTemp = 1;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//System.Windows.Forms.DtxMessageBox.Show("Hello, World!");

			Dtx.Windows.Forms.MessageBox.Show(text: "Hello, World!");
		}

		private void exitButton_Click(object sender, System.EventArgs e)
		{
			//Close();

			//System.Windows.Forms.Application.Exit();

			System.Windows.Forms.DialogResult enmResult =
				System.Windows.Forms.MessageBox.Show
				(text: "آیا به خروج از برنامه اطمینان دارید؟",
				caption: "سوال",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (enmResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
	}
}
