using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace AngularAPI.Controllers
{
    public class ReviewController : Controller
    {

        // POST api/values
        public void Post([FromBody]ProductModel value)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                connection.Open();
                //Using Lambda expressions
                var newReview = value.review.First(x => x.id == 0);

                command.CommandText = string.Format("INSERT INTO Review(ProductId, stars, author, body) VALUES({0}, {1}, '{2}', '{3}')",
                    value.id, newReview.stars, newReview.author, newReview.body);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}