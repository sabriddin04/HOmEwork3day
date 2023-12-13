int n=Convert.ToInt32(Console.ReadLine());
int []array = new int [n];
for(int i=0;i<n;i++){
    array[i]=Convert.ToInt32(System.Console.ReadLine());
}
int sum=1;
for (int i = 0; i < n; i++)
{
    sum*=array[i];
    if(i!=n-1){
        System.Console.Write(array[i]+"*");
    }
    else System.Console.Write(array[i]+"="+sum);
}

