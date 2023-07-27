using System.Collections.Generic;

namespace EasyNails.Core.Entities
{
    public class Branch
    {
        #region Attributes

        #endregion

        #region Builder

        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BranchGuidId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        #endregion

        #region PrivateMethods

        #endregion

        #region PublicMethods

        #endregion

    }
}
