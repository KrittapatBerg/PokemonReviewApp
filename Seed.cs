using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed //:Random
    {
        public static void SeedData(DataContext context) { }
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            /*public string PokemonName
            {
                get
                {
                    char p1 = (char)this.Next('A', 'Z'+1);
                    char p2 = (char)this.Next('A', 'Z'+1);
                    char p3 = (char)this.Next('A', 'Z'+1);

                    int n1 = this.Next(0, 10);
                    int n2 = this.Next(0, 10);
                    int n3 = this.Next(0, 10);

                    return $"{p1}{p2}{p3}{n1}{n2}{n3}";

                    dataContext.SaveChanges();
                }
            }*/




            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
            {
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        PokemonName = "Pikachu",
                        Birthdate = new DateTime(1903,1,1),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() { Name = "Electric"}}
                        },
                        Reviews = new List<Review>()
                        {
                            new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                            Reviewers = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                            new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                            Reviewers = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                            new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                            Reviewers = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                        }
                    },
                    Owner = new Owner()
                    {
                        OwnerName = "Jack London",
                        Gym = "Brocks Gym",
                        Country = new Country()
                        {
                            CountryName = "Kanto"
                        }
                    }
                },
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        PokemonName = "Squirtle",
                        Birthdate = new DateTime(1903,1,1),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() { Name = "Water"}}
                        },
                        Reviews = new List<Review>()
                        {
                            new Review { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                            Reviewers = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                            new Review { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                            Reviewers = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                            new Review { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                            Reviewers = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                        }
                    },
                    Owner = new Owner()
                    {
                        OwnerName = "Harry Potter",
                        Gym = "Mistys Gym",
                        Country = new Country()
                        {
                            CountryName = "Saffron City"
                        }
                    }
                },
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        PokemonName = "Venasuar",
                        Birthdate = new DateTime(1903,1,1),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() { Name = "Leaf"}}
                        },
                        Reviews = new List<Review>()
                        {
                            new Review { Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                            Reviewers = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                            new Review { Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                            Reviewers = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                            new Review { Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                            Reviewers = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                        }
                    },
                    Owner = new Owner()
                    {
                        OwnerName = "Ash Snow",
                        Gym = "Ashs Gym",
                        Country = new Country()
                        {
                            CountryName = "Millet Town"
                        }
                    }
                }
            };

                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();

            }
        }

    }
}


