namespace p.vasao {
    /// <summary>
    /// Classe responsável por obter o coeficiente.
    /// </summary>
    public class Coeficiente {
        public double ValorDoCoeficiente { get => GetCoenficiente(); }
        /// <summary>
        /// Classificação Do Canal
        /// </summary>
        public Classificacao Classificacao { get; private set; }
        /// <summary>
        /// Material do canal
        /// </summary>
        public Material Material { get; private set; }

        public Coeficiente(Classificacao classificacao, Material material) {
            Classificacao = classificacao;
            Material = material;
        }
        /// <summary>
        /// Obtém o Coeficiente pelos valores
        /// </summary>
        /// <returns>Obtém o coefiente definido.</returns>
        private double GetCoenficiente() {
            switch (Material) {
                case Material.Rocha:
                    switch (Classificacao) {
                        case Classificacao.MuitoBoa:
                            return 0.035;
                        case Classificacao.Boa:
                            return 0.040;
                        case Classificacao.Regular:
                            return 0.045;
                        case Classificacao.Ma:
                            return 0;
                        default:
                            return 0;
                    }
                case Material.Fundo_em_terra_e_talude_com_pedra:
                    switch (Classificacao) {
                        case Classificacao.MuitoBoa:
                            return 0.028;
                        case Classificacao.Boa:
                            return 0.030;
                        case Classificacao.Regular:
                            return 0.033;
                        case Classificacao.Ma:
                            return 0.035;
                        default:
                            return 0;
                    }
                case Material.Leito_pedregoso_e_talude_vegetado:
                    switch (Classificacao) {
                        case Classificacao.MuitoBoa:
                            return 0.025;
                        case Classificacao.Boa:
                            return 0.030;
                        case Classificacao.Regular:
                            return 0.035;
                        case Classificacao.Ma:
                            return 0.040;
                        default:
                            return 0;
                    }
                case Material.Revestimento_de_concreto:
                    switch (Classificacao) {
                        case Classificacao.MuitoBoa:
                            return 0.012;
                        case Classificacao.Boa:
                          return 0.014;
                        case Classificacao.Regular:
                            return 0.016;
                        case Classificacao.Ma:
                            return 0.018;
                        default:
                            return 0;
                    }
                case Material.Terra_retilineo_ou_uniforme:
                    switch (Classificacao) {
                        case Classificacao.MuitoBoa:
                            return 0.017;
                        case Classificacao.Boa:
                            return 0.020;
                        case Classificacao.Regular:
                            return 0.023;
                        case Classificacao.Ma:
                            return 0.025;
                        default:
                            return 0;
                    }
                case Material.Canais_dragados:
                    switch (Classificacao) {
                        case Classificacao.MuitoBoa:
                            return 0.025;
                        case Classificacao.Boa:
                            return 0.028;
                        case Classificacao.Regular:
                            return 0.030;
                        case Classificacao.Ma:
                            return 0.033;
                        default:
                            return 0;
                    }
                default:
                    return 0;
            }
        }
    }
}
