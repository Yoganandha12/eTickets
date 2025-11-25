using eTickets.Models;

namespace eTickets.Data
{
    public class AddDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the third cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the bio of the first producer",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the bio of the second producer",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the bio of the third producer",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the bio of the third actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = "This is the description of the first movie",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = Data.Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie 2",
                            Description = "This is the description of the second movie",
                            Price = 29.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(25),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = Data.Enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Movie 3",
                            Description = "This is the description of the third movie",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = Data.Enums.MovieCategory.Drama
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            Id = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            Id = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            Id = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            Id = 3,
                            MovieId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
