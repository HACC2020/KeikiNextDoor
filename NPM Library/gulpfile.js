const gulp = require('gulp');

gulp.task('css', () => {
    const postcss = require('gulp-postcss');
    const rename = require('gulp-rename');

    return gulp.src('styles.css')
        .pipe(postcss([
            require('precss'),
            require('tailwindcss'),
            require('autoprefixer')
        ]))
        .pipe(rename('tailwind.css'))
        .pipe(gulp.dest('../wwwroot/css/'));
});