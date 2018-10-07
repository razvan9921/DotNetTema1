using System;

namespace Product
{
    public class ProductLogic
    {
        private ProductEntity _product;
        public ProductLogic(ProductEntity product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(_product));
            }

            _product = product;
        }

        public bool isValid()
        {
            if (_product.StartDate < _product.EndDate)
            {
                return true;
            }
            return false;
        }

        public Double ComputeVAT()
        {
            return _product.Price + (_product.VAT * _product.Price);
        }
    }
}
