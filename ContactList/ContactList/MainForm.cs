namespace ContactList;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using var addContactForm = new AddContactForm();
        addContactForm.ShowDialog(this);
    }
}