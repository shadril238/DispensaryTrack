// shadril238

var app=angular.module("DispensaryTrack",[]);
app.controller('loginCtrl',function($scope, $http){
	$scope.login = function(){
		var data = $scope.login;
		var email=$scope.login.Email;
		var password=data.Password;
		$http.post("https://localhost:44338/api/login",data).then(function(res){
			debugger;
			localStorage.setItem("tkey",res.data.TKey);
			debugger;
		}, function(err){
			
		});
	}
});