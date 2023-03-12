namespace NetflixGang.Services.Interfaces
{
    public interface IBotService
    {
        Task Payment();
        Task ReceiptHistory();
    }
}
