  namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
} 

// when we constraint TProduct to Product or any of its subclasses
// we get access to product classes all properties

// So if we TProduct: Book, we will will still get all the propewries of
// Products class as Book is written based on Product Class