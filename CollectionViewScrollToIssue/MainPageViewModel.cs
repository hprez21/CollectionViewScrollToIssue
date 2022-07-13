using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewScrollToIssue
{
     public class MainPageViewModel
     {
          public List<PeopleGroup> PeopleList { get; set; }

          public MainPageViewModel()
          {
               var people = new Faker<Person>()
                    .RuleFor(p => p.Name, f => f.Person.FullName)
                    .RuleFor(p => p.Address, f => f.Person.Address.Street)
                    .Generate(25);

               var grouped =
                  from p in people
                  orderby p.Name
                  group p by p.Name[0].ToString()
                  into groups
                  select
                       new PeopleGroup(groups.Key, groups.ToList());

               PeopleList = grouped.ToList();
          }
     }
}
