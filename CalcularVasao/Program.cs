using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace p.vasao {
    /// <summary>
    ///  Classe Principal
    /// </summary>
    class Program {
        /// <summary>
        /// Metodo principal
        /// </summary>
        /// <param name="args">O que tem no console</param>
        static void Main(string[] args) {
            do {
                //Obtem dados
                Console.Write("Digite a altura: ");
                double h = double.Parse(Console.ReadLine());
                Console.Write("Digite a base: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Digite a valor atribuido: ");
                double m = double.Parse(Console.ReadLine());
                Console.Write("Digite a inclinação: ");
                double i = double.Parse(Console.ReadLine());
                Material material = GetMaterial();
                Classificacao classificacao = GetClassificacao();

            
                //Define parimetro, Raio Hidraulico e area
                double perimetro = GetPerimetro(b, h, m);
                double area = GetArea(h, m, b);
                double raioHidraulico = GetRaioHidraulico(area, perimetro);

                //Mostra Resultado
                Console.WriteLine($"Resultado perimetro: {perimetro}m");
                Console.WriteLine($"Resultado area: {area}m²");
                Console.WriteLine($"Resultado Raio Hidraulico: {raioHidraulico}");

                Coeficiente coeficiente = new Coeficiente(classificacao, material);
                Console.WriteLine($"Resultado Vazao: {GetVazao(area, raioHidraulico, i, coeficiente)}m³/s");
            } while (true);
            
        }
        /// <summary>
        /// Obtém a classificação pelo usuário.
        /// </summary>
        /// <returns>Retornar a calssficação escolhida.</returns>
        private static Classificacao GetClassificacao() {
            Console.WriteLine("\t \t Classificações ");
            Console.WriteLine($"0 - {Classificacao.MuitoBoa.ToString()}");
            Console.WriteLine($"1 - {Classificacao.Boa.ToString()}");
            Console.WriteLine($"2 - {Classificacao.Regular.ToString()}");
            Console.WriteLine($"3 - {Classificacao.Ma.ToString()}");
            Console.Write("Digite o número da Clasificação: ");
            int selecionado = int.Parse(Console.ReadLine());
            return (Classificacao)selecionado;
        }
        /// <summary>
        /// Obtém a área.
        /// </summary>
        /// <param name="h">Altura</param>
        /// <param name="m">Valor do Talude</param>
        /// <param name="b">Base</param>
        /// <returns></returns>
        public static double GetArea(double h, double m, double b) {
            // A = H * (B + (M * H))
            double partial1 = m * h;
            double partial2= b + (partial1);
            return h * partial2;
        } 
        /// <summary>
        /// Obtém o perímetro do canal
        /// </summary>
        /// <param name="b">Base</param>
        /// <param name="h">Altura</param>
        /// <param name="m">Valor da Talude</param>
        /// <returns>Retornar o perímetro do canal</returns>
        public static double GetPerimetro(double b,double h,double m) {
            // P = B + 2 * H(√(1 + m²))
            double raiz = Math.Sqrt(1 + (m*m));
            double partial1 = h * raiz;
            double partial2 = (2 * partial1);
            return b + partial2;
        }
        /// <summary>
        /// Obtém o Raio Hidráulico.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="p"></param>
        /// <returns>Re</returns>
        public static double GetRaioHidraulico(double a,double p) {
            // R = A / P
            return a / p;
        }
        /// <summary>
        /// A 
        /// </summary>
        /// <param name="a">Área</param>
        /// <param name="r">Raio Hidráulico</param>
        /// <param name="i">Declividade do Canal</param>
        /// <param name="co">Coeficiente de Rugosidade</param>
        /// <returns></returns>
        public static double GetVazao(double a,double r,double i,Coeficiente co) {
            // Q = A *( 1 / N) * R^2/3 * I^1/2
            double partial1_1 = (double)2 / (double)3;
            double partial1 = Math.Pow(r,partial1_1);
            double partial2_1 = (double)1 / (double)2;
            double partial2 = Math.Pow(i,partial2_1);
            double partial3 = (double)1 / co.ValorDoCoeficiente;
            double partial4 = partial1 * partial2;
            double partial5 = a * partial3;
            return partial4 * partial5 ;
        }
        /// <summary>
        /// Obtém o material
        /// </summary>
        /// <returns>Retorna o Material escolhido.</returns>
        public static Material GetMaterial() {
            Console.WriteLine("\t \t Materiais ");
            Console.WriteLine($"0 - {Material.Rocha.ToString()}");
            Console.WriteLine($"1 - {Material.Fundo_em_terra_e_talude_com_pedra.ToString()}");
            Console.WriteLine($"2 - {Material.Leito_pedregoso_e_talude_vegetado.ToString()}");
            Console.WriteLine($"3 - {Material.Revestimento_de_concreto.ToString()}");
            Console.WriteLine($"4 - {Material.Terra_retilineo_ou_uniforme.ToString()}");
            Console.WriteLine($"5 - {Material.Canais_dragados.ToString()}");
            Console.Write("Digite o número da Material: ");
            int selecionado = int.Parse(Console.ReadLine());
            return (Material)selecionado;

        }
       }
}
