using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNails.Core.Entities
{
    public abstract class EntityBase
    {
        #region Properties
        public int Id { get; set; }

        public bool IsActive { get; set; }
        #endregion
    }
}
