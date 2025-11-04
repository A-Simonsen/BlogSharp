using BlogSharp2025.DataAccessLibrary.Interfaces;
using BlogSharp2025.DataAccessLibrary.Model;
using DataAccess.Interface;
using DataAccess.Model;
using RestSharp;
using System.Collections.Generic;

namespace BlogSharp.ApiClient
{
    public class ApiClient : IAuthorDao, IBlogPostDao
    {
        #region Attributes and Constructors
        // Attributes
        private readonly string apiUri;
        private readonly RestClient _restClient;

        // Constructor
        public ApiClient(string apiUri)
        {
            this.apiUri = apiUri;
            _restClient = new RestClient(apiUri);
        }


        #endregion


        public Author? Get(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all authors from the API.
        /// </summary>
        /// <returns>All authors</returns>
        public IEnumerable<Author> GetAll()
        {
            // Create a GET request for the "authors" endpoint
            var request = new RestRequest("authors", Method.Get);

            var response = _restClient.Execute<IEnumerable<Author>>(request);

            if (response == null)
            {
                throw new Exception("No response from API");
            }
            if (!response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                throw new Exception($"API request failed with status code {response.StatusCode}");
            }
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Author author)
        {
            throw new NotImplementedException();
        }

        public int Create(Author author)
        {
            throw new NotImplementedException();
        }

        public BlogPost? GetOne(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<BlogPost> IBlogPostDao.GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public int Create(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
