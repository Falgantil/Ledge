var edge 		= require('edge'),
	ledge 		= require("./include/ledge");

ledge.initialize("My amazing app!", true);

var sys = require("sys");
var stdin = process.openStdin();

var counter = 0;

stdin.addListener("data", function(d) {
		// note:  d is an object, and when converted to a string it will
		// end with a linefeed.  so we (rather crudely) account for that  
		// with toString() and then substring()
		var input = d.toString().substring(0, d.length-1);
		ledge.writeText([counter, input], true);
		ledge.updateLcd(null, true);
		
		counter++;
		
		if(counter > 3) {
			counter = 0;
		}
	}
);