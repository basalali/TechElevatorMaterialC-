using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM reviews";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Review review = new Review();

                        review.Id = Convert.ToInt32(reader["review_id"]);
                        review.Username = Convert.ToString(reader["username"]);
                        review.Rating = Convert.ToInt32(reader["rating"]);
                        review.ReviewTitle= Convert.ToString(reader["review_title"]);
                        review.ReviewText = Convert.ToString(reader["review_text"]);
                        review.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        reviews.Add(review);

                    }

                }
            }


            catch (SqlException ex)
            {

                reviews = new List<Review>();

            }
            return reviews;
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
      
        public bool SaveReview(Review newReview)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();

                    string sql = "INSERT INTO reviews (username, rating, review_title, review_text) VALUES (@username, @rating, @review_title, @review_text);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue(@"username", newReview.Username);
                    cmd.Parameters.AddWithValue(@"rating", newReview.Rating);
                    cmd.Parameters.AddWithValue(@"review_title", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue(@"review_text", newReview.ReviewText);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        result = true;
                    }

                }

            }

            catch (SqlException ex)
            {

                throw ex;
            }

            return result;
        }
    }
}
