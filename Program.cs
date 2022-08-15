using MyProjectDictionary;

MyDictionary<int, string> plakaveSehirler = new MyDictionary<int, string>();
plakaveSehirler.Add(9, "Aydın");
plakaveSehirler.Add(44, "Malatya");
plakaveSehirler.Add(35, "İzmir");

Console.WriteLine(plakaveSehirler.Count);
Console.WriteLine();
plakaveSehirler.ShowList();