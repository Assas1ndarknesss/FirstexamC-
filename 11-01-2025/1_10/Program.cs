// int n = Convert.ToInt32(Console.ReadLine());
// int num=0;
// for(int i=n;i>0;i/=10){
// num+=i%10;
// }
// System.Console.WriteLine($"Sum : {num}");
// /////////////////task1////////////
// int n = Convert.ToInt32(Console.ReadLine());
// int f=(n*9/5) +32;
// System.Console.WriteLine($"Fahrenheit: {f}");
/////////////////task2////////////////
// double n = Convert.ToInt32(Console.ReadLine());
// double p=3.14;
// double pl = p*(n*n);
// double cr = 2*p*n;
// System.Console.WriteLine($"Area: {pl}");
// System.Console.WriteLine($"Circumference: {cr}");
////////////task3//////////////////////
// int n = Convert.ToInt32(Console.ReadLine());
// if(n%4==0 && n%100!=0){
//     System.Console.WriteLine("Leap Year: Yes");
// }
// else{
//     System.Console.WriteLine("Leap Year: No");
// }
///////////////task4//////////////////
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// int min=999999;
// int max=-999999;
// for(int i =0 ; i<n;i++){
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i =0 ; i<n;i++){
//     if(arr[i]>max){
//         max=arr[i];
//     }
//     if(arr[i]<min){
//         min=arr[i];
//     }
// }
// System.Console.WriteLine($"min: {min}");
// System.Console.WriteLine($"max: {max}");
// System.Console.WriteLine($"sum: {max+min}");
///////////////task5/////////
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for(int i =0 ; i<n;i++){
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i =0 ; i<n;i++){
// if (arr[i]%2==0){
//     System.Console.Write(0 + " ");
// }
// if (arr[i]%2!=0){
//     System.Console.Write(1 + " ");
// }
// }
///////////////task6/////////////
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for(int i =0 ; i<n;i++){
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// int res = Convert.ToInt32(Console.ReadLine());
//  for(int i = 0 ; i<n;i++){
//     for(int j = 0;j<i;j++){
//    if(arr[i]+arr[j+1]==res){
//    System.Console.WriteLine(arr[i] +" "+arr[j+1] );
//    }
// }  
//  }
//////////////task7////////////
// string n =Console.ReadLine();
// int vowels=0;
// int con=0;
// for(int i=0;i<n.Length;i++){
//     if(n[i]=='a' || n[i]=='o' || n[i]=='e' || n[i]=='i' || n[i]=='u' || n[i]=='y'){
// vowels++; }
// else
// {
//     con++;
// }


// }
// System.Console.WriteLine($"Vowels: {vowels}");
// System.Console.WriteLine($"Consonants: {con}");
///////////////task8//////////
// string n =Console.ReadLine();
// int vowels=0;
// int con=0;
// for(int i=0;i<n.Length;i++){
//     if(n[i]=='u' && n[i+1]=='s' && n[i+2]=='e' && n[i+3]=='r' && n[i+4]=='@' && n[i+5]=='e' && n[i+6]=='x' && n[i+7]=='a' && n[i+8]=='m' && n[i+9]=='p' && n[i+10]=='l' && n[i+11]=='e' && n[i+12]=='.' && n[i+13]=='c' && n[i+14]=='o' && n[i+15]=='m'            ){
//    System.Console.WriteLine("Valid email address"); break;  }
// else
// {
//     System.Console.WriteLine("Valid vrong email address "); break;
// }


// }
///////////task9///////////
