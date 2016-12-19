var app = angular.module('App',[]);

app.controller('EstudanteController', function($scope,$http){
    //GET PARA API
    document.querySelector('#btnTrazer').addEventListener('click',function(){
        $http.get("http://localhost:26213/api/Estudante/1").then(function(response){
            debugger;
            $scope.Data = response.data;

            document.querySelector("input[type=text]").value = $scope.Data.Nome;
            document.querySelector("input[type=email]").value = $scope.Data.Email;
            document.querySelector("textarea").value = $scope.Data.Observacoes;
        })
    })

    document.querySelector("#btnCadastrar").addEventListener('click',function(){
        
        debugger;
        //AQUI NOS FORMATAMOS O OBJETO JAVASCRIPT
        //PARA ENVIA-LO A API
        var objetoData = {
            Id: 0,
            Nome: document.querySelector("input[type=text]").value,
            Email: document.querySelector("input[type=email]").value,
            Observacoes: document.querySelector("textarea").value
        }

        $http.post("http://localhost:26213/api/Estudante",objetoData).then(function(response){
            debugger;
            alert(response.data);
        })
    })
})