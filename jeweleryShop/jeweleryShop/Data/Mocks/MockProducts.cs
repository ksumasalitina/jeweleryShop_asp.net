using System;
using System.Collections.Generic;
using System.Linq;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Mocks
{
    public class MockProducts : IProducts
    {
        private readonly ICategory _category = new MockCategory();

        public IEnumerable<Product> AllProducts {
            get
            {
                return new List<Product>
                {
                    new Product {
                        name = "Golden Earings",
                        description="Холодный розовый: сладкий, но не слишком терпкий, свежий, как февральский воздух. Ведь и любовь иногда щиплет, щекочет, бывает неудобной. KISS KISS – это красивая история о чувствах. ",
                        img="https://sovajewels.com/upload/iblock/c82/qnsf425em9azvzl3ai2y4d4zgo0wiyw6.jpg",
                        price=280,
                        isPopular=true,
                        available=true,
                        Category = _category.AllCategories.ElementAt(1)},

                    new Product {
                        name = "Ruby Earings",
                        description="Идеальное сочетание красок золота и камня, придающее дню яркости. Такое украшение уместно как в повседневной носке, так и в качестве подарка. Миниатюрное изделие коллекции Акварель не бросается в глаза, а потому актуально, не смотря на стиль наряда. В то же время цветной камень становится аккуратным акцентом в вашем образе.",
                        img="https://sovajewels.com/upload/iblock/255/255163c09a722f6a25894472d256b1a2.jpg",
                        price=799,
                        isPopular=false,
                        available=true,
                        Category = _category.AllCategories.ElementAt(1)},

                    new Product {
                        name = "Silver Ring",
                        description="Ко дню влюбленных мы представили праздничную коллекцию KISS KISS. Она напоминает признание в любви в конце романтического письма. Не идеальное для всех, но точно особенное для вас. ",
                        img="https://sovajewels.com/upload/iblock/d27/lwcjqpfkh5rmsc0wt06kjp0ap0ptv7i7.jpg",
                        price=450,
                        isPopular=true,
                        available=false,
                        Category = _category.AllCategories.First()},

                    new Product {
                        name = "Brilliant Ring",
                        description="Примерьте благодаря коллекции ROME образ богини, которая достойна поэтических строк и места в пантеоне. Мы хотим вдохновить вас на праздничное настроение.",
                        img="https://sovajewels.com/upload/iblock/e49/7uqlholidox120sv0ky20s52frcnp682.jpg",
                        price=1090,
                        isPopular=false,
                        available=true,
                        Category = _category.AllCategories.First()},

                    new Product {
                        name = "Golden Necklace",
                        description="Будь что будет, а ты оставайся собой, – вот что думаем о любви. Точнее, мы ее показываем в своих изделиях. Поэтому почувствуйте нашу любовь на себе.",
                        img="https://sovajewels.com/upload/iblock/7ec/um5ezt0wv772326fvfp3aaher6cpfegm.jpg",
                        price=940,
                        isPopular=true,
                        available=true,
                        Category = _category.AllCategories.ElementAt(2)},

                    new Product {
                        name = "Silver Necklace",
                        description="Muse - это коллекция о вдохновении. О том, что когда кто-то разочарован или грустный, его надо утешить",
                        img="https://sovajewels.com/upload/iblock/6d6/6d6c29b263cffaf3e6ee5bf286589f62.jpg",
                        price= 580,
                        isPopular=false,
                        available=false,
                        Category = _category.AllCategories.ElementAt(2)},

                    new Product {
                        name = "Golden Bracelet",
                        description="Каждый день мы делаем выбор. Спешим, чтобы не опоздать. Опаздываем, потому что надоедает спешить. Savanna - это напоминание о том, что иногда полезно остановиться. Оказаться в пустыне своих мыслей. Рассыпать их, отпустить.",
                        img="https://sovajewels.com/upload/iblock/4d3/4d335a49d1f62bacd89f44c2b325c098.jpg",
                        price=675,
                        isPopular=false,
                        available=true,
                        Category = _category.AllCategories.Last()},

                    new Product {
                        name = "Metal Bracelet",
                        description="Настоящая красота — в гармонии внешнего и внутреннего, в удовольствии от принятия своих состояний и черт. И если Рим доказывает это человечеству в течение трех столетий, то миссия украшений из коллекции SOVA — быть персональным напоминанием, что праздник жизни внутри вас.",
                        img="https://sovajewels.com/upload/iblock/408/oomxs00jymgyo14xf3rwgi0qg6fgtcij.jpg",
                        price=220,
                        isPopular=true,
                        available=true,
                        Category = _category.AllCategories.Last()},

                };
            }
        }

        public IEnumerable<Product> getPopulars {
            get; set;
        }

        public Product getProduct(int productID)
        {
            throw new NotImplementedException();
        }
    }
}
