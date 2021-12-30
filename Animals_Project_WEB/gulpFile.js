var gulp = require('gulp');
var concat = require("gulp-concat");
var cssmin = require("gulp-cssmin");
var uglify = require("gulp-uglify");

var paths = {  
    webroot: "./wwwroot/", 
    nodeModules: "./node_modules/"
};

paths.bootstrapCss = paths.nodeModules + "bootstrap/dist/css/bootstrap.css";
paths.vendorCssFileName = "vendor.min.css";
paths.destinationCssFolder = paths.webroot + "styles/";

gulp.task("minify-vendor-css", function () {
    return gulp.src(paths.bootstrapCss)
        .pipe(concat(paths.vendorCssFileName))
        .pipe(cssmin())
        .pipe(gulp.dest(paths.destinationCssFolder));
});

paths.bootstrapjs = paths.nodeModules + "bootstrap/dist/js/bootstrap.js";
paths.jqueryjs = paths.nodeModules + "jquery/dist/jquery.js";
paths.popperjs = paths.nodeModules + "popper.js/dist/umd/popper.js";
paths.vendorJsFiles = [paths.bootstrapjs, paths.jqueryjs, paths.popperjs];
paths.vendorJsFileName = "vendor.min.js";
paths.destinationJsFolder = paths.webroot + "Scripts/";


gulp.task("minify-vendor-js", function () {
    return gulp.src(paths.vendorJsFiles)
        .pipe(concat(paths.vendorJsFileName))
        .pipe(uglify())
        .pipe(gulp.dest(paths.destinationJsFolder));
});


gulp.task("js-watcher", function () {
    gulp.watch(paths.jsFiles, ["minify-vendor-js"]);
});