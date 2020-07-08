using StudentsAndTeachers.Interfaces;
using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.Repositories
{
    public class StreamMessagesRepository : IStreamMessageRepository
    {
        private readonly AppDbContext _appDbContext;
        public StreamMessagesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddMessage(StreamMessage streamMessage)
        {
            _appDbContext.Add(streamMessage);
            _appDbContext.SaveChanges();
        }

    }
}
