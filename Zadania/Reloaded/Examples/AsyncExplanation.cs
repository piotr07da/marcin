using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class AsyncExplanation
    {
        public async Task Test()
        {
            var operation = new SomeLongRunningOperation();

            // nic szczególnego - zwyczajne wywołanie zwyczajnej metody
            int numberA = operation.GetSomeIntSync();

            // tutaj wywołujemy metodę asynchroniczną, która zwraca obiekt typu Task<int> czyli obiekt reprezentujący zadanie, które w rezultacie da nam jakiegoś int'a.
            Task<int> taskWhichWillReturnNumber = operation.GetSomeIntAsync();

            // ten obiekt klasy Task<int> to jest takie coś dzięki czemu możemy awaitować (oczekiwać) na tego int'a.
            int numberB = await taskWhichWillReturnNumber;

            // powyższe linijki można zapisać bezpośrednio o tak:
            int numberC = await operation.GetSomeIntAsync();

            // Czyli podsumowując metoda GetSomeIntAsync zwraca obiekt reprezentujący zadanie, które w rezultacie da int'a,
            // a słowo kluczowe await oczekuje na skończenie zadania i wyłuskuje wynik czyli tego int'a.

            

            // To o czym Ci jeszcze nie opowiadałem to jest różnica pomiędzy Task, a Thread czyli zadanie a wątek.
            // Wątki są ciężkie - to znaczy powołanie do życia wątku wiąże się z kosztem pracy procesora, ale w wielu sytuacjach się to opłaca.
            // Taski są pewną warstwą abstrakcji położoną powyżej wątków - ukrywają wątki - nie musisz myśleć niskopoziomowo o wątkach tylko o zadaniach, a to już sam .NET zadecyduje czy na dane zadanie jest potrzebny nowy wątek czy nie.
            // Np. w Dart w ogóle nie ma wielowątkowości ale mimo to jest asynchroniczność.
            // - po prostu w chwili, w której jakieś zadanie miało by zawiesić wątek to inne zadanie przejmuje zasoby procesora i nie marnuje tego wątku.
            // No bo wyobraź sobie taki przykład:
            // Strzelasz do jakiegoś zasobu w internecie i oczekujsz jakiejś zwrotnej informacji.
            // W tym przykładzie większość czasu zmarnujesz na czekanie - czyli na ruch sieciowy przez internet.
            // Oczywistym jest, że nie chcesz żeby ta długo trwająca operacja (np. klika sekund) blokowała interfejs użytkownika - np. okno w Windowsie.
            // I masz dwie opcje:
            // - 1) tworzysz nowy wątek (Thread) i w tym wątku wykonujesz strzał do zasobu w internecie - niby spoko, bo dzięki temu główny wątek nie jest zablokowany, a cały strzał wykonujesz w wątku pobocznym
            //      Ale jakie są minusy? A na przykład taki, że marnujesz cały jeden wątek w systemie Windows po to żeby bezczynnie czekać na powrót danych z internetu - bez sensu.
            //      A po drugie problem jest taki, że jak już ten wątek skończy z robotę to musisz jakoś poinoformować wątek główny, że tak robota się skończyła - w przypadku wątków nie masz eleganckiego "await" tylko musisz nagrzmocić jakiś kod do synchronizacji wątków.
            // - 2) tworzysz nowy Task i w tym tasku wykonujesz strzał do zasobu w internecie - i tutaj .NET elegancko rozpoznaje, że nie jest potrzebny w ogóle nowy wątek - strzał do zasobu pójdzie w głównym wątku, po czym główny wątek natychmiast przełączy się na
            //      obsługę interfejsu użytkownika więc nic nie będzie zablokowane i użytkownik będzie mógł pracować, a tak szybko jak tylko wróci odpowiedź z internetu tak szybko task poinforuje, że się skończył i wynik jest już gotowy.
            //      Dzięki temu nie marnujemy wątków i czasu procesora. W .NET tak to mądrze działa, że jak .NET uzna, że jest mu potrzebny nowy wątek to sam go sobie weźmie z puli wątków. No i tutaj nie trzeba pisać żadnego kodu do synchronizacji - wystarczy zrobić await.
            // To jest takie pobieżne wyjaśnienie bo jak to dokładnie działa w bebechach .NET'a, jak jest robione zarządzanie pulą wątków to w sumie sam do końca się nie zagłębiałem.
        }
    }

    public class SomeLongRunningOperation
    {
        // metoda asynchroniczna czyli taka oznaczona słowem kluczowym async - samo to nie robi z niej jeszcze metody asynchronicznej - potrzebny jest dodatkowo jakiś await w środku - no bo jeżeli ta metoda miała by mieć tylko słówk async,
        // a w środku miał by być zwykły synchroniczny kod typu var x = 2 + 2 to nic to jeszcze nie daje.
        // Ponadto metoda zwraca obiekt typu Task<int> czyli obiekt reprezentujący zadanie, które po skończeniu zwróci int'a.
        // W różnych językach różnie się to nazywa, np. w Dart to taki Task<int> będzie się nazywać Future<int> - future czyli przyszłość. Można się też spotkać z pojęciem - obietnica.
        // Chodzi o to, że ten obiekt to jest obiekt, na którym można awaitować - czyli oczekiwać na jego skończenie.
        public async Task<int> GetSomeIntAsync()
        {
            return await Task.Run(() =>
            {
                return GetSomeIntSync();
            });
        }

        // najzwyklejsza metoda synchroniczna, która działa w tym wątku, w którym zostanie wywołana, a tym samym blokuje ten wątek do czasu zakończenia - w tym przypadku na potrzeby przykładu mamy po prostu delay na 2 sekundy
        public int GetSomeIntSync()
        {
            Thread.Sleep(2000);
            return 123456;
        }
    }
}
