using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Core.JsonObjects;
using Newtonsoft.Json;

namespace Exam.Core
{
    class Network
    {
        private static string API_url = "http://markforest.pro/index.php";
        private static string cookieUID = "";

        public static string SendRequest(Dictionary<string, string> pData, string method, string act)
        {
            string postData = "";
            byte[] data = null;

            if (pData != null)
            {
                foreach (KeyValuePair<string, string> item in pData)
                {
                    postData += $"{item.Key}={item.Value}&";
                }
                postData = postData.Remove(postData.Length - 1);// удаляем лишний &

                data = Encoding.UTF8.GetBytes(postData);
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(API_url + "?act=" + act);
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            if (cookieUID != "")
            {
                request.CookieContainer = new CookieContainer();
                Cookie cookie = new Cookie("uid", cookieUID);
                Uri uri = new Uri(API_url);
                cookie.Domain = new Uri(API_url).Host;
                request.CookieContainer.Add(cookie);
            }
            if (pData != null)
            {
                request.ContentLength = data.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

            //AuthObject auth = JsonConvert.DeserializeObject<AuthObject>(responseString);

            //response.Close();

            //return auth;
        }
        public static bool Login(string uname, string password)
        {
            DefaultAnswObject auth = JsonConvert.DeserializeObject<DefaultAnswObject>(SendRequest(new Dictionary<string, string>()
            {
                {"uname", uname},
                {"password", password}
            }, "POST", "login"));

            if (auth.successful)
            {
                cookieUID = auth.uid;
                return true;
            }
            else
            {
                MessageBox.Show(auth.error);
                return false;
            }
        }
        public static bool Register(string uname, string password, string email)
        {
            DefaultAnswObject auth = JsonConvert.DeserializeObject<DefaultAnswObject>(SendRequest(new Dictionary<string, string>()
            {
                {"uname", uname},
                {"password", password},
                {"email", email}
            }, "POST", "register"));

            if (auth.successful)
            {
                cookieUID = auth.uid;
                return true;
            }
            else
            {
                MessageBox.Show(auth.error);
                return false;
            }
        }
        public static HotelObject[] GetHotels()
        {
            if (cookieUID != "")
            {
                HotelsAnswObject answ = JsonConvert.DeserializeObject<HotelsAnswObject>(SendRequest(null, "GET", "getHotels"));

                if (answ.successful)
                {
                    return answ.hotels;
                }
                else
                {
                    MessageBox.Show("Oh shi... Error happened");
                    return null;
                }
            }
            return null;
        }
        public static bool SetComment(string comment, HotelObject hotel)
        {
            if (cookieUID != "")
            {
                DefaultAnswObject auth = JsonConvert.DeserializeObject<DefaultAnswObject>(SendRequest(new Dictionary<string, string>()
                {
                    {"hid", hotel.id.ToString()},
                    {"comment", comment}
                }, "POST", "setComment"));
                if (auth.successful)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static CommentObject[] GetComments(int hid)
        {
            if (cookieUID != "")
            {
                CommentsAnswObject answ = JsonConvert.DeserializeObject<CommentsAnswObject>(SendRequest(null, "GET", "getComments&hid=" + hid.ToString()));

                if (answ.successful)
                {
                    return answ.comments;
                }
                else
                {
                    MessageBox.Show("Oh shi... Error happened");
                    return null;
                }
            }
            return null;
        }
    }
}
