using System;
using System.Collections.Generic;

public static class Telefono
{
//  che inizia con +39 (esattamente lungo 13)
// - oppure con 0039 (esattamente lungi 14)
// - oppure con un 3 (esattamente lungo 10)


    public static string Check(string[] input)
    {
        for(int i = 0; i < input.Length; i++){
            if(((input[i][0] == '+' && input[i][1] == '3' && input[i][2] == '9') && (input[i].Length == 13)) || ((input[i][0] == '0' && input[i][1] == '0' && input[i][2] == '3' && input[i][3] == '9') && (input[i].Length == 14)) || ((input[i][0] == '3') && input[i].Length == 10)){
                return input[i];
            }else{
                continue;
            }
        }
        return "";
    }
}