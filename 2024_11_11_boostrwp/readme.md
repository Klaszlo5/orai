# HTML FORMOK

## Jelolo:
` <label for=""></label>`: Cimke a felhasznalonak itt irjuk le mit szeretnenek elkerni. A for az adott input mezo id ertekehez koti az elemet.
## Beviteli mezok
`<input type="text">`: Szoveget lehet bevini vele, egysor.\
`<input type="password">`: Jelszomezo\
`<input type="checkbox">`: A value ertekeben megadott tartalommal lehet csak dolgozni. A checkbox a jelolo gomb, barmennyi jelolheto belole.\
`<input type="radio">`: Ez a valaszto gomb. Ha egy adott ertek halmazbol csak egyet lehet valasztani akkor hasznaljuk ilyenkor a `name` tulajdonsaganak azonsonak kell lenie mindegyiknek.\
`<input type="file">`: Fajl valaszto.\
`<input type="email">`: Szerepe az adatok elkuldesekor mutatkozik meg a formailag hibas email cim eseten nem enged tovabblepni. (Egeszen addig mukodik mig a form esemenyeit nem valtoztatjuk meg utana mar nem.)\
`<input type="number">`: Szam ertekeket lehet vele bekerni fontos hogy a hatterben at konvertaljuk azert szamma a bevitt erteket. \
`<input type="range">`: Egy csuszka amiben egy adott ertek tartomanybol lehet erteket valasztani a kezdo- es a vegertekek be allithatoak valamint a lepes szam is benne.\
`<input type="date">`: Idopont beviteli mezo. Formazasa a bongeszo regionalis es nyelvi beallitasatol fugg.\
`<input type="checkbox">`: Színválasztó\
`<textarea></textarea>`: Tobbsoros szoveg beviteli mezo\
`<select></select>`: Valaszto elem: a valasztasokat az `option` paros tag-ek koze kell irni\
`<input type="reset">`: Torli a form elemek tartalmat\
`<input type="submit">`: Elkuldi a formot\
`<input type="button">`: Sajat mukodessel elathato gomb

## HTML Esemenyek
| Tulajdonsag | Az esemeny bekovetkezese|
| ------------ | --------------------- |
| onblur | az elem elvesziti a fokuszt |
| onchange | a mezo tartalma megvaltozik es elvesziti a fokuszt | 
| onclick | egerkattintas az objektumra (Barmilyen HTML tag az objektumnak minosul)|
| ondbclick | dupla-kattintas az objektumra |
| onerror | egy lap vagy egy kep betoltesekor hiba keletkezik |
| onfocus | egy elem megkapja a focust |
| onkeydown | egy billentyut lenyomunk | 
| onkeyup | egy billentyut elengedtek | 
| onload | egy oldal vagy egy kep letoltese vegetert |
| onmousedown | az egerdomb lenyomasa |
| onmousemove |  az eger mozgasa |
| onmouseup | az egergombot felengedik |
| onmouseout | az eger elhagyja az elemet | 
| onmouseover | az eger egy elem fele kerul |
| onresize | az ablak atmeretezese |
| onselect | a szoveg ki lett jelolve |
| onunload | az oldal elhagyasa, pl.: ablak bezárás | 
| onsubmit | az urlap elkuldes |
| DOMContentLoaded | Az oldal mar betoltodott, de a kepek es mas kulso fajlok meg nem |

## Esemenyek csoportositasa
1. Elemi esemenyek: Barmilyen HTML tag-re lefutnak
2. input-okra futo esemenyek: Valamilyen input esemenyre reagalnak
3. Window esemenyek: A bongeszo ablakhoz tartozo esemenyek 

## Specialis eleres
Vannak esemenyek amiknek a megfelelo mukodesukhoz esemeny kezelok kellenek. pl.: onkeyup, onkeydown, DOMContentLoaded, onload, onresize