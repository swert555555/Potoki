using System.Reflection.Emit;
using System;
using System.Diagnostics;
using System.Threading;

namespace Потоки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи имя. После начнется обратный отсчет, твоя задача - печатать текст.");
            Polsovatel chel = new(Name: Console.ReadLine());
            List<Polsovatel> polsovatels = new List<Polsovatel>();
            polsovatels.Add(chel);
            Console.Clear();
            string TextRead = "Почему от алкоголя люди кажутся красивее и сексуальнее? Исследование, опубликованное в 2003 году, показало, что мужчины и женщины, употреблявшие умеренное количество алкоголя, находили лица представителей противоположного пола на 25 процентов более привлекательными, чем их трезвые сверстники. На основе этого исследования ученые из Лондонского университета Рохэмпотна выяснили, что алкоголь ухудшает способность воспринимать асимметрию на лицах и снижает предпочтение симметричных лиц перед асимметричными. Ведь красота это что? Симметрия, то есть «правильные» черты лица и фигуры. На способность их распознавать и влияет алкоголь, меняя работу префронтальной коры. А его влияние на лобную долю усиливает наше желание сближаться с другими людьми. Последний гвоздь в крышку гроба: воздействие на вентральный стриатум, который включает импульсивное и нелогичное поведение. Почему это плохо? Ну не то чтобы плохо, скорее неэффективно. Я за то, чтобы любая коммуникация - особенно сексуальная - доставляла всем участникам максимум кайфа. А если вы на утро жалеете о содеянном, или, что ещё хуже, с содроганием смотрите на человека в постели - это уже не максимум. Про секс нужно вспоминать с наслаждением, а не с отвращением. Это если вы вообще его запомните, ведь на гиппокамп, хранилище памяти, алкоголь тоже плохо влияет. Чтобы не случалось всякой фигни, можете соблюдать золотое правило, первый секс с новым партнёром - на трезвую (или хотя бы полутрезвую) голову.";
            string YourText = "к";
            int Time = 60;
            Polsovatel.Vsego_Simvol = YourText.Length;

        Thread thread = new Thread(x =>
            {

                Console.SetCursorPosition(0, 1);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(TextRead); //DarkGray
                Console.ForegroundColor = ConsoleColor.White;
                int i = 0;
                Console.SetCursorPosition(1, 0);
                for (char console_char_text = Convert.ToChar(Console.Read()); Time != 0; console_char_text = Convert.ToChar(Console.Read()), i++)
                {
                    if (console_char_text == TextRead[i])
                        YourText += console_char_text;
                    //YourText = (string)YourText.Append(console_char_text);
                    else
                        i--;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(1, 0);
                    Console.WriteLine(console_char_text);
                    Console.WriteLine(YourText);
                }
            });
            
            thread.Start();
            Stopwatch sw = Stopwatch.StartNew();
                while (Time != 0)
                {
                    Time = Convert.ToInt32(60 - sw.ElapsedMilliseconds / 1000);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(Time);
                    Thread.Sleep(1000);
                }
            Console.Clear();
            Console.WriteLine("Время вышло! ...");

            Console.WriteLine(YourText); //не меняется строка, не заполняется

        }
    } 
}