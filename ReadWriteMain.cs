namespace HallieGearhartA6
{
    public partial class ReadWriteMain : Form
    {
        private List<MyModel> mappedObjects = new List<MyModel>();

        public ReadWriteMain()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object? sender, EventArgs e)
        {
            // Open the file dialog to let the user select a file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";  // Filter for JSON files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path from the dialog and read the file's contents
                    string filePath = openFileDialog.FileName;
                    string jsonData = File.ReadAllText(filePath);

                    // Deserialize the JSON data into a list of model objects
                    mappedObjects = JsonConvert.DeserializeObject<List<MyModel>>(jsonData);

                    // Display a message showing how many objects were loaded
                    MessageBox.Show($"{mappedObjects.Count} objects loaded successfully.");
                }
            }

            // Update the display count (this function should update a label to show the total count)
            UpdateObjectCount();
        }

        private void UpdateObjectCount()
        {
            // Assuming you have a label named lblObjectCount to display the number of loaded objects
            lblObjectCount.Text = $"Total Objects: {mappedObjects?.Count ?? 0}";
        }
    }

    public class MyModel
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
        public bool Property3 { get; set; }
    }
}
