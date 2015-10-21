TipoviOperatori
===============

PromjenaImenika
---------------

Primjer kako se promijeni podrazumijevani imenik nakon kreiranja projekta
u svojstvima projekta (Properties)

Ilustracija kako se istoimeni objekti iz razlièitih imenika mogu dohvaæati.


Dokumentacijski komentari
-------------------------
Primjer dokumentacijskih komentara - opis funkcije Kvadrat


Main
----
Unutar klase smije biti samo jedan Main metoda (bez obzira što se metode u C# 
mogu preoptereæivati).

Unutar izvedbenog (.EXE) modula može biti više Main metoda u razlièitim 
klasama, ali tada prevoditelju treba navesti koja klasa æe biti "poèetna", tj. 
od koje Main metode treba program pokrenuti.


Identifikatori
--------------
Primjer kako se neke kljuène i rezervirane rijeèi mogu koristiti za 
identifikatore.
- string je kljuèna rijeè (keyword);
- get je kontekstna kljuèna rijeè (contextual keyword), tj. ima posebno 
  znaèenje samo na odreðenim mjestima;
- Main je rezervirana rijeè (reserved word).


UgradjeniTipoviIL
-----------------
Primjer kojim se može pokazati da svi ugradjeni tipovi osim decimal imaju 
izravne ekvivalente u IL-u.
Izgenerirani kod treba pogledati s ILDASM (IL disassemblerom).


UgradjeniTipoviInicijalizacija
------------------------------
Primjer koji pokazuje kako se ugradjeni tipovi mogu inicijalizirati samo 
operatorom pridruživanja ili podrazumijevanim konstruktorom.


Nulabilni
---------

Primjer korištenja i inicijalizacije nulabilnih tipova.


Deklaracija var
---------------

Varijabli koja je deklarirana kljuènom rijeèi var æe prevoditelj automatski
odrediti tip.


OperatorIs
----------
Operator is provjerava je li objekt s lijeve strane kompatibilan s tipom na 
desnoj strani (je li instanca tog tipa ili nekog izvedenog tipa)


OperatorAs
----------
Operator as omoguæava sigurnu pretvorbu: ako se pretvorba ne može provesti
vrijednost objekta æe biti null. Kod operatora pretvorbe (cast) nepravilna
pretvorba æe baciti InvalidCastException.


OperatorSizeof
--------------
Operator sizeof vraæa velièinu memorijskog prostora kojeg tip zauzima. Moguæe 
je tražiti samo za vrijednosne tipove!


OperatorTypeof
--------------
Operator typeof vraæa kao rezultat objekt tipa Type koji sadrži sve informacije
o dotiènom tipu.
