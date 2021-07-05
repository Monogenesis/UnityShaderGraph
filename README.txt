
Projektname: Unity Shader Graph

Teammitglieder: Amadeus Zittel (203882)

Bedienung des Projekts:
	- Git klonen
		URL: https://github.com/Monogenesis/UnityShaderGraph.git
	- Verwendete Unity Version
		- 2021.1.5f1
		- Sollte allerdings mit jeder Unity Version, welche URP Kompatibel ist laufen
	- Main_Shader_Demonstration Scene auswaehlen

Besondere Leistungen:
	Lernmittel:
	- Grundlagenkenntnisse der Shadersprache Cg von Penny de Byl gelernt (https://www.udemy.com/course/unity-shaders/)
	- Grundlagen von Shadern (Udemy - Penny de Byl, Youtube: Freya Holmes)
	- Grundlagen Mathematik für Shader (Youtube: Freya Holmes)
	- Grundlagen Shader Graph (Unity Dokumentation, Youtube: Brackeys, Wilmer Lin GA School)
	
	Einfachere Shader:
		Hello World Shader:
			Ein einfacher Shader dem es den Nutzer ermöglicht die Farbe eines Materials anzupassen
		Dissolve Shader:
			Ein Shader der mittels eines "Simple Noise" und des Alpha Kanals einen "Auflösen" -  Effekt erzielt.
		Snow Shader:
			Dieser Shader färbt die geometrischen Oberflächen je nach ausgewählten Einfallswinkel mit weißer Farbe ein. Kern der Berechnung sind die "Normal" Vektoren der Oberfläche, welche mit dem Einfallswinkel verrechnet werden.
		
	Komplett selbst entwickelte Shader:
	Stretch Shader:
		Ein Shader der es ermöglicht eine Textur auf einer einfachen geometrischen Struktur anzubringen und sich
		nach der Skalierung des Objects anpasst die Textur gleichmäßig auf dem Object zu verteilen.
		Funktionsweise: Es muss für jede Orientierungsaxe ein Material mit der gewünschten Textur erstellt werden. Um
			das Material für die jeweilige Axe einzustellen muss ein Boolean Flag gesetzt werden.
			Diese Materialien werden dann auf den jeweiligen "faces" des gemoetrischen Objektes angebracht.
		Beispiel: Eine Seitenfläche entlang der X-Axe wird mit dem Material für die X-Axe angebracht, nun wenn sich die
			X-Komponente der Skalierung verändert, passt sich die Textur automatisch mit der Skalierung an.
	
	Shader mit Inspirationen:
	Interior Shader:
		Ein Shader der es ermöglicht durch eine zwei Dimensionale flache Oberfläche durch ein Fenster in einen Raum mit Perspektive hinein zu blicken.
		Es werden keine geometrischen Strukturen gerendert, lediglich eine Cubemap, welche die 6 Wände eines Raumes beinhaltet wird benötigt. 
		Dies sorgt für eine realistische Darstellung von Häusern welches in einer sehr performanten weise umgesetzt wird.
		Funktionsweise: https://www.proun-game.com/Oogst3D/CODING/InteriorMapping/InteriorMapping.pdf
		Beispiel: Shadermaterial mit der gewünschten Cubemap auf ein Quad anbringen. Je nach belieben in ein Fenster eines Hauses anbringen.
		Inspiration: Joost van Dongen, Mert Kirimgeri(https://www.youtube.com/watch?v=tXtu8Yzp7I0)
		Eigene Veränderungen: Wände zwischen den einzelnen Räumen mit einer Textur.

Herausforderungen:
	- Verstehen wie Shader ausgebaut sind
	- Shadersprachen kennenlernen (Cg, HLSL)
	- Vektormathematik für Shader lernen
	- Gute aktuelle Quellen finden
	- Umgang mit Unity Shader Graph erlernen
	- Umgang mit UV, Normal, Texture maps

Erfahrungen:
	- Cg wird von Unity nicht weiter unterstützted (Also URP und aufwärts)
	- Shader sind ein riesiges Fachgebiet
	- Shader geben dem Entwickler endlose Potenzial visuelle Anwendungen zu gestalten
	- Die Shader/ Shader Graph Lernkurve hat eine geringe Steigung


Verwendete Packages:
	- Universal Render Pipeline (URP)
	- ProBuilder
	- Visual Studio Code Editor

Verwendete Assets:
	- Suzanne Modell aus Blender
	- Cobblestone Textur von textures.com
	- Ausschließlich die Interior Cubemap von "TOZ Interior Shaders" Asset (Keine anderen Resourcen)