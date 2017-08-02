(function () {
    'use strict';

    angular.module('app').controller('csvController', loginController);

    function loginController(configService, $state) {
        var vm = this;

        vm.primaryList = [];

        vm.processFile = processFile;

        var fileInput = document.getElementById("csvViewer");

        init();

        function init() {
            if (!configService.getLogin()) $state.go('login');
        }

        function processFile() {
            
            vm.primaryList = [];

            readFile(function (result) {
                var list = [];
                var totalLines = result.split('\r\n').length - 1;
                var count = 0;
                var csvWorker = new Worker("/js/worker.js");

                csvWorker.addEventListener('message', function (message) {
                    list.push(message.data);
                    console.log('Processing...');
                    count++;
                    if (count >= totalLines) csvWorker.terminate();
                });
                               
                csvWorker.postMessage(result);                         

            });

        }

        function readFile(callback) {
            var reader = new FileReader();

            reader.onload = function () {
                return callback(reader.result);
            };

            reader.readAsBinaryString(fileInput.files[0]);
        }

    }

})();