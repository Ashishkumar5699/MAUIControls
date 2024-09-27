namespace CustomControlFramework.Entry;

public partial class SignaturePad : ContentView
{
	public SignaturePad()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        DrawBoard.Lines.Clear();
    }

    private void DrawBoard_DrawingLineCompleted(System.Object sender, CommunityToolkit.Maui.Core.DrawingLineCompletedEventArgs e)
    {
        ImageView.Dispatcher.Dispatch(async () =>
        {
            var stream = await DrawBoard.GetImageStream(300, 300);
            ImageView.Source = ImageSource.FromStream(() => stream);
        });
    }
}
