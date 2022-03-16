const filaTvRated = document.querySelector('.contenedor-carouselTvRated');
const peliculasTvRated = document.querySelectorAll('.peliculaTvRated');

const flechaIzquierdaTvRated = document.getElementById('flecha-izquierdaTvRated');
const flechaDerechaTvRated = document.getElementById('flecha-derechaTvRated');

// ? ----- ----- Event Listener para la flecha derecha. ----- -----
flechaDerechaTvRated.addEventListener('click', () => {
	filaTvRated.scrollLeft += filaTvRated.offsetWidth;

	const indicadorActivo = document.querySelector('.indicadoresTvRated .activo');
	if (indicadorActivo.nextSibling) {
		indicadorActivo.nextSibling.classList.add('activo');
		indicadorActivo.classList.remove('activo');
	}
});

// ? ----- ----- Event Listener para la flecha izquierda. ----- -----
flechaIzquierdaTvRated.addEventListener('click', () => {
	filaTvRated.scrollLeft -= filaTvRated.offsetWidth;

	const indicadorActivo = document.querySelector('.indicadoresTvRated .activo');
	if (indicadorActivo.previousSibling) {
		indicadorActivo.previousSibling.classList.add('activo');
		indicadorActivo.classList.remove('activo');
	}
});

// ? ----- ----- Paginacion ----- -----
const numeroPaginasTvRated = Math.ceil(peliculasTvRated.length / 5);
for (let i = 0; i < numeroPaginasTvRated; i++) {
	const indicador = document.createElement('button');

	if (i === 0) {
		indicador.classList.add('activo');
	}

	document.querySelector('.indicadoresTvRated').appendChild(indicador);
	indicador.addEventListener('click', (e) => {
		filaTvRated.scrollLeft = i * filaTvRated.offsetWidth;

		document.querySelector('.indicadoresTvRated .activo').classList.remove('activo');
		e.target.classList.add('activo');
	});
}

// ? ----- ----- Hover ----- -----
peliculasTvRated.forEach((pelicula) => {
	pelicula.addEventListener('mouseenter', (e) => {
		const elemento = e.currentTarget;
		setTimeout(() => {
			peliculasTvRated.forEach(pelicula => pelicula.classList.remove('hover'));
			elemento.classList.add('hover');
		}, 300);
	});
});

filaTvRated.addEventListener('mouseleave', () => {
	peliculasTvRated.forEach(pelicula => pelicula.classList.remove('hover'));
});