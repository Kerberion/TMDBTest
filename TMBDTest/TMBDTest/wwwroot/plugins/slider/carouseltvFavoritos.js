const filatvFavoritos = document.querySelector('.contenedor-carouseltvFavoritos');
const peliculastvFavoritos = document.querySelectorAll('.peliculatvFavoritos');

const flechaIzquierdatvFavoritos = document.getElementById('flecha-izquierdatvFavoritos');
const flechaDerechatvFavoritos = document.getElementById('flecha-derechatvFavoritos');

// ? ----- ----- Event Listener para la flecha derecha. ----- -----
flechaDerechatvFavoritos.addEventListener('click', () => {
	filatvFavoritos.scrollLeft += filatvFavoritos.offsetWidth;

	const indicadorActivo = document.querySelector('.indicadorestvFavoritos .activo');
	if (indicadorActivo.nextSibling) {
		indicadorActivo.nextSibling.classList.add('activo');
		indicadorActivo.classList.remove('activo');
	}
});

// ? ----- ----- Event Listener para la flecha izquierda. ----- -----
flechaIzquierdatvFavoritos.addEventListener('click', () => {
	filatvFavoritos.scrollLeft -= filatvFavoritos.offsetWidth;

	const indicadorActivo = document.querySelector('.indicadorestvFavoritos .activo');
	if (indicadorActivo.previousSibling) {
		indicadorActivo.previousSibling.classList.add('activo');
		indicadorActivo.classList.remove('activo');
	}
});

// ? ----- ----- Paginacion ----- -----
const numeroPaginastvFavoritos = Math.ceil(peliculastvFavoritos.length / 5);
for (let i = 0; i < numeroPaginastvFavoritos; i++) {
	const indicador = document.createElement('button');

	if (i === 0) {
		indicador.classList.add('activo');
	}

	document.querySelector('.indicadorestvFavoritos').appendChild(indicador);
	indicador.addEventListener('click', (e) => {
		filatvFavoritos.scrollLeft = i * filatvFavoritos.offsetWidth;

		document.querySelector('.indicadorestvFavoritos .activo').classList.remove('activo');
		e.target.classList.add('activo');
	});
}

// ? ----- ----- Hover ----- -----
peliculastvFavoritos.forEach((pelicula) => {
	pelicula.addEventListener('mouseenter', (e) => {
		const elemento = e.currentTarget;
		setTimeout(() => {
			peliculastvFavoritos.forEach(pelicula => pelicula.classList.remove('hover'));
			elemento.classList.add('hover');
		}, 300);
	});
});

filatvFavoritos.addEventListener('mouseleave', () => {
	peliculastvFavoritos.forEach(pelicula => pelicula.classList.remove('hover'));
});