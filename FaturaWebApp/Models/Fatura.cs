namespace FaturaWebApp.Models
{
    public class Fatura
    {
        public string? FaturaNo { get; set; }
        public string? FaturaTarihi { get; set; }
        public string FaturaDurumu { get; internal set; }
    }
}
