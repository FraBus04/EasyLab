using Microsoft.AspNetCore.Components;

namespace EasyLab.Components.Utils;

// Scoped per-circuit "portal": lets CheckboxDropdown render its open menu at the
// app root (via DropdownPortalHost) so it is never clipped by a scrolling ancestor.
public class DropdownPortalService
{
    public event Action? OnChange;

    public RenderFragment? Content { get; private set; }

    public void Show(RenderFragment content)
    {
        Content = content;
        OnChange?.Invoke();
    }

    public void Hide()
    {
        if (Content == null) return;
        Content = null;
        OnChange?.Invoke();
    }
}
