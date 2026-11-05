namespace iotMAUI
{
    public partial class MainPage : ContentPage
    {
        dataContainer DataContainer { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = DataContainer;
        }

        private void masterProgramme(object sender, EventArgs e)
        {
            bool convertedSuccessfully = int.TryParse(programme.Text, out int _selected);

            if (convertedSuccessfully)
            {
                DataContainer.WasherProgram = _selected;
            }
            else
            {
                DataContainer.WasherProgram = 0;
            }

        }

        private void flipOnStateVacuum(object sender, EventArgs e)
        {
            DataContainer.VaccumState = !DataContainer.VaccumState;
        }
    }
}
