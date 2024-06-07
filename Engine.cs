namespace TTT;

public class Engine
{
    private char symbol = 'x';
    Char[,] render = new Char[3,3];

    public Engine() {

        Init();
        Run();
    }

    private void Init(){
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                render[i,j] = new Char('?');
            }
        }
    }

    private void Run(){
        Console.Clear();
        Render();
        
        string input = "";
        while(input.Length!=2) { 
            Console.Clear();
            Render();
            input = Console.ReadLine();
        }
        
        int x = int.Parse(input[0].ToString());
        int y = int.Parse(input[1].ToString());
        // Console.WriteLine(x+" "+y);

        // symbol = (render[x-1,y-1].symbol == 'x') ? 'o' : 'x';
        symbol = (symbol == 'x') ? 'o' : 'x';
        render[x-1,y-1] = new Char(symbol);

        Run();
    }

    private void Render(){
        for(int i=0;i<3;i++){
            // string line="";
            for(int j=0;j<3;j++){
                // line+=render[i,j].symbol+" ";
                render[i,j].time--;
                if(render[i,j].time==0) render[i,j] = new Char('?');
                
                ConsoleColor color = ConsoleColor.White;
                if(render[i,j].symbol == 'x')
                    color = (render[i,j].time<=2) ? ConsoleColor.Yellow : ConsoleColor.Red;
                else if(render[i,j].symbol == 'o') 
                    color = (render[i,j].time<=2) ? ConsoleColor.Yellow : ConsoleColor.Blue;
                Console.ForegroundColor = color;
                Console.Write(render[i,j].symbol+" ");
            }
            // Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}