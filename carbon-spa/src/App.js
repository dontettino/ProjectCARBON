import React from "react";

import { Button, GlobalStyle } from "./styles/components";

const App = () => {
	function notifyMe() {
		// Let's check if the browser supports notifications
		if (!("Notification" in window)) {
			alert("This browser does not support desktop notification");
		}

		// Let's check whether notification permissions have already been granted
		else if (Notification.permission === "granted") {
			// If it's okay let's create a notification
			new Notification("Why did you click?");
		}

		// Otherwise, we need to ask the user for permission
		else if (Notification.permission !== "denied") {
			Notification.requestPermission().then(function(permission) {
				// If the user accepts, let's create a notification
				if (permission === "granted") {
					new Notification("Why did you click?");
				}
			});
		}

		console.log("clicked");
	}
	return (
		<div>
			<GlobalStyle />
			<div className="App">
				<Button danger onClick={notifyMe}>
					DON'T CLICK THIS BUTTON!
				</Button>
			</div>
		</div>
	);
};

export default App;
