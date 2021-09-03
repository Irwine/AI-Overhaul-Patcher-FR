# AI-Overhaul-Patcher
Un patcher synthesis AI Overhaul SE https://www.nexusmods.com/skyrimspecialedition/mods/21654
- Transfert les packages de AIO, conserve les packages ajoutés par les mods chargés ultérieurement et qui n'ont pas été supprimés par USEEP ou AIO.
- Transfet les listes de paquets d'observation et de combat d'AIO
- Ajoute les factions ajoutées par AIO à la dernière série de factions gagnantes.
- Transférer le statut maximum Essentiel/Protégé présent dans les plugins AIO ou chargés ultérieurement.
- Transférer le niveau de confiance minimum présent dans AIO ou dans les plugins chargés ultérieurement.
- Utilise les dernières tenues chargées qui n'ont pas été écrasées ou supprimées par AIO ou USEEP.

## Paramètres :
- Ignorer identique au dernier remplacement

		Défaut = false
	
		Lorsqu'activée, le patcheur ne remplacera pas les PNJ qui sont déjà patchés.
- Ignorer enregistrement joueur

		Défaut = true

		Lorsqu'activée, le patcheur ignorera l'enregistrement joueur (00000007).
- Maintenir le plus haut niveau de protection

		Défaut = true
	
		Lorsqu'activée, les PNJS définis comme essentiels ou protégés par d'autres mods conserveront le niveau de protection le plus élevé.
