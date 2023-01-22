using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Groceries.Any()) return;

            var activities = new List<Groceries>
            {
                new Groceries
                {
                    Title = "Banan",
                    Price = 29.95,
                    JmfrPris = 29.95,
                    BrandName = "Chiquita",
                    Category = "Frukt",
                    Info = "Solmogen banan",
                    CountryOfOrigin = "Costa Rica",
                    Img_url = "https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Cantaloupe Melon",
                    Price = 32.95,
                    JmfrPris = 32.95,
                    BrandName = "Cantaloupe.Melons",
                    Category = "Frukt",
                    Info = "Cantaloupe Melon",
                    CountryOfOrigin = "Australien, Waroona",
                    Img_url = "https://images.pexels.com/photos/4038763/pexels-photo-4038763.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                },
                new Groceries
                {
                    Title = "Kiwi",
                    Price = 9.95,
                    JmfrPris = 67.95,
                    BrandName = "New Zealand Kiwi Foundation",
                    Category = "Frukt",
                    Info = "Kiwi from inner New Zealand",
                    CountryOfOrigin = "New Zealand",
                    Img_url = "https://images.pexels.com/photos/849685/pexels-photo-849685.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Citron",
                    Price = 7.95,
                    JmfrPris = 49.95,
                    BrandName = "El gringo limón.mx",
                    Category = "Frukt",
                    Info = "Gul citrusfrukt",
                    CountryOfOrigin = "Mexico",
                    Img_url = "https://images.pexels.com/photos/1414122/pexels-photo-1414122.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Äpple Royal Gala",
                    Price = 25.95,
                    JmfrPris = 25.95,
                    BrandName = "Chile Apples.org",
                    Category = "Frukt",
                    Info = "Sött Äpple",
                    CountryOfOrigin = "Chile",
                    Img_url = "https://images.pexels.com/photos/10568559/pexels-photo-10568559.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Päron Conference",
                    Price = 27.95,
                    JmfrPris = 27.95,
                    BrandName = "AllPears",
                    Category = "Frukt",
                    Info = "Sött och gott päron",
                    CountryOfOrigin = "Frankrike",
                    Img_url = "https://dahab.se/media/catalog/product/cache/c33a865743098f24da0832a98845a0af/c/o/concorde-pear_variety-page_0.png",
                },
                new Groceries
                {
                    Title = "Papaya",
                    Price = 32.95,
                    JmfrPris = 32.95,
                    BrandName = "Papua New Guinea Fruits",
                    Category = "Frukt",
                    Info = "Papaya",
                    CountryOfOrigin = "Papua New Guinea",
                    Img_url = "https://images.pexels.com/photos/5507722/pexels-photo-5507722.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Kokosnöt",
                    Price = 15.95,
                    JmfrPris = 15.95,
                    BrandName = "African Nuts",
                    Category = "Frukt",
                    Info = "Ätmogen Kokosnöt",
                    CountryOfOrigin = "Zimbabwe",
                    Img_url = "https://images.pexels.com/photos/3986706/pexels-photo-3986706.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Apelsin",
                    Price = 31.95,
                    JmfrPris = 31.95,
                    BrandName = "Naranja.ES",
                    Category = "Frukt",
                    Info = "Apelsin från Andalusien",
                    CountryOfOrigin = "Spanien",
                    Img_url = "https://images.pexels.com/photos/161559/background-bitter-breakfast-bright-161559.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Clementin",
                    Price = 21.95,
                    JmfrPris = 21.95,
                    BrandName = "Maroc",
                    Category = "Frukt",
                    Info = "Clementin Marocko",
                    CountryOfOrigin = "Marocko",
                    Img_url = "https://images.pexels.com/photos/5500565/pexels-photo-5500565.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Banan EKO",
                    Price = 34.95,
                    JmfrPris = 34.95,
                    BrandName = "Dole",
                    Category = "Frukt",
                    Info = "Solmogen ekologisk banan",
                    CountryOfOrigin = "Costa Rica",
                    Img_url = "https://images.pexels.com/photos/2872755/pexels-photo-2872755.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Mango",
                    Price = 19.95,
                    JmfrPris = 99.95,
                    BrandName = "US.Mangoes",
                    Category = "Frukt",
                    Info = "Söt och ljuvlig mango",
                    CountryOfOrigin = "USA",
                    Img_url = "https://images.pexels.com/photos/2294471/pexels-photo-2294471.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Jordgubbar",
                    Price = 29.95,
                    JmfrPris = 29.95,
                    BrandName = "Bärgubben",
                    Category = "Frukt",
                    Info = "Svenska Jordgubbar",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images.pexels.com/photos/70746/strawberries-red-fruit-royalty-free-70746.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Blåbär i ask",
                    Price = 29.95,
                    JmfrPris = 121.95,
                    BrandName = "Sv.bär",
                    Category = "Frukt",
                    Info = "Odlade blåbär från södra Sverige",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images.pexels.com/photos/70862/pexels-photo-70862.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Persika",
                    Price = 32.50,
                    JmfrPris = 32.50,
                    BrandName = "Colombian fruits",
                    Category = "Frukt",
                    Info = "Solmogen persika",
                    CountryOfOrigin = "Colombia",
                    Img_url = "https://www.pexels.com/sv-se/foto/halsosam-frukt-fargrik-sot-1268122/",
                },
                new Groceries
                {
                    Title = "Passionsfrukt",
                    Price = 6.95,
                    JmfrPris = 139.95,
                    BrandName = "Pasión de Colombia",
                    Category = "Frukt",
                    Info = "50 gram ungefärlig vikt",
                    CountryOfOrigin = "Colombia",
                    Img_url = "https://www.snabbfrukt.se/wp-content/uploads/2019/10/298.jpg",
                },
                new Groceries
                {
                    Title = "Grapefrukt",
                    Price = 12.95,
                    JmfrPris = 51.95,
                    BrandName = "naranjases",
                    Category = "Frukt",
                    Info = "Klass 1, 300 gram ungefärlig vikt",
                    CountryOfOrigin = "Spanien",
                    Img_url = "https://images.pexels.com/photos/6156975/pexels-photo-6156975.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Äpple Granny Smith",
                    Price = 32.95,
                    JmfrPris = 32.95,
                    BrandName = "Italian fruits",
                    Category = "Frukt",
                    Info = "Sötsyrligt Äpple från Kalabrien",
                    CountryOfOrigin = "Italien",
                    Img_url = "https://images.pexels.com/photos/693794/pexels-photo-693794.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Gröna Druvor",
                    Price = 39.95,
                    JmfrPris = 78.95,
                    BrandName = "South African grapes",
                    Category = "Frukt",
                    Info = "Gröna Druvor 500g",
                    CountryOfOrigin = "Sydafrika",
                    Img_url = "https://cdn1.cdnme.se/4618866/8-3/vindruvor_grona_500g_mathem_59ccf1649606ee41ff5cc74e.jpg",
                },
                new Groceries
                {
                    Title = "Röda Druvor",
                    Price = 44.95,
                    JmfrPris = 89.80,
                    BrandName = "South African grapes",
                    Category = "Frukt",
                    Info = "Röda druvor 500g",
                    CountryOfOrigin = "Sydafrika",
                    Img_url = "https://images.pexels.com/photos/7214926/pexels-photo-7214926.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Gurka",
                    Price = 15.95,
                    JmfrPris = 74.95,
                    BrandName = "Svenska bönder",
                    Category = "Grönsaker",
                    Info = "Gurka klass 1 ca 260 gram",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/gurka-klass1-4.jpg",
                },
                new Groceries
                {
                    Title = "Tomat",
                    Price = 45.95,
                    JmfrPris = 45.95,
                    BrandName = "Svenska bönder",
                    Category = "Grönsaker",
                    Info = "Tomat växthus",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images.pexels.com/photos/533280/pexels-photo-533280.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                new Groceries
                {
                    Title = "Isbergssallad",
                    Price = 39.95,
                    JmfrPris = 39.95,
                    BrandName = "Svenska bönder",
                    Category = "Grönsaker",
                    Info = "Klass 1",
                    CountryOfOrigin = "Spanien",
                    Img_url = "https://upload.wikimedia.org/wikipedia/commons/6/69/Iceberg1.jpg",
                },
                new Groceries
                {
                    Title = "Grön Paprika",
                    Price = 69.95,
                    JmfrPris = 69.95,
                    BrandName = "Dr.Paprika",
                    Category = "Grönsaker",
                    Info = "Grön paprika klass 1",
                    CountryOfOrigin = "Spanien",
                    Img_url = "https://images.pexels.com/photos/2893635/pexels-photo-2893635.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                  new Groceries
                {
                    Title = "Röd Paprika",
                    Price = 69.95,
                    JmfrPris = 69.95,
                    BrandName = "Dr.Paprika",
                    Category = "Grönsaker",
                    Info = "Röd paprika klass 1",
                    CountryOfOrigin = "Spanien",
                    Img_url = "https://bilder.koketochgarden.se/Artikel/70237.png",
                },
                  new Groceries
                {
                    Title = "Gul Paprika",
                    Price = 69.95,
                    JmfrPris = 69.95,
                    BrandName = "Dr.Paprika",
                    Category = "Grönsaker",
                    Info = "Gul paprika klass 1",
                    CountryOfOrigin = "Spanien",
                    Img_url = "http://files.builder.misssite.com/97/aa/97aaab70-82f7-4e25-8cce-5c8ac06b4952.jpeg",
                },
                  new Groceries
                {
                    Title = "Gul Lök",
                    Price = 6.95,
                    JmfrPris = 6.95,
                    BrandName = "Svenska bönder",
                    Category = "Grönsaker",
                    Info = "Gul lök klass 1",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://outofhome.se/media/catalog/product/cache/30/image/17f82f742ffe127f42dca9de82fb58b1/g/u/gul-l_k.jpg",
                },
                  new Groceries
                {
                    Title = "Röd Lök",
                    Price = 19.95,
                    JmfrPris = 19.95,
                    BrandName = "Svenska Bönder",
                    Category = "Grönsaker",
                    Info = "Röd Lök klass 1",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images-bonnier.imgix.net/files/ifo/production/20210428214701/roedloeg-kdDO1LDsCnHVDXxBDYJnpw.jpg?auto=compress,format&w=1024&fit=fill&crop=focalpoint&ar=1:2%201024w",
                },
                  new Groceries
                {
                    Title = "Vitlök",
                    Price = 69.95,
                    JmfrPris = 69.95,
                    BrandName = "Chi tha",
                    Category = "Grönsaker",
                    Info = "Vitlök i lösvikt",
                    CountryOfOrigin = "Kina",
                    Img_url = "https://smakasverige.se/images/18.2423abf3149a28cf45348046/1415799796288/Vitlok.jpg",
                },
                  new Groceries
                {
                    Title = "Purjolök",
                    Price = 39.95,
                    JmfrPris = 39.95,
                    BrandName = "Netherlands veeijxthuis",
                    Category = "Grönsaker",
                    Info = "Purjolök klass 1",
                    CountryOfOrigin = "Nederländerna",
                    Img_url = "https://static.mathem.se/shared/images/products/large/purjolok-klass1-2.jpg",
                },
                  new Groceries
                {
                    Title = "Potatis Fast",
                    Price = 13.95,
                    JmfrPris = 13.95,
                    BrandName = "LPM Potatis Laholm",
                    Category = "Grönsaker",
                    Info = "Fast potatis klass 1",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images.pexels.com/photos/2286776/pexels-photo-2286776.jpeg?auto=compress&cs=tinysrgb&w=1600",
                },
                  new Groceries
                {
                    Title = "Mjölig Potatis",
                    Price = 11.95,
                    JmfrPris = 11.95,
                    BrandName = "LPM Potatis Laholm",
                    Category = "Grönsaker",
                    Info = "Mjölig potatis klass 1",
                    CountryOfOrigin = "Sverige",
                    Img_url = "http://sasongensbasta.se/wp-content/uploads/imagecache/a1/a1cdde11f04c81c8fa6e719f34063f24.jpg?i=eNpFzTESwiAQQNG7bI9ABCZuOu9g7WBAQBNggEwKxwt4Ng9lUln%2B13yNEl8Ve4Qwa2cvZYKh4mlr6tNsadU1RWcjzcttCuPVt3miayZjis3GRpc8JW0q7RjvKVP0GaIj1qy6GHIv%2BvuJpGNMEU4sl0Jwduy4VL04PLLbTxJhDaZ5GAIqxjZRCN4G59ufBMJYUt5hT84QtDHnVIwtFYbbpu8f0jw%2FOw%3D%3D&t=0621f58ff33e921d5b92090c2d3c99ac",
                },
                  new Groceries
                {
                    Title = "Ingefära",
                    Price = 79.95,
                    JmfrPris = 79.95,
                    BrandName = "Chi Hong Trading",
                    Category = "Grönsaker",
                    Info = "Ingefära klass 1",
                    CountryOfOrigin = "Kina",
                    Img_url = "https://pongmarket.se/image/1764/PMFG0007.jpg",
                },
                  new Groceries
                {
                    Title = "Vitkål",
                    Price = 19.95,
                    JmfrPris = 19.95,
                    BrandName = "Svenska Bönder",
                    Category = "Grönsaker",
                    Info = "Vitkål klass 1",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://media.istockphoto.com/id/1168999569/sv/foto/chef-f%C3%B6r-f%C3%A4rsk-vitk%C3%A5l-cutout-p%C3%A5-vit.jpg?s=612x612&w=0&k=20&c=U4hDS7AJGoa5gVdrYBBruEsM4nSj9VP4YxMdQvWHslw=",
                },
                  new Groceries
                {
                    Title = "Babyspenat Eko",
                    Price = 19.95,
                    JmfrPris = 285.00,
                    BrandName = "Svenska Bönder",
                    Category = "Grönsaker",
                    Info = "Babyspenat i påse klass 1. Vikt 80 gram",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://media.martinservera.se/fl_lossy,f_auto,w_525,h_525,c_pad,b_white/prod/martinservera/produkt/3/050/590/DV02_242214_01.png",
                },
                 new Groceries
                {
                    Title = "Mjölk",
                    Price = 21.95,
                    JmfrPris = 14.63,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Mellanmjölk från svenska kor. 1.5 liter",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/mellanmjolk-farsk-1-5--1l-arla.jpg",
                },
                  new Groceries
                {
                    Title = "Mjölk",
                    Price = 21.95,
                    JmfrPris = 14.63,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Standardmjölk från svenska kor. 1.5 liter",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn.natmat.se/content/shopimages/large/32199-165789.jpg",
                },
                  new Groceries
                {
                    Title = "Mjölk",
                    Price = 21.95,
                    JmfrPris = 14.63,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Lättmjölk från svenska kor. 1.5 liter",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://d2rfo6yapuixuu.cloudfront.net/h17/hac/13572700635166/7310865001115_1667378431648_master_axfood_400",
                },
                  new Groceries
                {
                    Title = "Vispgrädde 40%",
                    Price = 28.95,
                    JmfrPris = 58.95,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Vispgrädde från svenska kor. 500 ml",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn-kund.arla.se/remote/api.opv.se/WS/Arla/HierarchyService/v122/thumbnails/px500/vbjc4a75cijy3yv5nkycwyu6zq000000.Png",
                },
                  new Groceries
                {
                    Title = "Creme Fraiche 500 gram",
                    Price = 32.95,
                    JmfrPris = 87.50,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Creme Fraiche från svenska kor. 500 ml",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/07310865003775_c1c1.jpg",
                },
                  new Groceries
                {
                    Title = "Bregott Normalsaltat",
                    Price = 62.95,
                    JmfrPris = 125.90,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Normalsaltad matfettsblandning från svenska kor. 500 g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://thumb.mp-farm.com/66255202/preview.jpg",
                },
                new Groceries
                {
                    Title = "Bregott Extrasaltat",
                    Price = 62.95,
                    JmfrPris = 125.90,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Extrasaltad matfettsblandning från svenska kor. 500 g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images.opv.se/v120/thumbnails/px400/4433o44vkzz3zygjyeak3gqtca000000.Png",
                },
                new Groceries
                {
                    Title = "Bregott Mellan",
                    Price = 62.95,
                    JmfrPris = 125.90,
                    BrandName = "Arla",
                    Category = "Mejeri",
                    Info = "Mellan matfettsblandning från svenska kor. 500 g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://images.opv.se/v120/thumbnails/px400/3y7qdim2gticbzrzyqmuurswoa000000.Png",
                },
                new Groceries
                {
                    Title = "Apelsin Juice 2 liter",
                    Price = 32.95,
                    JmfrPris = 16.47,
                    BrandName = "Bravo",
                    Category = "Mejeri",
                    Info = "Apelsin Juice 2 liter",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://bravo.nu/wp-content/uploads/2022/06/2l_bravo_apelsin_v-454x1024.jpg",
                },
                new Groceries
                {
                    Title = "Äpple Juice 2 liter",
                    Price = 32.95,
                    JmfrPris = 16.47,
                    BrandName = "Bravo",
                    Category = "Mejeri",
                    Info = "Äpple Juice 2 liter",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://res.cloudinary.com/coopsverige/images/e_sharpen,f_auto,fl_clip,fl_progressive,q_90,c_lpad,g_center,h_330,w_330/v1664274829/cloud/259225/Juice%20%C3%84pple.jpg",
                },
                new Groceries
                {
                    Title = "Ägg 20-Pack",
                    Price = 62.95,
                    JmfrPris = 3.14,
                    BrandName = "Kronägg",
                    Category = "Mejeri",
                    Info = "Ägg klass 1 Sverige Mellan",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://d1ax460061ulao.cloudfront.net/500x500/9/1/917f7976e5476a2a7b2f30843f17c67a.jpg",
                },
                new Groceries
                {
                    Title = "Ägg 10-Pack",
                    Price = 33.95,
                    JmfrPris = 3.39,
                    BrandName = "Kronägg",
                    Category = "Mejeri",
                    Info = "Ägg klass 1 Sverige Mellan",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.kronagg.se/images/2920/07310067443416_c1c1.jpg?width=1200&height=630&bgcolor=fff",
                },
                new Groceries
                {
                    Title = "Ägg 6-Pack",
                    Price = 24.95,
                    JmfrPris = 4.15,
                    BrandName = "Kronägg",
                    Category = "Mejeri",
                    Info = "Ägg klass 1 Sverige Mellan",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/07310060004348_c1l1.jpeg.jpg",
                },
                new Groceries
                {
                    Title = "Yoggi Vanilj",
                    Price = 27.95,
                    JmfrPris = 27.95,
                    BrandName = "Yoggi",
                    Category = "Mejeri",
                    Info = "Yoghurt Vanilj 1000 gram",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.mardskog.se/images/thumbs/0002858_yoggi-vanilj-madagaskar-6x1l.jpeg",
                },
                  new Groceries
                {
                    Title = "Yoggi Skogsbär",
                    Price = 27.95,
                    JmfrPris = 27.95,
                    BrandName = "Yoggi",
                    Category = "Mejeri",
                    Info = "Yoghurt Skogsbär 1000 gram",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/07310865018472_c1l1.jpg",
                },
                  new Groceries
                {
                    Title = "Yoggi Samoa",
                    Price = 27.95,
                    JmfrPris = 27.95,
                    BrandName = "Yoggi",
                    Category = "Mejeri",
                    Info = "Yoghurt Samoa 1000 gram",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://media.martinservera.se/fl_lossy,f_auto,w_525,h_525,c_pad,b_white/prod/martinservera/produkt/3/051/763/DV02_430330_01.png",
                },
                  new Groceries
                {
                    Title = "Yoggi Mini Jordgubb",
                    Price = 27.95,
                    JmfrPris = 27.95,
                    BrandName = "Yoggi",
                    Category = "Mejeri",
                    Info = "Yoghurt Mini Jordgubb 1000 gram",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/yoggi-mini-yoghurt-jordgubb-1l-arla.jpg",
                },
                  new Groceries
                {
                    Title = "Falukorv Ring",
                    Price = 46.95,
                    JmfrPris = 38.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "1500g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn.natmat.se/content/shopimages/large/37472-57365.jpg",
                },
                new Groceries
                {
                    Title = "Bacon 3-pack",
                    Price = 39.95,
                    JmfrPris = 99.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "140 gram x 3",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn.natmat.se/content/shopimages/large/37484-54145.jpg",
                },
                new Groceries
                {
                    Title = "Kokt skinka",
                    Price = 22.95,
                    JmfrPris = 229.90,
                    BrandName = "Pärsons",
                    Category = "Kött & Chark",
                    Info = "Pålägg 100g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://assets.icanet.se/t_product_large_v1,f_auto/7330797077132.jpg",
                },
                new Groceries
                {
                    Title = "Rökt skinka",
                    Price = 22.95,
                    JmfrPris = 229.90,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "Pålägg 100g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://d2vvd32x83pgg5.cloudfront.net/hc1/h47/8974959280158/7330797077149_master_1648466440090_axfood_333",
                },
                new Groceries
                {
                    Title = "Rökt Kalkon",
                    Price = 22.95,
                    JmfrPris = 229.90,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "Pålägg 100g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/07330797077118_2.jpg",
                },
                new Groceries
                {
                    Title = "Cognacsmedwurst",
                    Price = 22.95,
                    JmfrPris = 229.90,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "Pålägg 100g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn.natmat.se/content/shopimages/large/162997-7330797770514.jpg",
                },
                new Groceries
                {
                    Title = "Blandfärs",
                    Price = 94.95,
                    JmfrPris = 94.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn.natmat.se/content/shopimages/large/113341-blandfars-ca-1000g-scan.jpg",
                },
                new Groceries
                {
                    Title = "Nötfärs 10%",
                    Price = 114.95,
                    JmfrPris = 114.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/notfars-10--ca-1000g-scan.jpg",
                },
                new Groceries
                {
                    Title = "Fläskfärs",
                    Price = 87.95,
                    JmfrPris = 87.95,
                    BrandName = "Garant",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://d1ax460061ulao.cloudfront.net/1000x1000/5/9/59f384ee61950dfcbf8594ac2b6c6b27.jpg",
                },
                new Groceries
                {
                    Title = "Karré Benfri",
                    Price = 89.95,
                    JmfrPris = 89.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.recepten.se/bilder/info/345/main/l/benfri_karree.jpg",
                },
                new Groceries
                {
                    Title = "Ryggbiff med kappa",
                    Price = 239.95,
                    JmfrPris = 239.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://dabas.blob.core.windows.net/media/martin-servera/168211_01.jpg",
                },
                new Groceries
                {
                    Title = "Fransyska av Nöt",
                    Price = 89.95,
                    JmfrPris = 89.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://svensktkott.se/wp-content/uploads/2019/11/n-fransyska.jpg",
                },
                new Groceries
                {
                    Title = "Fläskfilé Sverige",
                    Price = 189.95,
                    JmfrPris = 189.95,
                    BrandName = "Scan",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZQn6O6W2g3idbH0Imn8JtrKCb6Or-OV8ftg&usqp=CAU",
                },
                new Groceries
                {
                    Title = "Kycklingbröstfilé",
                    Price = 189.95,
                    JmfrPris = 189.95,
                    BrandName = "Kronfågel",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.recepten.se/bilder/info/5/main/l/kyckling.jpg",
                },
                new Groceries
                {
                    Title = "Kycklinglårfilé",
                    Price = 229.95,
                    JmfrPris = 229.95,
                    BrandName = "Kronfågel",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.menigo.se/globalassets/inriver/resources/407244_1.jpg?h=960&mode=max&quality=75&ref=157792&w=960",
                },
                new Groceries
                {
                    Title = "Kycklingklubba",
                    Price = 75.95,
                    JmfrPris = 75.95,
                    BrandName = "Kronfågel",
                    Category = "Kött & Chark",
                    Info = "ca 1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://cdn.kronfagel.se/app/uploads/2019/09/7849_7849_Klycklingklubba.png",
                },
                new Groceries
                {
                    Title = "Pasta Fusili",
                    Price = 14.95,
                    JmfrPris = 29.80,
                    BrandName = "Barilla",
                    Category = "Kolonial",
                    Info = "500g",
                    CountryOfOrigin = "Italien",
                    Img_url = "https://static.mathem.se/shared/images/products/large/08076802085981_d1c1.jpg",
                },
                new Groceries
                {
                    Title = "Pasta Penne",
                    Price = 14.95,
                    JmfrPris = 29.80,
                    BrandName = "Barilla",
                    Category = "Kolonial",
                    Info = "500g",
                    CountryOfOrigin = "Italien",
                    Img_url = "https://images.deliveryhero.io/image/product-information-management/624d793bc7f8495d9a0920cd.png?height=400",
                },
                new Groceries
                {
                    Title = "Pasta Farfalle",
                    Price = 14.95,
                    JmfrPris = 29.80,
                    BrandName = "Barilla",
                    Category = "Kolonial",
                    Info = "500g",
                    CountryOfOrigin = "Italien",
                    Img_url = "https://res.cloudinary.com/coopsverige/images/e_sharpen,f_auto,fl_clip,fl_progressive,q_90,c_lpad,g_center,h_330,w_330/v1656410915/cloud/254621/Pasta%20Farfalle.jpg",
                },
                new Groceries
                {
                    Title = "Pasta Ruote",
                    Price = 14.95,
                    JmfrPris = 29.80,
                    BrandName = "Barilla",
                    Category = "Kolonial",
                    Info = "500g",
                    CountryOfOrigin = "Italien",
                    Img_url = "https://www.miaspesa.it/image/resize-big?img=https%3A%2F%2Fd21mug5vzt7ic2.cloudfront.net%2Fcarrefour%2F52010%2Fresize%2F52010_1.jpg",
                },
                new Groceries
                {
                    Title = "Krossade Tomater",
                    Price = 14.95,
                    JmfrPris = 29.80,
                    BrandName = "Mutti",
                    Category = "Kolonial",
                    Info = "500g",
                    CountryOfOrigin = "Italien",
                    Img_url = "https://mutti-parma.com/app/uploads/sites/14/2019/10/polpa-400g-hires-nordic-768x1165.png",
                },
                new Groceries
                {
                    Title = "Tortilla Medium 8-pack",
                    Price = 18.95,
                    JmfrPris = 59.22,
                    BrandName = "Santa Maria",
                    Category = "Kolonial",
                    Info = "320g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.santamariaworld.com/globalassets/_products/tex-mex/102059.png",
                },
                new Groceries
                {
                    Title = "Havregryn",
                    Price = 14.95,
                    JmfrPris = 22.42,
                    BrandName = "AXA",
                    Category = "Kolonial",
                    Info = "1500g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://media.delitea.se/product-images/XL/axa-havregryn-1.5kg-1.jpg",
                },
                new Groceries
                {
                    Title = "Vetemjöl",
                    Price = 18.95,
                    JmfrPris = 18.95,
                    BrandName = "Kungsörnen",
                    Category = "Kolonial",
                    Info = "1000g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://static.mathem.se/shared/images/products/large/07310130006043_c1n1.jpg",
                },
                new Groceries
                {
                    Title = "Strösocker",
                    Price = 21.95,
                    JmfrPris = 21.95,
                    BrandName = "Dan Sukker",
                    Category = "Kolonial",
                    Info = "1000g",
                    CountryOfOrigin = "Danmark",
                    Img_url = "https://www.dansukker.se/Admin/Public/GetImage.ashx?image=%2FFiles%2Fproduct-cataloge%2Fproduct_large%2Fstrosocker-1kg.png&width=640&format=webp",
                },
                new Groceries
                {
                    Title = "Chips Sourcream & Onion",
                    Price = 22.95,
                    JmfrPris = 102.95,
                    BrandName = "Estrella",
                    Category = "Kolonial",
                    Info = "275g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.estrella.se/content/uploads/2020/04/thumbnails/estrella-sourcream-onion-chips-275g-175g-40g-83012-500x800.png",
                },
                new Groceries
                {
                    Title = "Chips Grill",
                    Price = 22.95,
                    JmfrPris = 102.95,
                    BrandName = "Estrella",
                    Category = "Kolonial",
                    Info = "275g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://media.delitea.se/product-images/XL/est-grillchips-40g-0.jpg",
                },
                new Groceries
                {
                    Title = "Chips Dill",
                    Price = 22.95,
                    JmfrPris = 102.95,
                    BrandName = "Estrella",
                    Category = "Kolonial",
                    Info = "275g",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.estrella.se/content/uploads/2020/04/estrella-dillchips-275g-175g-688x1024.png",
                },
                new Groceries
                {
                    Title = "Hushållspapper 4-pack",
                    Price = 39.95,
                    JmfrPris = 68.57,
                    BrandName = "Lambi",
                    Category = "Kolonial",
                    Info = "4 st",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.officedepot.se/-/media/commerce/sweden/original/85/58/8558063.jpg?bc=white&h=700&w=700&hash=10CC5DBD97687887DEB90A58E6366CB227B5911E",
                },
                new Groceries
                {
                    Title = "Toalettpapper 8-pack",
                    Price = 39.95,
                    JmfrPris = 68.57,
                    BrandName = "Lambi",
                    Category = "Kolonial",
                    Info = "8 st",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://res.cloudinary.com/coopsverige/images/e_sharpen,f_auto,fl_clip,fl_progressive,q_90,c_lpad,g_center,h_330,w_330/v1612136410/419317/Toalettpapper%20Classic%208-pack.jpg",
                },
                new Groceries
                {
                    Title = "Duschgel Axe Dark Temptation",
                    Price = 32.50,
                    JmfrPris = 130.00,
                    BrandName = "Axe",
                    Category = "Kolonial",
                    Info = "Duschgel man",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://www.tvattgiganten.se/wp-content/uploads/2016/11/AXE-Dark-Temptation.png",
                },
                new Groceries
                {
                    Title = "Duschgel Axe Black",
                    Price = 32.50,
                    JmfrPris = 130.00,
                    BrandName = "Axe",
                    Category = "Kolonial",
                    Info = "Duschgel man",
                    CountryOfOrigin = "Sverige",
                    Img_url = "https://c-of.niceshops.com/upload/image/product/large/default/axe-duschgel-black-250-ml-272404-sv.jpg",
                },

            };

            await context.Groceries.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}
