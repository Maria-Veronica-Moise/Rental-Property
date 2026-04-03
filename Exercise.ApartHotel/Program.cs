// TODO
// seating and bathroomfixture are not rooms but they are in the rooms folder

// 1. try to figure out which classes should be records.
// 2. Learn about immutability and what needs to be changed in the classes to achieve this (hint: property getters).
// 3. Slowly start to learn about Domain Driven Design (DDD). https://www.youtube.com/watch?v=fO2T5tRu3DE&list=PLYpjLpq5ZDGtR5nMKGDCa031hx1jVuHXn
// 4. Learn about the Trim() and Contains() method and use this in appropriate places in the code (hint: validating strings).
// 5. Try to push code to github (call me first to do this together) = Done, always use git semantic commit messages (for now: feat, refactor and test).
// 6. Learn about tests https://app.pluralsight.com/ilx/video-courses/c-sharp-10-unit-testing/course-overview mod 1 - 3 (MSTest first, xUnit after together).
// 7. Create a test project and write some tests for the Address class (call me first to do this together).
// 8. Learn about Linq, collections and interfaces. IEnumerable<T> .Any() .Sum() .Where() .Select() .ToList(). https://app.pluralsight.com/ilx/video-courses/c-sharp-10-linq-fundamentals/course-overview mod 1 - 8.
// 9. We are going to add some methods to the classes, for example, a method to calculate the total number of beds in an apartment unit, or a method to calculate the total area of a rental property. Try to implement these methods.
// 10. Update tests



using Exercise.ApartHotel;

var address = new Address(
    "Main Street",
    "123",
    "Anytown",
    "Anystate",
    "12345",
    "Anyland"
);

//address.Street = "New Street";
//address.HouseNumber = "";


try
{
    File.ReadAllText("nonexistentfile.txt"); // this will throw a FileNotFoundException. 
}
catch (Exception ex)
{
    //what is the difference between:

    //1.
    throw new Exception("File nonexistentfile.txt does not exist");
    //2.
    throw ex;
    //3.
    throw;  
}
