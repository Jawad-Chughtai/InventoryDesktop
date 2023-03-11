using InventoryDesktop.EntityFramework.ItemCategories;

namespace InventoryDesktop.Winforms.Models
{
    public class ItemCategoryModel
    {
        public int Id { get; set; }
        public  string Name { get; set; }   
        public string Code { get; set; }
        public int TypeId { get; set; }
        public string TypeName{ get; set; }
    }

    public static class AsItemCategoryModel
    {
        public static List<ItemCategoryModel> ToItemCategoryModel(this List<ItemCategory>? items)
        {
            var list = new List<ItemCategoryModel>();
            foreach (var item in items)
            {
                var listItem = new ItemCategoryModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Code = item.Code,
                    TypeId = item.ItemType.Id,
                    TypeName = item.ItemType.Name
                };

                list.Add(listItem);
            }

            return list;
        }
    }
}
