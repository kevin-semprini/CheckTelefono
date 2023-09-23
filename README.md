# CheckTelefono
date delle stringhe di numeri di telefono, un algoritmo le passa in rassegna e comunica se sono numeri validi

## quando un numero è valido?
è stato deciso che un numero di telefono viene definito valido secondo queste specifiche:<br>
inizia con +39 (esattamente lungo 13)<br><br>
inizia con 0039 (esattamente lungi 14)<br><br>
inizia con un 3 (esattamente lungo 10)<br><br>

## quando non è considerato valido?
quando inizia con qualsiasi altro numero ed è più piccolo di 10 numeri 


### varaibili e soluzioni basialri:
```C#
    public static string Check(string[] input)
    {   
        bool ritorna = true; //per ovviare al problema dello spazio in mezzo al numero
        for(int i = 0; i < input.Length; i++){
            ritorna = true;
            if (input[i] == ""){
                continue;
            }
            // l'if sotto mette in codice le caratteristiche dei numeri validi
            if(((input[i][0]=='+' && input[i][1]=='3' && input[i][2]=='9') && (input[i].Length==13)) || ((input[i][0]=='0' && input[i][1]=='0' && input[i][2]=='3' && input[i][3]=='9') && (input[i].Length==14)) || ((input[i][0]=='3') && input[i].Length==10)){
                for (int c = 0; c < input[i].Length; c++){
                    if( input[i][c] == ' '){
                        ritorna = false;
                    }
                }
            }else{
                continue;
            }
            if (ritorna){
                return input[i]; //la booleana usata come flag
            }else{
                continue;
            }
        }
        return "";
```


