using ScreenSoundWeb.Banco;
using ScreenSoundWeb.Modelos;

namespace ScreenSoundWeb.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
