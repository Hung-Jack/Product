using System.ComponentModel.DataAnnotations;

namespace Product.Models
{
    public class Item
    {
        [Display(Name = "商品編號")]
        public string Id { get; set; }
        
        [Display(Name = "商品名稱")] 
        public string Name { get; set; }
        [Display(Name = "售價")]
        public int Price { get; set; }
       
         [Display(Name = "庫存")]
        public int Quantity { get; set; }
       
    }
}
