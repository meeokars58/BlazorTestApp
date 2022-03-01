using BlazorTestApp.BankAccounts;

namespace BlazorTestApp.MyDomains.BankAccounts
{
    public class BankAccount : FullAuditedAggregateRoot<Guid>
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public BankAccountType BankaHesapTuru { get; set; }
        public string HesapNo { get; set; }
        public string IbanNo { get; set; }
        public Guid BankaSubeId { get; set; }
        public Guid? OzelKodId { get; set; }
        public Guid? OzelKodI2 { get; set; }
        public Guid? SubeId { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
    }
}