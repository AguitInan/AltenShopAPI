using ProductCore.Models;

namespace ProductCore.Datas
{
    public static class InitialProduct
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product { Id = 1000, Code = "f230fh0g3", Name = "Bamboo Watch", Description = "Product Description", Image = "bamboo-watch.jpg", Price = 65, Category = "Accessories", Quantity = 24, InventoryStatus = "INSTOCK", Rating = 5 },
            new Product { Id = 1001, Code = "nvklal433", Name = "Black Watch", Description = "Product Description", Image = "black-watch.jpg", Price = 72, Category = "Accessories", Quantity = 61, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1002, Code = "zz21cz3c1", Name = "Blue Band", Description = "Product Description", Image = "blue-band.jpg", Price = 79, Category = "Fitness", Quantity = 2, InventoryStatus = "LOWSTOCK", Rating = 3 },
            new Product { Id = 1003, Code = "244wgerg2", Name = "Blue T-Shirt", Description = "Product Description", Image = "blue-t-shirt.jpg", Price = 29, Category = "Clothing", Quantity = 25, InventoryStatus = "INSTOCK", Rating = 5 },
            new Product { Id = 1004, Code = "h456wer53", Name = "Bracelet", Description = "Product Description", Image = "bracelet.jpg", Price = 15, Category = "Accessories", Quantity = 73, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1005, Code = "av2231fwg", Name = "Brown Purse", Description = "Product Description", Image = "brown-purse.jpg", Price = 120, Category = "Accessories", Quantity = 0, InventoryStatus = "OUTOFSTOCK", Rating = 4 },
            new Product { Id = 1006, Code = "bib36pfvm", Name = "Chakra Bracelet", Description = "Product Description", Image = "chakra-bracelet.jpg", Price = 32, Category = "Accessories", Quantity = 5, InventoryStatus = "LOWSTOCK", Rating = 3 },
            new Product { Id = 1007, Code = "mbvjkgip5", Name = "Galaxy Earrings", Description = "Product Description", Image = "galaxy-earrings.jpg", Price = 34, Category = "Accessories", Quantity = 23, InventoryStatus = "INSTOCK", Rating = 5 },
            new Product { Id = 1008, Code = "vbb124btr", Name = "Game Controller", Description = "Product Description", Image = "game-controller.jpg", Price = 99, Category = "Electronics", Quantity = 2, InventoryStatus = "LOWSTOCK", Rating = 4 },
            new Product { Id = 1009, Code = "cm230f032", Name = "Gaming Set", Description = "Product Description", Image = "gaming-set.jpg", Price = 299, Category = "Electronics", Quantity = 63, InventoryStatus = "INSTOCK", Rating = 3 },
            new Product { Id = 1010, Code = "plb34234v", Name = "Gold Phone Case", Description = "Product Description", Image = "gold-phone-case.jpg", Price = 24, Category = "Accessories", Quantity = 0, InventoryStatus = "OUTOFSTOCK", Rating = 4 },
            new Product { Id = 1011, Code = "4920nnc2d", Name = "Green Earbuds", Description = "Product Description", Image = "green-earbuds.jpg", Price = 89, Category = "Electronics", Quantity = 23, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1012, Code = "250vm23cc", Name = "Green T-Shirt", Description = "Product Description", Image = "green-t-shirt.jpg", Price = 49, Category = "Clothing", Quantity = 74, InventoryStatus = "INSTOCK", Rating = 5 },
            new Product { Id = 1013, Code = "fldsmn31b", Name = "Grey T-Shirt", Description = "Product Description", Image = "grey-t-shirt.jpg", Price = 48, Category = "Clothing", Quantity = 0, InventoryStatus = "OUTOFSTOCK", Rating = 3 },
            new Product { Id = 1014, Code = "waas1x2as", Name = "Headphones", Description = "Product Description", Image = "headphones.jpg", Price = 175, Category = "Electronics", Quantity = 8, InventoryStatus = "LOWSTOCK", Rating = 5 },
            new Product { Id = 1015, Code = "vb34btbg5", Name = "Light Green T-Shirt", Description = "Product Description", Image = "light-green-t-shirt.jpg", Price = 49, Category = "Clothing", Quantity = 34, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1016, Code = "k8l6j58jl", Name = "Lime Band", Description = "Product Description", Image = "lime-band.jpg", Price = 79, Category = "Fitness", Quantity = 12, InventoryStatus = "INSTOCK", Rating = 3 },
            new Product { Id = 1017, Code = "v435nn85n", Name = "Mini Speakers", Description = "Product Description", Image = "mini-speakers.jpg", Price = 85, Category = "Clothing", Quantity = 42, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1018, Code = "09zx9c0zc", Name = "Painted Phone Case", Description = "Product Description", Image = "painted-phone-case.jpg", Price = 56, Category = "Accessories", Quantity = 41, InventoryStatus = "INSTOCK", Rating = 5 },
            new Product { Id = 1019, Code = "mnb5mb2m5", Name = "Pink Band", Description = "Product Description", Image = "pink-band.jpg", Price = 79, Category = "Fitness", Quantity = 63, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1020, Code = "r23fwf2w3", Name = "Pink Purse", Description = "Product Description", Image = "pink-purse.jpg", Price = 110, Category = "Accessories", Quantity = 0, InventoryStatus = "OUTOFSTOCK", Rating = 4 },
            new Product { Id = 1021, Code = "pxpzczo23", Name = "Purple Band", Description = "Product Description", Image = "purple-band.jpg", Price = 79, Category = "Fitness", Quantity = 6, InventoryStatus = "LOWSTOCK", Rating = 3 },
            new Product { Id = 1022, Code = "2c42cb5cb", Name = "Purple Gemstone Necklace", Description = "Product Description", Image = "purple-gemstone-necklace.jpg", Price = 45, Category = "Accessories", Quantity = 62, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1023, Code = "5k43kkk23", Name = "Purple T-Shirt", Description = "Product Description", Image = "purple-t-shirt.jpg", Price = 49, Category = "Clothing", Quantity = 2, InventoryStatus = "LOWSTOCK", Rating = 5 },
            new Product { Id = 1024, Code = "lm2tny2k4", Name = "Shoes", Description = "Product Description", Image = "shoes.jpg", Price = 64, Category = "Clothing", Quantity = 0, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1025, Code = "nbm5mv45n", Name = "Sneakers", Description = "Product Description", Image = "sneakers.jpg", Price = 78, Category = "Clothing", Quantity = 52, InventoryStatus = "INSTOCK", Rating = 4 },
            new Product { Id = 1026, Code = "zx23zc42c", Name = "Teal T-Shirt", Description = "Product Description", Image = "teal-t-shirt.jpg", Price = 49, Category = "Clothing", Quantity = 3, InventoryStatus = "LOWSTOCK", Rating = 3 },
            new Product { Id = 1027, Code = "acvx872gc", Name = "Yellow Earbuds", Description = "Product Description", Image = "yellow-earbuds.jpg", Price = 89, Category = "Electronics", Quantity = 35, InventoryStatus = "INSTOCK", Rating = 3 },
            new Product { Id = 1028, Code = "tx125ck42", Name = "Yoga Mat", Description = "Product Description", Image = "yoga-mat.jpg", Price = 20, Category = "Fitness", Quantity = 15, InventoryStatus = "INSTOCK", Rating = 5 },
            new Product { Id = 1029, Code = "gwuby345v", Name = "Yoga Set", Description = "Product Description", Image = "yoga-set.jpg", Price = 20, Category = "Fitness", Quantity = 25, InventoryStatus = "INSTOCK", Rating = 8 },
        };
    }
}
