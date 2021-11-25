namespace LEARNING_CONCEPTS
{
	public partial class Form2 : System.Windows.Forms.Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		// Step (1)
		//public Form1 MyForm1;
		//OR
		public Form1 MyForm1 { get; set; }

		private void Form2_Load(object sender, System.EventArgs e)
		{
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Step (4)
			MyForm1.myTextBox.Text = "Hello, World!";
			//OR
			//this.MyForm1.myTextBox.Text = "Hello, World!";
		}
	}
}
