using System.Net;

namespace Data_Access.Helpers
{//Oluşturma veya güncelleme işlemleri yapan bilgisayarın IP adresini alabilmek için kullanılacak.
    internal class IpAdress
    {
        #region Sunucu Ip Bilgisi (IPv4)
       // Bu sadece sunucunun verilerini verir ancak istediğim birimlerden bir kayıt veya güncelleme işlemi yapan bilgisayarın IP adresini sağlamak olduğu için bu metod işimi görmüyor.


        internal static string GetIpAddress()
        {
            var ipAddress = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in ipAddress.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {

                    return ip.ToString();
                }

            }
            return "";
        }
        #endregion
        #region İleride kullanılacak olan İstemci IP bilgisi

        //internal static string GetClientIpAdress(HttpContext httpContext)
        //{
        //    //Sunucuda Proxy veya Load Balancer varsa yanlış IP adresi alınmasın diye bir önkontrol yapıyoruz. 
        //    string? getIP = httpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();//İlk değer istemcı IP'sidir.
        //    //Eğer null veya boş string dönerse
        //    if (string.IsNullOrEmpty(getIP))
        //    {
        //        getIP = httpContext.Connection.RemoteIpAddress?.ToString();
        //    }//Doğrudan IP adresini almasını sağlıyoruz.
        //    //To string kaynaklı hata verebilir bu sebeple ? kullanılması gerekiyor
        //    return getIP;

        //} 
        #endregion
    }
}

//todo: Bu helper sınıfı servis katmanında tanımlanacak burada olmamalı.
