using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Потоки
{
    public class Top_Polsovatelei
    {
        public static string? Name = "Топ пользователей";
        public static List<Polsovatel>? Vse_polsovateli;

        
        public static void ConvertJson(List<Polsovatel> pols)
        {
            Vse_polsovateli = pols;
            string json = JsonConvert.SerializeObject(Vse_polsovateli);
            File.WriteAllText("C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\учеба\\C#\\Потоки\\he.json", json);
        }
        public static void ReadJSON()
        {
            string text = File.ReadAllText("C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\учеба\\C#\\Потоки\\he.json");
            Vse_polsovateli = JsonConvert.DeserializeObject<List<Polsovatel>>(text) ?? new List<Polsovatel>();
            Console.WriteLine(Top_Polsovatelei.Name);
            foreach (Polsovatel user in Vse_polsovateli)
            {
                Console.WriteLine("\nИмя: " + user.Name + "\nСимволов в секунду: " + user.Simvol_Sekund + "\nВсего символов: " + user.Vsego_Simvol);
                Console.WriteLine("---------------------");
            }
        }
    }

    public class Polsovatel
    {
        public string? Name;
        public int Vsego_Simvol = 0;
        public double Simvol_Sekund;

        public Polsovatel(string Name, double Simvol_Sekund, int Vsego_Simvol)
        {
            this.Name = Name;
            this.Vsego_Simvol = Vsego_Simvol;
            this.Simvol_Sekund = Simvol_Sekund;
        }
    }
}
