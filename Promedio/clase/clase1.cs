namespace PromedioDNota
{
    public class PromedioDeNota
    {
        public void PromedioMayorMenor()
        {
            decimal Promedio1 = 0;
            decimal Promedio2 = 0;
            decimal Promedio3 = 0;
            decimal nota = 0;

            try
            {
                Console.WriteLine("Ingrese su primer promedio aqui: ");
                Promedio1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su segundo promedio aqui: ");
                Promedio2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su tercer promedio aqui: ");
                Promedio3 = decimal.Parse(Console.ReadLine());

                nota = (Promedio1 + Promedio2 + Promedio3) / 3;
                if (nota >= 7)
                {
                    Console.WriteLine("Promocionado");

                }

                else
                {
                    Console.WriteLine("No Promocionado");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }


        }

    }

}
