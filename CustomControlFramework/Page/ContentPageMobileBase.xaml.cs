namespace CustomControlFramework.Page;

public partial class ContentPageMobileBase : ContentPage
{
	public ContentPageMobileBase()
	{
		InitializeComponent();
	}

	private async void OnLabelTapped(object sender, EventArgs e)
    {
        // Get the text from the label
		string labelText = (sender as dynamic).Text;

        if (!string.IsNullOrEmpty(labelText))
        {
            // Copy the text to clipboard
            await Clipboard.SetTextAsync(labelText);
        }
    }

	#region Bindable Propertices

	/// <summary>
	/// Gets or sets the ShowActivityIndicator property
	/// </summary>
	public bool ShowActivityIndicator
	{
		get { return (bool)GetValue(ShowActivityIndicatorProperty); }
		set { SetValue(ShowActivityIndicatorProperty, value); }
	}

	public static readonly BindableProperty ShowActivityIndicatorProperty =
		BindableProperty.Create(nameof(ShowActivityIndicator), typeof(bool), typeof(ContentPageMobileBase), false, BindingMode.TwoWay);

    /// <summary>
    /// Show progress
    /// </summary>
    public bool ShowProgres
	{
		get => (bool)GetValue(ShowProgresproperty);
		set => SetValue(ShowProgresproperty, value);
	}

    public static readonly BindableProperty ShowProgresproperty =
        BindableProperty.Create(nameof(ShowProgres), typeof(bool), typeof(ContentPageMobileBase), false);

    /// <summary>
    /// Progress value
    /// </summary>
    public double ProgressValue
    {
        get => (double)GetValue(Progresproperty);
        set => SetValue(Progresproperty, value);
    }

    public static readonly BindableProperty Progresproperty =
        BindableProperty.Create(nameof(ProgressValue), typeof(double), typeof(ContentPageMobileBase), 0.10, BindingMode.TwoWay);

    #endregion

}