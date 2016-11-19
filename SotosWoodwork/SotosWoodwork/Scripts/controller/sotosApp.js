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
    .when('/Setor', {
        templateUrl: '/Setor/SetorList',
        controller: 'setorController',
    })
    .when('/EditarSetor', {
        templateUrl: '/Setor/SetorForm',
        controller: 'setorController',
    })
    .when('/AdicionarSetor', {
        templateUrl: '/Setor/SetorForm',
        controller: 'setorController',
    })
    .when('/Maquina', {
        templateUrl: '/Maquina/MaquinaList',
        controller: 'maquinaController',
    })
    .when('/EditarMaquina', {
        templateUrl: '/Maquina/MaquinaForm',
        controller: 'maquinaController',
    })
    .when('/AdicionarMaquina', {
        templateUrl: '/Maquina/MaquinaForm',
        controller: 'maquinaController',
    })
    .when('/UnidadeMedida', {
        templateUrl: '/UnidadeMedida/UnidadeMedidaList',
        controller: 'unidademedidaController',
    })
    .when('/EditarUnidadeMedida', {
        templateUrl: '/UnidadeMedida/UnidadeMedidaForm',
        controller: 'unidademedidaController',
    })
    .when('/AdicionarUnidadeMedida', {
        templateUrl: '/UnidadeMedida/UnidadeMedidaForm',
        controller: 'unidademedidaController',
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
}).directive('convertToBool', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attrs, ngModel) {
            ngModel.$parsers.push(function (val) {
                return val == true || val == 'true';
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
            $scope.gruposList = response.data;
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

app.controller("setorController", function ($scope, $http, $routeParams, $location) {
    $scope.setoresList = [];
    $scope.sortType = "Set_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_setor = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Setor/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_setor = response.data;
        });
    }

    $scope.loadSetoresList = function () {
        $http.get(window.location.origin + "/Setor/FindAll", { method: "GET" }).then(function (response) {
            $scope.setoresList = response.data;
        });
    };

    $scope.delete = function (Sts_setor) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Setor/Delete",
                    params: {
                        id: Sts_setor.Set_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadSetoresList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_setor) {
        $http({
            method: "GET",
            url: window.location.origin + "/Setor/Save",
            params: {
                json: Sts_setor
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_setor.Set_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Setor';
            });
        });
    };

    $scope.loadSetoresList();
});

app.controller("maquinaController", function ($scope, $http, $routeParams, $location) {
    $scope.maquinasList = [];
    $scope.setoresList = [];
    $scope.gruposList = [];
    $scope.sortType = "Maq_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_maquina = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Maquina/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_maquina = response.data;
        });
    }

    $scope.loadMaquinasList = function () {
        $http.get(window.location.origin + "/Maquina/FindAll", { method: "GET" }).then(function (response) {
            $scope.maquinasList = response.data;
        });
    };

    $scope.loadSetoresList = function () {
        $http.get(window.location.origin + "/Setor/FindAll", { method: "GET" }).then(function (response) {
            $scope.setoresList = response.data;
            if (!$scope.Sts_maquina.Maq_codigo)
                $scope.Sts_maquina.Sts_setor = $scope.setoresList[0];
        });
    };

    $scope.delete = function (Sts_maquina) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {

            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Maquina/Delete",
                    params: {
                        id: Sts_maquina.Maq_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadMaquinasList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_maquina) {
        $http({
            method: "GET",
            url: window.location.origin + "/Maquina/Save",
            params: {
                json: Sts_maquina
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_maquina.Maq_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Maquina';
            });
        });
    };

    $scope.loadMaquinasList();
    $scope.loadSetoresList();
});

app.controller("unidademedidaController", function ($scope, $http, $routeParams, $location) {
    $scope.unidademedidaList = [];
    $scope.sortType = "Unm_sigla";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_unidademedida = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/UnidadeMedida/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_unidademedida = response.data;
        });
    }

    $scope.loadUnidadeMedidaList = function () {
        $http.get(window.location.origin + "/UnidadeMedida/FindAll", { method: "GET" }).then(function (response) {
            $scope.unidademedidaList = response.data;
        });
    };

    $scope.delete = function (Sts_unidademedida) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/UnidadeMedida/Delete",
                    params: {
                        id: Sts_unidademedida.Unm_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadUnidadeMedidaList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_unidademedida) {
        $http({
            method: "GET",
            url: window.location.origin + "/UnidadeMedida/Save",
            params: {
                json: Sts_unidademedida
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_unidademedida.Unm_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#UnidadeMedida';
            });
        });
    };

    $scope.loadUnidadeMedidaList();
});