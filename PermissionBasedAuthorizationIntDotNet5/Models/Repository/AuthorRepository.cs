using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermissionBasedAuthorizationIntDotNet5.Models.Repository
{
    public class AuthorRepository: IPermissionsAuthorRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>() {
                new Author {Id=1, FullName="jamal kamal",Phone=0666666666,Commantaire="good one"},
                new Author {Id=2, FullName="hamid kamal",Phone=0666666666,Commantaire="good one"},
                new Author {Id=3, FullName="amine kamal",Phone=0666666666,Commantaire="good one"},
                };
        }

        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
        }
    }
}
