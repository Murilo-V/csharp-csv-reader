using System.Globalization;
using CsvHelper;

using var streamReader = File.OpenText("/Users/alveira/Projects/csv_reader/csv_reader/username.csv");
using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

var users = csvReader.GetRecords<User>();

foreach (var user in users)
{
    Console.WriteLine(user);
}

record User(string Username, string Id, string FirstName, string LastName);
