const gulp = require('gulp');
const concat = require('gulp-concat');
const sass = require('gulp-sass');

// ****************************
// Move JS Files to src/js
// ****************************

//gulp.task('js', function () {
//    return gulp.src([
//            'node_modules/jquery/dist/jquery.min.js',
//            'node_modules/bootstrap/dist/js/bootstrap.min.js',
//            'node_modules/popper.js/dist/umd/popper.min.js',
//            'node_modules/owl.carousel2/dist/owl.carousel.min.js',
//            'node_modules/magnific-popup/dist/jquery.magnific-popup.min.js',
//            'node_modules/wowjs/dist/wow.min.js',
//            'node_modules/imagesloaded/imagesloaded.pkgd.min.js',
//            'node_modules/isotope-layout/dist/isotope.pkgd.min.js',
//            'node_modules/jarallax/dist/jarallax.min.js',
//            'node_modules/jarallax/dist/jarallax-video.min.js',
//            'node_modules/jquery-waypoints/waypoints.min.js',
//            'node_modules/counterup/jquery.counterup.min.js',
//            'node_modules/jquery.easing/jquery.easing.min.js',
//            'node_modules/jquery-countdown/dist/jquery.countdown.min.js',
//            'node_modules/jquery-nice-select/js/jquery.nice-select.min.js',
//            'node_modules/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js',
//            'node_modules/jquery-ui-slider/jquery-ui.min.js'
//        ])
//        .pipe(gulp.dest("scripts"));
//});

// ******************************
// Combine All js files into one
// ******************************

gulp.task('scripts', function () {
    return gulp.src([
        'node_modules/jquery/dist/jquery.min.js',
        'node_modules/bootstrap/dist/js/bootstrap.min.js',
        'node_modules/popper.js/dist/umd/popper.min.js',
        './scripts/default-assets/avoid.console.error.js',
        './scripts/default-assets/classy-nav.js',
        'node_modules/owl.carousel2/dist/owl.carousel.min.js',
        'node_modules/wowjs/dist/wow.min.js',
        'node_modules/magnific-popup/dist/jquery.magnific-popup.min.js',
        'node_modules/jquery-waypoints/waypoints.min.js',
        'node_modules/counterup/jquery.counterup.min.js',
        'node_modules/imagesloaded/imagesloaded.pkgd.min.js',
        'node_modules/isotope-layout/dist/isotope.pkgd.min.js',
        'node_modules/jarallax/dist/jarallax.min.js',
        'node_modules/jarallax/dist/jarallax-video.min.js',
        './scripts/default-assets/jquery.scrollup.min.js',
        'node_modules/jquery-countdown/dist/jquery.countdown.min.js',
        'node_modules/jquery-nice-select/js/jquery.nice-select.min.js',
        'node_modules/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js',
        'node_modules/jquery-ui-slider/jquery-ui.min.js',
        'node_modules/jquery.easing/jquery.easing.min.js'
    ])
        .pipe(concat('vendor.bundle.js'))
        .pipe(gulp.dest('./scripts/'));
});

// *************************************
// Move Font Awesome Fonts to src/fonts
// *************************************

gulp.task('fafonts', function () {
    return gulp.src([
            'node_modules/font-awesome/fonts/*'
        ])
        .pipe(gulp.dest('fonts'));
})

// *************************************
// Move Elegent Icons to src/fonts
// *************************************
gulp.task('elefonts', function () {
    return gulp.src([
            'node_modules/elegant-icons/fonts/*'
        ])
        .pipe(gulp.dest('css/fonts'));
})

// *******************************
// Move CSS to src/css
// *******************************

gulp.task('css', function () {
    return gulp.src([
            'node_modules/bootstrap/dist/css/bootstrap.min.css',
            'node_modules/font-awesome/css/font-awesome.min.css',
            'node_modules/owl.carousel2/dist/assets/owl.carousel.min.css',
            'node_modules/elegant-icons/style.css',
            'node_modules/wowjs/css/libs/animate.css',
            'node_modules/magnific-popup/dist/magnific-popup.css',
            'node_modules/jquery-nice-select/css/nice-select.css',
            'node_modules/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css',
            'node_modules/jquery-ui-slider/jquery-ui.min.css'
        ])
        .pipe(concat('vendor.bundle.css'))
        .pipe(gulp.dest('css'));
})

gulp.task('sass', function () {
  gulp.src('scss/main.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(gulp.dest('css'));
});

gulp.task('default', ['scripts', 'fafonts', 'elefonts', 'css', 'sass']);