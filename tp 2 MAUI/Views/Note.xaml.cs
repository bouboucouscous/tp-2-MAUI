namespace tp_2_MAUI;

public partial class Note : ContentPage
{

    public string sFileName = "123.notes.txt";

    public string _fileName;

    public Note()
	{
		InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        _fileName = Path.Combine(FileSystem.AppDataDirectory, path2: $"{sFileName}");
        ChargerNote(Path.Combine(appDataPath, sFileName));
        if (File.Exists(_fileName)) 
            TextEditor.Text = File.ReadAllText(_fileName);
    }

    private void ButtonSupprimer_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, TextEditor.Text);
    }

    private void ButtonEnregistrer_Clicked(object sender, EventArgs e)
    {
        if(File.Exists(_fileName))
            File.Delete(_fileName); 
        TextEditor.Text = string.Empty;
    }

    private void ChargerNote(string fileName)
    {
        Models.CNote noteModel = new Models.CNote();
        noteModel.Filename = fileName;
        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }
        BindingContext = noteModel;
    }
}