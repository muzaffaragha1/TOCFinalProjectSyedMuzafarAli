﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;
// using UnityScript.Scripting.Pipeline;

public class MPStartScript : MonoBehaviour
{
    public GameObject collectiblePrefab;

    void Start()
    {
        string[,] collectiblesString = new string[10, 2];
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            string randomString = this.generateString();
            bool palindrome = checkPalindrome(randomString);

            if (palindrome)
            {
                collectiblesString[i, 0] = randomString;
                collectiblesString[i, 0] = palindrome.ToString();
                count++;
            }else
            {
                collectiblesString[i, 0] = randomString;
                collectiblesString[i, 0] = palindrome.ToString();
            }
        }

        if(count < 3)
        {
            string palindrome1 = "xm22mxxm22mx";
            string palindrome2 = "xxmm2222mmxx";
            string palindrome3 = "xxmm2222mmxx";
            int inserted = 0;
            for(int j= 0; j<10; j++)
            {
                if(inserted == 3)
                {
                    break;
                }
                if(collectiblesString[j, 1] == "false")
                {
                    inserted++;
                    if(inserted == 1)
                    {
                        collectiblesString[j, 0] = palindrome1;
                    }else if (inserted == 2)
                    {
                        collectiblesString[j, 0] = palindrome2;
                    }
                    else
                    {
                        collectiblesString[j, 0] = palindrome3;

                    }
                }
                else
                {
                    inserted++;
                }
            }
            
        }
        for(int i=0; i<10; i++)
        {
            GameObject collectible = Instantiate(collectiblePrefab) as GameObject;
        }
    }

    protected string generateString()
    {
        System.Random ran = new System.Random();
        int length = ran.Next(9, 15);
        StringBuilder builder = new StringBuilder(length);
        int letterOffSet = 26;
        char offset = 'a';
        for(int i = 0; i < length; i++)
        {
            var @char = (char)ran.Next(offset, offset + letterOffSet);
            builder.Append(@char);
        }
        return builder.ToString();

    }

    protected bool checkPalindrome(string str)
    {
        string _reversestr = "";
        for(int i = str.Length -1; i>=0; i--)
        {
            _reversestr += str[i].ToString();
        }
        if (_reversestr == str)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
