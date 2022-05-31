using DataAccess.Enities.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Enities.Repositories
{
   public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(Context context)
            : base(context)
        { }
    }
}
