var myApp = angular.module('myApp', []);
angular.module('myApp').directive('myExample', function()   {
    return{
        template:   '<div> MyExample Directive here!</div>'

    };
});  
var gems = [
    {
        name: 'Dodecahedron',
        price: 2.95,
        description: 'Some gems have hidden qualities beyondtheir lustre, beyond their shine...Dodecahdron is one of those gems',
        canPurchase: true,
        soldOut: false,
        images: [
            {
                full: 'dodecahedron-02-full.jpg',
                thumb: 'dodecahedron-02-thumb.jpg'
            },
        ],
        reviews:[
            {
                stars: 5,
                body: 'I love this product!',
                author: 'joe@thomas.com'
            },
            {
                stars: 1,
                body:   'This product sucks',
                author: 'tim@hater.com'
            },

        ]
},
{
    name: 'Pentagonal',
    price: 5.95,
    description: 'The pentagonal gem is the newest addition to our store. We think you will love it',
    canPurchase: true,
    soldOut: false,
    images: [
        {
            full: 'pentagonal-01-full.jpg',
            thumb:  'pentagonal-01-thumb.jpg'   
        },
    ]
},
{
    name: 'Zircon',
    price:  1100,
    description:    'Zircon is our mostcoveted and sought after gem. You wil pay much to be the proud owner of this gorgeous and high shine gem.',
    canPurchase:    true,
    soldOut:    false,
    images: [
        {
            full:   'zircon-03-full.jpg',
            thumb:  'zircon-03-thumb.jpg'
        },
    ]
},
{
    name:   'Azurite',
    price:  110.50,
    description:    'Azurite is a fantastic new gem!',
    canPurchase:    true,
    soldOut:    false,
    images: [
        {
            full:   'azurite-04-full.jpg',
            thumb:  'azurite-04-thumb.jpg'
        },
    ]
},
{
    name: 'Bloodstone',
    price: 22.90,
    description: 'Origin of the Bloodstone is unknown, hence its low value. It has a very high shine and 12 sides, however.',
    canPurchase: true,
    soldOut: false,
    images: [
        {
            full:   'bloodstone-05-full.jpg',
            thumb:  'bloodstone-05-thumb.jpg'
        },
    ]
},
]   
myApp.controller('myController', function ($scope)
{
    $scope.model = gems;
});

myApp.controller("PanelController", function () {
    this.tab = 1;

    this.selectTab = function (setTab) {
        this.tab = setTab;
    };
    this.isSelected = function (checkTab) {
        return this.tab === checkTab;
    };
});
myApp.controller("ReviewController", function ($scope) {
    ($scope).review = {};

    $scope.addReview = function (product) {
        if (!product.reviews)
            product.reviews = [];

        product.reviews.push($scope.review);
        $scope.review = {};

    }
});
myApp.directive('productTitle', function () {
    return {
        restrict: "E",
        templateUrl: 'product-price.html',
        controller: function ($scope) {
            $scope.tab = 1;

            $scope.selectTab = function (setTab) {
                $scope.tab = setTab;
            }

            $scope.isSelected = function (checkTab) {
                return $scope.tab === checkTab;
            }
        },
        controllerAs: 'panels'
    }
});