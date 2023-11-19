using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Farplane.FFX.Data;

namespace Farplane.FFX.EditorPanels.SphereGridPanel
{
    /// <summary>
    /// Interaction logic for SphereGridPanel.xaml
    /// </summary>
    public partial class SphereGridPanel : UserControl
    {
        private SphereGridEditor _sphereGridEditor = new SphereGridEditor();

        public SphereGridPanel()
        {
            InitializeComponent();
            SphereGridEditor.Content = _sphereGridEditor;
        }

        public void Refresh()
        {
            _sphereGridEditor.Refresh();
        }

        public static List<NodeType> noAssign = new List<NodeType>()
        {
            new NodeType { ID = 0x00, Name = "Lv. 3 Lock" },
            new NodeType { ID = 0x01, Name = "Empty" },
            new NodeType { ID = 0x27, Name = "Lv. 1 Lock" },
            new NodeType { ID = 0x28, Name = "Lv. 2 Lock" },
            new NodeType { ID = 0x29, Name = "Lv. 4 Lock" },
        };

        public static List<NodeType> abilityNodes = new List<NodeType>()
        {
            new NodeType { ID = 0x2a, Name = "Delay Attack" },
            new NodeType { ID = 0x2b, Name = "Delay Buster" },
            new NodeType { ID = 0x2c, Name = "Sleep Attack" },
            new NodeType { ID = 0x2d, Name = "Silence Attack" },
            new NodeType { ID = 0x2e, Name = "Dark Attack" },
            new NodeType { ID = 0x2f, Name = "Zombie Attack" },
            new NodeType { ID = 0x30, Name = "Sleep Buster" },
            new NodeType { ID = 0x31, Name = "Silence Buster" },
            new NodeType { ID = 0x32, Name = "Dark Buster" },
            new NodeType { ID = 0x33, Name = "Triple Foul" },
            new NodeType { ID = 0x34, Name = "Power Break" },
            new NodeType { ID = 0x35, Name = "Magic Break" },
            new NodeType { ID = 0x36, Name = "Armor Break" },
            new NodeType { ID = 0x37, Name = "Mental Break" },
            new NodeType { ID = 0x38, Name = "Mug" },
            new NodeType { ID = 0x39, Name = "Quick Hit" },
            new NodeType { ID = 0x3a, Name = "Steal" },
            new NodeType { ID = 0x3b, Name = "Use" },
            new NodeType { ID = 0x3c, Name = "Flee" },
            new NodeType { ID = 0x3d, Name = "Pray" },
            new NodeType { ID = 0x3e, Name = "Cheer" },
            new NodeType { ID = 0x3f, Name = "Focus" },
            new NodeType { ID = 0x40, Name = "Reflex" },
            new NodeType { ID = 0x41, Name = "Aim" },
            new NodeType { ID = 0x42, Name = "Luck" },
            new NodeType { ID = 0x43, Name = "Jinx" },
            new NodeType { ID = 0x44, Name = "Lancet" },
            new NodeType { ID = 0x45, Name = "Guard" },
            new NodeType { ID = 0x46, Name = "Sentinel" },
            new NodeType { ID = 0x47, Name = "Spare Change" },
            new NodeType { ID = 0x48, Name = "Threaten" },
            new NodeType { ID = 0x49, Name = "Provoke" },
            new NodeType { ID = 0x4a, Name = "Entrust" },
            new NodeType { ID = 0x4b, Name = "Copycat" },
            new NodeType { ID = 0x4c, Name = "Doublecast" },
            new NodeType { ID = 0x4d, Name = "Bribe" },
            new NodeType { ID = 0x4e, Name = "Cure" },
            new NodeType { ID = 0x4f, Name = "Cura" },
            new NodeType { ID = 0x50, Name = "Curaga" },
            new NodeType { ID = 0x51, Name = "NulFrost" },
            new NodeType { ID = 0x52, Name = "NulBlaze" },
            new NodeType { ID = 0x53, Name = "NulShock" },
            new NodeType { ID = 0x54, Name = "NulTide" },
            new NodeType { ID = 0x55, Name = "Scan" },
            new NodeType { ID = 0x56, Name = "Esuna" },
            new NodeType { ID = 0x57, Name = "Life" },
            new NodeType { ID = 0x58, Name = "Full-Life" },
            new NodeType { ID = 0x59, Name = "Haste" },
            new NodeType { ID = 0x5a, Name = "Hastega" },
            new NodeType { ID = 0x5b, Name = "Slow" },
            new NodeType { ID = 0x5c, Name = "Slowga" },
            new NodeType { ID = 0x5d, Name = "Shell" },
            new NodeType { ID = 0x5e, Name = "Protect" },
            new NodeType { ID = 0x5f, Name = "Reflect" },
            new NodeType { ID = 0x60, Name = "Dispel" },
            new NodeType { ID = 0x61, Name = "Regen" },
            new NodeType { ID = 0x62, Name = "Holy" },
            new NodeType { ID = 0x63, Name = "Auto-Life" },
            new NodeType { ID = 0x64, Name = "Blizzard" },
            new NodeType { ID = 0x65, Name = "Fire" },
            new NodeType { ID = 0x66, Name = "Thunder" },
            new NodeType { ID = 0x67, Name = "Water" },
            new NodeType { ID = 0x68, Name = "Fira" },
            new NodeType { ID = 0x69, Name = "Blizzara" },
            new NodeType { ID = 0x6a, Name = "Thundara" },
            new NodeType { ID = 0x6b, Name = "Watera" },
            new NodeType { ID = 0x6c, Name = "Firaga" },
            new NodeType { ID = 0x6d, Name = "Blizzaga" },
            new NodeType { ID = 0x6e, Name = "Thundaga" },
            new NodeType { ID = 0x6f, Name = "Waterga" },
            new NodeType { ID = 0x70, Name = "Bio" },
            new NodeType { ID = 0x71, Name = "Demi" },
            new NodeType { ID = 0x72, Name = "Death" },
            new NodeType { ID = 0x73, Name = "Drain" },
            new NodeType { ID = 0x74, Name = "Osmose" },
            new NodeType { ID = 0x75, Name = "Flare" },
            new NodeType { ID = 0x76, Name = "Ultima" },
            new NodeType { ID = 0x77, Name = "Pilfer Gil" },
            new NodeType { ID = 0x78, Name = "Full Break" },
            new NodeType { ID = 0x79, Name = "Extract Power" },
            new NodeType { ID = 0x7a, Name = "Extract Mana" },
            new NodeType { ID = 0x7b, Name = "Extract Speed" },
            new NodeType { ID = 0x7c, Name = "Extract Ability" },
            new NodeType { ID = 0x7d, Name = "Nab Gil" },
            new NodeType { ID = 0x7e, Name = "Quick Pockets" },
        };

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            int empty = 0;
            int str   = 0;
            int def   = 0;
            int mgc   = 0;
            int mgd   = 0;
            int agi   = 0;
            int lck   = 0;
            int eva   = 0;
            int acc   = 0;
            for (int i = 0; i < 860; ++i)
            {
                var node = SphereGrid.ReadNode(i);
                // if (noAssign.Select(o => o.ID).Contains(node.NodeType))
                //     continue;

                // node.ActivatedBy = 127;
                if (node.ActivatedBy != 127)
                    SphereGrid.SetNodeActivation(i, 127);
                int nodeType;
                switch (node.NodeType)
                {
                    case 0x00: //lock spheres
                    case 0x27:
                    case 0x28:
                    case 0x29:
                        SphereGrid.SetNodeType(i, 0x01);
                        break;
                    case 0x02: //strength
                    case 0x03:
                    case 0x04:
                        SphereGrid.SetNodeType(i, 0x05);
                        break;
                    case 0x06: //defense
                    case 0x07:
                    case 0x08:
                        SphereGrid.SetNodeType(i, 0x09);
                        break;
                    case 0x0a: //Magic
                    case 0x0b:
                    case 0x0c:
                        SphereGrid.SetNodeType(i, 0x0d);
                        break;
                    case 0x0e: //Magic Defense
                    case 0x0f:
                    case 0x10:
                        SphereGrid.SetNodeType(i, 0x11);
                        break;
                    case 0x12: //Agility
                    case 0x13:
                    case 0x14:
                        SphereGrid.SetNodeType(i, 0x15);
                        break;
                    case 0x16: //luck
                    case 0x17:
                    case 0x18:
                        SphereGrid.SetNodeType(i, 0x19);
                        break;
                    case 0x1a: //evasion
                    case 0x1b:
                    case 0x1c:
                        SphereGrid.SetNodeType(i, 0x1d);
                        break;
                    case 0x1e: //Accuracy
                    case 0x1f:
                    case 0x20:
                        SphereGrid.SetNodeType(i, 0x21);
                        break;
                    case 0x22: //HP
                        SphereGrid.SetNodeType(i, 0x23);
                        break;
                    case 0x25: //MP
                    case 0x26:
                        SphereGrid.SetNodeType(i, 0x24);
                        break;
                }
            }
        }

        private void ButtonCreateHpNodes_OnClick(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 860; ++i)
            {
                var node = SphereGrid.ReadNode(i);
                if (node.NodeType == 0x22)//blank
                    SphereGrid.SetNodeType(i, 0x23);
            }
        }
        private void ButtonGetStats_OnClick(object sender, RoutedEventArgs e)
        {
            int empty   = 0;
            int str     = 0;
            int def     = 0;
            int mgc     = 0;
            int mgd     = 0;
            int agi     = 0;
            int lck     = 0;
            int eva     = 0;
            int acc     = 0;
            int hp      = 0;
            int mp      = 0;
            int ability = 0;
            int other   = 0;
            for (int i = 0; i < 860; ++i)
            {
                var node = SphereGrid.ReadNode(i);
                switch (node.NodeType)
                {
                    case 0x01:
                    case 0x00: //lock spheres
                    case 0x27:
                    case 0x28:
                    case 0x29:
                        empty++;
                        break;
                    case 0x05:
                        str++;
                        break;
                    case 0x09:
                        def++;
                        break;
                    case 0x0d:
                        mgc++;
                        break;
                    case 0x11:
                        mgd++;
                        break;
                    case 0x15:
                        agi++;
                        break;
                    case 0x19:
                        lck++;
                        break;
                    case 0x1d:
                        eva++;
                        break;
                    case 0x21:
                        acc++;
                        break;
                    case 0x23:
                        hp++;
                        break;
                    case 0x24:
                        mp++;
                        break;
                    case 0x2a:
                    case 0x2b:
                    case 0x2c:
                    case 0x2d:
                    case 0x2e:
                    case 0x2f:
                    case 0x30:
                    case 0x31:
                    case 0x32:
                    case 0x33:
                    case 0x34:
                    case 0x35:
                    case 0x36:
                    case 0x37:
                    case 0x38:
                    case 0x39:
                    case 0x3a:
                    case 0x3b:
                    case 0x3c:
                    case 0x3d:
                    case 0x3e:
                    case 0x3f:
                    case 0x40:
                    case 0x41:
                    case 0x42:
                    case 0x43:
                    case 0x44:
                    case 0x45:
                    case 0x46:
                    case 0x47:
                    case 0x48:
                    case 0x49:
                    case 0x4a:
                    case 0x4b:
                    case 0x4c:
                    case 0x4d:
                    case 0x4e:
                    case 0x4f:
                    case 0x50:
                    case 0x51:
                    case 0x52:
                    case 0x53:
                    case 0x54:
                    case 0x55:
                    case 0x56:
                    case 0x57:
                    case 0x58:
                    case 0x59:
                    case 0x5a:
                    case 0x5b:
                    case 0x5c:
                    case 0x5d:
                    case 0x5e:
                    case 0x5f:
                    case 0x60:
                    case 0x61:
                    case 0x62:
                    case 0x63:
                    case 0x64:
                    case 0x65:
                    case 0x66:
                    case 0x67:
                    case 0x68:
                    case 0x69:
                    case 0x6a:
                    case 0x6b:
                    case 0x6c:
                    case 0x6d:
                    case 0x6e:
                    case 0x6f:
                    case 0x70:
                    case 0x71:
                    case 0x72:
                    case 0x73:
                    case 0x74:
                    case 0x75:
                    case 0x76:
                    case 0x77:
                    case 0x78:
                    case 0x79:
                    case 0x7a:
                    case 0x7b:
                    case 0x7c:
                    case 0x7d:
                    case 0x7e:
                        ability++;
                        break;
                    default:
                        other++;
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append($"empty:{empty}\n");
            sb.Append($"str:{str} = str + {str      * 4}\n");
            sb.Append($"def:{def} = def + {def      * 4}\n");
            sb.Append($"mgc:{mgc} = magic + {mgc    * 4}\n");
            sb.Append($"mgd:{mgd} = mgd + {mgd      * 4}\n");
            sb.Append($"agi:{agi} = agility + {agi  * 4}\n");
            sb.Append($"lck:{lck} = luck + {lck     * 4}\n");
            sb.Append($"eva:{eva} = evasion + {eva  * 4}\n");
            sb.Append($"acc:{acc} = accuracy + {acc * 4}\n");
            sb.Append($"hp:{hp} = hp + {hp          * 300}\n");
            sb.Append($"hp:{mp} = hp + {mp          * 40}\n");
            sb.Append($"ability:{ability}\n");
            sb.Append($"other:{other}\n");
            var total = empty
                    + str
                    + def
                    + mgc
                    + mgd
                    + agi
                    + lck
                    + eva
                    + acc
                    + hp
                    + mp
                    + ability
                    + other;
            sb.Append($"Total: {total}");
            MessageBox.Show(sb.ToString());
        }
    }
}