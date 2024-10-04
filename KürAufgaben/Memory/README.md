Hallo und herzlich willkommen zum Memory Spiel.

Ich habe den Ordner mit allen versuchen des Memory in unterordnern
des Memory Ornders gelegt.

Es ist wichtig zu beachten das die ersten zwei Memorys nicht so 
funktioniert hatben wie ich es wollte, deshalb habe ich diese wieder 
verworfen. 

Warscheindlich zu früh, denn nach erneutem betrachten, hätte ich
diese Probleme villeicht lösen können. Trozdem habe ich immer neu 
angefangen bis zum dritten Versuch bei dem ich das gefühl hatte ich
sei nahe dran, doch falsch gedacht. 

Als ich nach mehreren Stunden immer noch nicht korrekt Starten konnte,
so das die Logik stimmt, habe ich meinen ganzen Code einfach Mal 
chatgpt gab, der mir sehr sehr viel verbessert undumstrukturiert hatt.
Vor allem da meine Logik zum Spiel falsch oder einfach zu schweirig 
war.

Ich wollte die Logik des überprüfens ob der Player die richtigen 
oder gleichen emojis hat, so konstruieren, dass es die emojis mit
einander vergleicht. Dies habe ich aber ziemlich schlecht implementiert
und dies hat zu falschen konsolen outputs geführt.

ChatGPT hat dies anders gemacht, unten eine erklährung zur Logik: 
(habe ich nicht selber geschrieben)

Spielinitialisierung:

Ein Board-Objekt wird erstellt.
Die InitializeBoard-Methode wird aufgerufen:

Erstellt eine Liste aller benötigten Symbole (jedes Symbol zweimal).
Mischt diese Liste zufällig mit OrderBy(s => Guid.NewGuid()).
Verteilt die gemischten Symbole auf die Card-Objekte im cards-Array.

Hauptspielschleife:

Die Play-Methode der Game-Klasse enthält eine while-Schleife, die 
läuft, solange !board.AllPairsFound() true ist.


Einzelner Spielzug:
a. Anzeige des aktuellen Spielstands:

board.Display() wird aufgerufen, um das Spielfeld auszugeben.

b. Eingabe des Spielers:

TryMove-Methode wird aufgerufen.
Eine while-Schleife läuft, bis eine gültige Eingabe erfolgt.
Die Eingabe wird auf Format und Gültigkeit geprüft.

c. Aufdecken der Karten:

MakeMove-Methode wird mit den zwei gewählten Positionen aufgerufen.
board.RevealCard() wird für beide Positionen aufgerufen.
Das aktualisierte Spielfeld wird angezeigt.

d. Vergleich der Karten:

board.IsMatch() prüft, ob die Symbole der aufgedeckten Karten 
übereinstimmen.

e. Behandlung des Ergebnisses:

Bei einem Treffer:

"Treffer!" wird ausgegeben.
board.RemoveCards() entfernt die Karten vom Spielfeld (setzt sie auf 
aufgedeckt und entfernt).


Bei keinem Treffer:

"Leider kein Treffer." wird ausgegeben.
Das Programm pausiert für 2 Sekunden mit Thread.Sleep(2000).
board.HideCards() verdeckt die Karten wieder.



f. Zählen des Versuchs:

player.IncrementAttempts() erhöht den Zähler für die Spielversuche.


Spielende:

Wenn alle Paare gefunden sind (board.AllPairsFound() gibt true 
zurück), endet die Hauptschleife.

Eine Glückwunschnachricht wird ausgegeben, zusammen mit der Anzahl 
der benötigten Versuche.