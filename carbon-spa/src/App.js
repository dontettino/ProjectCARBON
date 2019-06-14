import React from "react";

const App = () => {
	function notifyMe() {
		// Let's check if the browser supports notifications
		if (!("Notification" in window)) {
			alert("This browser does not support desktop notification");
		}

		// Let's check whether notification permissions have already been granted
		else if (Notification.permission === "granted") {
			// If it's okay let's create a notification
			var notification = new Notification("Why did you click?");
		}

		// Otherwise, we need to ask the user for permission
		else if (Notification.permission !== "denied") {
			Notification.requestPermission().then(function(permission) {
				// If the user accepts, let's create a notification
				if (permission === "granted") {
					var notification = new Notification("Why did you click?");
				}
			});
		}

		console.log("clicked");
	}
	return (
		<div className="App">
			<header className="App-header">
				<button onClick={notifyMe}>DON'T CLICK THIS BUTTON!</button>
			</header>
		</div>
	);
};

export default App;
