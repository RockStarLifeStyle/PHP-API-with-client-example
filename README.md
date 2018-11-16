# PHP-API-with-client-example
This is my first PHP API with client example on C#.

#Documentation

#Action List:

# Login
To Login you must send POST request to index.php file with GET param 'act'.
So you must to send POST request to this link: index.php?act=login, with POST params uname and password.
# Register
You must to send POST request to this link: index.php?act=register, with POST params uname, password and email.

Both of this actions will return you answer in JSON format
Example of the return:
{"successful":false,"error":"fill all required fields!"}.

So if "successful" is true the answer will be like this:

{"successful":true,"error":null, "uid": "login"}.

The uid depends on your login


# Get Hotel List
To get hotel list you must to send GET request to this link: index.php?act=getHotels, with cookie uid.
