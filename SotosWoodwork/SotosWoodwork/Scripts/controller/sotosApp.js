﻿var app = angular.module('sotosApp', ['ngRoute']);

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
    .when('/Grupo', {
        templateUrl: '/Grupo/GrupoList',
        controller: 'grupoController',
    })
    .when('/EditarGrupo', {
        templateUrl: '/Grupo/GrupoForm',
        controller: 'grupoController',
    })
    .when('/AdicionarGrupo', {
        templateUrl: '/Grupo/GrupoForm',
        controller: 'grupoController',
    })
    .when('/FormaPagamento', {
        templateUrl: '/FormaPagamento/FormaPagamentoList',
        controller: 'formaPagamentoController',
    })
    .when('/EditarFormaPagamento', {
        templateUrl: '/FormaPagamento/FormaPagamentoForm',
        controller: 'formaPagamentoController',
    })
    .when('/AdicionarFormaPagamento', {
        templateUrl: '/FormaPagamento/FormaPagamentoForm',
        controller: 'formaPagamentoController',
    })
    .when('/Cor', {
        templateUrl: '/Cor/CorList',
        controller: 'corController',
    })
    .when('/EditarCor', {
        templateUrl: '/Cor/CorForm',
        controller: 'corController',
    })
    .when('/AdicionarCor', {
        templateUrl: '/Cor/CorForm',
        controller: 'corController',
    })
    .when('/Fornecedor', {
        templateUrl: '/Pessoa/FornecedorList',
        controller: 'pessoaController',
    })
    .when('/EditarFornecedor', {
        templateUrl: '/Pessoa/FornecedorForm',
        controller: 'pessoaController',
    })
    .when('/AdicionarFornecedor', {
        templateUrl: '/Pessoa/FornecedorForm',
        controller: 'pessoaController',
    })
    .when('/Colaborador', {
        templateUrl: '/Pessoa/ColaboradorList',
        controller: 'pessoaController',
    })
    .when('/EditarColaborador', {
        templateUrl: '/Pessoa/ColaboradorForm',
        controller: 'pessoaController',
    })
    .when('/AdicionarColaborador', {
        templateUrl: '/Pessoa/ColaboradorForm',
        controller: 'pessoaController',
    })
    .when('/MateriaPrima', {
        templateUrl: '/Produto/MateriaPrimaList',
        controller: 'produtoController',
    })
    .when('/EditarMateriaPrima', {
        templateUrl: '/Produto/MateriaPrimaForm',
        controller: 'produtoController',
    })
    .when('/AdicionarMateriaPrima', {
        templateUrl: '/Produto/MateriaPrimaForm',
        controller: 'produtoController',
    })
    .when('/Produto', {
        templateUrl: '/Produto/ProdutoList',
        controller: 'produtoController',
    })
    .when('/EditarProduto', {
        templateUrl: '/Produto/ProdutoForm',
        controller: 'produtoController',
    })
    .when('/AdicionarProduto', {
        templateUrl: '/Produto/ProdutoForm',
        controller: 'produtoController',
    })
    .when('/EditarSetorPessoas', {
        templateUrl: '/SetorPessoas/SetorPessoasList',
        controller: 'setorPessoasController',
    })
    .when('/EditarProdutoMateriais', {
        templateUrl: '/ProdutoMateriais/ProdutoMateriaisList',
        controller: 'produtoMateriaisController',
    })
    .when('/EditarProdutoProcessos', {
        templateUrl: '/ProdutoProcessos/ProdutoProcessosList',
        controller: 'produtoProcessosController',
    })
    .when('/Orcamento', {
        templateUrl: '/Orcamento/OrcamentoList',
        controller: 'orcamentoController',
    })
    .when('/EditarOrcamento', {
        templateUrl: '/Orcamento/OrcamentoForm',
        controller: 'orcamentoController',
    })
    .when('/AdicionarOrcamento', {
        templateUrl: '/Orcamento/OrcamentoForm',
        controller: 'orcamentoController',
    })
    .when('/EditarOrcamentoProdutos', {
        templateUrl: '/OrcamentoProdutos/OrcamentoProdutosList',
        controller: 'orcamentoProdutosController',
    })
    .when('/EditarOrdemProdutos', {
        templateUrl: '/OrdemProdutos/OrdemProdutosList',
        controller: 'ordemProdutosController',
    })
    .when('/OrdemProducao', {
        templateUrl: '/OrdemProducao/OrdemProducaoList',
        controller: 'ordemProducaoController',
    })
    .when('/EditarOrdemProducao', {
        templateUrl: '/OrdemProducao/OrdemProducaoForm',
        controller: 'ordemProducaoController',
    })
    .when('/AdicionarOrdemProducao', {
        templateUrl: '/OrdemProducao/OrdemProducaoForm',
        controller: 'ordemProducaoController',
    })
    .when('/Estoque', {
        templateUrl: '/Estoque/EstoqueList',
        controller: 'estoqueController',
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
    $scope.fornecedoresList = [];
    $scope.colaboradoresList = [];
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
        $http.get(window.location.origin + "/Pessoa/FindAllClient", { method: "GET" }).then(function (response) {
            $scope.pessoasList = response.data;
        });
    };

    $scope.loadColaboradoresList = function () {
        $http.get(window.location.origin + "/Pessoa/FindAllEmployee", { method: "GET" }).then(function (response) {
            $scope.colaboradoresList = response.data;
        });
    };

    $scope.loadFornecedoresList = function () {
        $http.get(window.location.origin + "/Pessoa/FindAllProvider", { method: "GET" }).then(function (response) {
            $scope.fornecedoresList = response.data;
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
            url: window.location.origin + "/Pessoa/SaveClient",
            params: {
                json: Sts_pessoa
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_pessoa.Pes_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Pessoa';
            });
        });
    };

    $scope.saveFornecedor = function (Sts_pessoa) {
        $http({
            method: "GET",
            url: window.location.origin + "/Pessoa/SaveProvider",
            params: {
                json: Sts_pessoa
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_pessoa.Pes_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Fornecedor';
            });
        });
    };

    $scope.saveColaborador = function (Sts_pessoa) {
        $http({
            method: "GET",
            url: window.location.origin + "/Pessoa/SaveEmployee",
            params: {
                json: Sts_pessoa
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_pessoa.Pes_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Colaborador';
            });
        });
    };

    $scope.loadPessoasList();
    $scope.loadFornecedoresList();
    $scope.loadColaboradoresList();
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

app.controller("formaPagamentoController", function ($scope, $http, $routeParams, $location) {
    $scope.formaspagamentoList = [];
    $scope.sortType = "Frp_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_formapagamento = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/FormaPagamento/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_formapagamento = response.data;
        });
    }

    $scope.loadFormasPagamentoList = function () {
        $http.get(window.location.origin + "/FormaPagamento/FindAll", { method: "GET" }).then(function (response) {
            $scope.formaspagamentoList = response.data;
        });
    };

    $scope.delete = function (Sts_formapagamento) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {

            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/FormaPagamento/Delete",
                    params: {
                        id: Sts_formapagamento.Frp_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadFormasPagamentoList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_formapagamento) {
        $http({
            method: "GET",
            url: window.location.origin + "/FormaPagamento/Save",
            params: {
                json: Sts_formapagamento
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_formapagamento.Frp_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#FormaPagamento';
            });
        });
    };

    $scope.loadFormasPagamentoList();
});

app.controller("grupoController", function ($scope, $http, $routeParams, $location) {
    $scope.gruposList = [];
    $scope.sortType = "Grp_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_grupo = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Grupo/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_grupo = response.data;
        });
    }

    $scope.loadGruposList = function () {
        $http.get(window.location.origin + "/Grupo/FindAll", { method: "GET" }).then(function (response) {
            $scope.gruposList = response.data;
        });
    };

    $scope.delete = function (Sts_grupo) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Grupo/Delete",
                    params: {
                        id: Sts_grupo.Grp_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadGruposList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_grupo) {
        $http({
            method: "GET",
            url: window.location.origin + "/Grupo/Save",
            params: {
                json: Sts_grupo
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_grupo.Grp_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Grupo';
            });
        });
    };

    $scope.loadGruposList();
});

app.controller("corController", function ($scope, $http, $routeParams, $location) {
    $scope.coresList = [];
    $scope.sortType = "Cor_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_cor = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Cor/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_cor = response.data;
        });
    }

    $scope.loadCoresList = function () {
        $http.get(window.location.origin + "/Cor/FindAll", { method: "GET" }).then(function (response) {
            $scope.coresList = response.data;
        });
    };

    $scope.delete = function (Sts_cor) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Cor/Delete",
                    params: {
                        id: Sts_cor.Cor_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadCoresList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_cor) {
        $http({
            method: "GET",
            url: window.location.origin + "/Cor/Save",
            params: {
                json: Sts_cor
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_cor.Cor_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Cor';
            });
        });
    };

    $scope.loadCoresList();
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

app.controller("produtoController", function ($scope, $http, $routeParams, $location) {
    $scope.materiasprimaList = [];
    $scope.produtosList = [];
    $scope.fornecedoresList = [];
    $scope.unidademedidaList = [];
    $scope.coresList = [];
    $scope.sortType = "Pro_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_produto = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Produto/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_produto = response.data;
        });
    }

    $scope.loadMateriasPrimasList = function () {
        $http.get(window.location.origin + "/Produto/FindAllMateriaPrima", { method: "GET" }).then(function (response) {
            $scope.materiasprimaList = response.data;
        });
    };

    $scope.loadProdutosList = function () {
        $http.get(window.location.origin + "/Produto/FindAllProdutos", { method: "GET" }).then(function (response) {
            $scope.produtosList = response.data;
        });
    };

    $scope.loadFornecedoresList = function () {
        $http.get(window.location.origin + "/Pessoa/FindAllProvider", { method: "GET" }).then(function (response) {
            $scope.fornecedoresList = response.data;
        });
    };

    $scope.loadCoresList = function () {
        $http.get(window.location.origin + "/Cor/FindAll", { method: "GET" }).then(function (response) {
            $scope.coresList = response.data;
        });
    };

    $scope.loadUnidadeMedidaList = function () {
        $http.get(window.location.origin + "/UnidadeMedida/FindAll", { method: "GET" }).then(function (response) {
            $scope.unidademedidaList = response.data;
        });
    };

    $scope.delete = function (Sts_produto) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {

            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Produto/Delete",
                    params: {
                        id: Sts_produto.Pro_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadMateriasPrimasList();
                    });
                });
            }
        });
    };

    $scope.saveMateriaPrima = function (Sts_produto) {
        $http({
            method: "GET",
            url: window.location.origin + "/Produto/SaveMateriaPrima",
            params: {
                json: Sts_produto
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_produto.Pro_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#MateriaPrima';
            });
        });
    };

    $scope.saveProduto = function (Sts_produto) {
        $http({
            method: "GET",
            url: window.location.origin + "/Produto/SaveProduto",
            params: {
                json: Sts_produto
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_produto.Pro_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Produto';
            });
        });
    };

    $scope.loadMateriasPrimasList();
    $scope.loadFornecedoresList();
    $scope.loadUnidadeMedidaList();
    $scope.loadCoresList();
    $scope.loadProdutosList();
});

app.controller("setorPessoasController", function ($scope, $http, $routeParams, $location) {
    $scope.pessoasList = [];
    $scope.pessoasSetorList = [];
    $scope.sortType = "Pes_razaosocial";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_setor = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Setor/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_setor = response.data;
        });
    }

    $scope.loadPessoasList = function () {
        $http.get(window.location.origin + "/SetorPessoas/FindAllEmployees", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.pessoasList = response.data;
        });
    };

    $scope.loadSetorPessoasList = function () {
        $http.get(window.location.origin + "/SetorPessoas/FindAllEmployeesDepartment", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.pessoasSetorList = response.data;
        });
    };

    $scope.save = function () {
        $http({
            method: "POST",
            url: window.location.origin + "/SetorPessoas/Save",
            params: {
                json: angular.toJson($scope.pessoasSetorList),
                id: $scope.Sts_setor.Set_codigo
            }
        }).then(function (response) {
            bootbox.alert("Registros salvos com Sucesso!", function () {
                document.location.href = '#Setor';
            });
        });
    };

    $scope.shift = function () {
        $scope.aux = [];
        $scope.pessoasList.forEach(function (record, index) {
            if (record.marcado) {
                record.marcado = false;
                $scope.pessoasSetorList.push(record);
                $scope.pessoasList.splice(index, 1);
            }
        });

        $scope.aux = [];
        $scope.pessoasSetorList.forEach(function (record, index) {
            if (record.marcado) {
                record.marcado = false;
                $scope.pessoasList.push(record);
                $scope.pessoasSetorList.splice(index, 1);
            }
        });

    };

    $scope.loadPessoasList();
    $scope.loadSetorPessoasList();
});

app.controller("produtoMateriaisController", function ($scope, $http, $routeParams, $location) {
    $scope.produtoMateriaisList = [];
    $scope.materiasprimaList = [];
    $scope.sortType = "Pro_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_produto = {};
    $scope.Sts_produtomateriais = {};


    $scope.loadProdutoMateriaisList = function () {
        $http.get(window.location.origin + "/ProdutoMateriais/FindAllProdutoMateriais", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.produtoMateriaisList = response.data;
        });
    };

    $scope.loadMateriasPrimasList = function () {
        $http.get(window.location.origin + "/Produto/FindAllMateriaPrima", { method: "GET" }).then(function (response) {
            $scope.materiasprimaList = response.data;
        });
    };

    $scope.loadSts_produto = function () {
        $http.get(window.location.origin + "/ProdutoMateriais/GetProduto", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_produto = response.data;
            $scope.Sts_produtomateriais.Sts_produto = $scope.Sts_produto;
        });
    };

    $scope.delete = function (Sts_produtomateriais) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {

            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/ProdutoMateriais/Delete",
                    params: {
                        id: Sts_produtomateriais.Pmp_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadProdutoMateriaisList();
                    });
                });
            }
        });
    };

    $scope.save = function (Sts_produtomateriais) {
        $http({
            method: "GET",
            url: window.location.origin + "/ProdutoMateriais/Save",
            params: {
                json: Sts_produtomateriais
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_produtomateriais.Pmp_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#EditarProdutoMateriais?id=' + $routeParams.id;
            });
        });
    }
    $scope.loadProdutoMateriaisList();
    $scope.loadSts_produto();
    $scope.loadMateriasPrimasList();
});

app.controller("produtoProcessosController", function ($scope, $http, $routeParams, $location) {
    $scope.produtoProcessosList = [];
    $scope.maquinasList = [];
    $scope.setorPessoasList = [];
    $scope.sortType = "Pro_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_produto = {};
    $scope.Sts_produtoprocessos = {};


    $scope.loadProdutoProcessosList = function () {
        $http.get(window.location.origin + "/ProdutoProcessos/FindAllProdutoProcessos", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.produtoProcessosList = response.data;
        });
    };

    $scope.loadMaquinasList = function () {
        $http.get(window.location.origin + "/Maquina/FindAll", { method: "GET" }).then(function (response) {
            $scope.maquinasList = response.data;
        });
    };

    $scope.loadSetorPessoasList = function () {
        $http.get(window.location.origin + "/SetorPessoas/FindAll", { method: "GET" }).then(function (response) {
            $scope.setorPessoasList = response.data;
        });
    };

    $scope.loadSts_produto = function () {
        $http.get(window.location.origin + "/ProdutoProcessos/GetProduto", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_produto = response.data;
            $scope.Sts_produtoprocessos.Sts_produto = $scope.Sts_produto;
        });
    };

    $scope.delete = function (Sts_produtoprocessos) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {

            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/ProdutoProcessos/Delete",
                    params: {
                        id: Sts_produtoprocessos.Ppc_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadProdutoProcessosList();
                    });
                });
            }
        });
    };

    $scope.saveProcessos = function (Sts_produtoprocessos) {
        $http({
            method: "GET",
            url: window.location.origin + "/ProdutoProcessos/Save",
            params: {
                json: Sts_produtoprocessos
            }
        }).then(function (response) {
            bootbox.alert("! Registro " + (Sts_produtoprocessos.Ppc_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#EditarProdutoProcessos?id=' + $routeParams.id;
            });
        });
    }
    $scope.loadProdutoProcessosList();
    $scope.loadSts_produto();
    $scope.loadMaquinasList();
    $scope.loadSetorPessoasList();
});

app.controller("orcamentoController", function ($scope, $http, $routeParams, $location) {
    $scope.orcamentosList = [];
    $scope.pessoasList = [];
    $scope.formaspagamentoList = [];
    $scope.sortType = "Orc_data";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_orcamento = {};


    if ($routeParams.id) {
        $http.get(window.location.origin + "/Orcamento/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_orcamento = response.data;
            $scope.Sts_orcamento.Orc_data = new Date($scope.Sts_orcamento.Orc_data);
            $scope.Sts_orcamento.Orc_dataentrega = new Date($scope.Sts_orcamento.Orc_dataentrega);
        });
    }

    $scope.loadPessoasList = function () {
        $http.get(window.location.origin + "/Pessoa/FindAllClient", { method: "GET" }).then(function (response) {
            $scope.pessoasList = response.data;
        });
    };

    $scope.loadFormasPagamentoList = function () {
        $http.get(window.location.origin + "/FormaPagamento/FindAll", { method: "GET" }).then(function (response) {
            $scope.formaspagamentoList = response.data;
        });
    };

    $scope.loadOrcamentosList = function () {
        $http.get(window.location.origin + "/Orcamento/FindAll", { method: "GET" }).then(function (response) {
            $scope.orcamentosList = response.data;
        });
    };

    $scope.delete = function (Sts_orcamento) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Orcamento/Delete",
                    params: {
                        id: Sts_orcamento.Orc_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadOrcamentosList();
                    });
                });
            }
        });
    };

    $scope.gerarOP = function (Sts_orcamento) {
        bootbox.confirm("Deseja realmente gerar um Ordem de Produção para o Orçamento selecionado?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/Orcamento/gerarOP",
                    params: {
                        id: Sts_orcamento.Orc_codigo
                    }
                }).then(function (response) {
                    if (response != null && response.data != "Erro") {
                        bootbox.alert("Ordem de Produção gerada com sucesso!", function () {
                            document.location.href = '#OrdemProducao';
                        });
                    } else {
                        bootbox.alert("A ordem de produção não pode ser gerada, verifique os dados do orçamento!", function () {
                            document.location.href = '#Orcamento';
                        });
                    }
                });
            }
        });
    };

    $scope.save = function (Sts_orcamento) {
        $http({
            method: "GET",
            url: window.location.origin + "/Orcamento/Save",
            params: {
                json: Sts_orcamento
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_orcamento.Orc_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#Orcamento';
            });
        });
    };

    $scope.loadOrcamentosList();
    $scope.loadPessoasList();
    $scope.loadFormasPagamentoList();
});

app.controller("orcamentoProdutosController", function ($scope, $http, $routeParams, $location) {
    $scope.orcamentoProdutosList = [];
    $scope.produtosList = [];
    $scope.sortType = "Pro_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_orcamento = {};
    $scope.Sts_orcamentoprodutos = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/Orcamento/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_orcamento = response.data;
            $scope.Sts_orcamento.Orc_data = new Date($scope.Sts_orcamento.Orc_data);
        });
    }

    $scope.loadOrcamentoProdutosList = function () {
        $http.get(window.location.origin + "/OrcamentoProdutos/FindAllProductsOrder", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.orcamentoProdutosList = response.data;
        });
    };

    $scope.loadProdutosList = function () {
        $http.get(window.location.origin + "/Produto/FindAllProdutos", { method: "GET" }).then(function (response) {
            $scope.produtosList = response.data;
        });
    };

    $scope.delete = function (Sts_orcamentoprodutos) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/OrcamentoProdutos/Delete",
                    params: {
                        id: Sts_orcamentoprodutos.Ocp_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadOrcamentoProdutosList();
                        $scope.loadProdutosList();
                    });
                });
            }
        });
    };

    $scope.edit = function (Sts_orcamentoprodutos) {
        Sts_orcamentoprodutos.Ocp_dataentrega = new Date(Sts_orcamentoprodutos.Ocp_dataentrega);
        $scope.Sts_orcamentoprodutos = Sts_orcamentoprodutos;
        debugger;
        $('html, body').animate({
            scrollTop: $("#formOrdemProdutos").offset().top - $('html, body').offset().top + $('html, body').scrollTop()
        }, 1000);
    };
    $scope.new = function () {
        $scope.Sts_orcamentoprodutos = {};
    };

    $scope.save = function (Sts_orcamentoprodutos) {
        Sts_orcamentoprodutos.Sts_orcamento = $scope.Sts_orcamento;
        $http({
            method: "GET",
            url: window.location.origin + "/OrcamentoProdutos/Save",
            params: {
                json: Sts_orcamentoprodutos
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_orcamentoprodutos.Ocp_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                $scope.loadOrcamentoProdutosList();
                $scope.loadProdutosList();
                $scope.Sts_orcamentoprodutos = {};
            });
        });
    };

    $scope.loadOrcamentoProdutosList();
    $scope.loadProdutosList();
});

app.controller("ordemProducaoController", function ($scope, $http, $routeParams, $location) {
    $scope.ordensProducaoList = [];
    $scope.orcamentosList = [];
    $scope.sortType = "Ord_codigo";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_ordemproducao = {};


    if ($routeParams.id) {
        $http.get(window.location.origin + "/OrdemProducao/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_ordemproducao = response.data;
            $scope.Sts_ordemproducao.Ord_datacadastro = new Date($scope.Sts_ordemproducao.Ord_datacadastro);
            $scope.Sts_ordemproducao.Ord_dataentrega = new Date($scope.Sts_ordemproducao.Ord_dataentrega);
        });
    }

    $scope.loadOrcamentosList = function () {
        $http.get(window.location.origin + "/Orcamento/FindAll", { method: "GET" }).then(function (response) {
            $scope.orcamentosList = response.data;
        });
    };

    $scope.loadOrdensProducaoList = function () {
        $http.get(window.location.origin + "/OrdemProducao/FindAll", { method: "GET" }).then(function (response) {
            $scope.ordensProducaoList = response.data;
        });
    };

    $scope.delete = function (Sts_ordemproducao) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/OrdemProducao/Delete",
                    params: {
                        id: Sts_ordemproducao.Ord_codigo
                    }
                }).then(function (response) {
                    if (response != null && response.data != "Erro" && response.data != "Produzida") {
                        bootbox.alert("Registro excluído com Sucesso!", function () {
                            $scope.loadOrdensProducaoList();
                        });
                    } else if (response != null && response.data == "Produzida") {
                        bootbox.alert("A ordem de produção não pode ser cancelada pois a mesma já foi produzida!", function () {
                            $scope.loadOrdensProducaoList();
                        });
                    }
                });
            }
        });
    };

    $scope.save = function (Sts_ordemproducao) {
        $http({
            method: "GET",
            url: window.location.origin + "/OrdemProducao/Save",
            params: {
                json: Sts_ordemproducao
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_ordemproducao.Ord_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                document.location.href = '#OrdemProducao';
            });
        });
    };

    $scope.loadOrdensProducaoList();
    $scope.loadOrcamentosList;
});

app.controller("ordemProdutosController", function ($scope, $http, $routeParams, $location) {
    $scope.ordemProdutosList = [];
    $scope.produtosList = [];
    $scope.sortType = "Odp_codigo";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_ordemproducao = {};
    $scope.Sts_ordemprodutos = {};

    if ($routeParams.id) {
        $http.get(window.location.origin + "/OrdemProducao/GetById", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.Sts_ordemproducao = response.data;
            $scope.Sts_ordemproducao.Ord_datacadastro = new Date($scope.Sts_ordemproducao.Ord_datacadastro);
            $scope.Sts_ordemproducao.Ord_dataentrega = new Date($scope.Sts_ordemproducao.Ord_dataentrega);
        });
    }

    $scope.loadOrdemProdutosList = function () {
        $http.get(window.location.origin + "/OrdemProdutos/FindAllProductsOrder", { method: "GET", params: { id: $routeParams.id } }).then(function (response) {
            $scope.ordemProdutosList = response.data;
        });
    };

    $scope.loadProdutosList = function () {
        $http.get(window.location.origin + "/Produto/FindAllProdutos", { method: "GET" }).then(function (response) {
            $scope.produtosList = response.data;
        });
    };

    $scope.delete = function (Sts_ordemprodutos) {
        bootbox.confirm("Deseja realmente excluir o registro?", function (ok) {
            if (ok) {
                $http({
                    method: "GET",
                    url: window.location.origin + "/OrdemProdutos/Delete",
                    params: {
                        id: Sts_ordemprodutos.Odp_codigo
                    }
                }).then(function (response) {
                    bootbox.alert("Registro excluído com Sucesso!", function () {
                        $scope.loadOrdemProdutosList();
                        $scope.loadProdutosList();
                    });
                });
            }
        });
    };

    $scope.edit = function (Sts_ordemprodutos) {
        Sts_ordemprodutos.Odp_dataentrega = new Date(Sts_ordemprodutos.Odp_dataentrega);
        $scope.Sts_ordemprodutos = Sts_ordemprodutos;
        $('html, body').animate({
            scrollTop: $("#formOrdemProdutos").offset().top - $('html, body').offset().top + $('html, body').scrollTop()
        }, 1000);
    };
    $scope.new = function () {
        $scope.Sts_ordemprodutos = {};
    };

    $scope.save = function (Sts_ordemprodutos) {
        Sts_ordemprodutos.Sts_ordemproducao = $scope.Sts_ordemproducao;
        $http({
            method: "GET",
            url: window.location.origin + "/OrdemProdutos/Save",
            params: {
                json: Sts_ordemprodutos
            }
        }).then(function (response) {
            bootbox.alert("Registro " + (Sts_ordemprodutos.Odp_codigo === undefined ? "inserido" : "alterado") + " com Sucesso!", function () {
                $scope.loadOrdemProdutosList();
                $scope.loadProdutosList();
                $scope.Sts_ordemprodutos = {};
            });
        });
    };

    $scope.baixarOP = function (Sts_ordemprodutos) {
        bootbox.confirm("Deseja encerrar a O. P. e liberar o produto para estoque?", function (ok) {
            Sts_ordemprodutos.Sts_ordemproducao = $scope.Sts_ordemproducao;
            $http({
                method: "GET",
                url: window.location.origin + "/OrdemProdutos/baixarOP",
                params: {
                    id: Sts_ordemprodutos.Odp_codigo
                }
            }).then(function (response) {
                if (response != null && response.data != "Erro") {
                    bootbox.alert("Item da O. P. encerrado e liberado para o estoque!", function () {
                        $scope.loadOrdemProdutosList();
                        $scope.loadProdutosList();
                        $scope.Sts_ordemprodutos = {};
                    });
                } else {
                    bootbox.alert("A ordem de produção não pode ser encerrada, verifique os dados da O.P.!", function () {

                    });
                }
            });
        });
    }

    $scope.loadOrdemProdutosList();
    $scope.loadProdutosList();
});

app.controller("estoqueController", function ($scope, $http, $routeParams, $location) {
    $scope.estoquesList = [];
    $scope.sortType = "Pro_descricao";
    $scope.sortReverse = false;
    $scope.search = "";
    $scope.http = $http;
    $scope.Sts_estoque = {};

    $scope.loadEstoquesList = function () {
        $http.get(window.location.origin + "/Estoque/FindAll", { method: "GET" }).then(function (response) {
            $scope.estoquesList = response.data;
        });
    };


    $scope.loadEstoquesList();
});