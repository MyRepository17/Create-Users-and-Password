public class Program
{
    private static void Main(string[] args)
    {
        Program program= new Program();
        string palabraClave = "usuario";
        var respUsuario = program.GenerarUsuario(palabraClave);
        var respClave = program.GenerarClave();
        Console.WriteLine("Usuario:"+respUsuario);
        Console.WriteLine("Clave:"+respClave);
    }

    public string GenerarUsuario(string palabraClave)
    {
        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var Charsarr = new char[4];
        var random = new Random();

        for (int i = 0; i < Charsarr.Length; i++)
        {
            Charsarr[i] = characters[random.Next(characters.Length)];
        }
        var resultString = new String(Charsarr);
        return palabraClave+"-"+resultString;
    }
    public string GenerarClave()
    {
        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var Charsarr = new char[8];
        var random = new Random();

        for (int i = 0; i < Charsarr.Length; i++)
        {
            Charsarr[i] = characters[random.Next(characters.Length)];
        }
        var resultString = new String(Charsarr);
        return resultString;
    }
}