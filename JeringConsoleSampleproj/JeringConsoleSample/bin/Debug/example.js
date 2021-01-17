// JavaScript source code
module.exports = {

	//stalls for 5 seconds and returns
  stall: async(arg) => {
	await new Promise(resolve => setTimeout(resolve, 5000));
	return arg + "!!!";
	}
}