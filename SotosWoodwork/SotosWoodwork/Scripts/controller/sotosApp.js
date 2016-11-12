var app = angular.module('sotosApp', []);

app.controller("sotosController", function ($scope, $compile, $http) {
    $scope.requestPage = function (page, activeTab, model) {
        $("#content").load(page, function () {
            if (model) {
                $scope.model = model;
            } else {
                $scope.model = {};
            }
            $scope.$parent.activetab = activeTab;
            $compile($("#content"))($scope);
        });
    };
}).directive('convertToNumber', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attrs, ngModel) {
            ngModel.$parsers.push(function (val) {
                return parseInt(val, 10);
            });
            ngModel.$formatters.push(function (val) {
                return '' + val;
            });
        }
    };
});

app.controller("pessoaController", function ($scope, $http) {
    $scope.pessoasList = [];
    $scope.sortType = "pes_nomefantasia";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.pessoa = $scope.$parent.model;
    $scope.http = $http;

    $scope.loadPessoasList = function () {
        $http.get("Pessoa/FindAll", { method: "GET" }).then(function (response) {
            $scope.pessoasList = response.data;
        });
    };

    $scope.delete = function (pessoa) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: "Pessoa/Delete",
                    params: {
                        id: pessoa.pes_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadPessoasList();
                    });
                });
            }
        });
    };

    $scope.save = function (pessoa) {
        if (pessoa.pes_codigo === undefined) {
            $scope.insert(pessoa);
        } else {
            $scope.update(pessoa);
        }
    };

    $scope.insert = function (pessoa) {
        $http({
            method: "GET",
            url: "Pessoa/Insert",
            params: {
                json: pessoa
            }
        }).then(function (response) {
            bootbox.alert("Registro inserido com Sucesso!", function () {
                $scope.requestPage('Pessoa');
            });
        });
    };

    $scope.update = function (pessoa) {
        $http({
            method: "GET",
            url: "Pessoa/Update",
            params: {
                json: pessoa
            }
        }).then(function (response) {
            bootbox.alert("Registro alterado com Sucesso!", function () {
                $scope.requestPage('Pessoa');
            });
        });
    };

    $scope.loadPessoasList();
});