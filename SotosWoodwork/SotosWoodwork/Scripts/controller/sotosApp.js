var app = angular.module('sotosApp', ['ngRoute']);

app.config(function ($routeProvider, $locationProvider) {
    $routeProvider
    .when('/', {
        templateUrl: '/Home/Dashboard',
        controller: 'sotosController',
    })
    .when('/Pessoa', {
        templateUrl: '/Pessoa/PessoaList',
        controller: 'pessoaController',
    })
    .when('/EditarPessoa', {
        templateUrl: '/Pessoa/PessoaForm',
        controller: 'pessoaController',
    })
    .when('/AdicionarPessoa', {
        templateUrl: '/Pessoa/PessoaForm',
        controller: 'pessoaController',
    })
    .otherwise({ redirectTo: '/' });
});


app.controller("sotosController", function ($scope, $http) {

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

app.controller("pessoaController", function ($scope, $http, $routeParams, $location) {
    $scope.pessoasList = [];
    $scope.cidadesList = [];
    $scope.gruposList = [];
    $scope.sortType = "Pes_razaosocial";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_pessoa = {};
    $scope.Pes_tipo = [{ valor: "F", descricao: "Física" }, { valor: "J", descricao: "Jurídica" }];

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Pessoa/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_pessoa = response.data;
        });
    }

    $scope.loadPessoasList = function () {
        $http.get(window.location.origin + "/Pessoa/FindAll", { method: "GET" }).then(function (response) {
            $scope.pessoasList = response.data;
        });
    };

    $scope.loadCidadesList = function () {
        $http.get(window.location.origin + "/Cidade/FindAll", { method: "GET" }).then(function (response) {
            $scope.cidadesList = response.data;
            if (!$scope.Sts_pessoa.Pes_codigo)
                $scope.Sts_pessoa.Sts_cidade = $scope.cidadesList[0];
        });
    };

    $scope.loadGruposList = function () {
        $http.get(window.location.origin + "/Grupo/FindAll", { method: "GET" }).then(function (response) {
            $scope.cidadesList = response.data;
        });
    };

    $scope.delete = function (Sts_pessoa) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {

            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Pessoa/Delete",
                    params: {
                        id: Sts_pessoa.Pes_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadPessoasList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_pessoa) {
        $http({
            method: "GET",
            url: window.location.origin + "/Pessoa/Save",
            params: {
                json: Sts_pessoa
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_pessoa.Pes_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Pessoa';
            });
        });
    };

    $scope.loadPessoasList();
    $scope.loadCidadesList();
    $scope.loadGruposList();
});