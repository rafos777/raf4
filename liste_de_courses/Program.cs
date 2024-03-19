List<string> listeCourses = new List<string>();

int itemNb = 0;
int userNb = 0;
do
{
    itemNb = 0;
    Console.WriteLine("=====================");
    Console.WriteLine("   Shopping list : ");
    foreach (var item in listeCourses)
    { 
        itemNb++;
        Console.WriteLine($"{itemNb} - {item}"); 
    }
    Console.WriteLine("=====================");
    Console.WriteLine("  1 - Add a new item");
    Console.WriteLine("  2 - Delete an item");
    Console.WriteLine("  3 - Leave ");
    Console.WriteLine("=====================");
    if (Int32.TryParse(Console.ReadLine(), out userNb))
    {
        if (userNb == 1)
        {
            Console.WriteLine("What do you want to add?");
            string userAdd = Console.ReadLine();
            listeCourses.Add(userAdd);
        }
        else if (userNb == 2)
        {
            Console.WriteLine("What do you want to remove (index of the item)?");
            int userDelete;

            if (Int32.TryParse(Console.ReadLine(), out userDelete))
            {
                if (userDelete <= listeCourses.Count && userDelete > 0)
                {
                    listeCourses.RemoveAt(userDelete - 1);
                }
            }
        }
        else
        {
            Console.WriteLine("Input Error");
        }
    }
    else if (userNb != 3)
    {
        Console.WriteLine("Input Error");
    }    
}
while (userNb != 3);
