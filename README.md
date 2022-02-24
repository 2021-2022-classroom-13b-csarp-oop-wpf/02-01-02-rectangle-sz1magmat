# 02-01-02
*Setter és osztályok külön fájlokba. Saját kivételek. Kivétel kezelés.*


Készítsen osztályt téglalap objektumok kezelésére. A téglalap létrehozásakor meg kell adni a két oldalát. A két oldal módosítható tulajdonság legyen (SideA, SideB). A téglalap osztályban a terület (Area) és a kerület (Perimeter) leolvasható tulajdonság legyen. Ha a téglalap adatait karakterlánccá alakítja, akkor felhasználóbarát módon jelenítse meg az oldalait, területét és kerületét. A ToString metódusban használjon két tizedes jegyes kerekítést. Máshol ne kerekítsen!
Példányosítson két téglalapot és a nagyobb területű téglalapnak jelenítse meg a kerületét!

[második rész]  
Biztosítsa, hogy negatív vagy nulla oldalú téglalapot ne lehessen létrehozni. Az oldalak módosításakor se lehessen negatív vagy nulla méretet megadni. Ilyen anomália keletkezésekor dobjon saját kivételt (RectangleSideIsNullOrZero)!  
Kivételkezeléssel biztosítsa, hogy a kivétel legyen elkapva, a kivétel üzenete az outputon legyen olvasható!
