namespace EasyNails.Core.Entities
{
    public class Branch : EntityBase
    {
        // TODO: Agregar el resto de configuraciones para la entidad
        #region Properties
        public string Name { get; set; } = string.Empty;
        public string BranchGuidId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        #endregion

    }
}
