# Lab1_NET_JAVA
Zadaniem laboratorium było stworzenie programu rozwiązującego problem plecakowy metodą zachłanną, napisaniem testów jednostkowych do problemu oraz stworzenie prostego GUI

Główną klasą programu jest Problem zawiera ona parametry takie jak liczba przedmiotów wybrana przez użytkownika, seed do wyznaczania losowych wag i wartości oraz listę zawierającą wszystkie przedmioty. Główną funkcją klasy jest Solve przyjmuje ona pojemność plecaka podaną przez użytkownika, następnie za pomocą parametru ratio który jest stosunkiem wartości do wagi przedmiotu lista przedmiotów jest sortowana od największej wartości ratio do najmniejszej. Po posortowaniu funkcja przechodzi przez posortowaną listę przedmiotów i sprawdza czy plecak posiada jeszcze pojemność by włożyć przedmiot jeżeli ma dodaje jego wartość i wagę do zmiennych zsumowanych oraz ID do listy przedmiotów w plecaku, na końcu funkcja zwraca klasę result która posiada przeciążoną funkcję ToString zwracającą jakie przedmioty są w plecaku, jaka jest ich wspólna wartośc oraz waga.

Testami użytymi do testowania funkcji były: 
czy jest tworzona prawidłowa liczba przedmiotów, 
czy program zwróci zero gdy żaden przedmiot się nie zmieści, 
czy program zwraca poprawny wynik dla konkretnego przypadku, 
czy program prawidłowo zwróci jeden element gdy tylko on się mieści, 
czy program prawidło doda wszystkie elementy do plecaka przy dużej pojemności, 
czy program zwróci błąd gdy użytkownik poda 0 przedmiotów

Interfejs graficzny posiada trzy pola w które użytkownik może wpisać wartości takie jak liczbę przedmiotów, seed i pojemność, program w polu wynik zwróci które przedmioty zostały wsadzone, jaka jest ich wspólna waga oraz wartość, w polu wartości program wypisze wszystkie wygenerowane przedmioty dla problemu.
GUI posiada również prostą obsługę błędów gdy użytkownik spróbuje uruchomić program gdy pole jest puste, wartość jest napisem, wartości są ujemne lub równe 0 program w polu umieści teksty informujący użytkownika jaki jest błąd oraz zmieni kolor pola na czerwony, a sam program się nie uruchomi
