using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class UserRating
    {
        public int ID { get; set; }

        public string UserId { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "User Rating")]
        [Range(1, 5)]
        public decimal UsrRating { get; set; }
    }

    public class UserRatingsDBContext : DbContext
    {
        public DbSet<UserRating> Ratings { get; set; }
    }

}