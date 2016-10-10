using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly object i;

        public object author { get; private set; }
        public object body { get; private set; }
        public object stars { get; private set; }

        // GET api/products 
        public IEnumerable<ProductModel> Get()
        {
            List<ProductModel> model = new List<ProductModel>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString            {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT   *   FROM Product";
            connect.Open();
            using ((sqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProductModel product = new ProductModel();
                    product.id = reader.GetInt32(0)(reader.GetOrdinal["id"]);
                    product.canPurchase = reader.GetBoolean(4);
                    product.soldOut = reader.GetBoolean(3);
                    product.Name = reader.GetString(1);
                    product.Price = reader.GetDecimal();
                    product.description = reader.GetString(reader.GetOrdinal["description"]);
                    model.Add(product);
                }
            }

            foreach(ProductModel p in model)
            {
                SqlCommand imageCommand = connection.CreateCommand();
                command.CommandText = string.Format("SELECT id, full, thumb FROM Image WHERE ProductID = {0}", p.id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<ImageModel> image = new List<ImageModel>();
                    while (reader.Read())
                    {
                        ImageModel  1 = new ImageModel();
                        i.id = reader.GetInt32(reader.GetOrdinal("id"));
                        i.full = reader.IsDBNull(reader.GetOrdinal("full")) ? null : reader.GetString(reader.GetOrdinal("full"));
                        i.thumb = reader.IsDBNull(reader.GetOrdinal("thumb")) ? null : reader.GetString(reader.GetOrdinal("thumb"));
                        images.Add(i);
                    }
                    p.images = images.ToArray();
                }

                SqlCommand reviewCommand = connection.CreateCommand();
                command.CommandText = string.Format("SELECT id, stars, author, body FROM Review WHERE ProductID = {0}", p.id);
                using (SqlDataReader reader = command.ExecuteReader());
                {
                    
                }
                {

                }
            }

            }
            //return new ProductModel[]
            //{
              //  new ProductModel
                //{
                  //  Name = "Dodecahedron",
                    //Price = 12.95m,
                    //description = "Some gems have hidden qualities beyondtheir lustre, beyond their shine...Dodecahdron is one of those gems",
                    //soldOut =   false,
                   // canPurchase = true,
                    //images = new ImageModel[]
                    //{
                      //  new ImageModel
                        //{
                          //  full = "dodecahedron-02-full.jpg",
                            //thumb = "dodecahedron-02-full.jpg"
                        //}
                    //},
                    //review = new    ReviewModel[]
                 //   {
               //         new ReviewModel
                   //     {
                     //       stars = 5.00m,
                       //     body =  "I love this product!",
                         //   author = "joe@thomas.com"
                    //    },

                    //}

              //  },
                //new ProductModel
                //{
                  //  Name    =   "Pentagonal",
            //        Price   =   5.95m,
              //      description = "The pentagonal gem is the newest addition to our store. We think you will love it",
                //    soldOut =   false,
                  //  canPurchase =   true,
                    //images  =   new ImageModel[]
                    //{
                       // new ImageModel
                //        {
                  //          full    =   "pentagonal-01-full.jpg",
                    //        thumb   =   "pentagonal-01-full.jpg"
                      //  }
                    //},
                   
                //},
              //  new ProductModel
                //{
                  //  Name    =   "Zircon",
                    //Price   =   1100,
            //        description =   "Zircon is our mostcoveted and sought after gem. You will pay much to be proud owner of this gorgeous and high shine gem.",
              //      soldOut =   false, 
                //    canPurchase =   true,
                  //  images  =   new ImageModel[]
                    //{
                      //  new ImageModel
                        //{
                          //  full    =   "zircon-03-full.jpg",
                            //thumb   =   "zircon-03-full.jpg"
                  //      }
                    //}
           //     }

        //    };

        }
    }
}
