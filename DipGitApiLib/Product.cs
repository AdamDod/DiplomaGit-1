using System;
using System.Collections.Generic;
using System.Linq;

namespace DipGitApiLib {
    public class Product {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }
    }

    public class Products {
        public List<Product> ProductList { get; set; }

        /// <summary>
        /// Sums the qty of all items in ProductList together
        /// </summary>
        /// <returns></returns>
        public int GetTotalQtyProducts() {
            int totalQ = 0;

            foreach(Product product in ProductList) {
                totalQ += product.Qty;
            }

            return totalQ;
        }

        /// <summary>
        /// Gets the total cost of inventory, that is the sum of the cost of all items 
        /// </summary>
        /// <returns></returns>
        public float GetTotalValueProducts() {
            float totalCost = 0;

            foreach(Product product in ProductList) {
                 totalCost += (product.Price * product.Qty);
            }

            return totalCost;
        }
    }
}
