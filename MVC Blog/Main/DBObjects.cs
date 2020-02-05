using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Entities
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {
            #region News
            if (!content.News.Any())
            {
                content.AddRange(
                   new News
                   {
                       title = "Man pretends to have coronavirus mid-flight, forcing plane to turn around - The Independent",
                       prew = "Passenger charged with ‘mischief’",
                       fulltext = "A man onboard a flight falsely claimed he had coronavirus, forcing the plane to turn around." +
                       "The WestJet service had been en route to Montego Bay, Jamaica, from Toronto, Canada, " +
                       "when the 29-year-old Canadian national announced he had the deadly virus, which …",
                       img = "/img/first_news_image.jpg",
                       author = "Helen Coffey"
                   },
                   new News
                   {
                       title = "What next for Edinburgh Ikea as chain announce first UK store closure? - Edinburgh News",
                       prew = "The Swedish giants have announced their first ever UK store closure",
                       fulltext = "Ikea says it has no plans to close its store in Edinburgh, following " +
                       "the Swedish furniture giants decision to shut an outlet in Coventry city centre." +
                       "In what will be the chains first closure of a big UK branch, the shop in the West Midlands will cease tradin …",
                       img = "/img/second_news_image.jpg",
                       author = "Joe Cawthorn"
                   },
                   new News
                   {
                       title = "Grieving mother faces shock £24,000 John Lewis card bill - The Guardian",
                       prew = "She had just lost her long-term partner when the bill landed for a card with £3,000 limit",
                       fulltext = "My 80-year-old mother has received an inexplicable credit card bill for nearly £24,000." +
                       " She acquired a John Lewis Partnership card in 2016 with a credit limit of £3,000. In 2017 she set up a direct debit" +
                       " to pay the bills and received monthly statements to sho …",
                       img = "/img/third_news_image.jpg",
                       author = "Anna Tims"
                   }
                );
            }
            #endregion
        }

    }
}
