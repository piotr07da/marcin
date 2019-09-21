using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class AsyncExample2
    {
        public async Task Test()
        {
            var sw = new Stopwatch();

            sw.Start();

            WywolajDwaCiagiOperacji();

            sw.Stop();
            Console.WriteLine($"Całość trwała: {sw.ElapsedMilliseconds} milisekund.");
            Console.ReadKey();

            sw.Reset();
            sw.Start();

            await WywolajDwaCiagiOperacjiAsync();

            sw.Stop();
            Console.WriteLine($"Całość trwała: {sw.ElapsedMilliseconds} milisekund.");
            Console.ReadKey();
        }

        public void WywolajDwaCiagiOperacji()
        {
            WywolajPierwszyCiagOperacji();
            WywolajDrugiCiagOperacji();
        }

        public void WywolajPierwszyCiagOperacji()
        {
            WywolajOperacje(1, 1, 500);
            WywolajOperacje(1, 2, 2000);
            WywolajOperacje(1, 3, 500);
            WywolajOperacje(1, 4, 500);
            WywolajOperacje(1, 5, 1000);
        }

        public void WywolajDrugiCiagOperacji()
        {
            WywolajOperacje(2, 1, 500);
            WywolajOperacje(2, 2, 1000);
            WywolajOperacje(2, 3, 1000);
            WywolajOperacje(2, 4, 1000);
            WywolajOperacje(2, 5, 1000);
        }

        private void WywolajOperacje(int numerCiagu, int numerOperacji, int delay)
        {
            Thread.Sleep(delay);
            Console.WriteLine($"Ciąg {numerCiagu} - Operacja {numerOperacji}");
        }

        public async Task WywolajDwaCiagiOperacjiAsync()
        {
            var t1 = WywolajPierwszyCiagOperacjiAsync();
            var t2 = WywolajDrugiCiagOperacjiAsync();

            Console.WriteLine("Oczekuję na skończenie dwóch równoległych ciągów operacji.");

            await Task.WhenAll(t1, t2);

            Console.WriteLine("Zakończono oba równoległe ciągi operacji poprzez awaitowanie słowem await.");
        }

        public async Task WywolajPierwszyCiagOperacjiAsync()
        {
            await WywolajOperacjeAsync(1, 1, 500);
            await WywolajOperacjeAsync(1, 2, 2000);
            await WywolajOperacjeAsync(1, 3, 500);
            await WywolajOperacjeAsync(1, 4, 500);
            await WywolajOperacjeAsync(1, 5, 1000);
        }

        public async Task WywolajDrugiCiagOperacjiAsync()
        {
            await WywolajOperacjeAsync(2, 1, 500);
            await WywolajOperacjeAsync(2, 2, 1000);
            await WywolajOperacjeAsync(2, 3, 1000);
            await WywolajOperacjeAsync(2, 4, 1000);
            await WywolajOperacjeAsync(2, 5, 1000);
            await WywolajOperacjeAsync(2, 6, 7000);
        }

        private async Task WywolajOperacjeAsync(int numerCiagu, int numerOperacji, int delay)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(delay);
                Console.WriteLine($"Ciąg {numerCiagu} - Operacja {numerOperacji}");
            });
        }
    }
}
