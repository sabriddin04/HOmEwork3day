int n=Convert.ToInt32(Console.ReadLine());
int [] arr =new int[n];
for(int i=0;i<n;i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int max=arr[0];
int index=0;
for (int i = 0; i <n; i++)
{
    if(max<arr[i]){
        max=arr[i];
        index=i;
    }
}
System.Console.WriteLine(index);