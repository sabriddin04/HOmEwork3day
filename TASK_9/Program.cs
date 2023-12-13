int n=Convert.ToInt32(Console.ReadLine());
int [] arr=new int [n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());

}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
for (int i = a; i <=b; i++)
{
    if(arr[i]%2!=0){
        System.Console.Write(arr[i]+" ");
    }
}
