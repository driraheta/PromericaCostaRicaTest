﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repositories
{
    public interface IMakeRepository
    {
        Task<IEnumerable<Make>> GetAllMakes();

        Task<Make> GetMake(int id);

        Task<bool> InsertMake();

        Task<bool> UpdateMake();

        Task<bool> DeleteMake();
    }
}
