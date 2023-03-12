
using Microsoft.AspNetCore.Mvc;
using NetflixGang.Services.Interfaces;
using System.Text;

namespace NetflixGang.Services
{
    public class BotService : IBotService
    {
        public string GeneratePromptPayUrl()
        {
            var promptpayId = "0918548171";
            var amount = (decimal)85.0;
            string payload = GeneratePromptPayPayload("0918548171", (decimal)85.0);
            string encodedPayload = Convert.ToBase64String(Encoding.UTF8.GetBytes(payload));
            string kbankUrl = $"https://online.kasikornbankgroup.com/K-Online/topup/PromptPay?promptpayId={promptpayId}&amount={amount}&promptpayData={encodedPayload}";

            return kbankUrl;
        }

        public Task ReceiptHistory()
        {
            throw new NotImplementedException();
        }


        private string GeneratePromptPayPayload(string promptpayId, decimal amount) 
        {
            int satangAmount = (int)(amount * 100);
            var payload = $"000201010212{promptpayId.Length:D2}{promptpayId}5303764{satangAmount:D10}5802TH";

            return payload;
        }

    }
}
