﻿namespace BlazorExpress.Bulma.Docx;

public partial class Section : BulmaComponentBase
{
    #region Members

    private string? headerClassNames => $"{Size.ToTitleSizeClass()} mt-4 mb-3";

    private string link => $"{PageUrl}#{Link}".Trim().ToLower();

    #endregion

    #region Methods

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && IsFirstRenderComplete)
        {
            await Task.Delay(200);
            await JSRuntime.InvokeVoidAsync("navigateToHeading");
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task OnClick()
    {
        await JSRuntime.InvokeVoidAsync("navigateToHeading");
    }

    #endregion

    #region Properties, Indexers

    protected override string? ClassNames
        => BuildClassNames(
            Class,
            (BulmaCssClass.Section, true),
            (BulmaCssClass.IsMobile, IsMobile));

    /// <summary>
    /// Gets or sets the child content.
    /// </summary>
    /// <remarks>
    /// Default value is <see langword="null"/>.
    /// </remarks>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool IsMobile { get; set; } = true;

    [Parameter] public string? Link { get; set; }

    [Parameter] public string? Name { get; set; }

    [Parameter] public string? PageUrl { get; set; }

    [Parameter] public HeadingSize Size { get; set; }

    #endregion
}
