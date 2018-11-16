<?php
include_once 'functions.php';

if (isset($_GET['act'])) {
    $act = $_GET['act'];
    switch ($act) {
        case 'login':
            login($_POST['uname'], $_POST['password']);
            break;
        case 'register':
            register($_POST['uname'], $_POST['password'], $_POST['email']);
            break;
        case 'getHotels':
            if (checkAuth($_COOKIE['uid'])) {
                getHotels();
            }
            break;
        case 'getComments':
            if (checkAuth($_COOKIE['uid'])) {
                getComments($_GET['hid']);
            }
            break;
        case 'setComment':
            if(checkAuth($_COOKIE['uid'])) {
                addComment($_COOKIE['uid'], $_POST['comment'], $_POST['hid']);
            }
            break;
    }
}