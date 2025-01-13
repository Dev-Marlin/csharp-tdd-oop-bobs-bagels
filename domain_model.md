## Domain model


|Classes     			   |Methods/Properies                |Scenarios                                                                                 |Output                                                        |
|:-------------------------|:--------------------------------|:-----------------------------------------------------------------------------------------|:-------------------------------------------------------------|
|Product.cs                |Price                            |Customer wants to know cost of specific product                                           |double showing cost of product                                |
|Product.cs                |Name                             |Customer wants toknow what they are buying                                                |string showing name of product                                |
|Product.cs                |SKU                              |To scan in product we  need to know its ID                                                |string showing SKU of product                                 |
|Product.cs                |Variant                          |To give the customer a chooice the shop have variants of each product                     |string showing variant of product                             |
|Product.cs                |ToString                         |customer wants to know information about specific product                                 |string showing information about product                      |
|Basket.cs                 |AddProduct(Product p)            |A customer wants to buy a product                                                         |bool that shows if basket is full or if it even exists        |
|Basket.cs                 |RemoveProduct(string SKU)        |A customer changes its mind to buy                                                        |bool that shows if it existed                                 |
|Basket.cs                 |TotalCost()                      |A customer wants to know what they need to pay                                            |double that shows the total price for every product in basket |
|Basket.cs                 |AllProducts()                    |The customer wants to know what products they have in the basket                          |string that shows all the current products in basket          |
|Basket.cs                 |GetProduct(string SKU)           |customer want to find specifik product in basket                                          |returns the specifik product if found                         |
|Basket.cs                 |Capacity                         |For the customer so they know there basket is full                                        |int that shows the max items of the basket                    |
|Bagel.cs                  |AddFilling(Filling f)            |Customer dont want a plain and boring bagel                                               |bool that shows if its to much filling                        |
|Bagel.cs                  |Filling capacity                 |there is actually a limit for bagel fillings                                              |                                                              |
|Bagel.cs                  |CheckFillingPrice()              |before buying bagel with filling customer wants to know how much in debt they will be     |double showing total price of filling                         |
|Bagel.cs                  |AllTheFilling()                  |customer wants to know what filling the bagel have                                        |string showing all the filling on specific bagel              |
|Inventory.cs              |ProductInInventory(string SKU)   |before buying product the store need to check if the product is in                        |Returns the wanted product and true, if not exist false       |
|Inventory.cs              |AddProductToInventory(Product p) |manager wants to update the inventory                                                     |                                                              |
|IDiscount.cs              |CheckDiscount(List<Product> pl)  |the customer wants to know if they will get any discount on the products they are buying  |double showing the new price for the product with the discount|

