public class Player
    {
        public int hunger = 0;
        int selectedItem = 0;

        public void Update()
        {
            //Eat the item
            if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                Item i = inventory.items[selectedItem].item;
                if (ItemManager.GetProperty<Edible>(i.ID) != null)
                {
                    ItemManager.GetProperty<Edible>(selectedItem).Eat(i);
                }
                else
                {
                    Debug.WriteLine(inventory.items[selectedItem].item.name + " is not edible");
                }
            }
        }
    }
