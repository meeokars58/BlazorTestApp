namespace BlazorTestApp.MyDomains.BankBranchs
{
    public class BankBranch
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public Guid? OzelKod1 { get; set; }
        public Guid? OzelKod2 { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
    }
}