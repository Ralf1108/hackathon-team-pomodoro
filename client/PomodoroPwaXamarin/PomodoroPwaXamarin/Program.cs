using System;
using System.Reflection;
using Ooui;
using Xamarin.Forms;

namespace PomodoroPwaXamarin
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.AssemblyCultureAttribute a = new AssemblyCultureAttribute("");
            Console.WriteLine("Attribute: " + a);

            Console.WriteLine("Start");

            Forms.Init();

            var mainPage = new MainPage();
            UI.Publish("/", mainPage.GetOouiElement());
            
            Console.WriteLine("End");
        }
    }
}
