/*
 * Created by Jack Hosier 
 * This .dll file stores the hashing function for application security 
*/
using System;
using System.Text;
using System.Security.Cryptography;

namespace HashFunction
{
    public class SHA512
    {
        public static string SHA512Hash(string str)
        {
            SHA512 sha512 = new SHA512(); //SHA512 object 
            
            byte[] hashValue = sha512.ComputeHash(Encoding.UTF8.GetBytes(str)); //compute the hash
                
            StringBuilder sb = new StringBuilder();

            foreach(byte b in hashValue)
            {
                sb.Append(String.Format("{0,2:X2}", b)); //build a string of all the bytes 
            }


            //return the hashed string 
            return sb.ToString();


            
        }
    }
}