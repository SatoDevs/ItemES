class EdibleProperty : Property
    {
        public int hungerBoost;

        public void Eat(Player player)
        {
            Debug.WriteLine("You eat the item ");
            player.health += hungerBoost;
        }
    }
