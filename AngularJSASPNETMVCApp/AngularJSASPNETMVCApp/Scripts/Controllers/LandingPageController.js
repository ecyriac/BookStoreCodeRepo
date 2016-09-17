// JavaScript source code
var LandingPageController = function ($scope, $http) {
    $scope.models = {
        bookTitle: '',
        bookIsbn: '',
        bookPublisher: '',
        searchBook: ''
    };

    $scope.AddBook = function ()
    {
        debugger;
        var aNewBook = {
            Title: $scope.models.bookTitle,
            Isbn: $scope.models.bookIsbn,
            Publisher: $scope.models.bookPublisher
        }
        var response = $http({
            method: "post",
            url: "/Home/AddBook",
            data: JSON.stringify(aNewBook),
            dataType: "json"
        });
        GetBooks($scope, $http);
        return response;
    } // end of AddBook

    GetBooks($scope, $http);
}

function GetBooks($scope, $http) {
    $http({
        method: 'Get',
        url: '/Home/GetBooks'
    }).success(function (data, status, headers, config) {
        $scope.Books = { BooksArray: data };
    }).error(function (data, status, headers, config) {
        $scope.message = 'Unexpected Error';
    });
}

// The $inject property of every controller (and pretty much every other type of object in Angular)
// needs to be a string array equal to the controllers arguments, only as strings
LandingPageController.$inject = ['$scope', '$http'];


