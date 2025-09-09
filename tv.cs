public class Televisao
{
    private const int CANAL_MAX = 520;
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Canal = 1;
        UltimoCanal = 1;
        Volume = 50;
        Estado = false;
        Mudo = false;
    }

    public float Tamanho { get; } 
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public int UltimoCanal { get; private set; }
    public bool Estado { get; private set; }
    public bool Mudo { get; private set; }

    public void Ligar()
    {
        Estado = true;
        Canal = UltimoCanal;
        Console.WriteLine("TV ligada no canal " + Canal);
    }

    public void Desligar()
    {
        Estado = false;
        UltimoCanal = Canal;
        Console.WriteLine("TV desligada");
    }

    public void IrParaCanal(int numero)
    {
        if (numero >= 1 && numero <= CANAL_MAX)
        {
            Canal = numero;
            UltimoCanal = numero;
        }
        else
        {
            Console.WriteLine("Canal inválido");
        }
    }

    public void CanalAcima()
    {
        if (Canal < CANAL_MAX)
        {
            Canal++;
            UltimoCanal = Canal;
        }
    }

    public void CanalAbaixo()
    {
        if (Canal > 1)
        {
            Canal--;
            UltimoCanal = Canal;
        }
    }

    public void AumentarVolume()
    {
        if (!Mudo)
        {
            if (Volume < VOL_MAX)
                Volume++;
            else
                Console.WriteLine("Volume já está no máximo");
        }
    }

    public void DiminuirVolume()
    {
        if (!Mudo)
        {
            if (Volume > VOL_MIN)
                Volume--;
            else
                Console.WriteLine("Volume já está no mínimo");
        }
    }

    public void AtivarMudo()
    {
        Mudo = true;
        Console.WriteLine("Mudo ativado");
    }

    public void DesativarMudo()
    {
        Mudo = false;
        Console.WriteLine("Mudo desativado");
    }
}
