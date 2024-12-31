using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models 
{
    public class Subcategory
    {


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SubCategoryName { get; set; }


        public ICollection<ServiceSubcategory> serviceSubcategories { get; set; }

    }
}
