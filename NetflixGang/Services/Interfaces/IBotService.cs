using Microsoft.AspNetCore.Mvc;

namespace NetflixGang.Services.Interfaces
{
    public interface IBotService
    {
        string GeneratePromptPayUrl();
        Task ReceiptHistory();
    }
}
