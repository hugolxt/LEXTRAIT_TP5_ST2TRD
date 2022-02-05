using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void DecreaseQualityForNormalItems(Item item)
        {
            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality--;
            }
        }

        public void BackStagedPassed(Item item)
        {
            if (item.Quality < 50)
            {
                if (item.SellIn < 11)
                {
                    item.Quality++;
                }

                if (item.SellIn < 6)
                {
                    item.Quality++;
                }   
            }
        }

        public void SellinReachZero(Item item)
        {
            if (item.Name != "Aged Brie")
            {
                if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            item.Quality--; // Normal Item
                        }
                    }
                }
                else
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
            else // item is Aged Brie
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        } 
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecreaseQualityForNormalItems(Items[i]);
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality++;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            BackStagedPassed(Items[i]);
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn--;
                }

                if (Items[i].SellIn < 0)
                {
                    SellinReachZero(Items[i]);
                }
            }
        }
    }
}
