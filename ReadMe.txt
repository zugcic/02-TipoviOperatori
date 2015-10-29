TipoviOperatori
===============

Main
----
Unutar klase smije biti samo jedan Main metoda (bez obzira što se metode u C# 
mogu preopterećivati).

Unutar izvedbenog (.EXE) modula može biti više Main metoda u različitim 
klasama, ali tada prevoditelju treba navesti koja klasa će biti "početna", tj. 
od koje Main metode treba program pokrenuti.

ZADATAK 1: Iz klase Program treba ukloniti suvišne metode Main
ZADATAK 2: U postavkama prevoditelja promijeniti ulaznu metodu tako da
           se pokreće Class1.Main()


Dokumentacijski komentari
-------------------------
Primjer dokumentacijskih komentara - opis funkcije Kvadrat

ZADATAK: Za funkciju DuljinaDvijeRiječi napisati dokumentacijske komentare
         i provjeriti pojavljuju li se opis u oblačiću funkcije.


Imenici
-------
Ilustracija kako se istoimeni objekti iz različitih imenika mogu dohvaćati.

ZADATAK: Modificirati kod u Program.Main tako da može koristiti obje klase
         MojaKlasa iz imenika PrviImenik i imenika DrugiImenik


Promjena postavki imenika
-------------------------
Primjer kako se promijeni podrazumijevani imenik nakon kreiranja projekta
u svojstvima projekta (Properties)

ZADATAK: 1. Kreirati projekt za konzolnu aplikaciju PostavkeImenika. 
         2. U postavkama projekta promijeniti podrazumijevani imenik u 
		    Vsite.CSharp 
		 3. Ispraviti imenik u automatski generiranom kodu
		 3. Definirati dvije nove klase: MojaKlasa1 i MojaKlasa2 te
		    instancirati objekte tih klasa u metodi Program.Main


Identifikatori
--------------
Primjer kako se neke ključne i rezervirane riječi mogu koristiti za 
identifikatore.

ZADATAK 1: U metodu Program.Main dodati varijablu s imenom "string"
           Provjeriti javlja li prevoditelj pogrešku za ime varijable. 
		   Ako javlja, napraviti potrebnu promjenu da se ime može 
		   koristiti.

ZADATAK 2: U istu metodu dodati varijablu s imenom "get". Ponoviti
           postupke iz ZADATKA 1.

ZADATAK 3: U istu metodu dodati varijablu s imenom "Main". Ponoviti
           postupke iz ZADATKA 1.

ZADATAK 4: U istu metodu dodati varijablu sa hrvatskim dijakritičkim
           znakovima (npr. "četrdesetšest"). Ponoviti postupke iz
		   ZADATKA 1.

ZADATAK 5: U prethodnoj varijabli slovo 'č' zamijeniti njegovim Unicode
           kodom \u0161 i provjeriti prihvaća li prevoditelj takav
		   oblik imena.

ZADATAK 6: U istu metodu dodati varijablu "бројШест" te provjeriti 
           prihvaća li prevoditelj to ime.


UgradjeniTipoviIL
-----------------
Primjer kojim se može pokazati da svi ugradjeni tipovi osim decimal imaju 
izravne ekvivalente u IL-u.

ZADATAK: Prevesti program te generirani kod pogledati ILDASM-om (IL disassemblerom).


UgradjeniTipoviInicijalizacija
------------------------------
Primjer koji pokazuje kako se ugradjeni tipovi mogu inicijalizirati samo 
operatorom pridruživanja ili podrazumijevanim konstruktorom.

U Program.Main treba:

ZADATAK 1: Inicijalizirati varijablu tipa int pozivom podrazumijevanog 
           (praznog) konstruktora te ispisati vrijednost varijable.

ZADATAK 2: Inicijalizirati drugu varijablu tipa int pozivom 
           konstruktora koji kao argument prima broj 4. 
		   Provjeriti dozvoljava li to prevoditelj.

ZADATAK 3: Inicijalizirati varijablu tipa string pozivom podrazumijevanog
           konstruktora. Provjeriti dozvoljava li to prevoditelj.

ZADATAK 4: Napisati kod koji inicijalizira novu varijablu tipa string 
           na vrijednost "string 1".


Nulabilni
---------
Primjer korištenja i inicijalizacije nulabilnih tipova.

ZADATAK 1: Dodati u Program.Main naredbu kojom se vrijednost nulabilnog
           tipa double postavlja na null referencu te ispisati nakon toga
		   sadržaj varijable.

ZADATAK 2: Ponoviti to isto za (ne-nulabilnu) varijablu tipa double.

ZADATAK 3: Definirati nulabilnu varijablu korištenjem generičkog tipa
           Nullable<T> te ponoviti postupke iz ZADATKA 1.


Deklaracija var
---------------
Varijabli koja je deklarirana ključnom riječi var će prevoditelj automatski
odrediti tip.

U metodi Program.Main:

ZADATAK 1: Dodati varijablu "i0" tipa var i inicijalizirati ju nekim cijelim 
           brojem.
           Dodati varijablu "d0" tipa var i inicijalizirati ju nekim decimalnim 
		   brojem.
		   Dodati naredbu:
		   i0 = d0;
		   te provjeriti prihvaća li prevoditelj tu naredbu.

ZADATAK 2: Dodati varijablu "i1" tipa int i inicijalizirati ju istim cijelim 
           brojem kao varijablu i0.
		   Dodati varijablu "d1" tipa double i inicijalizirati ju istim cijelim 
           brojem kao varijablu d0.
		   Prevesti kod i usporediti kod naredbi za inicijalizacije varijabli
		   i0 i d0, odnosno i1 i d1.

ZADATAK 3: Deklarirati varijablu "s" tipa var i inicijalizirati ju pozivom
           konstruktora strukture S definirane u istoj datoteci.
		   Napisati naredbe za postavljanje vrijednosti polja a i b
		   u toj strukturi na proizvoljne vrijednosti i provjeriti
		   da li se kod može prevesti.
         

PridruživanjeBazniIzvedeni
--------------------------
Ilustracija dozvoljenih pridruživanja između baznog i izvedenog tipa.

ZADATAK 1: Dodajte u metodu Program.Main pozive svih mogućih metoda nad
           instancama objekata osoba i osobaStudent.

ZADATAK 2: Deklarirajte objekt tipa Student i pokušajte ga instancirati 
           pozivom konstruktora tipa Osoba. Provjerite što prevoditelj 
		   javlja. 
		  

Pretvorba
---------
Ilustracija kada se smije koristiti operator cast.

ZADATAK 1: Provjeriti za koja pridruživanja u metodi Program.Main treba 
           staviti operator pretvorbe da prevoditelj ne bi prijavio pogrešku.

ZADATAK 2: Za svaki objekt dodati pozive svih mogućih metoda.


OperatorIs
----------
Operator is provjerava je li objekt s lijeve strane kompatibilan s tipom na 
desnoj strani (je li instanca tog tipa ili nekog izvedenog tipa).

ZADATAK: U metodu Program.Main dodajte provjere za svaki objekt (janko i
         osoba) jesu li tipa Osoba i tipa Student.


OperatorAs
----------
Operator as omogućava sigurnu pretvorbu: ako se pretvorba ne može provesti
vrijednost objekta će biti null.

ZADATAK: Pokrenuti metodu Program.Main i provjeriti što će se ispisati te
         koja će iznimka biti bačena.


OperatorSizeof
--------------
Operator sizeof vraća veličinu memorijskog prostora kojeg tip zauzima. Moguće 
je tražiti samo za vrijednosne tipove!

ZADATAK 1: Napisati naredbe kojima će se ispisati duljina podatka tipa decimal 
           i podatka tipa double.

ZADATAK 2: Napisati naredbe kojima će se ispisati duljina podatka tipa 
           MojaStruktura (koja ima samo dva polja) i podatka tipa 
		   MojaSloženaStruktura (koja uz dva polja ima i metodu).
           Usporediti rezultate ispisa.

ZADATAK 3: Napisati naredbu kojom će se ispisati duljina podatka tipa 
           MojaKlasa.


OperatorTypeof
--------------
Operator typeof vraća kao rezultat objekt tipa Type koji sadrži sve informacije
o dotičnom tipu.
