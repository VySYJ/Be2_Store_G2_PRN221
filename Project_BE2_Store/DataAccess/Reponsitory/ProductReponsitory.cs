using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsitory
{
    public class ProductReponsitory : IProductReponsitory
    {
        public IEnumerable<Product> GetProducts()
        {
            return ProductDAO.Instance.GetProductList();
        }
    }
}
