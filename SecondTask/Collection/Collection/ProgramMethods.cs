using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ProgramMethods
    {
        public Dictionary<int, List<Entity>> convertEntitiesToDictionary(List<Entity> listEntity)
        {
            Dictionary<int, List<Entity>> myDictionary = new Dictionary<int, List<Entity>>();
            myDictionary = listEntity.GroupBy(x => x.parentId).ToDictionary(x => x.Key, x=>x.ToList());
            return myDictionary;
        }

        public void getAllFromDictionary(Dictionary<int, List<Entity>> myDictionary)
        {
            foreach (var item in myDictionary)
            {
                Console.Write("Key = " + item.Key + ", Value = List {");
                int counter = 0;
                String nowId = null;
                foreach (var entity in item.Value)
                {
                    if (counter > 0)
                        nowId = ", Entity{Id=" + entity.Id+"}";
                    else
                        nowId = "Entity{Id=" + entity.Id+"}";
                    counter++;
                    Console.Write(nowId);
                }
                Console.WriteLine("}");
            }
        }
    }
}
