import styled, { createGlobalStyle } from "styled-components";

export const GlobalStyle = createGlobalStyle`
  body {
		margin: 0;
		padding: 0;

		@import url('https://fonts.googleapis.com/css?family=Dosis');
		font-family: 'Dosis', sans-serif;

		background-color: black;

		text-align: center;
	}
	:root {
		--main-color: rgb(123, 0, 188);
		--secondary-color: #efefef;
	}
`;

export const Button = styled.button`
	color: var(--main-color);
	text-transform: uppercase;
	font-family: "Dosis", sans-serif;
	font-size: 2rem;
	background-color: transparent;
	height: 10rem;
	width: 10rem;
	cursor: pointer;

	border: 1px groove black;
	/* border-radius: 50%; */
	text-align: center;
	text-decoration: none;

	transition: 0.3s;

	background: linear-gradient(0deg, #000, #272727);
	position: relative;
	margin: calc(50vh - 5rem);

	:hover {
		color: var(--secondary-color);
		background-color: ${props => (props.danger ? "#ff2323" : "var(--main-color)")};
	}

	:before,
	:after {
		content: "";
		position: absolute;
		left: -2px;
		top: -2px;
		background: linear-gradient(
			45deg,
			#fb0094,
			#0000ff,
			#00ff00,
			#ffff00,
			#ff0000,
			#fb0094,
			#0000ff,
			#00ff00,
			#ffff00,
			#ff0000
		);
		background-size: 400%;
		width: calc(100% + 4px);
		height: calc(100% + 4px);
		z-index: -1;
		animation: steam 20s linear infinite;
	}

	@keyframes steam {
		0% {
			background-position: 0 0;
		}
		50% {
			background-position: 400% 0;
		}
		100% {
			background-position: 0 0;
		}
	}

	:after {
		filter: blur(50px);
	}
`;
