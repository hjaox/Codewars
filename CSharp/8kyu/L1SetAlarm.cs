﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/568dcc3c7f12767a62000038/csharp


Write a function named setAlarm/set_alarm/set-alarm/setalarm (depending on language) which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.

The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. Examples:

employed | vacation 
true     | true     => false
true     | false    => true
false    | true     => false
false    | false    => false
 */

namespace CSharp._8kyu
{
    public class L1SetAlarm
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            return employed && !vacation ? true : false;
        }
    }
}
