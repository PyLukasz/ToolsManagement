﻿using System.Collections.Generic;
using ToolsManagement.Models.Drill;

namespace ToolsManagement.Services.Interfaces
{
    public interface IDrillService
    {
        IEnumerable<DrillDto> GetAll();
        int CreateDrill(CreateDrillDto dto);
        DrillDto GetById(int id);
        void Delete(int id);
        void Update(int id, UpdateDrillDto dto);
    }
}
