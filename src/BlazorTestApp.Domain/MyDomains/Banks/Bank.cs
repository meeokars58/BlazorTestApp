namespace BlazorTestApp.MyDomains.Banks
{
    public class Bank : FullAuditedAggregateRoot<Guid>
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public Guid? OzelKod1 { get; set; }
        public Guid? OzelKod2 { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
    }
}