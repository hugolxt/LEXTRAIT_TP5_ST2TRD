using System;
using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GuildedRose.Test
{
    [TestFixture]
    public class Test4
    {
        [Test]
        public void test()
        {
            // if selling = 0 => Quality delta = 2
            Assert.True(true);
            IList<Item> Items = new List<Item> { new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 100}, };
            GildedRose app = new GildedRose(Items);


            for (int i = 0; i < 30; i++)
            {
                var prevQuality = Items[0].Quality;
                
                app.UpdateQuality();
                
                var deltaQuality = prevQuality - Items[0].Quality;
                    
                    
                Assert.AreEqual(2, deltaQuality);
            }
        }
    }
}