namespace SweetBites.ServerApp.Data
{
    public static class AppDbInitializer
    {
        //Create a Seed Method to Add list to Database
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Sweets.Any())
                {
                    context.Sweets.AddRange(sweets);
                    context.SaveChanges();
                }
            }
        }

        public static List<Sweet> sweets = new List<Sweet>
        {
            new Sweet
            {
                Name = "Chocolate Cake",
                Description = "A rich and decadent chocolate cake topped with creamy frosting.",
                NumberOfReviewers = 10,
                ReviewValue = 4.5,
                ImageUrl = $"https://source.unsplash.com/random/400x200/?Chocolate Cake"
            },
            new Sweet
            {
                Name = "Strawberry Cheesecake",
                Description = "Creamy cheesecake with a graham cracker crust, topped with fresh strawberries.",
                NumberOfReviewers = 8,
                ReviewValue = 4.2,
                ImageUrl = "https://source.unsplash.com/random/400x200/?sweet,dessert"
            },
            new Sweet
            {
                Name = "Blueberry Muffins",
                Description = "Moist and fluffy muffins filled with juicy blueberries.",
                NumberOfReviewers = 12,
                ReviewValue = 4.7,
                ImageUrl = $"https://source.unsplash.com/random/400x200/?Blueberry Muffins"
            },
            new Sweet
            {
                Name = "Vanilla Cupcakes",
                Description = "Delightful cupcakes with a smooth vanilla buttercream frosting.",
                NumberOfReviewers = 6,
                ReviewValue = 4.0,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Vanilla Cupcakes"
            },
            new Sweet
            {
                Name = "Apple Pie",
                Description = "Warm and flaky pie filled with cinnamon-spiced apples.",
                NumberOfReviewers = 9,
                ReviewValue = 4.3,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Apple Pie"
            },
            new Sweet
            {
                Name = "Red Velvet Cake",
                Description = "Velvety smooth cake with a hint of cocoa, topped with cream cheese frosting.",
                NumberOfReviewers = 7,
                ReviewValue = 4.1,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Red Velvet Cake"
            },
            new Sweet
            {
                Name = "Lemon Bars",
                Description = "Tangy and sweet bars with a buttery crust and zesty lemon filling.",
                NumberOfReviewers = 5,
                ReviewValue = 4.4,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Lemon Bars"
            },
            new Sweet
            {
                Name = "Pecan Pie",
                Description = "Traditional pie filled with a rich and gooey pecan filling.",
                NumberOfReviewers = 11,
                ReviewValue = 4.6,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Pecan Pie"
            },
            new Sweet
            {
                Name = "Carrot Cake",
                Description = "Moist and flavorful cake filled with grated carrots and topped with cream cheese frosting.",
                NumberOfReviewers = 9,
                ReviewValue = 4.3,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Carrot Cake"
            },
            new Sweet
            {
                Name = "Raspberry Tart",
                Description = "Butter pastry shell filled with sweet and tangy raspberry filling.",
                NumberOfReviewers = 6,
                ReviewValue = 4.0,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Raspberry Tart"
            },
            new Sweet
            {
                Name = "Chocolate Chip Cookies",
                Description = "Classic cookies packed with chocolate chips and baked to perfection.",
                NumberOfReviewers = 12,
                ReviewValue = 4.7,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Chocolate Chip Cookies"
            },
            new Sweet
            {
                Name = "Banana Bread",
                Description = "Moist and delicious bread made with ripe bananas and a hint of cinnamon.",
                NumberOfReviewers = 8,
                ReviewValue = 4.2,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Banana Bread"
            },
            new Sweet
            {
                Name = "Coconut Macaroons",
                Description = "Chewy and sweet coconut cookies with a crispy exterior.",
                NumberOfReviewers = 10,
                ReviewValue = 4.5,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Coconut Macaroons"
            },
            new Sweet
            {
                Name = "Key Lime Pie",
                Description = "Tangy and creamy pie made with fresh key limes and a buttery graham cracker crust.",
                NumberOfReviewers = 7,
                ReviewValue = 4.1,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Key Lime Pie"
            },
            new Sweet
            {
                Name = "Cinnamon Rolls",
                Description = "Soft and fluffy rolls swirled with cinnamon and topped with a sweet glaze.",
                NumberOfReviewers = 9,
                ReviewValue = 4.3,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Cinnamon Rolls"
            },
            new Sweet
            {
                Name = "Mango Mousse",
                Description = "Light and airy dessert made with fresh mangoes and whipped cream.",
                NumberOfReviewers = 6,
                ReviewValue = 4.0,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Mango Mousse"
            },
            new Sweet
            {
                Name = "Cherry Pie",
                Description = "Sweet and tart pie filled with juicy cherries and a flaky crust.",
                NumberOfReviewers = 11,
                ReviewValue = 4.6,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Cherry Pie"
            },
            new Sweet
            {
                Name = "Oreo Truffles",
                Description = "Decadent truffles made with crushed Oreo cookies and cream cheese, coated in chocolate.",
                NumberOfReviewers = 5,
                ReviewValue = 4.4,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Oreo Truffles"
            },
            new Sweet
            {
                Name = "Lava Cake",
                Description = "Indulgent chocolate cake with a gooey molten center, served warm.",
                NumberOfReviewers = 9,
                ReviewValue = 4.3,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Lava Cake"
            },
            new Sweet
            {
                Name = "Pumpkin Pie",
                Description = "Classic pie made with spiced pumpkin filling and a flaky crust.",
                NumberOfReviewers = 7,
                ReviewValue = 4.1,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Pumpkin Pie"
            },
            new Sweet
            {
                Name = "Molten Chocolate Brownies",
                Description = "Gooey and fudgy brownies with a rich chocolate center.",
                NumberOfReviewers = 10,
                ReviewValue = 4.5,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Molten Chocolate Brownies"
            },
            new Sweet
            {
                Name = "Peach Cobbler",
                Description = "Warm and comforting dessert with juicy peaches and a buttery biscuit topping.",
                NumberOfReviewers = 8,
                ReviewValue = 4.2,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Peach Cobbler"
            },
            new Sweet
            {
                Name = "Raspberry Swirl Cheesecake",
                Description = "Creamy cheesecake with a swirl of raspberry puree and a buttery graham cracker crust.",
                NumberOfReviewers = 6,
                ReviewValue = 4.0,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Raspberry Swirl Cheesecake"
            },
            new Sweet
            {
                Name = "Sugar Cookies",
                Description = "Buttery and sweet cookies decorated with colorful sugar sprinkles.",
                NumberOfReviewers = 12,
                ReviewValue = 4.7,
                ImageUrl = "https://source.unsplash.com/random/400x200/?Sugar Cookies"
            }
        };
    }
}
