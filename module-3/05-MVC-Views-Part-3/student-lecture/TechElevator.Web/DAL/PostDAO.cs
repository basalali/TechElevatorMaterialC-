using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TechElevator.Web.Models;

namespace TechElevator.Web.DAL
{
    public class PostDAO
    {
        private string sql_GetAllPosts = "SELECT * from posts;";
        private string sql_GetPost = "SELECT * FROM posts WHERE id = @id;";
        string connectionString;
        public PostDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))                
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql_GetAllPosts, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Post post = new Post();

                        post.Id = Convert.ToInt32(reader["id"]);
                        post.UserName = Convert.ToString(reader["username"]);
                        post.PostImage = Convert.ToString(reader["postimage"]);

                        posts.Add(post);

                    }
                }
                return posts;
            }

            catch (SqlException)
            {
                posts = new List<Post>();

            }
            return posts;

        }

        public Post GetPost(int id)
        {
            Post post = new Post();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql_GetPost, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        post.Id = Convert.ToInt32(reader["id"]);
                        post.UserName = Convert.ToString(reader["username"]);
                        post.PostImage = Convert.ToString(reader["postimage"]);
                    }
                }
                return post;
            }

            catch (SqlException)
            {
                post = new Post();

            }
            return post;

        }

    }
}
