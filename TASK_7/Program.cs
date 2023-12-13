int n=Convert.ToInt32(Console.ReadLine());
int []arr =new int [n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    
}
int first=0;
    int second=0;
for (int i = 0; i < n-1; i++)
{
    if((arr[i]>0 && arr[i+1]>0) ||(arr[i]<0 && arr[i+1]<0 )){
        first=arr[i];
        second=arr[i+1];
    }
    
}
if(first==0 ){System.Console.Write(" ");}
else{
System.Console.Write(first+" "+second);
}
