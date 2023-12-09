window.scrollTo = (id) => {
	var element = document.getElementById(id);

	if(element !== null)
		element.scrollIntoView({ behavior: 'smooth',  });
}

window.addEventListener('scroll', function (evt) {
	let navBar = document.getElementById('nav-bar');

	(window.scrollY > 25)
		? navBar.classList.add('nav-border')
		: navBar.classList.remove('nav-border');
})
