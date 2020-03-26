using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks[] perks;
            string aux;
            int numNPCs;
           //pedir ao user o nº de npc
            Console.Write("Insira nº de NPCs: ");
            aux = Console.ReadLine();
            numNPCs = Convert.ToInt32(aux);
            perks = new Perks[numNPCs];
           //para cada npc, pedir as suas características
            
            for (int i = 0, i < numNPCs; i++)
            {
                Console.Write($"NPC {i} tem Stealth (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCPerks.Stealth;
                }
                Console.Write($"NPC {i} tem Combat (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCPerks.Combat;
                }
                Console.Write($"NPC {i} tem Lockpick (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCPerks.Lockpick;
                }
                Console.Write($"NPC {i} tem Luck (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCPerks.Luck;
                }
            }
           //mostrar no ecrã as características
           Console.WriteLine();

           for (int i = 0; i < numNPCs; i++)
           {
               Perks p = Perks1.Combat | Perks.Luck;
               Console.WriteLine($"Perks do NPC {i}: {perks[i]}");

                if (perks[i] & p == p)
                {
                    Console.WriteLine("\tYou shall win all fights");
                }
           }

        }
    }
}
