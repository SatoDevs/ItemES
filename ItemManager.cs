public static class ItemManager
    {
        public static int itemNumber = 0;
        public static List<Item> items = new List<Item>();

        //Adds an empty item to the list
        public static void createItem(string name, string description)
        {
            Item i = new Item();
            i.ID = itemNumber;
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

        //Returns the property of specified type from the specified item 
        public static T GetProperty<T>(int id) where T : Property
        {
            foreach (Property c in items[id].properties)
                if (c is T r)
                    return r;

            return default;
        }
    }
