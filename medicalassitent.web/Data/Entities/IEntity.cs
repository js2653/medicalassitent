using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Data.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        bool WasDeleted { get; set; }
    }

}
