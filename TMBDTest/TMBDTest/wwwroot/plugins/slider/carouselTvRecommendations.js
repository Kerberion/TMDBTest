const filaTvRecommendations = document.querySelector('.contenedor-carouselTvRecommendations');
const peliculasTvRecommendations = document.querySelectorAll('.peliculaTvRecommendations');

const flechaIzquierdaTvRecommendations = document.getElementById('flecha-izquierdaTvRecommendations');
const flechaDerechaTvRecommendations = document.getElementById('flecha-derechaTvRecommendations');

// ? ----- ----- Event Listener para la flecha derecha. ----- -----
flechaDerechaTvRecommendations.addEventListener('click', () => {
	filaTvRecommendations.scrollLeft += filaTvRecommendations.offsetWidth;

	const indicadorActivo = document.querySelector('.indicadoresTvRecommendations .activo');
	if (indicadorActivo.nextSibling) {
		indicadorActivo.nextSibling.classList.add('activo');
		indicadorActivo.classList.remove('activo');
	}
});

// ? ----- ----- Event Listener para la flecha izquierda. ----- -----
flechaIzquierdaTvRecommendations.addEventListener('click', () => {
	filaTvRecommendations.scrollLeft -= filaTvRecommendations.offsetWidth;

	const indicadorActivo = document.querySelector('.indicadoresTvRecommendations .activo');
	if (indicadorActivo.previousSibling) {
		indicadorActivo.previousSibling.classList.add('activo');
		indicadorActivo.classList.remove('activo');
	}
});

// ? ----- ----- Paginacion ----- -----
const numeroPaginasTvRecommendations = Math.ceil(peliculasTvRecommendations.length / 5);
for (let i = 0; i < numeroPaginasTvRecommendations; i++) {
	const indicador = document.createElement('button');

	if (i === 0) {
		indicador.classList.add('activo');
	}

	document.querySelector('.indicadoresTvRecommendations').appendChild(indicador);
	indicador.addEventListener('click', (e) => {
		filaTvRecommendations.scrollLeft = i * filaTvRecommendations.offsetWidth;

		document.querySelector('.indicadoresTvRecommendations .activo').classList.remove('activo');
		e.target.classList.add('activo');
	});
}

// ? ----- ----- Hover ----- -----
peliculasTvRecommendations.forEach((pelicula) => {
	pelicula.addEventListener('mouseenter', (e) => {
		const elemento = e.currentTarget;
		setTimeout(() => {
			peliculasTvRecommendations.forEach(pelicula => pelicula.classList.remove('hover'));
			elemento.classList.add('hover');
		}, 300);
	});
});

filaTvRecommendations.addEventListener('mouseleave', () => {
	peliculasTvRecommendations.forEach(pelicula => pelicula.classList.remove('hover'));
});