// openingScripts04.js 
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Numbers_and_dates
// https://blog.elmah.io/how-to-send-push-notifications-to-a-browser-in-asp-net-core/
// 

const greetPara = document.querySelector('#greetpara');
greetPara.addEventListener('onload', altGreeting());

/* Set the width of the side navigation to 250px and the left margin of the page content to 250px */
function openNav() {
  document.getElementById("mySidenav").style.width = "250px";
  document.getElementById("openingScn").style.marginLeft = "250px";
}

/* Set the width of the side navigation to 0 and the left margin of the page content to 0 */
function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
  document.getElementById("openingScn").style.marginLeft = "0";
}

// altGreeting function --------------------------------------------------------------
function altGreeting ()
{
	let dayNames =["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
	let monthNames=["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
	let curDate = new Date();
	let yrNow = curDate.getFullYear();
	let moNow = curDate.getMonth();
	let dayNow = curDate.getDay();
	let hourNow = curDate.getHours();
	let dayPart = '';
	
	let nowDate = curDate.toDateString();
	if(hourNow < 12)
	{ 
	    dayPart = '  Morning ';
	}
	else if (hourNow  >=	12  &&  hourNow < 18 )
	{
	    dayPart =' Afternoon ';
	}
	else if (hourNow >=18)
	{
	     dayPart = ' Evening ';
	}

	greetPara.textContent = `  Good  ${dayPart} today is ${dayNames[dayNow]}  ${monthNames[moNow]} ${curDate.getDate()}, ${yrNow}`;
} // eo altGreeting function ------------------------------------------------------------

