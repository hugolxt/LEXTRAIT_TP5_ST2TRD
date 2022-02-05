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

## Part 1 ##
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

## Part 2 : Application's tests ## 

Look online for NUnit (and NFluent if you want) and AAA test pattern. Create a project in the solution (ie: GuildedRose.Test). To increase clarity, split your tests into multiple files in a way you see fit / clever.

**Write some tests about this code. There should be about ~10 tests that should all pass and cover most of the cases. More tests the better.**

#### Question 1: Question : What is the benefit of adding tests here ? 

### Part 3 ###


### Part 4 ###

