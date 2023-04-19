using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class menu
    {
        private List<item> items;
        private bool continueFlag;

        public void Execute()
        {
            items = new List<item>();
            continueFlag = true;

            while (continueFlag)
            {
                itemMenu();
                endingMenu();
            }

        }

        private void itemMenu()
        {
            Console.WriteLine("Ingresa un numero para agregar un item :");
            Console.WriteLine("1. Potion");
            Console.WriteLine("2. Arma");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    potionmenu();
                    break;
                case "2":
                    weaponmenu();
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
        }
        private void potionmenu()
        {

        }

        private void weaponmenu()
        {

        }

        private void endingMenu()
        {
            bool endingContinueFlag = true;

            while (endingContinueFlag)
            {
                Console.WriteLine("Introducir el número de la acción que quiere realizar");
                Console.WriteLine("1. Añadir otra arma");
                Console.WriteLine("2. Mostrar todas las armas");
                Console.WriteLine("3. Eliminar un arma");
                Console.WriteLine("4: Salir");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        endingContinueFlag = false;
                        break;
                    case "2":
                        ShowAllWeapons();
                        break;
                    case "3":
                        RemoveWeapon();
                        break;
                    case "4":
                        endingContinueFlag = false;
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No es una opción válida");
                        break;
                }


            }
        }

        private void ShowAllWeapons()
        {
            Console.WriteLine("La lista de objetos es: ");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i]}");
            }
        }

        private void RemoveWeapon()
        {
            Console.WriteLine("Introducir el número del arma a remover:");
            ShowAllWeapons();
            int option = int.Parse(Console.ReadLine());

            if (option >= 0 && option < items.Count)
            {
                items.RemoveAt(option);
            }
            else
            {
                Console.WriteLine("pon otro número");
            }
        }
    }
}
