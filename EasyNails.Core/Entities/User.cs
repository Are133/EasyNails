namespace EasyNails.Core.Entities
{
    public class User
    {
        //TODO: Falata agregar mas propiedas a la clase user y por ello agregar el resto de configuraciones de la table.
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        #endregion
    }
}
