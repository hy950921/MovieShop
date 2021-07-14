using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    // DataAnnotations
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        // DataAnnotations
        [MaxLength(64)]
        [Required]
        public string Name { get; set; }

        //navigation
        public ICollection<MovieGenre>  MovieGenres { get; set; }
    }

    // to modify entity/table 2 options: dataAnnotation, fluent API
}
