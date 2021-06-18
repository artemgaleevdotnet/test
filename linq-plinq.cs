var collection = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

var coll1 = collection.Where(x => x > 2);
var coll2 = collection.Where(x => x > 2).ToList();

collection.Add(8);

foreach (var v in coll1)
{
    Console.WriteLine(v);
}

foreach (var v in coll2)
{
    Console.WriteLine(v);
}

coll1.AsParallel().ForAll(x => Console.WriteLine(x));

coll2.AsParallel().ForAll(x => Console.WriteLine(x));