var app = angular.module('app', ['kendo.directives']);

app.controller('customController', ['$scope', function ($scope) {

    $scope.allStates = {
        data: [
        { id: 1, text: 'Alabama' },
        { id: 2, text: 'Florida' },
        { id: 3, text: 'Georgia' },
        { id: 4, text: 'New York' },
        { id: 5, text: 'Ohio' },
        { id: 6, text: 'Oregon' }
        ]
    };
    $scope.selectedStates = [];


    $scope.selectOptions = {
        placeholder: "Select products...",
        dataTextField: "text",
        dataValueField: "id",
        valuePrimitive: true,
        autoBind: false,
        dataSource: $scope.allStates
    };
    $scope.selectedIds = [4, 7];
}]);