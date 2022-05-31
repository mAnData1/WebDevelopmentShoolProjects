using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Enities.Repositories.Interfaces;


namespace DataAccess.Enities.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorReposiory
    {
        public AuthorRepository(Context context) 
            : base(context)
        {
        }
    }
}
