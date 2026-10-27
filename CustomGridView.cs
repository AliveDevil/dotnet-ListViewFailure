using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ListViewFailure;

public class CustomGridView : GridView
{
    public static ResourceKey CustomGridViewItemContainerStyleKey { get; } = new ComponentResourceKey(typeof(CustomGridView), nameof(CustomGridViewItemContainerStyleKey));
    public static ResourceKey CustomGridViewStyleKey { get; } = new ComponentResourceKey(typeof(CustomGridView), nameof(CustomGridViewStyleKey));

    protected override object DefaultStyleKey => CustomGridViewStyleKey;

    protected override object ItemContainerDefaultStyleKey => CustomGridViewItemContainerStyleKey;
}
