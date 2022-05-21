using System.Collections.Generic;

namespace XamMultiColumnComboEditorStudy;

public class MainViewModel
{
    public IReadOnlyList<Item> Items { get; } = new[]
    {
        new Item("Orange"),
        new Item("Apple")
    };
}