using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewScrollToIssue
{
     public class PeopleGroup : List<Person>
     {
          public string Name { get; set; }

          public PeopleGroup(string name, List<Person> people)
               : base(people)
          {
               Name = name;
          }
     }
}
