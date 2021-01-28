using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager(new MernisServiceAdapter(), campaignManager);
            while (exit!= true)
            {
                Console.WriteLine("---Menü-----");
                Console.WriteLine("1- Oyuncu Listele \n2- Oyuncu Ekle \n3-Oyuncu Sil \n4-Oyuncu Güncelle \n" +
                    "5- Kampanya Listele \n6- Kampanya Ekle \n7- Kampanya Sil \n8- Kampanya Güncelle \n" +
                    "9- Oyunları Listele \n10- Oyun Ekle  \n11- Oyun Sil  \n12- Oyun Güncelle  \n13- Oyun Satın Al \n" +
                    "14- Sistemden Çıkış Yap");
                Console.WriteLine("-----------------");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                int choice=Convert.ToInt32( Console.ReadLine() );
                Console.Clear();
                
                switch (choice)
                {
                    case 1: playerManager.List();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Eklenecek oyuncunun sırası ile Id Ad Soyad TC Doğum yılı ve telefon numarasını giriniz");
                        playerManager.Save(new Player
                        {   Id = Convert.ToInt32(Console.ReadLine()),
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            NationalityId =Console.ReadLine(),
                            BirthYear = Convert.ToInt32(Console.ReadLine()),
                            PhoneNumber = Console.ReadLine()
                        });
                        break;
                    case 3:
                        Console.WriteLine("Silinecek Oyuncunun sırası ile Ad Soyad TC Doğum yılı bilgilerini giriniz  ");
                        playerManager.Delete(new Player
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            NationalityId = Console.ReadLine(),
                            BirthYear = Convert.ToInt32(Console.ReadLine())
                        });
                        break;
                    case 4:
                        Console.WriteLine("Güncellenecek oyuncunun tc numarasını giriniz");
                        playerManager.Update(new Player
                        {
                            NationalityId = Console.ReadLine()
                        });
                        break;
                    case 5:
                        campaignManager.List();
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Eklenecek olan kampanyanın ıd numarasını, adını ve indirim oranını giriniz ");
                        campaignManager.Add(new Campaign
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            DiscountRate = Convert.ToDouble(Console.ReadLine())
                        });
                        break;
                    case 7:
                        Console.WriteLine("Silinecek olan kampanya ıd numarasını, adını ve indirim oranını giriniz");
                        campaignManager.Delete(new Campaign
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            DiscountRate = Convert.ToDouble(Console.ReadLine())
                        });
                        break;
                    case 8:
                        Console.WriteLine("Önce güncellemek istediğiniz kampanyanın ıd numarasını, adını ve indirim oranını " +
                            "daha sonra güncellenmiş kampanyanın ıd numarasını, adını ve indirim oranını giriniz");
                        campaignManager.Update(new Campaign
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            DiscountRate = Convert.ToDouble(Console.ReadLine())
                        }, new Campaign
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            DiscountRate = Convert.ToDouble(Console.ReadLine())
                        });
                        break;
                    case 9:
                        gameManager.List();
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.WriteLine("Eklenecek olan oyunun ıd numarasını, adını ve fiyatını giriniz ");
                        gameManager.Add(new Game
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            Price = Convert.ToInt32(Console.ReadLine())
                        });
                        break;
                    case 11:
                        Console.WriteLine("Silinecek olan oyunun ıd numarasını, adını ve fiyatınıgiriniz");
                        gameManager.Delete(new Game
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            Price = Convert.ToInt32(Console.ReadLine())
                        });
                        break;
                    case 12:
                        Console.WriteLine("Önce güncellemek istediğiniz oyunun ıd numarasını, adını ve fiyatını " +
                            "daha sonra güncellenmiş oyunun ıd numarasını, adını ve fiyatını giriniz");
                        gameManager.Update(new Game
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            Price = Convert.ToInt32(Console.ReadLine())
                        }, new Game
                        {
                            Id = Convert.ToInt32(Console.ReadLine()),
                            Name = Console.ReadLine(),
                            Price = Convert.ToInt32(Console.ReadLine())
                        });
                        break;
                    case 13:
                        campaignManager.List();
                        Console.WriteLine("Satın almak istediğiniz oyunun adını, uygulamak istediğiniz kampanyanın Id numarasını ve sırası ile Ad Soyad TC Doğum yılı bilgilerinizi giriniz ");
                        gameManager.Buy(new Game
                        {
                            Name= Console.ReadLine()
                        }, new Campaign
                        {
                            Id= Convert.ToInt32(Console.ReadLine())
                        }, new Player
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            NationalityId = Console.ReadLine(),
                            BirthYear = Convert.ToInt32(Console.ReadLine())
                        }); Console.ReadLine();
                        break;
                    case 14:
                        exit = true;  break;
                }
                Console.Clear();
            }
        }
    }
}
