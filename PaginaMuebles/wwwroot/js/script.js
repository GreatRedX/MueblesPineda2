const carouselImages = document.getElementById('carouselImages');
const images = carouselImages.querySelectorAll('img');
let currentIndex = 0;

// Función para mover el carrusel
function moveSlide(direction) {
  const totalSlides = images.length;
  currentIndex = (currentIndex + direction + totalSlides) % totalSlides;
  updateCarousel();
}

// Función que actualiza la posición del carrusel
function updateCarousel() {
  const imageWidth = carouselImages.clientWidth; // se ajusta con el contenedor visible
  carouselImages.style.transform = `translateX(-${currentIndex * imageWidth}px)`;
}

// Movimiento automático cada 5 segundos
setInterval(() => {
  moveSlide(1);
}, 5000);

// Redimensiona el carrusel si cambia el tamaño de la ventana
window.addEventListener('resize', updateCarousel);
