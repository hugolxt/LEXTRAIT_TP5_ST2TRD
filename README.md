# LEXTRAIT_TP5_ST2TRD

##  Informations ##

**Rendering date :** Friday 4th February.  
**Author :** Hugo Lextrait.  
**School :** Efrei Paris.  
**Student Number:** 20170687.  

## Ressources ##

In this C# project we are working with the **GildRose library** that you cna find here  https://github.com/emilybache/GildedRose-Refactoring-Kata 
This TP is divided in 4 differents parts answered below 

## Projects Answers ##

## Part 1 : Some questions about the code ##
#### Question 1: What is this code about?

This code reproduce a the functionnement of a Tavern who sold items with a specific quality and quantity day after day.
We have the information on names, expiration dates and qualities of all items that the Tavern has in stock under specific defined starting data.

#### Question 2: Can you clearly identify the name of all the goods stored in the Guilded Rose?

The Guilded Rose is storing the goods defined below : 

Name   |
------------- |
+5 Dexterity Vest  |
Aged Brie  |
Elixir of the Mongoose  |
Sulfuras, Hand of Ragnaros (x2)  |
Backstage passes to a TAFKAL80ETC concert (x3)  |
Conjured Mana Cake  |
  
#### Question 3: What happens when the day is over?

When it's th end of the day, quality and selling of all items are modified according to fixed conditions. It's means that this attributes can be modified or not. 

#### Question 4: What happens to cheese when the day is over?

When the day is over the Cheese's quality grows.

#### Question 5: What happens when a concert ticket goes over its expiration day?

At his expiration day is passed, its quality goes to 0.

#### Question 6: What makes this code hard to read?

This code is hard to read because there is lot of nested stuctures like nested IF statement. This structure seems to be improved.

#### Question 7: Do you think the rules are clear enough so that you could rework the entire solution from scratch?

From scratch, it will no be an easy work but thanks to the vast documentation in every langages, the application principle is pretty clear. That's a very good point for a work of application recreation.

---

## Part 2 : Application's tests ## 

Look online for NUnit (and NFluent if you want) and AAA test pattern. Create a project in the solution (ie: GuildedRose.Test). To increase clarity, split your tests into multiple files in a way you see fit / clever.

**Write some tests about this code. There should be about ~10 tests that should all pass and cover most of the cases. More tests the better.**

#### Question 1: Question : What is the benefit of adding tests here ? 

Unit tests guarantee that the application (the code) fulfills the conditions and that the principle of the application is respected. In addition, when modifying the code, they allow the coder to quickly test the various conditions that the application must meet. Throughout the modification or impregnation process, tests ensure the reliability and integrity of the application.

---

### Part 3 : Refactoring the code ###

Only now can you modify the GuildedRose.cs file. Before you rush in, ask yourself how you want to implement this in a clever way. I want different classes, single purpose function, objects. Tests should be green at the end, and you should not have extensively modified them. You should however update them if you changed the architecture of your code to reflect this.

=> You can find the answer in the **GildedRose.cs**

---

### Part 4 : Up, up, and away  ###

Implement the conjured item property. 
Then, find at least 3 ways to expand this code to add more functionalities. Explain how you would carry on with your implementation of the code. Thread carefully, this is harder than you think it is. Scalability is key. You don’t need to code these, but you should explain in detail what you would do. 

#### Answer :

We can think about new features to add some new content and roleplay around the Guilded Shop.

My first Idea would have been to create a better User Interface in order to make the shop more userfriendly. A good way to do it would have been to use a Graphical C# application like WPF apps. This way would allow the user to follow each day and the evolution of all the items more clearly using colors and icons. A clear interface allow to simplify the game understanding and evolution.

---

Second idea would have been to allow the user to create and insert his own items in the shop with the possibility to declare the item as a normal, personalized, conjured or legendary item. It would have been really interesting to follow his own items evolution to undestand the game. like below 

->  Would you want to add a new item to the Guilded Shop ? (y/n)

->  What's the item's type ?
  1. Normal
  2. Conjured
  3. Legendary
  4. Personalized

->  Enter the following informations :
->  Name : xxx
->  Starting Quality : xxx
->  Starting Sellin : xxx
->  Starting Quality : xxx


---

Moreover, a really simple feature that could have completly change the game understanding could have been to add the delta (positiv or negativ) for the quality and Sellin according to last day like below:

---------------         day 7          ----------------
Name              | SellIn (delta)    | Quality (delta)

+5 Dexterity Vest | 3 (-1)            | 13 (-1)
Aged Brie         | -5 (-1)           | 12 (+2)
...
...





