using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        private List<Player> player;
        private List<NPC> npc;
        private List<Item> item;
        private bool continueFlag;

        public void Execute()
        {
            player = new List<Player>();
            npc = new List<NPC>();
            item = new List<Item>();
            continueFlag = true;

            while (continueFlag)
            {
                AddMenu();
                EndingMenu();
            }
            
        }

        private void AddMenu()
        {
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("1.Crear un Personaje");
            Console.WriteLine("2.Crear un NPC");
            Console.WriteLine("3.Crear un Item");
            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    CreatePlayer();
                    break;
                case "2":
                    CreateSeller();
                    CreateTalker();
                    CreateEnemy();
                    break;
                case "3":
                    CreateWeapon();
                    Createpotions();
                    break;
                default:
                    Console.WriteLine("la opción no existe");
                    break;
            }
        }

        private void CreatePlayer()
        {
            string name;
            string itemList;
            float experience;
            int level;
            float money;

            Console.WriteLine("Introducir nombre");
            name= Console.ReadLine();
            Console.WriteLine("Introducir lista de items");
            itemList= Console.ReadLine();
            Console.WriteLine("Introducir experiencia");
            experience=float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir nivel:");
            level=int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir dinero");
            money=float.Parse(Console.ReadLine());

            player.Add(new Player(name, itemList, experience, level, money));
        }
        private void CreateSeller()
        {
            string name;
            float money;
            string itemList;
            float life;
            string type;

            Console.WriteLine("Introducir nombre:");
            name=Console.ReadLine();
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

            npc.Add(new Talkers(textList,name, life, type));
        }

        private void CreateEnemy()
        {
            string name;
            float life;
            string type;
            float damage;
            string itemList;
            int level;
            float givenExperience;

            Console.WriteLine("Introducir nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir vida:");
            life = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir tipo:");
            type = Console.ReadLine();
            Console.WriteLine("Introducir daño del enemigo:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir lista de items:");
            itemList = Console.ReadLine();
            Console.WriteLine("Introducir nivel");
            level = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir experiencia que da:");
            givenExperience = float.Parse(Console.ReadLine());


            npc.Add(new Enemy(damage,itemList,level,givenExperience,name,life,type));
        }

        private void CreateWeapon()
        {
            float damage;
            string name;
            string type;
            float price;

            Console.WriteLine("Introducir el daño:");
            damage=float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir nombre del arma:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir tipo de arma:");
            type = Console.ReadLine();
            Console.WriteLine("Introducir precio:");
            price = float.Parse(Console.ReadLine());

            item.Add(new Weapon(damage, name, type, price));
    }

        private void Createpotions()
        {
            int capacity;
            string name;
            string type;
            float price;

            Console.WriteLine("Introducir capacidad de la poción:");
            capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir nombre del arma:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir tipo de arma:");
            type = Console.ReadLine();
            Console.WriteLine("Introducir precio:");
            price = float.Parse(Console.ReadLine());

            item.Add(new Potions(capacity, name, type, price));
        }


        private void EndingMenu()
        {
            bool endingContinueFlag = true;

            while (endingContinueFlag)
            {
                Console.WriteLine("Introducir el número de la acción que quiere realizar");
                Console.WriteLine("1: Crear otro Personaje");
                Console.WriteLine("2: Crear otro NPC");
                Console.WriteLine("3: Seleccionar un Item");
                Console.WriteLine("4: Mostrar todos los Jugadores");
                Console.WriteLine("5: Mostrar todos los NPC'S");
                Console.WriteLine("6: Mostrar todos los Items");
                Console.WriteLine("7: Eliminar un NPC");
                Console.WriteLine("8: Eliminar un Item");
                Console.WriteLine("9: Salir");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        endingContinueFlag=false;
                        break;
                    case "2":
                        endingContinueFlag=false;
                        break;
                    case "3":
                        endingContinueFlag = false;
                        break;
                    case "4":
                        ShowPlayer();
                        break;
                    case "5":
                        ShowNPC();
                        break;
                    case "6":
                        ShowItems();
                        break;
                    case "7":
                        RemoveNPC();
                        break;
                    case "8":
                        RemoveItem();
                        break;
                    case "9":
                        endingContinueFlag = false;
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No es una opción válida");
                        break;
                }


            }
        }

        private void ShowPlayer()
        {
            for (int i = 0; i < player.Count; i++)
            {
                Console.WriteLine($"{i}: {player[i].IShowData()}");
            }
        }

        private void ShowNPC()
        {
            for(int i = 0; i < npc.Count; i++)
            {
                Console.WriteLine($"{i}: {npc[i].IShowData()}");
            }
        }

        private void ShowItems()
        {
            for (int i =0; i < item.Count;i++)
            {
                Console.WriteLine($"{i}: {item[i].IShowData()}");
            }
        }

        private void RemoveNPC()
        {
            Console.WriteLine("Introduce el número del npc a remover");
            ShowNPC();
            int option = int.Parse( Console.ReadLine() );

            if ( option >= 0 && option <npc.Count ) 
            {
                npc.RemoveAt(option);
            }
            else
            {
                Console.WriteLine("No es un nombre válido");
            }
        }

        private void RemoveItem()
        {
            Console.WriteLine("Introduce el número del item a remover");
            ShowNPC();
            int option = int.Parse(Console.ReadLine());

            if (option >= 0 && option < item.Count)
            {
                npc.RemoveAt(option);
            }
            else
            {
                Console.WriteLine("No es un nombre válido");
            }
        }

    }
}
