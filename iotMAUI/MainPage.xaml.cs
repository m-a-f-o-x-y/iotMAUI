namespace iotMAUI
{
    public partial class MainPage : ContentPage
    {
        dataContainer dataContainer = new();

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = dataContainer;


            
        }

        private void masterProgramme(object sender, EventArgs e)
        {
            int _selected = 0; 
            int.TryParse(programme.Text, out _selected);

            dataContainer.WasherProgram = _selected;
        }

        private void flipOnStateVacuum(object sender, EventArgs e)
        {
            dataContainer.VaccumState = !dataContainer.VaccumState;
        }
    }
}
