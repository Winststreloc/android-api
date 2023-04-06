﻿using System.Text.RegularExpressions;
using AndroidAPI.Interface;
using AndroidAPI.Models.Responce;

namespace AndroidAPI.Data;

public class PizzaDATA : IPizzaData
{
    public List<List<ProductItemResponse>> GetMenu()
    {
        return new List<List<ProductItemResponse>>
        {
            new List<ProductItemResponse>
            {
                new ProductItemResponse(1,
                    "Пепперони",
                    "Томатный соус, пикантная пепперони, моцарелла",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/70834e6311c0483493bf2279dbc1718d_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 13.9 },
                        { "Средняя", 22.9 },
                        { "Большая", 27.9 }
                    }),
                new ProductItemResponse(2,
                    "Гавайская",
                    "Ветчина, ананасы, моцарелла, томатный соус",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/c16bf6aa92ba4792805e1a3d4522ab65_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 17.9 },
                        { "Средняя", 25.9 },
                        { "Большая", 29.9 }
                    }),
                new ProductItemResponse(3,
                    "Маргарита",
                    "Итальянские травы, томатный соус, томаты, моцарелла",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/a10ad669c5054be2b019613e5cfd2477_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 17.9 },
                        { "Средняя", 25.9 },
                        { "Большая", 29.9 }
                    }),
                new ProductItemResponse(4,
                    "Колбаски Барбекю",
                    "Острые колбаски чоризо, соус барбекю, томаты, красный лук, моцарелла, томатный соус",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/5652bea74e0e4deba4736cf47927bfa8_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 17.9 },
                        { "Средняя", 25.9 },
                        { "Большая", 29.9 }
                    }),
                new ProductItemResponse(5,
                    "Сырная",
                    "Моцарелла, сыры чеддер и пармезан, соус альфредо",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/c04ab5bb5c824108ac857043bc8f8751_366x366.webp",
                    "Пицца",
                    new Dictionary<string, double> { { "Маленькая", 11.9 }, { "Средняя", 19.9 }, { "Большая", 25.9 } }),
                new ProductItemResponse(6,
                    "Пепперони фреш",
                    "Томаты, пепперони, моцарелла, томатный соус",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/ad96af75a4424d16a68439242840f605_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double> { { "Маленькая", 11.9 }, { "Средняя", 19.9 }, { "Большая", 25.9 } }),
                new ProductItemResponse(7,
                    "Диабло",
                    "Острые колбаски чоризо, острый перец халапеньо, соус барбекю, митболы из говядины, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/665733171e894c2991d0bdb4cab4e1b7_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double> { { "Маленькая", 20.9 }, { "Средняя", 28.4 }, { "Большая", 32.4 } }),
                new ProductItemResponse(8,
                    "Ветчина и сыр",
                    "Моцарелла, ветчина, соус альфредо",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/bdc5caa51bd64af1b8712fc03aeaf386_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double> { { "Маленькая", 13.9 }, { "Средняя", 22.9 }, { "Большая", 27.9 } }),
                new ProductItemResponse(9,
                    "Сырный цыпленок",
                    "Цыпленок, моцарелла, сыры чеддер и пармезан, сырный соус, томаты, соус альфредо, чеснок\n",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/2d8ceb3abd6646c5a7012916a720e9ed_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 20.9 },
                        { "Средняя", 28.4 },
                        { "Большая", 32.4 }
                    }),
                new ProductItemResponse(10,
                    "Четыре сыра",
                    "Моцарелла, сыры чеддер и пармезан, сырный соус, томаты, соус альфредо, чеснок",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/91e62f95cea14ceebc06fe046e03e759_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 20.9 },
                        { "Средняя", 28.4 },
                        { "Большая", 32.4 }
                    }),
                new ProductItemResponse(11,
                    "Мясная",
                    "Острая чоризо, томатный соус, цыпленок, пикантная пепперони, моцарелла, ветчина",
                    "https://dodopizza-a.akamaihd.net/static/Img/Products/4fa4de77d8a34912830cfdbedfaff698_760x760.webp",
                    "Пицца",
                    new Dictionary<string, double>
                    {
                        { "Маленькая", 19.9 },
                        { "Средняя", 26.4 },
                        { "Большая", 30.4 }
                    }),
            },
            new List<ProductItemResponse>
            {
                new ProductItemResponse(12,
                    "Гамбургер",
                    "Рубленый бифштекс из натуральной цельной говядины на карамелизованной булочке, заправленной горчицей, кетчупом, луком и кусочком маринованного огурчика",
                    "https://ma-prod-cdn.mcdonalds.ru/product/bbb6f3fb03b14f1ea0ab31aa925a7712/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double>
                    {
                        { "price", 3.0 }
                    }),
                new ProductItemResponse(13,
                    "Чизбургер",
                    "Рубленый бифштекс из натуральной цельной говядины с кусочками сыра Чеддер на карамелизованной булочке, заправленной горчицей, кетчупом, луком и кусочком маринованного огурчика",
                    "https://ma-prod-cdn.mcdonalds.ru/product/dac6ea5f7ad54081a92f9f644b97d717/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 4.0 } }),
                new ProductItemResponse(14,
                    "Двойной Чизбургер",
                    "Два рубленых бифштекса из натуральной цельной говядины с двумя кусочками сыра Чеддер на карамелизованной булочке, заправленной горчицей, кетчупом, луком и двумя кусочками маринованного огурчика",
                    "https://ma-prod-cdn.mcdonalds.ru/product/129b7f8976fc4bd6ba13a9b87a3bbed5/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 6.0 } }),
                new ProductItemResponse(15,
                    "Биг Хит",
                    "Легендарный бургер с двумя рублеными бифштексами из 100% говядины, маринованными огурчиками, свежим салатом «Айсберг», ломтиком плавленого сыра Чеддер и специальным соусом «Биг Хит» на новой булочке с двумя видами кунжута",
                    "https://ma-prod-cdn.mcdonalds.ru/product/c8718aba15b44562ac143acc7a82a627/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 6.0 } }),
                new ProductItemResponse(16,
                    "Биг Спешиал Джуниор",
                    "Бургер с рубленым бифштексом из 100% говядины на булочке с кунжутом, два кусочка сыра Эмменталь, свежий салат, лук, ломтик помидора и особенный соус Гриль с дымком.",
                    "https://ma-prod-cdn.mcdonalds.ru/product/b5bbc36e53d944dca624250ab1367f95/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 7.9 } }),
                new ProductItemResponse(17,
                    "Гранд",
                    "Сочный бифштекс из натуральной говядины, приготовленный на гриле, карамелизованная булочка с кунжутом, два ломтика сыра Чеддер, кетчуп, горчица, свежий лук и маринованные огурчики",
                    "https://ma-prod-cdn.mcdonalds.ru/product/514c14937f7943d58bb5e60750d03115/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 7.9 } }),
                new ProductItemResponse(18,
                    "Гранд Де Люкс",
                    "Сочный бифштекс из натуральной говядины, приготовленный на гриле, карамелизованная булочка с кунжутом, два ломтика сыра Чеддер, свежий салат, кусочек помидора и лук, маринованные огурчики, кетчуп, горчица и специальный соус",
                    "https://ma-prod-cdn.mcdonalds.ru/product/a61d77d4a7894ff3b225b2286ffe1ac3/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 9.9 } }),
                new ProductItemResponse(19,
                    "Двойной Гранд",
                    "Два сочных бифштекса из натуральной говядины, приготовленных на гриле, карамелизованная булочка с кунжутом, два ломтика сыра Чеддер, лук, маринованные огурчики, кетчуп и горчица",
                    "https://ma-prod-cdn.mcdonalds.ru/product/16122f69741b44c4998fb2ee227c7d43/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 9.9 } }),
                new ProductItemResponse(20,
                    "Биг Спешиал Ростбиф",
                    "Неповторимый сандвич с большим рубленым бифштексом из 100% говядины, сочными ломтиками Ростбифа, пряным соусом Релиш с зернами горчицы, сыром Эмменталь, свежими овощами и знаменитым соусом с дымком на большой булочке с кунжутом.",
                    "https://ma-prod-cdn.mcdonalds.ru/product/1c7557ba08864f009f34608bf939d1ea/android/l/main.png",
                    "Бургеры",
                    new Dictionary<string, double> { { "price", 11.9 } }),
            },
            new List<ProductItemResponse>
            {
                new ProductItemResponse(21,
                    "Ролл с лососем",
                    "Классический ролл с лососем.",
                    "https://i.imgur.com/GKfb02E.png",
                    "Роллы",
                    new Dictionary<string, double>
                    {
                        { "4 шт.", 5.0 },
                        { "8 шт.", 9.0 },
                        { "12 шт.", 14.0 }
                    }),
                new ProductItemResponse(22,
                    "Капоэйра",
                    "Классический ролл с огурцом и сыром сливочным.",
                    "https://i.imgur.com/jq3qh5g.png",
                    "Роллы",
                    new Dictionary<string, double>
                    {
                        { "4 шт.", 5.9 },
                        { "8 шт.", 10.0 },
                        { "12 шт.", 15.9 }
                    }),
                new ProductItemResponse(23,
                    "Филадельфия",
                    "Лосось, огурец, сыр сливочный.",
                    "https://i.imgur.com/3w77BBD.png",
                    "Роллы",
                    new Dictionary<string, double>
                    {
                        { "4 шт.", 7.9 },
                        { "8 шт.", 15.0 },
                        { "12 шт.", 18.9 }
                    }),
                new ProductItemResponse(24,
                    "Филадельфия лайт",
                    "Лосось, огурец, сыр сливочный.",
                    "https://i.imgur.com/2AzVKmA.png",
                    "Роллы",
                    new Dictionary<string, double>
                    {
                        { "4 шт.", 6.9 },
                        { "8 шт.", 13.0 },
                        { "12 шт.", 19.9 }
                    }),
                new ProductItemResponse(25,
                    "Калифорния с крабом",
                    "Крабовые палочки с майонезом, соус хондаши, огурец, авокадо, икра масаго оранжевая.",
                    "https://i.imgur.com/wP3ahpw.png",
                    "Роллы",
                    new Dictionary<string, double>()
                    {
                        { "4 шт.", 7.9 },
                        { "8 шт.", 15.0 },
                        { "12 шт.", 18.9 }
                    }),
                new ProductItemResponse(26,
                    "Креветка в деле",
                    "Креветки темпура, авокадо, кляр, сухари панко, сыр сливочный, соус Свит чили, соус Унаги, белый кунжут.",
                    "https://i.imgur.com/a6heLWE.png",
                    "Роллы",
                    new Dictionary<string, double>()
                    {
                        { "4 шт.", 8.9 },
                        { "8 шт.", 15.9 },
                        { "12 шт.", 20.0 }
                    }),
                new ProductItemResponse(27,
                    "Техасская резня",
                    "Сыр сливочный, Филе куриное варено-копченое, Помидор, Кляр, Сухари панировочные, Соус Гриль хайнс, Соус унаги, Белый кунжут",
                    "https://i.imgur.com/52Fisyq.png",
                    "Роллы",
                    new Dictionary<string, double>()
                    {
                        { "4 шт.", 8.9 },
                        { "8 шт.", 16.0 },
                        { "12 шт.", 21.0 }
                    }),
                new ProductItemResponse(28,
                    "Теплый",
                    "Сыр сливочный, тунец, лук зеленый, кляр, сухари панировочные, соус сырный Heinz, соус васаби микс, соус унаги, рисовые шарики.",
                    "https://i.imgur.com/74qjh7e.png",
                    "Роллы",
                    new Dictionary<string, double>()
                    {
                        { "4 шт.", 7.9 },
                        { "8 шт.", 15.0 },
                        { "12 шт.", 18.9 }
                    }),
                new ProductItemResponse(29,
                    "Мидори",
                    "Кунжут белый, тунец, такуан, сыр сливочный, соус васаби микс, икра масаго оранжевая, кунжут черный.",
                    "https://i.imgur.com/eQyKhwR.png",
                    "Роллы",
                    new Dictionary<string, double>
                    {
                        { "4 шт.", 8.9 },
                        { "8 шт.", 16.0 },
                        { "12 шт.", 23.9 }
                    }),
            },
            new List<ProductItemResponse>
            {
                new ProductItemResponse(30,
                    "Картофель Фри",
                    "Картофель Фри - это вкусные, обжаренные в растительном фритюре и слегка посоленные палочки картофеля.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/436709097-grand-fri-600x600.png",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
                new ProductItemResponse(31,
                    "Картофель по-деревенски",
                    "Картофель по-деревенски - это вкусные, обжаренные в растительном фритюре ломтики картофеля со специями.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/633541452-kartofel-po-derevenski-600x600.png",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
                new ProductItemResponse(32,
                    "Луковые кольца ",
                    "Луковые кольца - это вкуснейшие луковые кольца в хрустящей панировке, обжаренные во фритюре.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/103534747-lukovye-koltsa-600x600.png",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
                new ProductItemResponse(33,
                    "Креветки",
                    "Креветки - это королевские креветки в хрустящей панировке. Еще аппетитнее с соусом 1000 островов. Легко. Изысканно. Вкусно.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/877680964-krevetki-600x600.png",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
                new ProductItemResponse(333,
                    "Наггетсы",
                    "Наши наггетсы сделаны из нежного белого куриного мяса в легкой хрустящей панировке. Рекомендуем к ним восемь разных, но одинаково вкусных соусов на выбор: сырный, кетчуп, барбекю, кисло-сладкий, карри, чесночный, горчичный.",
                    "https://orderapp-static.burgerkingrus.ru/x256/mobile_image/c554221ac0154021767705addbedbcff.webp",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
                new ProductItemResponse(34,
                    "Сырные Медальоны",
                    "Горячие дольки нежного сыра с хрустящей корочкой. Идеально с любимым соусом!",
                    "https://orderapp-static.burgerkingrus.ru/x256/mobile_image/3042b37865c22eb8c83290b21d07d2c3.webp",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
                new ProductItemResponse(35,
                    "Крылышки",
                    "Крылышки по фирменному рецепту отлично подойдут как закуска к обеду или пиву.",
                    "https://orderapp-static.burgerkingrus.ru/x256/mobile_image/fcd39a2a1c5d69d0c5a34a1144deb502.webp",
                    "Закуски",
                    new Dictionary<string, double> { { "price", 3.0 } }),
            },
            new List<ProductItemResponse>
            {
                new ProductItemResponse(36,
                    "Кока-Кола",
                    "Прохладительный газированный напиток «Кока-Кола».",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/333973051-koka-kola-0-4l-600x600.jpg",
                    "Напитки",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }),
                new ProductItemResponse(37,
                    "Кока-Кола Зеро",
                    "Прохладительный газированный напиток «Кока-Кола Зеро» не содержит калорий.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/7149840-koka-kola-zero-0-4l-600x600.jpg",
                    "Напитки",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }),
                new ProductItemResponse(38,
                    "Фанта",
                    "Прохладительный газированный напиток Фанта. Содержит источник фенилаланина.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/411939992-fanta-0-4l-600x600.jpg",
                    "Напитки",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }),
                new ProductItemResponse(39,
                    "Спрайт",
                    "Прохладительный газированный напиток Спрайт. Содержит источник фенилаланина.",
                    "https://mcdonaldsmenu.ru/image/cache/catalog/photo/950632087-sprajt-0-4l-600x600.jpg",
                    "Напитки",
                    new Dictionary<string, double>
                    {
                        { "0,3 л.", 3.0 },
                        { "0,5 л.", 3.9 },
                        { "0,8 л.", 4.9 }
                    }),
                new ProductItemResponse(300,
                    "Липтон Айс Ти Лимон",
                    "Прохладительный напиток со вусом лимона Липтон Айс Ти Лимон.",
                    "https://ma-prod-cdn.mcdonalds.ru/product/ef8dea8d706343a5bf528a1386f31809/android/l/main.png",
                    "Напитки",
                    new Dictionary<string, double>
                    {
                        { "0,3 л.", 3.0 },
                        { "0,5 л.", 3.9 },
                        { "0,8 л.", 4.9 }
                    }),
                new ProductItemResponse(40,
                    "Липтон Айс Ти Зеленый",
                    "Прохладительный напиток со вкусом зеленого чая Липтон Айс Ти Зеленый Чай.",
                    "https://ma-prod-cdn.mcdonalds.ru/product/586e58ad917d4741a9573f0fb1d1b275/android/l/main.png",
                    "Напитки",
                    new Dictionary<string, double>
                    {
                        { "0,3 л.", 3.0 },
                        { "0,5 л.", 3.9 },
                        { "0,8 л.", 4.9 }
                    }),
                new ProductItemResponse(41,
                    "Фраппе Мокко 0,3 л.",
                    "Однородный кремообразный сливочный напиток без крупных кубиков льда. Имеет умеренный кофейно-шоколадный вкус. Сверху напиток украшается взбитыми сливками и шоколадным соусом.",
                    "https://ma-prod-cdn.mcdonalds.ru/product/2dd9098436914c138f470a51de3b744e/android/l/main.png",
                    "Напитки",
                    new Dictionary<string, double>
                    {
                        { "price", 4.2 }
                    }),
                    new ProductItemResponse(42,
                        "Фраппе Карамельный 0,3 л.",
                        "Однородный кремообразный сливочный напиток без крупных кубиков льда. Имеет умеренный кофейно-карамельный вкус. Сверху напиток украшается взбитыми сливками и карамельным соусом.",
                        "https://ma-prod-cdn.mcdonalds.ru/product/45d0ac066ef3480f8c664031a4be811b/android/l/main.png",
                        "Напитки",
                        new Dictionary<string, double> { { "price", 4.2 } }
                    ),
                    new ProductItemResponse(43,
                        "Фраппе Клубничный 0,3 л.",
                        "Однородный кремообразный сливочный напиток без крупных кубиков льда. Имеет умеренный клубничный вкус. Сверху напиток украшается взбитыми сливками и клубничным соусом.",
                        "https://ma-prod-cdn.mcdonalds.ru/product/85c23398edc94caaa04c06fa25c82e8b/android/l/main.png",
                        "Напитки",
                        new Dictionary<string, double> { { "price", 4.2 } }
                    )
            },
            new List<ProductItemResponse>()
            {
                new ProductItemResponse(44,
                    "Соус Сырный",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/86ca25c7c9974a9bb9c35aa034ea2030/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }
                ),
                new ProductItemResponse(45,
                    "Соус Кисло-сладкий",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/b3fee6dbfafd454eb1f45793d4237e37/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }
                ),
                new ProductItemResponse(46,
                    "Соус Терияки",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/8a973ecabfc94f75824ec8d4d02fc99b/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }
                ),
                new ProductItemResponse(47,
                    "Соус 1000 островов",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/906541842b014f68b5426753d9a06cb9/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }),
                new ProductItemResponse(48,
                    "Соус Чесночный",
                    "Пикантный соус с нежным сливочно-чесночным вкусом.",
                    "https://ma-prod-cdn.mcdonalds.ru/product/d7a5df9c3d564eb9882485fc8a111af6/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }),
                new ProductItemResponse(49,
                    "Соус Горчичный",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/83d227a56b334ac38fd7a12bb1a2d0b8/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double>
                        { { "0,3 л.", 3.0 }, { "0,5 л.", 3.9 }, { "0,8 л.", 4.9 } }),
                new ProductItemResponse(50,
                    "Кетчуп",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/2c3b57c271484267a13789d346d54492/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double> { { "price", 4.2 } }),
                new ProductItemResponse(51,
                    "Соус Сладкий чили",
                    "Классический соус тайской кухни, острый и в то же время сладкий!",
                    "https://ma-prod-cdn.mcdonalds.ru/product/48cc3ee16e19447ba7daf02bc36ec586/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double> { { "price", 4.2 } }),
                new ProductItemResponse(52,
                    "Соус Барбекю",
                    "",
                    "https://ma-prod-cdn.mcdonalds.ru/product/33da0fc8a9ff478abe27bf92444b0c95/android/l/main.png",
                    "Соусы",
                    new Dictionary<string, double> { { "price", 4.2 } })
            },
        };
    }
    public List<string> GetCategories() {
        return new List<string> {"Все", "Пицца", "Бургеры", "Роллы", "Закуски", "Напитки", "Соусы"};
    }

    public ProductItemResponse? GetProductById(int id)
    {
        var data = GetMenu();
        return data.SelectMany(l => l).FirstOrDefault(p => p.Id == id);
    }

    public List<ProductItemResponse> GetSearchResult(string searchString)
    {
        var data = GetMenu().SelectMany(l => l);
        return data.Where(t => 
            t.Name.ToLower().Contains(Regex.Escape(searchString).ToLower())
        ).ToList();
    }

    public List<ProductItemResponse> GetTechnicByCategory(string category)
    {
        var data = GetMenu().SelectMany(d => d).ToList();
        return data.Where(t => t.Category == category).ToList();
    }
}