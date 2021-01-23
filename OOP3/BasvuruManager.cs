using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) 
        {
            //Başvuran bilgilerini değerlendirme
            //Aşağıda ki gibi yazarsan sadece Konut kredisi hesaplar
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            
            krediManager.Hesapla();                                  //bu şekilde yazarsak referans olan bilgilerden isteneni hesaplar
            loggerService.Log();
        }

        internal void BasvuruYap(IKrediManager ihtiyacKrediManager, fileLoggerService fileLoggerService)
        {
            throw new NotImplementedException();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
 }
