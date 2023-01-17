# HexViewer

Acest cod este un vizualizator hexazecimal simplu. Acesta ia ca argumente de la linia de comandă un nume de fișier și numărul de octeți pe linie pe care dorește să îi afișeze. Deschide fișierul specificat, îl citește în bucăți de numărul specificat de octeți pe linie și apoi scrie fiecare octet în format hexazecimal în consolă. Dacă există o eroare la citirea fișierului, va afișa un mesaj de eroare. Codul foloseste clasele File si FileStream din namespace-ul System.IO si clasa Console din namespace-ul System pentru a realiza acest lucru.

1.Verifică dacă numărul de argumente de la linia de comandă este mai mic de 
2.Dacă da, afișează un mesaj de utilizare și iese din program.
3.Salvează primul argument ca fiind numele fișierului și al doilea argument ca numărul de octeți pe linie.
4.Încearcă să deschidă fișierul folosind FileStream, cu opțiunile FileMode.Open și FileAccess.Read.
5.Declară o variabilă pentru a stoca numărul de octeți citit și un buffer de octeți cu dimensiunea specificată de numărul de octeți pe linie.
6.Folosind un ciclu, citește din fișier în buffer și pentru fiecare octet din buffer, scrie valoarea hexazecimală în consolă.
7.Dacă apare o excepție de tip IOException, afișează un mesaj de eroare.

Aceasta este o modalitate simplă de a citi și afișa conținutul unui fișier în format hexazecimal pe consolă.
