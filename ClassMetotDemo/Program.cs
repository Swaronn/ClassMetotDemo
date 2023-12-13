// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Musteri musteri1 = new Musteri()
{
    Id = 1,
    FirstName = "Umut",
    LastName="Bulundu",
    Number="0484156489",
};
Musteri musteri2 = new Musteri()
{
    Id= 2,
    FirstName = "Engin",
    LastName = "Demirog",
    Number = "03586570876",
};
Musteri[] musteris = new Musteri[] { musteri1, musteri2 };
MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1 as Musteri);
musteriManager.Add(musteri2 as Musteri);
Console.WriteLine("-------------");
musteriManager.List(musteris);
Console.WriteLine("------------");
musteriManager.Remove(musteri1);
musteriManager.Remove(musteri2);
Console.WriteLine("-------------");
musteriManager.List(musteris);



