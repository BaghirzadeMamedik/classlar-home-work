
using classlar_home_work;

products product1 = new();

product1.Id = 1;
product1.Name = "Compar";
product1.Price = 50;




static void SEOLink(string text)
{
    var seo = text.ToLower().Replace(" ", "-")
                  .Replace("ə", "e")
                  .Replace("ğ", "g")
                  .Replace("ç", "c");

    Console.WriteLine(seo);
}

SEOLink(product1.Name);

static void EDV18(int edv)
{
    int faiz;
    faiz =(int)(edv * 0.18);
    Console.WriteLine(faiz);
}

EDV18(product1.Price);