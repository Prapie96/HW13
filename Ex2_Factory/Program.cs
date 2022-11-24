class Program
{
    static void Main(string[] args)
    {
        Queue<int> PutFruits = new Queue<int>();
        Queue<int> FisrtCut = new Queue<int>();
        Queue<int> SecondCut = new Queue<int>(); 
        char FruitSize = '?';
        while(FruitSize == '?'||FruitSize == 'L'||FruitSize == 'M'||FruitSize == 'S' )
        {
            FruitSize = char.Parse(Console.ReadLine());
           
           if(FruitSize == 'L')
            {
                PutFruits.Push(1);
                PushL(ref FisrtCut,ref SecondCut);  
            }
            else if(FruitSize == 'M')
            {
                PutFruits.Push(2);
                PushM(ref FisrtCut);  
            }
             else if(FruitSize == 'S')
            {
                PutFruits.Push(3);
            }

        }
        ShowSize(PutFruits,FisrtCut,SecondCut);
    }
    static void ShowSize(Queue<int>PutFruits,Queue<int> FisrtCut,Queue<int> SecondCut){
        for(int i = 0; i < PutFruits.GetLength(); i++)
        {
            Console.Write("{0}",PutFruits.Get(i));
        }
        for(int p = 0; p < FisrtCut.GetLength(); p++)
        {
            Console.Write("{0}", FisrtCut.Get(p));
        }
        for(int m = 0; m < SecondCut.GetLength(); m++)
        {
            Console.Write("{0}", SecondCut.Get(m));
        }
    }
    static void PushL(ref Queue<int> FisrtCut,ref Queue<int> SecondCut){
        for(int i= 0;i<2;i++){
            FisrtCut.Push(2);
        }
        for(int O = 0;O<6;O++){
            SecondCut.Push(3);
            }
    }
    static void PushM(ref Queue<int> FisrtCut){
        for(int i = 0;i<3;i++){
           FisrtCut.Push(3);
        }
        
    }
}


