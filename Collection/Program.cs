namespace Collection
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<Entity> list = new List<Entity>()
            {
                new Entity { Id = 1, ParentId = 0, Name = "Root entity" },
                new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity" },
                new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity" },
                new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity" },
                new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity" }
            };


            foreach (var entity in returnEntity(list))
            {
                Console.WriteLine(entity.Key + " " + entity.Value);
            }
        }

        public static Dictionary<int, List<Entity>> returnEntity(List<Entity> list)
        {
            Dictionary<int, List<Entity>> entity = new Dictionary<int, List<Entity>>();

            foreach (var ent in list)
            {
                entity[ent.ParentId] = new List<Entity>()
                {
                    ent
                };
            }

            return entity;
        }
    }

    class Entity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
    }
}