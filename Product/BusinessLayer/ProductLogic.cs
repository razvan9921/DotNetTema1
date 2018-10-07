using System;

namespace Product
{
    public class ProductLogic
    {
        public bool isValid(ProductEntity product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            if (product.StartDate < product.EndDate)
            {
                return true;
            }
            return false;
        }
        public float ComputeVAT(ProductEntity product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            return product.Price + (product.VAT * product.Price);
        }
    }
}
