
namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            {
                var a = 5;
                var b = 3.16;
                // ovdje prevoditelj javlja pogrešku da double
                // ne može pretvoriti implicitno u int
                b = a;
            }

            {
                // u IL kodu možemo vidjeti da će gornje inicijalizacije
                // prevoditelj pretvoriti u isto što i donji kod
                int a = 5;
                double b = 3.16;
            }

            var s = new S();
            s.a = 10;
        }
    }
}
