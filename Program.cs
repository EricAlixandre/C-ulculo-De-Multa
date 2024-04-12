using System;
//entrada
Console.WriteLine("Digite a velocidade máxima da via:");
int velmax= int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da velocidade em que você estava dirigindo:");
int velocidade= int.Parse(Console.ReadLine());
int multa=0;
//condiçoes
if (velocidade<=velmax){
    Console.WriteLine("Motorista respeitou a lei");
}
else if(velocidade<=velmax+10){
    multa=50;
}
else if(velocidade>=velmax+11 && velocidade<=velmax+30){
    multa=100;
}
else{
    multa=200;
}
Console.Write("O valor da multa a ser cobrada é:R$"+multa);

