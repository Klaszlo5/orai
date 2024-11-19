# Call Stack (Szinkron)

1. LIFO (Last In, First Out) alapon működik, azaz a legutoljára bekerült függvény az első, amit a rendszer kilépéskor eltávolít.
2. Amikor a JavaScript egy függvényt meghív, az bekerül a Call Stack-be, és amíg a függvény nem fut le teljesen, addig ott is marad.
3. Ha egy függvény egy másik függvényt hív meg, az új függvény is bekerül a verembe, és annak befejezése előtt a korábbi függvény nem fejeződhet be.
4. Amint egy függvény befejeződik, a Call Stackből kikerül, és a rendszer visszatér a következő függvényhíváshoz, ha van ilyen.

# Callback Queue (Aszinkron)
Def:  A Callback Queue vagy visszahivasi sor, egy sor, amelyben az aszinkron muveletek (pl. idozitok, AJAX hivasok) visszahivasai varakoznak, hogy lefussanak, amint a Call Stack üres.

1. Ha egy aszinkron muvelet veget er (pl.: lejar az idozito) a hozza tartozo callback fuggveny bekerul a Callback Queue-ba.
2. A JavaScript Event Loop-js folyamatosan elenorzi, hogy a Call Stack ures-e.
3. Amint a Call Stack ures az Event Loop kiveszi az elso elemet a Callback Queue-bol es berakja a Call Stack-be, hogy lefusson.

Kovetkeztetes: Az aszinkron muveletek sorra kerules tehat csak akkor tortenik meg, ha a Call Stack teljesen ures, igy biztositva, hogy a JavaScript szinkron es aszinkron reszei jol elkulonuljenek egymastol.  

# Event Loop
Feladata a szinkron es aszinkron folyamatok harmonikus mukodesenek megteremtese JS-ben.

1. Az Event Loop figyeli, hogy van-e valami a Call Stack-ben.
2. Ha a Call Stack ures, ellenorzi a Callback Queue-t
3. Ha van valami a Callback Queue-ban, akkor athelyezi a Call Stack-be, ahol az vegre hajtodik.

# Osszefoglalas:

1. A Call Stack kezeli a szinkron függvényhívásokat, amíg a Call Stackben futó függvények nincsenek befejezve, addig az új hívások nem kerülhetnek futtatásra.
2. A Callback Queue tárolja az aszinkron műveletek visszahívásait, amik majd a Call Stack üresedése után kerülhetnek végrehajtásra.
3. Az Event Loop figyeli a Call Stacket és a Callback Queue-t, és gondoskodik arról, hogy az aszinkron visszahívások a megfelelő időben kerüljenek lefuttatásra.

# setTimeout():
1. Ket parameteres fuggveny: 
    * az elso parameter: a futatni kivant fugveny (mindig arrow function)
2. Feladata a fuggvenyek kesleltetett lefutatasa.

# setInterval
Ket parameteres fuggveny: 


## Task
1. Kérje be a felhasználó nevét. 
2. Azonnal üdvözölje a felhasználót a konzolon a nevével együtt. 
3. 2 másodperc után kérdezze meg, hogy szeretne-e tovább menni a programban (igen/nem). 
4. Ha a válasz "igen", 4 másodperc után gratuláljon a döntéshez, és írja ki: "Nagyszerű választás!". 
5. Ha a válasz "nem", 3 másodperc után búcsúzzon el a felhasználótól: "Viszlát, [név]!". 
6. Bármelyik esetben egy végső üzenetet írjon ki 5 másodperc késleltetéssel: "A program véget ért." 