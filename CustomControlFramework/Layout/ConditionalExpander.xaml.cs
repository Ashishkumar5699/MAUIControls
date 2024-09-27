using System.Runtime.CompilerServices;

namespace CustomControlFramework.Layout;

public partial class ConditionalExpander : ContentView
{
    //public static readonly BindableProperty HeadingProperty = BindableProperty.Create(nameof(Heading), typeof(string), typeof(ConditionalExpander), null);
    public static readonly BindableProperty ConditionProperty = BindableProperty.Create(nameof(Condition), typeof(bool), typeof(ConditionalExpander), false);
    public static readonly BindableProperty HeaderViewProperty = BindableProperty.Create(nameof(HeaderView), typeof(View), typeof(ConditionalExpander));
    public static readonly BindableProperty ContentViewProperty = BindableProperty.Create(nameof(ContentView), typeof(View), typeof(ConditionalExpander));

    public ConditionalExpander()
	{
		InitializeComponent();
	}

    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == nameof(HeaderView))
        {
            header.Content = HeaderView;
        }
        else if (propertyName == nameof(ContentView))
        {
            content.Content = ContentView;
        }
    }

    //public string Heading
    //{
    //    get => (string)GetValue(HeadingProperty);
    //    set => SetValue(HeadingProperty, value);
    //}

    public bool Condition
    {
        get => (bool)GetValue(ConditionProperty);
        set => SetValue(ConditionProperty, value);
    }

    public View HeaderView
    {
        get => (View)GetValue(HeaderViewProperty);
        set => SetValue(HeaderViewProperty, value);
    }
    public View ContentView
    {
        get => (View)GetValue(ContentViewProperty);
        set => SetValue(ContentViewProperty, value);
    }
}
