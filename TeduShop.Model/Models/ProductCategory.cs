using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Categories")]
    public class ProductCategory
    {
        [Key]
        //AutoIncrement
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID{ set; get; }
        [Required]
        public string Name{ set; get; }
        
        [Required]
        public string Alias{ set; get; }
        public string Description{ set; get; }
        public int? ParentID{ set; get; }
        public int? DisplayOrder{ set; get; }
        public string Image{ set; get; }
        public bool? HomeFlag{ set; get; }

        public virtual IEnumerable<Product> Product { set; get; }
    }
}