List<Account> accounts = new List<Account> ();

accounts a1 = new("Caina Antunes",1001);
accounts a2 = new("Andre Cassulino",1002);
accounts a3 = new("Gabriel Claro",1003);
accounts a1 = new("Glauco Todesco",1004);

accounts.Add(a1);
accounts.Add(a2);
accounts.Add(a3);
accounts.Add(a4);

accounts.Sort();

foreach(Account account in accounts){
    Console.WriteLine(account);

Console.WriteLine("------------");

accounts.Sort(new UserComparer());

foreach(Account account in accounts)
    Console.WriteLine(account);
}

