 public class Item
    {
        public int ID;
        public string name;
        public string description;
        public List<Property> properties;
        public Rectangle drawRectangle;
    }

    public static class ItemManager
    {
        public static int itemNumber = 0;
        public static List<Item> items = new List<Item>();

        //Adds an empty item to the list
        public static void createItem(string name, string description)
        {
            Item i = new Item();
            i.ID = items.Count;
            i.properties = new List<Property>();
            i.name = name;
            i.description = description;
            items.Add(i);
            itemNumber++;
        }

        //Displays the list of items
        public static void showAllItems()
        {
            foreach( Item i in items)
            {
                Debug.WriteLine("ID: " + i.ID + ", name: " + i.name + ", description: " + i.description);
            }
        }

        //Adds the property to the specified item
        public static void addProperty(int id, Property property)
        {
            items[id].properties.Add(property);
        }

        public static void removeProperty<T>(int id) where T : Property
        {
            foreach (Property c in items[id].properties.ToList())
                if (c is T r)
                    items[id].properties.Remove(c);
        }

        //Returns the property of specified type from the specified item 
        public static T GetProperty<T>(int id) where T : Property
        {
            foreach (Property c in items[id].properties)
                if (c is T r)
                    return r;

            return default;
        }
    }
