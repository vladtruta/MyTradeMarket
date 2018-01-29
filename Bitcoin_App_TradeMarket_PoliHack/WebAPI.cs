using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin_App_TradeMarket_PoliHack
{
    class WebAPI
    {
        private static string apiKey = "9d77-f4fb-76fe-7ca3";
        private static string pin = "veresmort";
        private static string firstPart = "https://block.io/api/v2/";

        public static string CreateNwAdress()
        {
            string request = null;
            string returnValue = null;

            request = firstPart + "get_new_address/?api_key=" + apiKey;

            WebRequest web =  WebRequest.Create(request);

            HttpWebResponse response = (HttpWebResponse)web.GetResponse();

            Stream writen = response.GetResponseStream();
            StreamReader reader = new StreamReader(writen);

            string toBeRead;

            while ((toBeRead = reader.ReadLine()) != null)
            {
                if (toBeRead.Contains("address"))
                {
                    string[] getLine = toBeRead.Split('"');
                    try
                    {
                        returnValue = getLine[3];
                        returnValue.Trim();
                    }
                    catch
                    {
                        returnValue = null;
                    }
                }
            }
            // Got Json code. Extracting adress now
            // Further info : https://msdn.microsoft.com/en-us/library/system.net.webrequest(v=vs.110).aspx
            return (returnValue);
        }

        public static string MakeTransaction (string buyer, string seller, decimal ammount)
        {
            string request = null;
            string returnValue = null;
            string toBeRead = null;

            request = firstPart + "withdraw_from_addresses/?api_key=" + apiKey + "&from_addresses=" + buyer +"&to_addresses=" + seller + " &amounts=" + ammount.ToString() + "&pin=" + pin;

            try
            {
                WebRequest web = WebRequest.Create(request);

                HttpWebResponse response = (HttpWebResponse)web.GetResponse();

                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);

                toBeRead = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Got Json code. Extracting adress now
            // Further info : https://msdn.microsoft.com/en-us/library/system.net.webrequest(v=vs.110).aspx
            
            return (returnValue);
        }

        public static double GetBalance(string adress)
        {
            string returnValue = null;
            string toBeRead = null;
            string request = null;

            request = firstPart + "get_address_balance/?api_key=" + apiKey + "&addresses=" + adress;
            //retrieving balance from json server api response 

            try
            {
                WebRequest web = WebRequest.Create(request);

                HttpWebResponse response = (HttpWebResponse)web.GetResponse();

                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);
                while ((toBeRead = reader.ReadLine()) != null)
                {
                    if (toBeRead.Contains("available_balance"))
                    {
                        string[] getLine = toBeRead.Split('"');
                        try
                        {
                            returnValue = getLine[3];
                            returnValue.Trim();
                        }
                        catch
                        {
                            returnValue = null;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return (double.Parse(returnValue));
        }

        public static string GetExchangeCurrency(string adress)
        {
            string returnValue = null;
            string toBeRead = null;
            string request = null;

            request = firstPart + "get_address_balance/?api_key=" + apiKey + "&addresses=" + adress;
            //retrieving currency form from json server api response 

            try
            {
                WebRequest web = WebRequest.Create(request);

                HttpWebResponse response = (HttpWebResponse)web.GetResponse();

                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);

                while ((toBeRead = reader.ReadLine()) != null)
                {
                    if (toBeRead.Contains("network"))
                    {
                        string[] getLine = toBeRead.Split('"');
                        try
                        {
                            returnValue = getLine[3];
                            returnValue.Trim();
                        }
                        catch
                        {
                            returnValue = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return (returnValue);
        }

        // https://block.io/docs/basic

        public static List<string> GetTransactionsMultipleIDS(string type, string adress)
        {
            // getting the ids in the transactions / wallet
            // if List == null => no transaction has been ever made on the wallet 

            List<string> returnValues = new List<string>();
            string request = null;
            string toBeRead = null;
            string foundId = null;

            request = firstPart + "get_transactions/?api_key=" + apiKey + "&type=" + type + "&addresses=" + adress;

            try
            {
                WebRequest web = WebRequest.Create(request);

                HttpWebResponse response = (HttpWebResponse)web.GetResponse();

                Stream writen = response.GetResponseStream();
                StreamReader reader = new StreamReader(writen);

                while ((toBeRead = reader.ReadLine()) != null)
                {
                    if (toBeRead.Contains("txid"))
                    {
                        string[] getLine = toBeRead.Split('"');
                        try
                        {
                            foundId = getLine[3];
                            foundId.Trim();
                        }
                        catch
                        {
                            foundId = null;
                        }
                        returnValues.Add(foundId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return (returnValues);
        }
    }
}
