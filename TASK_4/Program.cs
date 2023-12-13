int n=Convert.ToInt32(Console.ReadLine());
int [] arr=new int[n];
for(int i=0;i<n;i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int cnt=0;
for (int i = 0; i <n; i++)
{
    for(int j=0;j<n;j++){
        if(i!=j && arr[i]==arr[j])
        {
            cnt++;
        }
    }
    if(cnt==0) System.Console.Write(arr[i]+" ");
    cnt=0;
}
