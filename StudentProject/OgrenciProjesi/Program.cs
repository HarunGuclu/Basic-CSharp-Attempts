class Program
{
    static void Main(string[] args)
    {
        
        List<string> EkleList = new List<string>();
        int counterEkle = 0;
        while (true)
        {
            
            int islem;
            string secim;

            
            Console.WriteLine("---------Ana Menu---------");
            Console.WriteLine("1->OGRENCI EKLEME");
            Console.WriteLine("2->OGRENCİ SILME");
            Console.WriteLine("3->OGRENCİ GUNCELLEME");
            Console.WriteLine("4->OGRENCI ARAMA");
            Console.WriteLine("5->OGRENCI GORUNTULEME");
            Console.WriteLine("6->CIKIS");
            Console.Write("Yapmak istediginiz islemi secin:");
            islem=int.Parse(Console.ReadLine());

            if (islem == 6) { Console.WriteLine("Basarili bir sekilde cikis yapildi.."); break; }
            Console.Clear();
            switch (islem)
            {
                case 1:
                {
                        string isimSoyisim;

                        do
                        {
                            
                            Console.Write("Isim ve soyisim giriniz:");
                            isimSoyisim = Console.ReadLine();
                            EkleList.Add(isimSoyisim);
                            counterEkle++;
                            Console.Write("Basarili bir sekilde eklendi..Baska kayit eklemek ister misiniz(e-h):");
                            secim = Console.ReadLine();
                            while (secim != "h" && secim != "e")
                            {
                                Console.WriteLine("Hatali secim.Tekrar deneyin(e-h):");
                                secim = Console.ReadLine();
                            }
                        } while (secim == "e");
                        break;
                }
                case 5:
                {
                        Console.WriteLine("-----Ogrenci Listesi------");
                        for (int i = 0; i < counterEkle; i++)
                        {
                            Console.WriteLine(EkleList[i]);
                        }
                        break;
                }
                case 2:
                {
                        string silinecek;
                        do
                        {

                            Console.Write("Silinecek isim soyismi beraber giriniz:");
                            silinecek = Console.ReadLine();
                            if(EkleList.Contains(silinecek))
                            {
                                EkleList.Remove(silinecek);
                                counterEkle--;
                                Console.Write("Basarili bir sekilde silindi..Baska kayit silmek ister misiniz(e-h):");
                                secim = Console.ReadLine();
                                
                            }
                            else
                            {
                                Console.Write("Kisi bulunamadi..Baska kayit silmek ister misiniz(e-h):");
                                secim = Console.ReadLine();                               
                            }
                            while (secim != "h" && secim != "e")
                            {
                                Console.WriteLine("Hatali secim.Tekrar deneyin(e-h):");
                                secim = Console.ReadLine();
                            }

                        } while (secim=="e");
                        break;
                }
                case 3:
                {
                        do
                        {
                            Console.Write("Guncellenecek isim soyismi beraber giriniz:");
                            string aranan = Console.ReadLine();
                            string guncellenen;
                            if (EkleList.Contains(aranan))
                            {
                                Console.Write("Güncel halini giriniz:");
                                guncellenen= Console.ReadLine();
                                int index = EkleList.IndexOf(aranan);
                                EkleList[index]=guncellenen;
                                Console.Write("Basarili bir sekilde guncellendi..Tekrar guncelleme yapmak ister misiniz(e-h):");
                                secim = Console.ReadLine();
                            }
                            else
                            {
                                Console.Write("Kisi bulunamadi..Baska kayit silmek ister misiniz(e-h):");
                                secim = Console.ReadLine();
                            }
                            while (secim != "h" && secim != "e")
                            {
                                Console.WriteLine("Hatali secim.Tekrar deneyin(e-h):");
                                secim = Console.ReadLine();
                            }
                        } while (secim == "e");
                        break;
 
                }
                case 4:
                {
                        string aranan;
                        do
                        {

                            Console.Write("Aranacak isim soyisimi beraber giriniz:");
                            aranan = Console.ReadLine();
                            if (EkleList.Contains(aranan) )
                            {
                                Console.WriteLine(aranan);
                                Console.Write("Aradiginiz kisi bulundu.. Baska kayit aramak ister misiniz(e-h):");
                                secim = Console.ReadLine();

                            }
                            else
                            {
                                Console.Write("Kisi bulunamadi..Baska kayit aramak ister misiniz(e-h):");
                                secim = Console.ReadLine();
                            }
                            while (secim != "h" && secim != "e")
                            {
                                Console.WriteLine("Hatali secim.Tekrar deneyin(e-h):");
                                secim = Console.ReadLine();
                            }

                        } while (secim == "e");
                        break;

                    }
                default:
                {
                        Console.WriteLine("Hatali secim..Tekrar deneyiniz."); break;
                }

                    
            }




                
            
        }
    }
}