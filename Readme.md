#Target Store Location Scraper - Socrata Open Data

This C# Console App scrapes Target.com's website for store locations and pushes it up to Socrata for open data sharing.

This runs as a scheduled WebJob on Azure once a month. See the results at [Open Data](https://opendata.socrata.com/Business/Target-Stores-in-USA/4mte-zfws).

##Usage
Modify the App.config with your own Socrata API key, username, password, and Dataset Resource Id

##Misc
The State URLs on Target's site are hardcoded as they aren't quite scrapable. They weirdly load in data via AJAX. It was just easier this way. 

They load in the store locations via JSON payload in a hidden div that's rendered server side. That gets parsed out and mapped to the Store object.
Weird, right?

##License
This doesn't do much. Do what you want with it. Attribute me, don't attribute me, I don't really care. Use it an example to see how to push data to Socrata Open Data. 