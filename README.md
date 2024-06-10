# Sportboot Application

Dieses Projekt ist eine Windows Forms Anwendung in C#, die es ermöglicht, Sportboote zu verwalten. Das Programm ermöglicht das Hinzufügen von Sportbooten, das Anzeigen von Bootsinformationen, sowie die Berechnung, ob für ein Boot ein Führerschein benötigt wird und das Gewicht des Bootes.

## Inhaltsverzeichnis
- [Installation](#installation)
- [Verwendung](#verwendung)
- [Klassenbeschreibung](#klassenbeschreibung)
  - [Sportboot](#sportboot)
  - [Form1](#form1)

## Installation

1. Klonen Sie das Repository oder laden Sie die Dateien herunter.
2. Öffnen Sie das Projekt in Visual Studio.
3. Stellen Sie sicher, dass alle erforderlichen NuGet-Pakete installiert sind.
4. Bauen Sie das Projekt, um sicherzustellen, dass keine Fehler vorhanden sind.
5. Starten Sie die Anwendung über Visual Studio.

## Verwendung

1. Beim Start der Anwendung werden vier zufällige Sportboote erstellt und angezeigt.
2. Um ein neues Sportboot hinzuzufügen:
   - Geben Sie eine 3-stellige Bootsnummer, die Länge und die Motorleistung in die entsprechenden Textfelder ein.
   - Klicken Sie auf den Button "Eingabe", um das Boot hinzuzufügen.
   - Die Bootsliste wird aktualisiert und angezeigt.
3. Um zu überprüfen, ob ein Führerschein für das erste Boot in der Liste erforderlich ist:
   - Klicken Sie auf den Button "Führerschein prüfen".
   - Das Ergebnis wird im entsprechenden Label angezeigt.
4. Um das Gewicht des ersten Bootes in der Liste anzuzeigen:
   - Klicken Sie auf den Button "Gewicht anzeigen".
   - Das Gewicht wird im entsprechenden Label angezeigt.

## Klassenbeschreibung

### Sportboot

Die `Sportboot` Klasse repräsentiert ein Sportboot mit den folgenden Eigenschaften:

- **Bootsnummer** (int): Eine eindeutige 3-stellige Identifikationsnummer des Bootes.
- **Länge** (int): Die Länge des Bootes in Metern.
- **Motorleistung** (int): Die Motorleistung des Bootes in kW.
- **Gewicht** (double, öffentlich): Das berechnete Gewicht des Bootes.
- **FuehrerscheinPlicht** (bool, öffentlich): Gibt an, ob für das Boot ein Führerschein erforderlich ist.

**Methoden:**

- **Sportboot()**: Konstruktor, der ein Boot mit Standardwerten initialisiert.
- **Sportboot(int, int, int)**: Konstruktor, der ein Boot mit angegebenen Werten initialisiert.
- **ToString()**: Überschreibt die Standardmethode, um die Bootsinformationen als Zeichenkette zurückzugeben.

### Form1

Die `Form1` Klasse ist das Hauptformular der Anwendung und bietet die Benutzeroberfläche zur Verwaltung der Sportboote.

**Eigenschaften:**

- **listeSportboote** (List<Sportboot>): Eine Liste, die alle Sportboote enthält.
- **random** (Random): Ein Zufallszahlengenerator zur Erstellung von Zufallswerten für die Boote.

**Methoden:**

- **Form1()**: Konstruktor, der die Benutzeroberfläche initialisiert und vier zufällige Sportboote erstellt.
- **btn_eingabe_Click(object, EventArgs)**: Event-Handler, der ausgeführt wird, wenn der Eingabe-Button geklickt wird. Fügt ein neues Sportboot zur Liste hinzu.
- **btn_fuehrerschein_Click(object, EventArgs)**: Event-Handler, der ausgeführt wird, wenn der Führerschein-Button geklickt wird. Überprüft, ob ein Führerschein für das erste Boot erforderlich ist.
- **btn_gewicht_Click(object, EventArgs)**: Event-Handler, der ausgeführt wird, wenn der Gewicht-Button geklickt wird. Zeigt das Gewicht des ersten Bootes an.
- **Ausgabe()**: Aktualisiert die Textbox, um die Liste der Sportboote anzuzeigen.
