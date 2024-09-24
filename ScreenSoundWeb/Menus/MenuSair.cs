using ScreenSound.Modelos;
using ScreenSoundWeb.Banco;

namespace ScreenSoundWeb.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
