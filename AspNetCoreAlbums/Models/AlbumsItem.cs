using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAlbums.Models
{
    public class AlbumsItem
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}
