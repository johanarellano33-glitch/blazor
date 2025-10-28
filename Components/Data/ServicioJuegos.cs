using xx.Components.Data;

namespace xx.Components.Data
{
    public class ServicioJuegos
    {
        private List<Juego> juegos = new List<Juego>
    {
    new Juego{Identificador=1, Nombre="Ravel" , Jugado=false},
    new Juego{Identificador= 2, Nombre= "Carcasonne", Jugado= true}
};
public Task<List<Juego>> ObtenerJuegos() => Task.FromResult(juegos);
public Task AgregarJuego (Juego juego)
{
    juegos.Add(juego);
    return Task.CompletedTask;
}
        public Task ActualizarJuego(Juego juego)
        {
            var juegoExistente = juegos.FirstOrDefault(j => j.Identificador == juego.Identificador);
            if (juegoExistente != null)
            {
                juegoExistente.Nombre = juego.Nombre;
                juegoExistente.Jugado = juego.Jugado;
            }
            return Task.CompletedTask;
        }
        public Task EliminarJuego(int identificador)
        {
            var juego = juegos.FirstOrDefault(j => j.Identificador == identificador);
            if (juego != null)
            {
                juegos.Remove(juego);
            }
            return Task.CompletedTask;
        }
    }


}