<?php
include('header.php');
require_once('../includes/Administration.php');
require_once('../includes/db-inc.php');
?>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/statistics.css">
    <title>Statistics</title>
</head>

<?php
$quantityLaptops = $adm->NrOfProductsForEachCategory($conn, "LAPTOPS");
$quantityHeadphones = $adm->NrOfProductsForEachCategory($conn, "HEADPHONES");
$quantityConsoles = $adm->NrOfProductsForEachCategory($conn, "CONSOLES");
$quantityCharges = $adm->NrOfProductsForEachCategory($conn, "CHARGES");
$quantityGames = $adm->NrOfProductsForEachCategory($conn, "GAMES");
$quantityCables = $adm->NrOfProductsForEachCategory($conn, "CABLES");
$quantitySpeakers = $adm->NrOfProductsForEachCategory($conn, "SPEAKERS");
?>

<body>
    <div class="wrapper">
        <div class="panel">
            <div class="panel-header">
                <h3 class="title">Products Chart #1</h3>
            </div>

            <div class="panel-body">
                <div class="categories">
                    <div class="category">
                        <span>Total Products</span>
                        <span>230</span>
                    </div>
                    <div class="category">
                        <span>Categories</span>
                        <span>8</span>
                    </div>
                    <div class="category">
                        <span>In stock</span>
                        <span>702</span>
                    </div>
                </div>


                <figure>
                    <figcaption>Number of products from each category</figcaption>
                    <svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" class="chart" width="600" height="150" aria-labelledby="title" role="img">
                        <g class="bar">
                            <rect width="40" height="19"></rect>
                            <text x="45" y="9.5" dy=".20em" dx=".35em"><?php echo "$quantityConsoles Consoles"; ?></text>
                        </g>
                        <g class="bar">
                            <rect width="80" height="19" y="20"></rect>
                            <text x="85" y="28" dy=".35em" dx=".35em"><?php echo "$quantityHeadphones Headphones"; ?></text>
                        </g>
                        <g class="bar">
                            <rect width="150" height="19" y="40"></rect>
                            <text x="150" y="48" dy=".35em" dx=".35em"><?php echo "$quantityCharges Charges"; ?></text>
                        </g>
                        <g class="bar">
                            <rect width="190" height="19" y="60"></rect>
                            <text x="191" y="68" dy=".35em" dx=".35em"><?php echo "$quantityCables Cables"; ?></text>
                        </g>
                        <g class="bar">
                            <rect width="230" height="19" y="80"></rect>
                            <text x="240" y="88" dy=".35em" dx=".35em"><?php echo "$quantityGames Games"; ?></text>
                        </g>
                        <g class="bar">
                            <rect width="370" height="19" y="100"></rect>
                            <text x="370" y="108" dy=".35em" dx=".35em"><?php echo "$quantityLaptops Laptops"; ?></text>
                        </g>
                    </svg>
                </figure>
            </div>
        </div>
    </div>
</body>

<?php
include('javascript.php');
?>
</body>

</html>