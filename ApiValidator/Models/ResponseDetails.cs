using System.Net;

namespace ApiValidator.Models
{
    /// <summary>
    /// ResponseDetails que hereda las propiedades de GenericResponse
    /// </summary>
    public class ResponseDetails : GenericResponse
    {
        /// <summary>
        /// HttpStatusCode
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// Json Result
        /// </summary>
        public string Json { get; set; }
    }
}
