# AI-Overhaul-Patcher
Un patcher synthesis pour AI Overhaul SE https://www.nexusmods.com/skyrimspecialedition/mods/21654
- Transfert les packages d'AIO, conserve les packages ajoutés par les mods chargés ultérieurement, qui n'ont pas été supprimés par USEEP ou AIO.
- Transfet les listes de packages d'observation et de combat d'AIO
- Ajoute les factions ajoutées par AIO à la dernière série de factions gagnantes.
- Transférer le statut maximum Essentiel/Protégé présent dans les plugins AIO ou chargés ultérieurement.
- Transférer le niveau de confiance minimum présent dans AIO ou dans les plugins chargés ultérieurement.
- Utilise les dernières tenues chargées qui n'ont pas été écrasées ou supprimées par AIO ou USEEP.

## Paramètres :
- Ignorer Identique Au Dernier Remplacement

		Default = false
	
		Lorsqu'activée, le patcher ne remplacera pas les PNJ qui sont déjà patchés.
- Ignorer Enregistrement Joueur

		Default = true

		Lorsqu'activée, le patcher ignorera l'enregistrement joueur (00000007).
- Maintenir Le Plus Haut Niveau De Protection

		Default = true
	
		Lorsqu'activée, les PNJS définis comme essentiels ou protégés par d'autres mods conserveront le niveau de protection le plus élevé.
		
## Versions à utiliser :
0.30.3 et 0.19.1
