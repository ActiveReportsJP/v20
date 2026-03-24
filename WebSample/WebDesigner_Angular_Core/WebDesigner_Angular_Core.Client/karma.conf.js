module.exports = function (config) {
  config.set({
    basePath: '',
    frameworks: ['@angular-devkit/build-angular'],
    plugins: [
      require('karma-chrome-launcher'),
      require('@angular-devkit/build-angular/plugins/karma')
    ],
    reporters: ['progress', 'kjhtml'],
    port: 9876,
    colors: true,
    logLevel: config.LOG_INFO,
    autoWatch: true,
    browsers: ['Chrome'],
    singleRun: false,
    restartOnFileChange: true,
    listenAddress: 'localhost',
    hostname: 'localhost'
  });
};

