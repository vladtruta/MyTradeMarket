using System;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Bitcoin_App_TradeMarket_PoliHack
{
    class Encryption
    {

        public static byte[] EncryptString_PrivateKey(string str)
        {
            UnicodeEncoding convertor = new UnicodeEncoding();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            byte[] dataToEncrypt = convertor.GetBytes(str);
            byte[] encryptedData = null;
            byte[] decryptedData = null;

            try
            {
                encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false, RSA);
                decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(false), false, RSA);
                MessageBox.Show(convertor.GetString(encryptedData));
                MessageBox.Show(convertor.GetString(decryptedData));
                return (encryptedData);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Ecryption has failed.");
            }
            return (null);
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding, RSACryptoServiceProvider RSA)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
               

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
      
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
               
                return null;
            }

        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding, RSACryptoServiceProvider RSA)
        {
            UnicodeEncoding convertor = new UnicodeEncoding();
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
              
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
         
                MessageBox.Show(convertor.GetString(decryptedData));
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());

                return null;
            }
        }
    }

}

