## Domain model


|Classes     			   |Methods/Properies             |Scenarios                                                                                 |Output                                                        |
|:-------------------------|:-----------------------------|:-----------------------------------------------------------------------------------------|:-------------------------------------------------------------|
|Product.cs                |Cost                          |Customer wants to know cost of specific product                                           |double showing cost of product                                |
|Product.cs                |Name                          |Customer wants toknow what they are buying                                                |string showing name of product                                |
|Product.cs                |SKU                           |To scan in product we  need to know its ID                                                |string showing SKU of product                                 |
|Product.cs                |Variant                       |To give the customer a chooice the shop have variants of each product                     |string showing variant of product                             |
|Basket.cs                 |AddProduct(string SKU)        |A customer wants to buy a product                                                         |bool that shows if basket is full or if it even exists        |
|Basket.cs                 |RemoveProduct(string SKU)     |A customer changes its mind to buy                                                        |bool that shows if it existed                                 |
|Basket.cs                 |TotalCost()                   |A customer wants to know what they need to pay                                            |double that shows the total price for every product in basket |
|Basket.cs                 |Capacity                      |For the customer so they know there basket is full                                        |int that shows the max items of the basket                    |
|Bagel.cs                  |AddFilling(string SKU)        |Customer dont want a plain and boring bagel                                               |bool that shows if its to much filling                        |
|Bagel.cs                  |Filling capacity              |there is actually a limit for bagel fillings                                              |                                                              |
|Bagel.cs                  |CheckFillingPrice()           |before buying bagel with filling customer wants to know how much in debt they will be     |double showing total price of filling                         |

