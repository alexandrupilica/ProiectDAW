using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Entities;

namespace ProiectDAW.IServices
{
        public interface ISongService
        {
            List<Song> GetAll();
            Song GetById(int id);
            bool Insert(Song song);
            bool Update(Song song);
            bool Delete(int id);
        }

}
