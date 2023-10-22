using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsitory
{
    public class CategoryReponsitory : ICategoryReponsitory
    {
        public IEnumerable<Category> GetCategories()
        {
            return CategoryDAO.Instance.GetCategoryList();
        }
    }
}
