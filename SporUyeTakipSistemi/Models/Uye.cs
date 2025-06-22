using System;

namespace SporUyeTakipSistemi.Models
{
    public class Uye
    {
        public int Id { get; set; }                    
        public string Ad { get; set; }                  
        public string Soyad { get; set; }              
        public string TCKimlik { get; set; }            
        public DateTime KayitTarihi { get; set; }       
        public DateTime BitisTarihi { get; set; }       

       
        public int KalanGun
        {
            get
            {
                int kalan = (BitisTarihi - DateTime.Now).Days;
                return kalan < 0 ? 0 : kalan;
            }
        }
    }
}
