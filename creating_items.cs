            //Sandwich
            ItemManager.createItem("sandwich", "it looks good");
            Edible edible = new Edible();
            edible.hungerBoost = 10;
            ItemManager.addProperty(0, edible);


            ItemManager.createItem("Rock", "this is not edible");
            ItemManager.createItem("Sword", "this is not edible");
            ItemManager.createItem("Helmet", "this is not edible");

            ItemManager.showAllItems();
