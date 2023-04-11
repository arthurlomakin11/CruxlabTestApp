using CruxlabTestApp;

var fileStrings = File.ReadAllLines("passwords.txt");

var matchedPasswordsCount= fileStrings.Count(fileString => new PasswordPattern(fileString).IsPasswordMatching());
Console.WriteLine(matchedPasswordsCount);