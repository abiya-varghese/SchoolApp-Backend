namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 3, 2, 4, 6, 7, 8 };
            var res=from n in num
                    let i= n*n*n
                    where i>100&&i<1000
                    select i;
            foreach( var h in res ) { 
            Console.WriteLine(h);
            }
        }
    }
}
