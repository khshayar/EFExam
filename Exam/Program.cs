// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography;
using Exam.EfPersistance;
using Exam.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

var context = new EfDataContext();

Console.WriteLine("Hello, World!");


while (true)
{
    try
    {
        Run();

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        
    }
}

void Run()
{
    Console.WriteLine("select number "+
                      "\n 1 : CRUD zoo "+
                      "\n 2 : show options1 "+
                      "\n 3 : show options2 "+
                      "\n 4 : show options3 "+
                      "\n 5 : show options4 "+
                      "\n 6 : show options5"+
                      "\n 7 : CRUD PART"+
                      "\n 8 : CRUD ANIMAL"+
                      "\n 9 ; CRUD TIKET");
    var select = Console.ReadLine();
    switch (select)
    {
        case "1":
            CRUDZOO();
            break;
        case "2":
            show1(context);
            break;
        case "3":
            Show2(context);
            break;
        case "4" :
            Show3(context);
            break;
        case "5" :
            Show4(context);
            break;
        case "6":
            Show5(context);
            break;
        case "7" :
            CRUDPART();
            break;
        case "8":
            CRUDANIMAL();
            break;
        case "9" :
            CRUDTIKET();
            break;
        default:
            Console.WriteLine("you select wrong number");
            break;
    }
    {
        
    }
}

void CRUDPART()
{
    Console.WriteLine("select"+
                      "\n 1: creat part "+
                      "\n 2: reade part"+
                      "\n 3: update part"+
                      "\n 4;delet part ");
    var select = Console.ReadLine();
    switch (select)
    {
        case "1":
        {

            Console.WriteLine("enter  zoo name");
            var zname = Console.ReadLine();
            var part = context.Set<Zoo>().Where(_ => _.Name == zname).FirstOrDefault();
            Console.WriteLine("teda part ra vard konid");
            var tedad = Console.ReadLine();
            CreatPart(context, part.Id, int.Parse(tedad));
        }
            break;
        case "2":
        {
            Console.WriteLine("enter part id to reade");
            var id = int.Parse(Console.ReadLine());
            var part = context.Set<Part>().Where(_ => _.Id == id).FirstOrDefault();
            Console.WriteLine($"{part.Id} {part.Name} {part.TedadAnimal}{part.Animal}{part.Tikets}");

        }
            break;
        case "3":
        {
            Console.WriteLine("enter tiket id to update");
            var id = int.Parse(Console.ReadLine());
            var part = context.Set<Part>().Where(_ => _.Id == id).FirstOrDefault();
            Console.WriteLine("enter new part");
            var name = Console.ReadLine();
            part.Name = name;
            context.SaveChanges();
        }
            break;
        case "4":
        {
            Console.WriteLine("enter tiket id to remove");
            var id = int.Parse(Console.ReadLine());
            var part = context.Set<Part>().Where(_ => _.Id == id).FirstOrDefault();
            context.Set<Part>().Remove(part);
            context.SaveChanges();
        }
            break;
        default:
            Console.WriteLine("you enter wrong number");
            break;
    }
}

void CRUDANIMAL()
{
    Console.WriteLine("select"+
                      "\n 1: creat animal "+
                      "\n 2: reade animal"+
                      "\n 3: update animal"+
                      "\n 4;delet animal ");
    var select = Console.ReadLine();
    switch (select)
    {
        case "1":
        {

            Console.WriteLine("enter part of zoo name");
            var pname = Console.ReadLine();
            var part = context.Set<Part>().Where(_ => _.Name == pname).FirstOrDefault();
            Console.WriteLine("teda animal ra vard konid");
            var tedad = Console.ReadLine();
            CreatAnimal(context, part.Id, int.Parse(tedad));
        }
            break;
        case "2":
        {
            Console.WriteLine("enter animal id to reade");
            var id = int.Parse(Console.ReadLine());
            var animal = context.Set<Animal>().Where(_ => _.Id == id).FirstOrDefault();
            Console.WriteLine($"{animal.Id} {animal.Part} {animal.Name}");

        }
            break;
        case "3":
        {
            Console.WriteLine("enter animal id to update");
            var id = int.Parse(Console.ReadLine());
            var animal = context.Set<Animal>().Where(_ => _.Id == id).FirstOrDefault();
            Console.WriteLine("enter new animal name");
            var name = Console.ReadLine();
            animal.Name = name;
            context.SaveChanges();
        }
            break;
        case "4":
        {
            Console.WriteLine("enter animal id to remove");
            var id = int.Parse(Console.ReadLine());
            var animal = context.Set<Tiket>().Where(_ => _.Id == id).FirstOrDefault();
            context.Set<Tiket>().Remove(animal);
            context.SaveChanges();
        }
            break;
        default:
            Console.WriteLine("you enter wrong number");
            break;
    }
}

void CRUDTIKET()
{
    Console.WriteLine("select"+
                      "\n 1: creat tiket "+
                      "\n 2: reade tiket"+
                      "\n 3: update tikeet"+
                      "\n 4;delet tiket ");
    var select = Console.ReadLine();
    switch (select)
    {
        case "1":
        {

            Console.WriteLine("enter part of zoo name");
            var pname = Console.ReadLine();
            var part = context.Set<Part>().Where(_ => _.Name == pname).FirstOrDefault();
            Console.WriteLine("teda bilit ra vard konid");
            var tedad = Console.ReadLine();
            CreatTiket(context, part.Id, int.Parse(tedad));
        }
            break;
        case "2":
        {
            Console.WriteLine("enter tiket id to reade");
            var id = int.Parse(Console.ReadLine());
            var tiket = context.Set<Tiket>().Where(_ => _.Id == id).FirstOrDefault();
            Console.WriteLine($"{tiket.Id} {tiket.Part} {tiket.Price}");

        }
            break;
        case "3":
        {
            Console.WriteLine("enter tiket id to update");
            var id = int.Parse(Console.ReadLine());
            var tiket = context.Set<Tiket>().Where(_ => _.Id == id).FirstOrDefault();
            Console.WriteLine("enter new price");
            var price = decimal.Parse(Console.ReadLine());
            tiket.Price = price;
            context.SaveChanges();
        }
            break;
        case "4":
        {
            Console.WriteLine("enter tiket id to remove");
            var id = int.Parse(Console.ReadLine());
            var tiket = context.Set<Tiket>().Where(_ => _.Id == id).FirstOrDefault();
            context.Set<Tiket>().Remove(tiket);
            context.SaveChanges();
        }
            break;
        default:
            Console.WriteLine("you enter wrong number");
            break;
    }
}


void show1(EfDataContext context)
    {
        //مشاهده هر باغ وحش به همراه نام و آدرس و حیوانات درون آن
        var zoo = context.Set<Zoo>().Include(_ => _.Parts).ThenInclude(_ => _.Animal).ToList();
        foreach (var z in zoo)
        {
            Console.Write($"{z.Name}    ");
            foreach (var p in z.Parts)
            {
                Console.Write($"{p.Name}  {p.Animal.Name}");
            }

            Console.WriteLine();
        }
    }

void Show2(EfDataContext context)
    {
        //مشاهده یک باغ وحش و تعداد بخش هایی که تشکیل شده به همراه قیمت بلیط و مساحت هر بخش
        Console.WriteLine("enter zoo name");
        var name = Console.ReadLine();
        var zoo = context.Set<Zoo>().Where(_ => _.Name == name).Include(_ => _.Parts);
        foreach (var z in zoo)
        {
            Console.Write($"{z.Name} ");
            foreach (var p in z.Parts)
            {
                Console.WriteLine($"{p.Name}  {p.Masahat} {p.Tikets} ");
            }

            Console.WriteLine();
        }
    }

void Show3(EfDataContext context)
    {
        //مشاهده بخش های باغ وحش و نوع و تعداد حیوانات درون آن به همراه توضیحات 
        Console.WriteLine("ente zoo name for watching tedad animal");
        var name = Console.ReadLine();
        var zoo = context.Set<Zoo>().Where(_ => _.Name == name)
            .Include(_ => _.Parts).ThenInclude(_ => _.Animal).ToList();

        foreach (var z in zoo)
        {
            foreach (var p in z.Parts)
            {
                Console.WriteLine($"{p.Name} {p.Animal} {p.TedadAnimal} {p.Titel}");
            }

            Console.WriteLine();
        }

    }

void Show4(EfDataContext context)
    {
        //مشاهده بلیط فروخته شده در بخش های مختلف یک باغ وحش به ترتیب تعداد بلیط فروخته شده
        Console.WriteLine("ente zoo name for watching tedad animal");
        var name = Console.ReadLine();
        var part = context.Set<Part>().Where(_ => _.Zoo.Name == name)
            .Include(_ => _.Tikets).ToList();
        foreach (var p in part)
        {
            p.Tikets.Sort();
        }

        foreach (var p in part)
        {
            Console.WriteLine($"{p.Name} {p.Tikets}");
        }

    }

void Show5(EfDataContext context)
    {
        //مشاهده بلیط فروخته شده در بخش های مختلف یک باغ وحش به ترتیب مجموع قیمت بلیط فروخته شده

    }

void CRUDZOO()
    {
        Console.WriteLine("select");
        var select = Console.ReadLine();
        switch (select)
        {
            case "1":
                CreatZoo(context);
                break;
            case "2":
                ReadZoo(context);
                break;
            case "3":
                UpdateZoo(context);
                break;
            case "4":
                RemoveZoo(context);
                break;
            default:
                Console.WriteLine("you enter wrong number");
                break;
        }
    }

void ReadZoo(EfDataContext context)
    {
        var zoo = context.Set<Zoo>().ToList();
        foreach (var z in zoo)
        {
            Console.WriteLine($"{z.Id} {z.Name}");
        }
    }

void UpdateZoo(EfDataContext context)
    {
        Console.WriteLine("enter zoo name to update ");
        var name = Console.ReadLine();
        var zoo = context.Set<Zoo>().Where(_ => _.Name == name).FirstOrDefault();
        Console.WriteLine($"enter you new name ({zoo.Name})");
        var nname = Console.ReadLine();
        zoo.Name = nname;
        context.SaveChanges();
    }

void RemoveZoo(EfDataContext context)
    {
        Console.WriteLine("enter your zoo name to remove");
        var name = Console.ReadLine();
        var zoo = context.Set<Zoo>().Where(_ => _.Name == name).FirstOrDefault();
        context.Set<Zoo>().Remove(zoo);
        context.SaveChanges();
    }


void CreatZoo(EfDataContext context)
    {
        Console.WriteLine("enter your zoo name");
        var name = Console.ReadLine();
        var zoo = new Zoo()
        {
            Name = name
        };
        context.Set<Zoo>().Add(zoo);
        context.SaveChanges();
        Console.WriteLine("enter part count");
        var count = int.Parse(Console.ReadLine());
        CreatPart(context, zoo.Id, count);

    }

void CreatPart(EfDataContext context, int zooId, int tedad)
    {
        for (int i = 0; i < tedad; i++)
        {
            Console.WriteLine("enter part name");
            var name = Console.ReadLine();
            Console.WriteLine("Masahat ro vard konid");
            var masahat = long.Parse(Console.ReadLine());
            Console.WriteLine("enter titel about ");
            var titel = Console.ReadLine();
            Console.WriteLine("enter count of animals");
            var tedat = Console.ReadLine();
            var part = new Part()
            {
                Name = name,
                Masahat = masahat,
                TedadAnimal = tedat,
                Titel = titel,
                ZooId = zooId
            };
            context.Set<Part>().Add(part);
            context.SaveChanges();
            CreatAnimal(context, part.Id, int.Parse(part.TedadAnimal));
            Console.WriteLine("enter count of tiket");
            var tedadt = int.Parse(Console.ReadLine());
            CreatTiket(context, part.Id, tedadt);

        }

    }

    void CreatAnimal(EfDataContext context, int partId, int tedad)
    {
        Console.WriteLine("enter animal name");
        var name = Console.ReadLine();
        for (int i = 0; i < tedad; i++)
        {
            var animal = new Animal()
            {
                Name = name,
                PartId = partId
            };
            context.Set<Animal>().Add(animal);
            context.SaveChanges();
        }
    }

    void CreatTiket(EfDataContext context, int partId, int tedad)
    {
        Console.WriteLine("ghimat pilite in bakhsh ro vard konid ");
        var price = decimal.Parse(Console.ReadLine());
        for (int i = 0; i < tedad; i++)
        {
            var tiket = new Tiket()
            {
                Price = price,
                PartId = partId
            };
            context.Set<Tiket>().Add(tiket);
            context.SaveChanges();
        }
    }

