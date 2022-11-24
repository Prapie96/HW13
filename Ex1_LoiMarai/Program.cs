class Program
{
    static void Main(string[] args)
    {
        Queue<char>LoiMarai = new Queue<char>{};
        char NameFlowers = '?';
        int NubG = 0;
        
        
        while(NameFlowers == '?'||NameFlowers == 'J'||NameFlowers == 'G'||NameFlowers == 'O'||NameFlowers == 'R'){
            NameFlowers = char.Parse(Console.ReadLine());

                if(NameFlowers == 'J'){
                    LoiMarai.Push('J');
                    
                }
                else if (NameFlowers == 'G'){   
                    if(NubG <3){
                        LoiMarai.Push('G');
                        NubG = NubG + 1 ;
                    }
                    else{
                        Console.WriteLine("Invalid pattern.");
                    }
                }
                else if (NameFlowers == 'O'){
                    LoiMarai.Push('O');
                }
                else if (NameFlowers == 'R'){
                    LoiMarai.Push('R');
                }
                
        }
        ShowFlower(LoiMarai);
        
    static void ShowFlower(Queue<char>LoiMarai){
        for(int i = 0; i < LoiMarai.GetLength(); i++)
        {
            Console.Write("{0}",LoiMarai.Get(i));
        }
        
    }

    }
}
