using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice_With_WebAPI.Models;

namespace Practice_With_WebAPI.Service
{
    public interface ILoaiRepository
    {
        List<LoaiVM> GetAll();
        LoaiVM GetById(int id);
        LoaiVM Add(LoaiModel loai);
        void Update(LoaiVM loai);
        void Delete(int id);
    }
}
