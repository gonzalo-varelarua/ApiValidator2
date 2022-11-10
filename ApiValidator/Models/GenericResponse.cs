using System.Collections.Generic;

namespace ApiValidator.Models
{
    /// <summary>
    /// GenericResponse Class
    /// </summary>
    public class GenericResponse
    {
        /// <summary>
        /// SuccessfulOperation
        /// </summary>
        public bool SuccessfulOperation { get; set; }
        /// <summary>
        /// StatusCode
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Errors
        /// </summary>
        public List<string> Errors { get; set; }
    }
}
