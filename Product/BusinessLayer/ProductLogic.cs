using System;

namespace Product
{
    public class ProductLogic
    {
        private ProductEntity _product;
        public ProductLogic(ProductEntity product)
        {
            _product = product;
        }

        public bool isValid()
        {
            if (_product == null)
            {
                throw new ArgumentNullException(nameof(_product));
            }

            if (_product.StartDate < _product.EndDate)
            {
                return true;
            }
            return false;
        }
        public Double ComputeVAT()
        {
            if (_product == null)
            {
                throw new ArgumentNullException(nameof(_product));
            }

            return _product.Price + (_product.VAT * _product.Price);
        }
    }
}
