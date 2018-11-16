<?php
function connect(
    $host = 'localhost',
    $user = 'root',
    $pass = '',
    $dbname = 'traveldb_api'
) {
    $link = mysql_connect($host, $user, $pass) or die('connection error');
    mysql_select_db($dbname) or die('db open error');
    mysql_query("set names 'utf8'");
}

function register($name, $pass, $email) {
    $answ = [];

    $name = trim(htmlspecialchars($name));
    $pass = trim(htmlspecialchars($pass));
    $email = trim(htmlspecialchars($email));
    if (empty($name) || empty($pass) || empty($email)) {
        $answ['successful'] = false;
        $answ['error'] = 'fill all required fields!';
        echo json_encode($answ);
        return false;
    }

    $pass = md5($pass);
    $insert = "insert into users (login, pass, email, roleId) values('$name', '$pass', '$email', 2)";

    connect();
    mysql_query($insert);
    $error = mysql_errno();
    if ($error) {
        if($error == 1062) {
            $answ['successful'] = false;
            $answ['error'] = 'This Login Is Already Taken!';
            echo json_encode($answ);
        }
        else {
            $answ['successful'] = false;
            $answ['error'] = "Error code: $error";
            echo json_encode($answ);
        }
        return false;
    }

    $answ['successful'] = true;
    $answ['error'] = null;
    $answ['uid'] = $name;
    echo json_encode($answ);
//    $answ['act'] = "You registered!";
    return true;
}

function login($name, $pass) {
    $name = trim(htmlspecialchars($name));
    $pass = trim(htmlspecialchars($pass));
    if (empty($name) || empty($pass)) {
        $answ['successful'] = false;
        $answ['error'] = 'fill all required fields!';
        echo json_encode($answ);
        return false;
    }

    $pass = md5($pass);

    $q = "select * from users where users.login = '$name' and users.pass = '$pass'";

    connect();

    $res = mysql_query($q);
    $row = mysql_fetch_array($res, MYSQL_NUM);

    $error = mysql_errno();
    if ($error) {
        $answ['successful'] = false;
        $answ['error'] = "Error code: $error";
        echo json_encode($answ);
        return false;
    }

    if ($row) {
        $answ['successful'] = true;
        $answ['error'] = null;
        $answ['uid'] = $row[1];
//        $answ['act'] = "You logged in!";
        echo json_encode($answ);
        return true;
    }

    $answ['successful'] = false;
    $answ['error'] = "Incorrect login/password";
    echo json_encode($answ);

    return false;
}

function checkAuth($cookie_param) {
    $q = "select * from users where users.login = '$cookie_param'";

    connect();

    $res = mysql_query($q);
    $row = mysql_fetch_array($res, MYSQL_NUM);

    $error = mysql_errno();
    if ($error) {
//        echo "<h3 class='alert alert-danger'>Error code: $error</h3>";
        return false;
    }
    if ($row)
        return true;
    else
        return false;
}

function addComment($session_param, $comment, $hid) {
    $q = "select * from users where users.login = '$session_param'";

    $comment = trim(htmlspecialchars($comment));
    if (empty($comment)) {
        $answ = [];
        $answ['success'] = false;
        $answ['error'] = 'Fill Comment Field';
        echo json_encode($answ);
        return false;
    }

    connect();

    $res = mysql_query($q);
    $row = mysql_fetch_array($res, MYSQL_NUM);

    $error = mysql_errno();
    if ($error) {
        $answ = [];
        $answ['success'] = false;
        $answ['error'] = "Error code: $error";
        echo json_encode($answ);
        return false;
    }

    if ($row) {
        $user_id = $row[0];
        $q = "insert into comments (hotelId, userId, comment) values ($hid, $user_id, '$comment')";

        mysql_query($q);

        $error = mysql_errno();
        if ($error) {
            $answ = [];
            $answ['success'] = false;
            $answ['error'] = "Error code: $error";
            echo json_encode($answ);
            return false;
        }

        $answ = [];
        $answ['success'] = true;
        $answ['error'] = null;
        echo json_encode($answ);
        return true;
    }
    else
        return false;
}

function getHotels() {
    $q = "select ho.id, ho.hotelName, ci.cityName as city, co.countryName as country, ho.stars, ho.cost, ho.info, img.imagePath as image
          from hotels ho, countries co, cities ci, images img
          where ho.countryId = co.id and ho.cityId = ci.id and img.hotelId = ho.id";

    connect();
    $res = mysql_query($q);

    $error = mysql_errno();
    if ($error) {
        $answ['successful'] = false;
        $answ['error'] = "Error code: $error";
        echo json_encode($answ);
        return false;
    }

    $hotels = [];

    while($row = mysql_fetch_array($res, MYSQL_ASSOC)) {
        $hotels[] = $row;
    }

    $answ['successful'] = true;
    $answ['hotels'] = $hotels;
    echo json_encode($answ);

    return true;
}

function getComments($hotel_id) {
    $q = "select co.id, us.login as user, co.comment as text from hotels ho, comments co, users us
          where co.userId = us.id and co.hotelId = ho.id";

    connect();

    $res = mysql_query($q);

    $comments = [];

    while($row = mysql_fetch_array($res, MYSQL_ASSOC)) {
        $comments[] = $row;
    }

    $error = mysql_errno();
    if ($error) {
        $answ['successful'] = false;
        $answ['error'] = "Error code: $error";
        echo json_encode($answ);
        return false;
    }

    $answ['successful'] = true;
    $answ['comments'] = $comments;
    echo json_encode($answ);

    return true;
}