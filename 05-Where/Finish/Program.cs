using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var result = vm.WhereMethod();

List<List<int>> listOfLists = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 }
};

var i = 0;
foreach (var innerlist in listOfLists)
{
    foreach (var num in innerlist)
    {
        if (i <= 4)
        {
            i++;
            Console.WriteLine(i);
        }
    }
}

// Display Results
//vm.Display(result);