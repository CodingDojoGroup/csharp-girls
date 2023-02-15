

Dictionary<string,int> namesandages = new Dictionary<string,int>();
namesandages.Add("Jamie", 35);
namesandages.Add("Sean", 24);
namesandages.Add("Jocelyn", 21);
namesandages.Add("Maddie", 12);
namesandages.Add("Brandon", 10);
namesandages.Add("Stephanie", 58);
namesandages.Add("Gregg", 36);
namesandages.Add("Stephon", 42);

foreach(KeyValuePair<string,int> entry in namesandages)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
