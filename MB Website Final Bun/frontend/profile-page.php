<?php
include('header.php');
?>

<body class="profile-page">
    <div class="container">
        <div class="card-container">

            <div class="upper-container">
                <div class="image-container">
                    <img src="../images/profile.jpeg">
                </div>
            </div>

            <div class="lower-container">
                <div>
                    <br>
                    <h3><?php echo $_SESSION["name"]; ?></h3>
                    <br>
                    <h3><?php echo $_SESSION["email"]; ?></h3>
                    <br><br>
                </div>
                <div>
                    <br>
                </div>
                <div>
                    <a href="edit-profile.php"><input type="submit" value="  Edit Profile  " class="btn"></a>
                    <br><br>
                    <a href="change-password.php"><input type="submit" value="   Change Password  " class="btn"></a>
                </div>
            </div>
        </div>

        <?php
        include('javascript.php');
        ?>

    </div>
</body>

</html>