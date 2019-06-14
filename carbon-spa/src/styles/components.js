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
		--main-color: #3d1f68;
		--secondary-color: #efefef;
	}
`;

export const Button = styled.button`
	color: var(--main-color);
	text-transform: uppercase;
	font-family: "Dosis", sans-serif;
	font-size: inherit;
	background-color: transparent;
	height: 7rem;
	width: 7rem;
	cursor: pointer;

	border: 1px groove black;
	border-radius: 50%;
	text-align: center;
	text-decoration: none;

	transition: 0.3s;

	position: absolute;
	transform: translate(-50%);
	top: 50%;

	:hover {
		color: var(--secondary-color);
		background-color: ${props => (props.danger ? "#ff2323" : "var(--main-color)")};
	}
`;
