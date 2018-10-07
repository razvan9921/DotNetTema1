using System;

namespace Product
{
    public class ProductLogic
    {
        private ProductEntity _product;
        public ProductLogic(ProductEntity product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public bool isValid()
        {
            var isValid = (_product.StartDate < _product.EndDate) ? true : false;

            return isValid;
        }

        public Double ComputeVAT()
        {
            return _product.Price + (_product.VAT * _product.Price);
        }
    }
}
