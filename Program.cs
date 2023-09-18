internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> dicccionario = new Dictionary<int, string>();
        Console.WriteLine("El total de el elemento es: " + dicccionario.Count);
        Dictionary<string, string> openWith = new Dictionary<string, string>();

        openWith.Add("txt","notepad.exe");
        openWith.Add("bmp","paint.exe");
        openWith.Add("did","paint.exe");
        openWith.Add("rft","wordpad.exe");
        
        Dictionary<string, string>.KeyCollection ketColl = openWith.Keys;

        foreach (string key in ketColl){
            Console.WriteLine(key);
        }

        // try
        // {
        //     openWith.Add("txt","winword.exe");
        // }
        // catch (ArgumentException)
        // {
        //     Console.WriteLine("un elemento con la llave \"txt\" esta presente");
        // }
    }


}