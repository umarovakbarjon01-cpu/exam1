//task1

// int a=Convert.ToInt32(Console.ReadLine());
// int [] b =  new int [a];
// for(int i=0; i<a; i++)
// {
//        b[i]=Convert.ToInt32(Console.ReadLine());
// }
// int c=0;
// for(int i=0; i<a; i++)
// {
//    int s=0;
//    for(int k=0; k<a; k++)
    // {
        // if(b[i]==b[k])
        // s++;
    // }
    // if(c<s)
    // {
        // c=s;
    // }
// }
    // System.Console.WriteLine(c);

//Task2

// int n=Convert.ToInt32(Console.ReadLine());
// bool palind=isPalindrom ( n);
// Console.WriteLine(palind);

// bool isPalindrom (int n)

// {
//      int rev=0;
//    for(int i=n; i>0; i/=10)
//    {
//     rev=rev*10;
//     rev+=i%10;
//    }
//    if(rev==n)
//    {
//     return true;
//    }
//     return false;
//}
 

 //Task5

//  int a=Convert.ToInt32(Console.ReadLine());
// int [] b =  new int [a];
// for(int i=0; i<a; i++)
// {
    //    b[i]=Convert.ToInt32(Console.ReadLine());
// }
// int c=0;
// for(int i=0; i<b.Length; i++)
// {
    // if(c<b[i])
    // {
        // c=b[i];
    // }
// }
// System.Console.WriteLine(c);

//Task7

// System.Console.Write("a = ");
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.Write("b = ");
// int b=Convert.ToInt32(Console.ReadLine());
// Multiply(ref a, ref b);
// void Multiply(ref int a,ref int b)
// {
    // a=a*2;
    // b=b*2;
    // System.Console.WriteLine($"a = {a} ");
    // System.Console.WriteLine($"b = {b} ");
// }

//Task8                                       
//   int a=Convert.ToInt32(Console.ReadLine());     
//  int [] b =  new int [a];                        
//  for(int i=0; i<a; i++)                          
//  {                                               
    //  b[i]=Convert.ToInt32(Console.ReadLine());
//  }                                               
// int c=0;                                        
//  for(int i=0; i<b.Length; i++)                   
// {                                               
//    if(i%2==0)                                  
//   {                                           
    // c++;                                 
    // }                                           
// }                                               
//  System.Console.WriteLine(c);   


//Task9                                       
//   int a=Convert.ToInt32(Console.ReadLine());     
//  int [] b =  new int [a]; 
//  int c=0;                        
//  int s=0; 
//  for(int i=0; i<a; i++)                          
//  {                                               
    //  b[i]=Convert.ToInt32(Console.ReadLine());
    //  c+=b[i];
    //  s++;
//  }                                               
// int akk=0;
// 
//  for(int i=0; i<b.Length; i++)
// {
    // if(c/s>b[i])
    // {
        // akk++;
    // }
// }
// System.Console.WriteLine(akk);
// 

int a=Convert.ToInt32(Console.ReadLine());

int sum=Summ(a);

{
    if(a==0)
    {
        return 0;
    }
   
}