using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice_With_WebAPI.Models;

namespace Practice_With_WebAPI.Service
{
    public interface IHangHoaResposity
    {
        List<HangHoaModel> GetAll(string search, double? from, double? to, string sortBy, int page = 1);
    }
}
