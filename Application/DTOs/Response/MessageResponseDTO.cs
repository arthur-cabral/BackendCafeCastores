using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class MessageResponseDTO
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public MessageResponseDTO(string message, bool success)
        {
            Message = message;
            Success = success;
        }
    }
}
