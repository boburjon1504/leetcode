public class ProductOfNumbers {
    private List<int> products;
    public ProductOfNumbers() {
        products = new List<int>();
    }
    
    public void Add(int num) {
        if(num == 0){
            products.Clear();
            products.Add(0);
        }else{
            if(products.Count == 0 || products.Last() == 0){
                products.Add(num);
            }else{
                products.Add(products.Last() * num);
            }
        }
    }
    
    public int GetProduct(int k) {
        if(products.Count == 0){
            return 0;
        }
        if(k >= products.Count && products.First() == 0){
            return 0;
        }
        if(k >= products.Count){
            return products.Last();
        }
        if(k + 1 == products.Count && products.First() == 0){
            return products.Last();
        }
        return products.Last() / products[^(k + 1)];
    }
}