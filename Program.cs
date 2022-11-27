internal class Program
{
    private static void Main(string[] args)
    {
         Methods methods=new Methods();
        //1
        methods.FirstMethod();

        //2
        methods.SecondMethod();
        
        //3
        methods.ThirdMethod();

        //4
        methods.FourthMethod();

        


        
        
    }

}
public class  Methods
{
    public void FirstMethod()
    {
        Console.WriteLine("please,enter a positive number!: ");
        int n=Convert.ToInt32(Console.ReadLine());
        uint [] array=new uint[n];
        
        

        for(int i=0;i<array.Length;i++)
        {
            Console.WriteLine("please, enter {0}. number:",i+1);
            array[i]=Convert.ToUInt32(Console.ReadLine());         

        }
        foreach (var item in array)
        {
            if(item%2==0)
            Console.WriteLine(item);
                           
        }
    } 

    public void SecondMethod()
    {

        Console.WriteLine("please, enter a number:");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please, enter a number:");
         int y=Convert.ToInt32(Console.ReadLine());
        int[] dizi=new int[x];
        for(int i=0;i<x;i++)
        {
         Console.WriteLine("please, enter {0}. number:",i+1);
          dizi[i]=Convert.ToInt32(Console.ReadLine());  
        }

         foreach (var item in dizi)
        {
            if(item%y==0||item==y)
            Console.WriteLine(item);
                           
        }
       
    }
     public void ThirdMethod()
        {
            Console.WriteLine("please,enter positive number");
            int n=Convert.ToInt32(Console.ReadLine());  

            string [] array=new string[n];
            
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("please, enter {0}. word:",i+1);
                array[i]=Console.ReadLine();
            }
            Console.WriteLine("reverse pronunciation:");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
       
        public void FourthMethod()
        {
            Console.WriteLine("Please enter a sentence.");
            string s=Console.ReadLine();            
            string [] array=s.Split(" ");
            string word=string.Join("",array);
            Console.WriteLine("Word Count:"+array.Count()+"   Letter Count:"+word.Count());
            

        }
}