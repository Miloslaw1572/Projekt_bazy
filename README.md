Wymagania systemowe:
-.NET SDK w wersji 8.0.x (Nie wyższej)
-Dostęp do bazy danych SQL
-Przeglądarka internetowa (Chrome, Firefox, Edge)

Instalacja:
-Pobierz plik bazadanych.sql
-Otwórz SQL Server Management Studio
-Z górnego menu wybierz File, potem Open i File, a następnie wskaż pobrany plik bazadanych.sql
-Gdy skrypt otworzy się w oknie edytora, upewnij się, że jesteś połączony z właściwym serwerem i kliknij przycisk Połącz
-SQL Server wykona wszystkie instrukcje po kolei: stworzy tabele i uzupełni je danymi. Po odświeżeniu listy baz danych po lewej stronie,  baza powinna być gotowa do użycia
-Pobierz pliki projektu na swój dysk lub sklonuj repozytorium
-Uruchom bazę danych i wykonaj migracje, jeśli są wymagane
-Zmień bazę danych w pliku appsettings.json w folderze Proj_bazy w linijce:  "DefaultConnection": "Server=DESKTOP-KQCRTQF\\SQLEXPRESS;Database=HotelReservationDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;" z "DESKTOP-KQCRTQF\\SQLEXPRESS" na twoją, której używasz, najlepiej wpisz localhost\\(Nazwa bazy np. SQLEXPRESS)
-Otwórz folder projektu w terminalu
-Wpisz dotnet run
-W przeglądarce wpisz adres który ukazał się w konsoli, przykładowy adres to http://localhost:5291, u ciebie będzie pewnie http://localhost://xxxx


Testowi użytkownicy:
-ADMIN: email: miloslaw12345@gmail.com hasło: milosz123
-UŻYTKOWNIK email: mluk@gmail.com hasło: Milosz123!

Opis działania:
Jest to aplikacja do rezerwowania pokoi w hotelu, po zarejestrowaniu i zalogowaniu na pasku górnym pokażą się 2 opcje, Zarezerwuj oraz Moje Rezerwacje, po wciśnięciu Rezerwuj można zarezerwować pokój, gdy się to zrobi można zobaczyć swoje rezerwacje w zakładce Moje Rezerwacje, administrator widzi 2 dodatkowe zakładki, Dodaj Pokój i Zarządzaj Pokojami, może tam dodać pokój, wybrać numer i typ, oraz zarządzać pokojami (podglądać jakie są).
