using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIOverhaulPatcher.Settings
{
    class Settings
    {
        public bool IgnorerIdentiqueAuDernierRemplacement { get; set; } = false;
        public bool IgnorerEnregistrementJoueur { get; set; } = true;
        public bool MaintenirLePlusHautNiveauDeProtection { get; set; } = true;
    }
}
