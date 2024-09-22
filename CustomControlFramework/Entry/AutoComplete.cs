// using System;
// using System.Collections;
// using System.Reflection;

namespace CustomControlFramework.Entry
{
	public class AutoComplete : ContentView
    {
//         public static readonly BindableProperty SuggestionsProperty = BindableProperty.Create(nameof(Suggestions), typeof(IEnumerable), typeof(AutoComplete), null, BindingMode.OneWay, null, OnSuggestionsChanged);
//         public static readonly BindableProperty SearchTextProperty = BindableProperty.Create(nameof(SearchText), typeof(string), typeof(AutoComplete), null, BindingMode.TwoWay, null, OnSearchTextChanged);
//         public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(AutoComplete), null, BindingMode.OneWay, null, OnPlaceholderChanged);
//         public static readonly BindableProperty MaximumVisibleSuggestionItemsProperty = BindableProperty.Create(nameof(MaximumVisibleSuggestionItems), typeof(int), typeof(AutoComplete), 4);
//         public static readonly BindableProperty SuggestionItemTemplateProperty = BindableProperty.Create(nameof(SuggestionItemTemplate), typeof(DataTemplate), typeof(AutoComplete), null, BindingMode.OneWay, null, OnSuggestionItemTemplateChanged);
//         public static readonly BindableProperty DisplayPropertyNameProperty = BindableProperty.Create(nameof(DisplayPropertyName), typeof(string), typeof(AutoComplete));

//         public IEnumerable Suggestions
//         {
//             get { return (IEnumerable)GetValue(SuggestionsProperty); }
//             set { SetValue(SuggestionsProperty, value); }
//         }

//         public string SearchText
//         {
//             get { return (string)GetValue(SearchTextProperty); }
//             set { SetValue(SearchTextProperty, value); }
//         }

//         public string Placeholder
//         {
//             get { return (string)GetValue(PlaceholderProperty); }
//             set { SetValue(PlaceholderProperty, value); }
//         }

//         public int MaximumVisibleSuggestionItems
//         {
//             get { return (int)GetValue(MaximumVisibleSuggestionItemsProperty); }
//             set { SetValue(MaximumVisibleSuggestionItemsProperty, value); }
//         }

//         public DataTemplate SuggestionItemTemplate
//         {
//             get { return (DataTemplate)GetValue(SuggestionItemTemplateProperty); }
//             set { SetValue(SuggestionItemTemplateProperty, value); }
//         }

//         public string DisplayPropertyName
//         {
//             get { return (string)GetValue(DisplayPropertyNameProperty); }
//             set { SetValue(DisplayPropertyNameProperty, value); }
//         }

//         public ItemsStack SuggestionsListView { get; private set; }
//         public Entry SearchEntry { get; private set; }
//         public IEnumerable OriginSuggestions { get; private set; }
//         public NestedScrollView SuggestionWrapper { get; private set; }
//         public Grid Container { get; private set; }

//         public bool IsSelected { get; private set; }
//         public int TotalNumberOfTypings { get; private set; }

//         private static void OnSuggestionsChanged(object bindable, object oldValue, object newValue)
//         {
//             var autoCompleteView = bindable as AutoComplete;

//             var suggestions = (IEnumerable)newValue;
//             autoCompleteView.OriginSuggestions = suggestions;

//             suggestions = autoCompleteView.FilterSuggestions(suggestions, autoCompleteView.SearchText);
//             autoCompleteView.SuggestionsListView.ItemsSource = suggestions;
//         }

//         private static void OnSearchTextChanged(object bindable, object oldValue, object newValue)
//         {
//             var autoCompleteView = bindable as AutoComplete;

//             var suggestions = autoCompleteView.OriginSuggestions;
//             if (newValue != null)
//             {
//                 suggestions = autoCompleteView.FilterSuggestions(suggestions, autoCompleteView.SearchText);
//                 // assign when initializing with data
//                 if (autoCompleteView.SearchEntry.Text != autoCompleteView.SearchText)
//                 {
//                     autoCompleteView.SearchEntry.Text = autoCompleteView.SearchText;
//                 }
//             }
//             autoCompleteView.SuggestionsListView.ItemsSource = suggestions;

//             //if (Device.OS == TargetPlatform.Android)
//             //{
//             //    // update the layout -> only do this when user is typing instead of selection an item from suggestions list 
//             //    // -> prevent duplicated update layout
//             //    if (!autoCompleteView.IsSelected)
//             //    {
//             //        autoCompleteView.UpdateLayout();
//             //    }
//             //    else
//             //    {
//             //        autoCompleteView.IsSelected = false;
//             //    }
//             //}
//         }

//         private static void OnSuggestionItemTemplateChanged(object bindable, object oldValue, object newValue)
//         {
//             var autoCompleteView = bindable as AutoCompleteView;

//             if (autoCompleteView.SuggestionsListView != null)
//             {
//                 autoCompleteView.SuggestionsListView.ItemTemplate = autoCompleteView.SuggestionItemTemplate;
//             }
//         }

//         public IEnumerable FilterSuggestions(IEnumerable suggestions, string keyword)
//         {
//             if (string.IsNullOrEmpty(keyword) || suggestions == null) return suggestions;

//             var searchWords = keyword.ConvertToNonMark().ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
//             var result = suggestions.Cast<object>();
//             foreach (var item in searchWords)
//             {
//                 if (!string.IsNullOrEmpty(DisplayPropertyName))
//                 {
//                     result = result.Where(x => x.GetType().GetRuntimeProperty(DisplayPropertyName).GetValue(x).ToString().ConvertToNonMark().ToLower().Contains(item)).ToList();
//                 }
//                 else
//                 {
//                     result = result.Where(x => x.ToString().ConvertToNonMark().ToLower().Contains(item)).ToList();
//                 }
//             }

//             return result;
//         }

//         private static void OnPlaceholderChanged(object bindable, object oldValue, object newValue)
//         {
//             var autoCompleteView = bindable as AutoCompleteView;
//             autoCompleteView.SearchEntry.Placeholder = newValue?.ToString();
//         }

//         public void UpdateLayout()
//         {
//             var expectedHeight = this.getExpectedHeight();
//             Container.HeightRequest = expectedHeight;
//             Container.ForceLayout();
//         }


//         private void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
//         {
//             TotalNumberOfTypings++;
//             Device.StartTimer(TimeSpan.FromMilliseconds(1000), () => {
//                 TotalNumberOfTypings--;
//                 if (TotalNumberOfTypings == 0)
//                 {
//                     SearchText = e.NewTextValue;
//                 }
//                 return false;
//             });
//         }

//         private void SearchEntry_Focused(object sender, FocusEventArgs e)
//         {
//             UpdateLayout();
//             IsSelected = false;
//         }

//         private void SearchEntry_Unfocused(object sender, FocusEventArgs e)
//         {
//             Container.HeightRequest = 50;
//             Container.ForceLayout();
//         }

//         private void SuggestionsListView_ItemSelected(object sender, ItemTappedEventArgs e)
//         {
//             IsSelected = true;
//             SearchEntry.Text = !string.IsNullOrEmpty(DisplayPropertyName) ? e.Item?.GetType()?.GetRuntimeProperty(DisplayPropertyName)?.GetValue(e.Item)?.ToString() : e.Item?.ToString();
//             Container.HeightRequest = 50;
//             Container.ForceLayout();
//         }

//         private void OverlapContentView_Tapped(object sender, TappedEventArgs e)
//         {
//             UpdateLayout();
//             IsSelected = false;

//         }

//         private int getExpectedHeight()
//         {
//             var items = SuggestionsListView.ItemsSource as IList;
//             int wrapperHeightRequest = items != null ?
//                 (items.Count >= MaximumVisibleSuggestionItems ? MaximumVisibleSuggestionItems * 40 : items.Count * 40) : 0;
//             if (Device.OS == TargetPlatform.Android)
//             {
//                 return wrapperHeightRequest + 50;
//             }
//             return MaximumVisibleSuggestionItems * 40 + 50;
//         }

//         public AutoComplete()
//         {
//             Container = new Grid();
//             SearchEntry = new Entry();
//             SuggestionsListView = new ItemsStack();
//             SuggestionWrapper = new NestedScrollView();

//             // init Grid Layout
//             Container.RowSpacing = 0;
//             Container.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
//             Container.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
//             Container.RowDefinitions.Add(new RowDefinition() { Height = 50 });
//             Container.HeightRequest = 50;

//             // init Search Entry
//             SearchEntry.HorizontalOptions = LayoutOptions.Fill;
//             SearchEntry.VerticalOptions = LayoutOptions.Fill;
//             SearchEntry.TextChanged += SearchEntry_TextChanged;
//             SearchEntry.Unfocused += SearchEntry_Unfocused;
//             SearchEntry.Focused += SearchEntry_Focused;

//             // init Suggestions ListView
//             SuggestionsListView.BackgroundColor = Color.White;
//             SuggestionsListView.ItemTapped += SuggestionsListView_ItemSelected;
//             SuggestionsListView.VerticalOptions = LayoutOptions.End;
//             SuggestionsListView.Spacing = 1;

//             // suggestions Listview's wrapper
//             SuggestionWrapper.VerticalOptions = LayoutOptions.Fill;
//             SuggestionWrapper.Orientation = ScrollOrientation.Vertical;
//             SuggestionWrapper.BackgroundColor = Color.White;
//             SuggestionWrapper.Content = SuggestionsListView;

//             Container.Children.Add(SuggestionWrapper);
//             Container.Children.Add(SearchEntry, 0, 1);

//             this.Content = Container;
//         }

    }
}

