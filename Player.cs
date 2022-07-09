public class Player
    {
        public int hunger = 0;
        int selectedItem = 0;

        public void Update()
        {
            //Eat the item
            if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                if (ItemManager.GetProperty<Edible>(selectedItem) != null)
                {
                    ItemManager.GetProperty<Edible>(selectedItem).Eat();
                    Debug.WriteLine("You eat " + ItemManager.items[selectedItem].name);
                }
            }
        }
    }
