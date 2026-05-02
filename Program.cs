double a1, b1, c1, a2, b2, c2, a3, b3, c3, a4, b4, c4, a5, b5, c5;

Console.WriteLine("Siz Amallar bajaruvchi Dasturga kirdingiz ! \n\t 1 raqami ostida Arifmetik amallar !\n\t 2 Raqami ostida Geometrik amallar !");
string e = Console.ReadLine();
int f = Convert.ToInt32(e);

switch(f)
    { 
    case 1:
        {
            Console.WriteLine(" Salom Siz Arifmetik amallarni bajaruvchi dasturni ishga tushurdingiz !");
            Console.WriteLine(" Salom Siz 💰 Protsent farqi (o‘zgarish foizi)ni topuvchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
            Console.Write("Boshlang'ich qiymatni kiriting : ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Oxirgi yani Yakuniy qiymatni kiriting : ");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. 💰 Protsent farqi (o‘zgarish foizi) berilgan qiymatlar asosida topamiz !\n Dastur siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Protsent farqi : ");
            c1 = ((b1-a1)/a1*100);
            Console.Write(c1 +"%\n");
            Console.WriteLine("Yani siz kiritgan qiymatlar asosida 💰 Protsent farqi (o‘zgarish foizi) : " + c1);


            Console.WriteLine(" Salom Siz 📊 Geometrik va arifmetik o‘rtacha qiymatlar qiymatlarni aniqlovchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
            Console.Write("Birinchi qiymatni kiriting : ");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ikkinchi qiymatni kiriting : ");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("📊 Geometrik va Arifmetik o‘rtacha qiymat berilgan qiymatlar asosida topamiz !\n Siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Arifmetik o‘rtacha qiymat: ");
            c2 = (a2+b2)/2;
            Console.Write(c2 +"\n");
            Console.Write("Geometrik o‘rtacha qiymat: ");
            double d = Math.Sqrt(a2*b2);
            Console.Write(d +"\n");
            break;
            

        }
    

    case 2:
        {
            Console.WriteLine(" Salom Siz Geometrik amallarni bajaruvchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
            Console.Write("Birinchi qiymatni kiriting : ");
            a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ikkinchi qiymatni kiriting : ");
            b3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. 📐 To‘g‘ri burchakli uchburchak gipotenuzasi va yuzini berilgan qiymatlar asosida topamiz !\n Siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Gipotenuza: ");
            c3 = Math.Sqrt(Math.Pow(a3,2) + Math.Pow(b3,2));
            Console.Write(c3 +"\n");
            Console.WriteLine("Yani siz kiritgan qiymatlar asosida uchburchakning gipotenuzasi : " + c3);
            Console.WriteLine("Yuzasi : " + (a3*b3)/2);


            Console.WriteLine(" Salom Siz Parallel ulangan ikki qarshilikning umumiy qarshiligi topuvchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
            Console.Write("Birinchi qarshilikning qiymatni kiriting : ");
            a4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ikkinchi qarshilikning qiymatni kiriting : ");
            b4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. 🔌 Parallel ulangan ikki qarshilikning umumiy qarshiligi berilgan qiymatlar asosida topamiz !\n Dastur siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Umumiy qarshilik : ");
            c4 = ((a4 * b4)/(a4 + b4));
            Console.Write(c4 +"\n");
            Console.WriteLine("Yani siz kiritgan qiymatlar asosida parallel ulangan ikki qarshilikning umumiy qarshiligi : " + c4);
            break;         

            
        }
    
    default:
    Console.WriteLine("Siz noto'g'ri tugmani bosdingiz !");
    break;
    }