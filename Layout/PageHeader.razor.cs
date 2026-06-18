namespace MenuTest.Layout;


public partial class PageHeader
{
    private string _pageTitle = string.Empty;
    private Type? _rightContent { get; set; }
    private Type? _leftContent { get; set; }

    private Dictionary<string, object?>? _rightContentParameters;
    private Dictionary<string, object?>? _leftContentParameters;
    private string _leftContentPadding = "";

}