using System;
using System.Collections.Generic;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIOverhaulPatcher.Settings
{
    class Settings
    {
        [SettingName("Ignorer pnj identique au dernier override")]
        public bool IgnoreIdenticalToLastOverride { get; set; } = false;
        
        [SettingName("Ignorer l'enregistrement joueur")]
        public bool IgnorePlayerRecord { get; set; } = true;
        
        [SettingName("Maintenir le plus haut niveau de protection")]
        public bool MaintainHighestProtectionLevel { get; set; } = true;
    }
}
