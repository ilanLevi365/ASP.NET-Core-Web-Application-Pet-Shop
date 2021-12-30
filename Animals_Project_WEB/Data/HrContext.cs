using Animals_Project_WEB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Data
{
    public class HrContext : DbContext
    {
        public HrContext(DbContextOptions<HrContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new { CategoryId = 1, Name = "Reptiles" },
                new { CategoryId = 2, Name = "Poultry" },
                new { CategoryId = 3, Name = "Marine" }
            );

            modelBuilder.Entity<Animal>().HasData(             
                new { AnimalId =  1, Name = "lizard", Age = 12, Picture_Name = "lizard_Img.png", Description = "Most types of lizards have a tail and four legs except for certain species where the limbs are missing. An example of a limbless lizard found in the wild in Israel is the woodland crease. Some lizards are characterized by excellent swimming ability and some have a very long tongue.", CategoryId = 1 },
                new { AnimalId = 2, Name = "Turtle", Age = 50, Picture_Name = "turtle_Img.jpg", Description = "Turtles are reptiles with hard shells that protect them from predators. They are among the oldest and most primitive reptile groups, which evolved thousands of years ago. Turtles live all over the world in almost any type of climate.", CategoryId = 1 },
                new { AnimalId = 3, Name = "Snake", Age = 25, Picture_Name = "snake_Img.jpg", Description = "There are about 2,300 species of snakes in the world, divided into 15 families and spread over all continents except Antarctica. Snakes prefer warm countries. In countries where the winter is too cold they go into hibernation. Most snakes live on land, but there are also water snakes that live in the sea. Water snakes are usually very venomous, but are not aggressive.", CategoryId = 1 },
                new { AnimalId = 4, Name = "Parrot", Age = 10, Picture_Name = "parrot_Img.png", Description = "In the parrot series there are several hundred species found in tropical and subtropical regions on all continents except Antarctica. Some have excellent imitation ability and colorful appearance, and as a result, some of them have become ornamental birds and pets.", CategoryId = 2 },
                new { AnimalId = 6, Name = "Pigeon", Age = 2, Picture_Name = "Pigeon_Img.jpg", Description = "There are about 318 species of pigeons. The pigeons are monogamous, and change mates only in the event of the death of one of the mates. Once the nest is ready, the female will lay one egg and in most cases will lay another egg after a day. Each pair feeds one chick of pigeon milk which is formed in their throats.", CategoryId = 2 },
                new { AnimalId = 7, Name = "Owl", Age = 7, Picture_Name = "owl_Img.jpg", Description = "The owl is active only at night and hunts its prey in the following way: it flies in complete silence in the dark and then it attacks the prey, killing it with its claws and tearing pieces from it with its uncle's beak. Owls notice prey with their sharp eyes adapted to night vision, and with their sharp sense of hearing.", CategoryId = 2 },
                new { AnimalId = 9, Name = "Goldfish", Age = 1, Picture_Name = "Goldfish_Img.jpg", Description = "The goldfish or goldfinch (scientific name: Carassius auratus) is a fish from the carp family (Cyprinidae), which lives in freshwater. This fish has been domesticated for several species and is common as a pet in aquariums and ornamental fish in ornamental ponds.", CategoryId = 3 },
                new { AnimalId = 10, Name = "Battlefish", Age = 2, Picture_Name = "battle_fish_Img.png", Description = "Battlefish or Carboniferous in this genus over 60 species, are small fish, and their length is not less than 2.5 cm in the species B. chanoides and up to 14 cm in B. acarensis, they are so named due to the trait of the males Fight each other to the death.", CategoryId = 3 },
                new { AnimalId = 11, Name = "Parrotfish", Age = 3, Picture_Name = "Parrotfish_Img.jpeg", Description = "The Pacific Sea Parrot (scientific name: Fratercula cirrhata) is a species of sea parrot, found in the northern Pacific Ocean. Pacific parrots nest in dense flocks off the shores of Japan.", CategoryId = 3 }
            );

            modelBuilder.Entity<Comment>().HasData(
                new { CommentId = 1, AnimalId = 6, Coment = "Amazing production!" },
                new { CommentId = 2, AnimalId = 6, Coment = "Wow beautiful." },
                new { CommentId = 3, AnimalId = 6, Coment = "Inspiring." },
                new { CommentId = 4, AnimalId = 6, Coment = "The white the most beautiful!" },
                new { CommentId = 5, AnimalId = 3, Coment = "Scary." },
                new { CommentId = 6, AnimalId = 3, Coment = "Dangerous!" },
                new { CommentId = 7, AnimalId = 11, Coment = "Amazing production!" },
                new { CommentId = 8, AnimalId = 11, Coment = "Wowww!!!" },
                new { CommentId = 9, AnimalId = 11, Coment = "Inspiring!!" },
                new { CommentId = 10, AnimalId = 2, Coment = "Is very interesting." },
                new { CommentId = 11, AnimalId = 1, Coment = "Very agile." }
            );
        }
    }
}
