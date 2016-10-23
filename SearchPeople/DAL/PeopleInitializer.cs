using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SearchPeople.Models;

namespace SearchPeople.DAL
{
    public class PeopleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<People>
    {
        protected override void Seed(People context)
        {
            var testPeople = new List<Person>()
            {
                new Person{ID = 1, lastName = "Palmer", firstName="Chris", address="123 Street", age=22, interests="Sports",profilePicture= null},
                new Person{ID=2, lastName="Smith",firstName="Joe", address="321 Road", age=35, interests="Reading", profilePicture= null},
                new Person{ID=3, lastName="Smith",firstName="Henry", address="1 Infinite Loop", age=21, interests="Programming", profilePicture=null},
                new Person{ID=4, lastName="Schmoe",firstName="Joe", address="Boulevard of Broken Dreams", age=45, interests="Fishing", profilePicture=null},
                new Person{ID=5, lastName="Johns",firstName="Jimmy", address="Stairway to Heaven", age=30, interests="Surfing", profilePicture=null}

            };

            testPeople.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();

        }
    }
}