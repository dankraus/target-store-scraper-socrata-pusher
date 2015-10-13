using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetStoreScraperSocrataPusher
{
    static class StateURLCollection
    {
        private static List<string> stateURLs = new List<string>{ 
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=AL&stateName=Alabama",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=AK&stateName=Alaska",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=AZ&stateName=Arizona",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=AR&stateName=Arkansas",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=CA&stateName=California",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=CO&stateName=Colorado",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=CT&stateName=Connecticut",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=DE&stateName=Delaware",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=FL&stateName=Florida",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=GA&stateName=Georgia",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=HI&stateName=Hawaii",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=ID&stateName=Idaho",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=IL&stateName=Illinois",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=IN&stateName=Indiana",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=IA&stateName=Iowa",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=KS&stateName=Kansas",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=KY&stateName=Kentucky",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=LA&stateName=Louisiana",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=ME&stateName=Maine",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=MD&stateName=Maryland",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=MA&stateName=Massachusetts",
            "http://gam.target.com/store-locator/state-result?stateCode=MI&stateName=Michigan",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=MN&stateName=Minnesota",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=MS&stateName=Mississippi",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=MO&stateName=Missouri",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=MT&stateName=Montana",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NE&stateName=Nebraska",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NV&stateName=Nevada",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NH&stateName=New Hampshire",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NJ&stateName=New Jersey",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NM&stateName=New Mexico",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NY&stateName=New York",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=NC&stateName=North Carolina",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=ND&stateName=North Dakota",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=OH&stateName=Ohio",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=OK&stateName=Oklahoma",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=OR&stateName=Oregon",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=PA&stateName=Pennsylvania",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=RI&stateName=Rhode Island",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=SC&stateName=South Carolina",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=SD&stateName=South Dakota",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=TN&stateName=Tennessee",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=TX&stateName=Texas",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=UT&stateName=Utah",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=VA&stateName=Virginia",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=WA&stateName=Washington",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=DC&stateName=Washington DC",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=WV&stateName=West Virginia",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=WI&stateName=Wisconsin",
            "http://gam.target.com/store-locator/state-result?lnk=statelisting_stateresult&stateCode=WY&stateName=Wyoming" 
        };

        public static List<string> URLs { get { return stateURLs; } }

    }
}
