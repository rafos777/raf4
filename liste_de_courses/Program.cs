List<string> listeCourses = new List<string>();

int itemNb = 0;
int userNb = 0;
do
{
    itemNb = 0;
    Console.WriteLine("=====================");
    Console.WriteLine("liste de courses: ");
    foreach (var item in listeCourses)
    { 
        itemNb++;
        Console.WriteLine($"{itemNb} - {item}"); 
    }
    Console.WriteLine("=====================");
    Console.WriteLine("  1 - mettre un nouveau produit");
    Console.WriteLine("  2 - supprimer un produit");
    Console.WriteLine("  3 - quitter");
    Console.WriteLine("=====================");
    userNb = Convert.ToInt32(Console.ReadLine());
    if (userNb == 1)
    {
        Console.WriteLine("What do you want to add?");
        string userAdd = Console.ReadLine();
        listeCourses.Add(userAdd);
    }
    else if (userNb == 2)
    {
        Console.WriteLine("What do you want to remove (nb of the item)?");
        int userDelete = Convert.ToInt32(Console.ReadLine());
        listeCourses.RemoveRange(userDelete-1,1);
    }
}
while (userNb != 3);
