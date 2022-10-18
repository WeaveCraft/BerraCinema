Projekt 1: Berras Bio //Utveckling av webbapplikationer Campus Nyköpin

Inlämning senast 2021-05-08 23:59
Inledning
Bakgrund
Ni ska bygga en webbapplikation med ASP.NET Razor Pages som kan boka biobiljetter.
Uppgiften ska utföras i grupper om två personer. Ni väljer själva samarbetspartner. De som vill kan utföra
uppgiften enskilt. Använd Git för versionshantering.

Vad ska du leverera?
En webbapplikation för bokning av biobiljetter.

Er projektuppgift

Vad ska ni göra?
För G
Berras Bio är en liten biograf som vill ha ett webbaserat bokningssystem. En besökare ska kunna se en lista
på vilka filmer som går idag. För varje film ska det framgå vad filmen heter, när den börjar och hur många
platser det är kvar i salongen.
Man ska på något sätt kunna välja en visning och antal biljetter man vill ha. När man valt klart ska en
bokningsbekräftelse visas.
Fullbokade filmer ska finnas kvar i listan, men ha ett annat utseende. Använd en annan CSS-klass.
Berras Bio är liten och nischad. De visar samma filmer varje dag och har bara en salong med 50 platser.
Tips: skriv kod som lägger in startdata i databasen, så går det lätt att återställa databasen till ursprungsskick.
Koden kan bestå av C#-kod eller SQL.

För VG
Berras skaffar en till salong med 100 platser. Nu måste gränssnittet uppdateras så att besökaren även ser
vilken salong filmen visas i.
Det ska gå att sortera visningarna antingen fallande på tid eller fallande på antal platser kvar. En användare
ska bara kunna boka 1–12 biljetter åt gången. Använd validering i både frontend och backend.
Extra utmaning
När man bokar biljetter skulle man kunna välja plats också. Se hur SF Bio låter besökaren klicka på stolar för
att välja platser, och gör något liknande.

Modellera
Börja med att bestämma hur datamodellen skall se ut. Vilka entiteter behöver finnas? Vilka relationer har de
till varandra? Bestäm er för om ni vill bygga databasen först eller entiteter först – båda arbetssätten
accepteras. (Dock är det sannolikt enklast att jobba enligt Code First)
Arkitektur
Bestäm sedan vilka sidor du ska ha. Det är helt tillåtet att diskutera hur du organiserar programmet med
klasskamrater, men inte att kopiera någon annans upplägg rakt av.

Inlämning och redovisning
Inlämning av uppgiften görs i Moodle senast 2021-05-08 klockan 23:59. Packa alla dokument i en ZIP-fil.
Döp filen enligt <ditt namn>BerrasBio<versionsnummer>.zip. Kom ihåg att köra en Clean solution innan ni
zippar och lämnar in.
Redovisning
Redovisa laborationen för läraren (och klassen) med Visual Studio och en lokal webbserver.
Bedömning och återkoppling
  
Betygskriterier
För Godkänt krävs
• Applikationen använder ASP.NET Core Razor Pages och Entity Framework (senaste version av allt)
• Applikationen visas korrekt i två av de stora webbläsarna
• En besökare kan se vilka filmer som visas och hur många platser det finns kvar
• En besökare ska kunna boka biljetter till en visning och få se en bekräftelse på bokningen
• Applikationen är städad: Index.cshtml är borta eller utbytt, Privacy-sidan är borta, Huvudmenyn är
städad.
  
För Väl Godkänt krävs
• Biografen har två salonger
• Det ska framgå av en visning i vilken salong den är
• Visningarna kan sorteras på visningstid och platser kvar
• Besökare ska bara kunna boka mellan 1 och 12 biljetter åt gången
• Priset för en biljett varierar med
o Film
o Föreställning (dvs tid)

Projekt 1 – Berras Bio 2022-04-24 Claes Engelin
• Det skall tydligt framgå vad biljetterna kostar per styck och vad priset för hela beställningen blir.
För VG krävs dessutom
• Inlämning görs före deadline
• Applikationen fungerar korrekt på första försöket i lärarens dator.
Återkoppling
Ni kommer att få återkoppling på uppgiften i LearnPoint, inom två veckor efter inlämning.
Återkoppling kommer även att lämnas i samband med gruppmöten samt under lärarledda
handledningstimmar.

![Screenshot 2022-10-13 220444](https://user-images.githubusercontent.com/90194213/195698629-efceb450-c981-4b5f-9536-7027b5fdf0c9.png)
![Screenshot 2022-10-13 220456](https://user-images.githubusercontent.com/90194213/195698646-c5677248-b829-4449-be2d-f6d0733e7d20.png)
![Screenshot 2022-10-13 220507](https://user-images.githubusercontent.com/90194213/195698658-f8ae3f40-d633-45d8-813b-6059f8eab0e3.png)
![Screenshot 2022-10-13 220522](https://user-images.githubusercontent.com/90194213/195698662-67cd073c-cc26-4b7e-8c82-1cf830b9a65c.png)
![Screenshot 2022-10-13 220542](https://user-images.githubusercontent.com/90194213/195698667-43f6d47a-32ef-4ab1-acc0-df6d571a8d21.png)
![Screenshot 2022-10-13 220556](https://user-images.githubusercontent.com/90194213/195698672-9da85deb-bdb0-42b0-9051-6f5c8a23d5b4.png)
![Screenshot 2022-10-13 220605](https://user-images.githubusercontent.com/90194213/195698686-73965885-8e03-4722-87a0-701da6cf471c.png)
![Screenshot 2022-10-13 220314](https://user-images.githubusercontent.com/90194213/195698693-3f1153d4-c29e-43ad-af27-7d5fdeda6cb4.png)

