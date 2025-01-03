/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Views/**/*.cshtml", // Inclut toutes les vues Razor
        "./wwwroot/js/**/*.js", // Inclut les fichiers JavaScript
        "./Pages/**/*.cshtml",  // Inclut les vues dans Pages si Razor Pages est utilisé
    ],
    theme: {
        extend: {
            colors: {
                'lion': '#AA8453',
                'lion-dark': '#937248',
                'eerie-black': '#222222',
                'coyote': '#80633E',
                'platinum': '#E0E0E0',
                'nero': '#202020',
                'nero-dark': "#1E1E1E",
                'light-gray': "#e9e9e9",
                'teal': "#008080",
                'teal-dark': "#004c4c",
                'teal-book': "#b2d8d8",
            },
            fontFamily: {
                'barlow': ['Barlow', 'sans-serif'],
                'gilda': ['Gilda Display', 'serif'],
                'mont': ['Montserrat', 'sans-serif'],
                'barlow-cond': ['Barlow Condensed', 'sans-serif']
            },
            backgroundImage: {
                'header-image': "linear-gradient(rgba(0, 0, 0, 0.8), rgba(0, 0, 0, 0.8)), url('/header-image.jpg')",
                'banner-image': "linear-gradient(0deg, rgba(16, 16, 16, 0.5), rgba(16, 16, 16, 0.5)), url('/banner-image.png')",
                'booking-image': "linear-gradient(rgba(16, 16, 16, 0.5), rgba(16, 16, 16, 0.5)), url('/booking-image.png')"
            },
        },
    },
    plugins: [],
}