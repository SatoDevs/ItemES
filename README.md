# ItemECS
Experimental ECS for game item modularity
kind of an ECS, kind of not

This system allows you to create any kind of property (behavior/functionnality) and add them to items.

Example:
-------------------------------------------------------------------------------------------------------

//Setting the properties  
EdibleProperty sandwichEdible = new EdibleProperty();  
edible.hungerBoost = 10;  
  
AttackProperty sandwichAttack = new AttackProperty();  
sandwichAttach.damage = 5;  
  
//Creating the item  
ItemManager.createItem("Sandwich", "Just a regular Sandwich");  
ItemManager.AddProperty(0, sandwichEdible);  //adds said property to item ID 0  
ItemManager.AddProperty(0, new EquipProperty());  
ItemManager.AddProperty(0, sandwichAttack);  
ItemManager.AddProperty(0, new ThrowProperty());  
