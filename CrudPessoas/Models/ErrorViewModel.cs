using System.Runtime.Serialization;

namespace CrudPessoas.Models
{
    /// <summary>
    /// Modelo para exibir erros no aplicativo.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// ID da solicitação que gerou o erro.
        /// </summary>
        [DataMember]
        public string? RequestId { get; set; }

        /// <summary>
        /// Indica se o RequestId deve ser exibido.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
