namespace EasyNails.Core.Entities
{
    public class Branch
    {
        // TODO: Agregar el resto de configuraciones para la entidad
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BranchGuidId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        #endregion

    }
}
