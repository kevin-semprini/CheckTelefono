# CheckTelefono
date delle stringhe di numeri di telefono, un algoritmo le passa in rassegna e comunica se sono numeri validi

##quando un numero è valido?
è stato deciso che un numero di telefono viene definito valido secondo queste specifiche:
inizia con +39 (esattamente lungo 13)
inizia con 0039 (esattamente lungi 14)
inizia con un 3 (esattamente lungo 10)

#quando non è considerato valido?
quando inizia con qualsiasi altro numero ed è più piccolo di 10 numeri 


### varaibili e soluzioni basialri:
```C#

for(int i = 0; i < input.Length; i++){
            if(((input[i][0] == '+' && input[i][1] == '3' && input[i][2] == '9') && (input[i].Length == 13)) || ((input[i][0] == '0' && input[i][1] == '0' && input[i][2] == '3' && input[i][3] == '9') && (input[i].Length == 14)) || ((input[i][0] == '3') && input[i].Length == 10)){
                return input[i];
            }else{
                continue;
            }
        }
        return "";

```


