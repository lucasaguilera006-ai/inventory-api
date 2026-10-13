using System.ComponentModel.DataAnnotations;

namespace InventoryAPI.DTOs
{
    public class ChatRequestDTO
    {
        [MaxLength(2000)]
        public string Content { get; set; } = string.Empty;
        public int? ConversationId { get; set; }
    }
}