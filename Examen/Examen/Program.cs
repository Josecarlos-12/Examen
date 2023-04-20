using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        private List<NPC> npc;
        public void Execute() { 
        }

        private void AddMenu() {
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("Crear un NPC");
            string option= Console.ReadLine();

            switch (option)
            {
                case "2":
                    CreateTalker();
                    CreateSeller();
                    break;
            }

        }

        private void CreateTalker()
        {
            string name;
            string textList;
            float life;
            string type;

            Console.WriteLine("Introducir nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir lista de textos:");
            textList = Console.ReadLine();
            Console.WriteLine("Introducir vida:");
            life = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir tipo");
            type = Console.ReadLine();

            npc.Add(new Talkers(textList, name, life, type));
        }

        private void CreateSeller()
        {
            string name;
            float money;
            string itemList;
            float life;
            string type;

            Console.WriteLine("Introducir nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir dinero:");
            money = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir lista de items:");
            itemList = Console.ReadLine();
            Console.WriteLine("Introducir vida:");
            life = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir tipo");
            type = Console.ReadLine();

            npc.Add(new Seller(money, itemList, name, life, type));
        }

    }
}
