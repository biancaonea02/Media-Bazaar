
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <script src="https://kit.fontawesome.com/64d58efce2.js" crossorigin="anonymous"></script>
    <link href="../css/login.css" rel="stylesheet">
    <title>Media Bazaar - Log In</title>
</head>

    <main>
        <section>
            

            <div class="page-wrapper bg-gra-01  p-b-100 font-poppins">
              <br>
              <br>
              <br>
        <div class="wrapper wrapper--w780">
            <div class="card card-3">
                <div class="card-heading">
                </div>
                <div class="card-body">
                    <h2 class="title">Welcome back!</h2>
                    <?php
                        if(isset($_GET["error"]))
                        {
                        if($_GET["error"] == "invalidemail")
                        {
                            echo '<div class="error"
                                <p>The provided email is invalid.</p>
                                </div>';
                        }
                        else if($_GET["error"] == "emailnotexists")
                        {
                            echo '<div class="error"
                                <p>The provided email does not exist.</p>
                                </div>';

                        }
                        else if($_GET["error"] == "passwordsnotmatch")
                        {
                            echo '<div class="error"
                                <p>The password is incorrect. Try again.</p>
                                </div>';
                        }
                        }
                    ?>
                    <br>
                    <form action="../includes/login-inc.php" method="post">
                        <div class="input-group">
                            <input class="input--style-3" type="text" placeholder="Email" name="email">
                        </div>
                        <div class="input-group">
                            <input class="input--style-3" type="password" placeholder="Password" name="password">
                        </div>
                        <div class="p-t-10">
                            <button class="logInBtn" type="submit" name="submit">Log In</button>
                        </div>
                    </form>
                    
                </div>
            </div>
        </div>
    </div>
        </section>
    </main>
    <!-- <?php
    include_once 'footer.php';
    ?> -->
