namespace CustomControlFramework.Page;

public partial class ContentPageMobileBase : ContentPage
{
	public ContentPageMobileBase()
	{
		InitializeComponent();
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
	#endregion

}