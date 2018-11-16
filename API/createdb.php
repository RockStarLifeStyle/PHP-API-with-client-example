<?php
include_once 'functions.php';
connect();

$ct1 = "create table countries(
id int not null auto_increment primary key,
countryName varchar(64) unique
) default charset='utf8'";

$ct2 = "create table cities(
id int not null auto_increment primary key,
countryId int,
foreign key (countryId) references countries (id) on delete cascade,
cityName varchar(64) unique
) default charset='utf8'";

$ct3 = "create table hotels(
id int not null auto_increment primary key,
hotelName varchar(64) unique,
cityId int,
countryId int,
foreign key (cityId) references cities (id) on delete cascade,
foreign key (countryId) references countries (id) on delete cascade,
stars int,
cost int,
info varchar(1024)
) default charset='utf8'";

$ct4 = "create table images(
id int not null auto_increment primary key,
imagePath varchar(255),
hotelId int,
foreign key (hotelId) references hotels (id) on delete cascade
) default charset='utf8'";

$ct5 = "create table roles(
id int not null auto_increment primary key,
roleName varchar(32)
) default charset='utf8'";

$ct6 = "create table users(
id int not null auto_increment primary key,
login varchar(64) unique,
pass varchar(128),
email varchar(128),
discont int,
roleId int,
foreign key (roleId) references roles (id) on delete cascade,
avatarPath varchar(255)
) default charset='utf8'";

$ct7 = "create table sales(
id int not null auto_increment primary key,
userId int,
foreign key (userId) references users(id) on delete cascade,
hotelId int,
foreign key (hotelId) references hotels(id) on delete cascade
) default charset='utf8'";

$ct8 = "create table comments(
id int not null auto_increment primary key,
hotelId int,
userId int,
foreign key (hotelId) references hotels(id) on delete cascade,
foreign key (userId) references users(id) on delete cascade,
comment varchar(256)
) default charset='utf8'";

mysql_query($ct1);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}


mysql_query($ct2);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}

mysql_query($ct3);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}

mysql_query($ct4);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}

mysql_query($ct5);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}

mysql_query($ct6);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}

mysql_query($ct7);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}

mysql_query($ct8);
$err = mysql_errno();

if($err) {
    echo 'Error code 1: '.$err."<br>";
    return false;
}