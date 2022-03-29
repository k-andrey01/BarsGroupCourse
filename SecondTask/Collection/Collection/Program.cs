using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity entity1 = new Entity(1, 0, "Root entity");

            Entity entity2 = new Entity(2, 1, "First child of 1 entity");

            Entity entity3 = new Entity(3, 1, "Second child of 1 entity");

            Entity entity4 = new Entity(4, 2, "Child of 2 entity");

            Entity entity5 = new Entity(5, 4, "Child of 4 entity");

            List<Entity> myEntities = new List<Entity>();
            myEntities.Add(entity1);
            myEntities.Add(entity2);
            myEntities.Add(entity3);
            myEntities.Add(entity4);
            myEntities.Add(entity5);

            ProgramMethods programMethods = new ProgramMethods();
            Dictionary<int, List<Entity>> myDictionary = programMethods.convertEntitiesToDictionary(myEntities);

            programMethods.getAllFromDictionary(myDictionary);
        }
    }
}
