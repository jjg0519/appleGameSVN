///////////////////////////////////////////////////////////
//  Game.cs
//  Implementation of the Class Game
//  Generated by Enterprise Architect
//  Created on:      16-11��-2016 19:47:11
//  Original author: ant_d
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Newtonsoft.Json;
using AntDesigner.GameCityBase.boxs;

namespace AntDesigner.GameCityBase
{
    public static class ToolsSecret
    {
        // public static GameDegree gameDegree { get; set; }
        static ToolsSecret()
        {
            //gameDegree = GameDegree.Common;
            EncrypRelationArry = new char[,]
            {
{'A','A'},
{'B','B'},
{'C','C'},
{'D','D'},
{'E','E'},
{'F','F'},
{'G','G'},
{'H','H'},
{'I','I'},
{'J','J'},
{'K','K'},
{'L','L'},
{'M','M'},
{'N','N'},
{'O','O'},
{'P','P'},
{'Q','Q'},
{'R','R'},
{'S','S'},
{'T','T'},
{'U','U'},
{'V','V'},
{'W','W'},
{'X','X'},
{'Y','Y'},
{'Z','Z'}
            };

        }

        public static string GetSHA1(string arrStr)
        {

            byte[] arryByte = Encoding.UTF8.GetBytes(arrStr);
            byte[] arrByteToSHA1 = SHA1.Create().ComputeHash(arryByte);
            string arrByteSHA1ToStr = BitConverter.ToString(arrByteToSHA1);
            arrByteSHA1ToStr = arrByteSHA1ToStr.Replace("-", "");
            return arrByteSHA1ToStr.ToLower();
        }

        private static char[,] EncrypRelationArry { get; set; }
        public static string EncryptOpenId(string strASKII)
        {

        char[] charList = strASKII.ToArray();
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < charList.Length; i++)
            {
                for (int k = 0; k < EncrypRelationArry.GetLength(0); k++)
                {
                    if (charList[i]==EncrypRelationArry[k,0])
                    {
                        newStr.Append(EncrypRelationArry[k, 1]);
                        break;
                    }
                    if (k==EncrypRelationArry.GetLength(0)-1)
                    {
                        newStr.Append(charList[i]);
                    }
                    
                }
            }


            return newStr.ToString();
        }
        public static string DecryptOpenId(string strASKII)
        {
            char[] charList = strASKII.ToArray();
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < charList.Length; i++)
            {
                for (int k = 0; k < EncrypRelationArry.GetLength(0); k++)
                {
                    if (charList[i] == EncrypRelationArry[k, 1])
                    {
                        newStr.Append(EncrypRelationArry[k, 0]);
                        break;
                    }
                    if (k == EncrypRelationArry.GetLength(0) - 1)
                    {
                        newStr.Append(charList[i]);
                    }
                }
            }


            return newStr.ToString();
        }
 
}//end Game

}//end namespace AntDesigner.AppleGame