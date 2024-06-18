using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.Calculator
{
    public partial class History : ComponentBase
    {
        [Parameter] public Stack<string> ResultsHistory { get; set; } = null!;
    }
}
