var edge = require('edge');

module.exports = {
	initialize: edge.func('include/CS_Initialize.cs'),
	writeText: edge.func('include/CS_WriteText.cs'),
	updateLcd: edge.func('include/CS_UpdateLcd.cs')
};