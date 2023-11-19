// Decompiled with JetBrains decompiler
// Type: Farplane.FFX.EditorPanels.Debug.DebugPanel
// Assembly: Farplane, Version=0.5.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 5828093B-4204-4837-BBC5-68E56E0DDAD5
// Assembly location: C:\Users\jaksl\Downloads\Farplane_0.5.0.1\Farplane.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace Farplane.FFX.EditorPanels.Debug
{
  public partial class DebugPanel : UserControl, IComponentConnector
  
  {
    private readonly int _debugOffset = Offsets.GetOffset(OffsetType.DebugFlags);
    private readonly int[] _debugOffsets = (int[]) Enum.GetValues(typeof (DebugFlags));
    private List<int> known;
    private List<int> unknown;
    // internal StackPanel StackDebugOptions;
    // internal CheckBox CheckEnemyInvincible;
    // internal CheckBox CheckPartyInvincible;
    // internal CheckBox CheckEnemyControl;
    // internal CheckBox CheckGamepadCamera;
    // internal CheckBox CheckOverdriveAlways;
    // internal CheckBox CheckAlwaysCritical;
    // internal CheckBox CheckAlwaysDeal1;
    // internal CheckBox CheckAlwaysDeal10000;
    // internal CheckBox CheckAlwaysDeal99999;
    // internal CheckBox CheckAlwaysRareDrop;
    // internal CheckBox CheckBattleAPx100;
    // internal CheckBox CheckBattleGilx100;
    // internal CheckBox CheckSensorEnabled;
    // internal CheckBox CheckShowUnknownFlags;
    // internal TextBlock TextUnknownWarning;
    // internal StackPanel StackUnknown;
    // private bool _contentLoaded;

    public DebugPanel() => this.InitializeComponent();

    public void Refresh()
    {
      byte[]   numArray = Memory.ReadBytes(this._debugOffset, 32);
      string[] names    = Enum.GetNames(typeof (DebugFlags));
      Array    values   = Enum.GetValues(typeof (DebugFlags));
      this.known = new List<int>();
      this.unknown = new List<int>();
      for (int index = 0; index < names.Length; ++index)
      {
        if (names[index].StartsWith("Unknown"))
          this.unknown.Add((int) values.GetValue(index));
        else
          this.known.Add((int) values.GetValue(index));
      }
      for (int index = 0; index < this.known.Count; ++index)
        (this.StackDebugOptions.Children[index] as CheckBox).IsChecked = new bool?(numArray[this.known[index]] == (byte) 1);
      for (int index = 0; index < this.unknown.Count; ++index)
        (this.StackUnknown.Children[index] as CheckBox).IsChecked = new bool?(numArray[this.unknown[index]] == (byte) 1);
    }

    private void CheckBox_Changed(object sender, RoutedEventArgs e)
    {
      for (int index = 0; index < this.known.Count; ++index)
        Memory.WriteByte(this._debugOffset + this.known[index], (this.StackDebugOptions.Children[index] as CheckBox).IsChecked.Value ? (byte) 1 : (byte) 0);
      for (int index = 0; index < this.unknown.Count; ++index)
        Memory.WriteByte(this._debugOffset + this.unknown[index], (this.StackUnknown.Children[index] as CheckBox).IsChecked.Value ? (byte) 1 : (byte) 0);
      this.Refresh();
    }

    private void CheckShowUnknownFlags_OnChecked(object sender, RoutedEventArgs e)
    {
      this.StackUnknown.Visibility = this.CheckShowUnknownFlags.IsChecked.Value ? Visibility.Visible : Visibility.Hidden;
      this.TextUnknownWarning.Visibility = this.CheckShowUnknownFlags.IsChecked.Value ? Visibility.Visible : Visibility.Collapsed;
    }

    // [DebuggerNonUserCode]
    // [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    // public void InitializeComponent()
    // {
    //   if (this._contentLoaded)
    //     return;
    //   this._contentLoaded = true;
    //   Application.LoadComponent((object) this, new Uri("/Farplane;component/ffx/editorpanels/debug/debugpanel.xaml", UriKind.Relative));
    // }

    // [DebuggerNonUserCode]
    // [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    // [EditorBrowsable(EditorBrowsableState.Never)]
    // void IComponentConnector.Connect(int connectionId, object target)
    // {
    //   switch (connectionId)
    //   {
    //     case 1:
    //       this.StackDebugOptions = (StackPanel) target;
    //       break;
    //     case 2:
    //       this.CheckEnemyInvincible = (CheckBox) target;
    //       this.CheckEnemyInvincible.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckEnemyInvincible.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 3:
    //       this.CheckPartyInvincible = (CheckBox) target;
    //       this.CheckPartyInvincible.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckPartyInvincible.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 4:
    //       this.CheckEnemyControl = (CheckBox) target;
    //       this.CheckEnemyControl.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckEnemyControl.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 5:
    //       this.CheckGamepadCamera = (CheckBox) target;
    //       this.CheckGamepadCamera.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckGamepadCamera.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 6:
    //       this.CheckOverdriveAlways = (CheckBox) target;
    //       this.CheckOverdriveAlways.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckOverdriveAlways.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 7:
    //       this.CheckAlwaysCritical = (CheckBox) target;
    //       this.CheckAlwaysCritical.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckAlwaysCritical.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 8:
    //       this.CheckAlwaysDeal1 = (CheckBox) target;
    //       this.CheckAlwaysDeal1.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckAlwaysDeal1.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 9:
    //       this.CheckAlwaysDeal10000 = (CheckBox) target;
    //       this.CheckAlwaysDeal10000.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckAlwaysDeal10000.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 10:
    //       this.CheckAlwaysDeal99999 = (CheckBox) target;
    //       this.CheckAlwaysDeal99999.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckAlwaysDeal99999.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 11:
    //       this.CheckAlwaysRareDrop = (CheckBox) target;
    //       this.CheckAlwaysRareDrop.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckAlwaysRareDrop.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 12:
    //       this.CheckBattleAPx100 = (CheckBox) target;
    //       this.CheckBattleAPx100.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckBattleAPx100.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 13:
    //       this.CheckBattleGilx100 = (CheckBox) target;
    //       this.CheckBattleGilx100.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckBattleGilx100.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 14:
    //       this.CheckSensorEnabled = (CheckBox) target;
    //       this.CheckSensorEnabled.Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       this.CheckSensorEnabled.Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 15:
    //       this.CheckShowUnknownFlags = (CheckBox) target;
    //       this.CheckShowUnknownFlags.Checked += new RoutedEventHandler(this.CheckShowUnknownFlags_OnChecked);
    //       this.CheckShowUnknownFlags.Unchecked += new RoutedEventHandler(this.CheckShowUnknownFlags_OnChecked);
    //       break;
    //     case 16:
    //       this.TextUnknownWarning = (TextBlock) target;
    //       break;
    //     case 17:
    //       this.StackUnknown = (StackPanel) target;
    //       break;
    //     case 18:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 19:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 20:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 21:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 22:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 23:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 24:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 25:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 26:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 27:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 28:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 29:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 30:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 31:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 32:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 33:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 34:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 35:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     case 36:
    //       ((ToggleButton) target).Checked += new RoutedEventHandler(this.CheckBox_Changed);
    //       ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.CheckBox_Changed);
    //       break;
    //     default:
    //       this._contentLoaded = true;
    //       break;
    //   }
    // }
  }
}
