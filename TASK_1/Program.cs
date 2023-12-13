
int n=Convert.ToInt32(Console.ReadLine());
if(n<100) System.Console.WriteLine(n*0.05+n);
else if(n>=100 && n<=200)System.Console.WriteLine(n+n*0.07);
else System.Console.WriteLine(n+n*0.1);
