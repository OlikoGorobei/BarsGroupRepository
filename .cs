using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    public class Entity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "Id: " + Id + "   ParentId: " + ParentId + "Name" + Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Entity> enity = new List<Entity>();
            enity.Add(new Entity() { Id = 1, ParentId = 0, Name = "Root entity" });
            enity.Add(new Entity() { Id = 2, ParentId = 1, Name = "Child of 1 entity" });
            enity.Add(new Entity() { Id = 3, ParentId = 1, Name = "Child of 1 entity" });
            enity.Add(new Entity() { Id = 4, ParentId = 2, Name = "Child of 2 entity" });
            enity.Add(new Entity() { Id = 5, ParentId = 4, Name = "Child of 4 entity" });

            Console.WriteLine();
            foreach (Entity aEnity in enity)
            {
                Console.WriteLine(aEnity);
            }



        }
    }
}

                

       
  

            


           
