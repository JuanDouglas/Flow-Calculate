namespace FlowCalculate {
    /// <summary>
    /// Classe responsável por obter o coeficiente.
    /// </summary>
    public class Coefficient {
        public double Value { get => GetCoenficiente(); }
        /// <summary>
        /// Classificação Do Canal
        /// </summary>
        public Classification Classificacao { get; private set; }
        /// <summary>
        /// Material do canal
        /// </summary>
        public Material Material { get; private set; }

        public Coefficient(Classification classificacao, Material material) {
            Classificacao = classificacao;
            Material = material;
        }
        /// <summary>
        /// Obtém o Coeficiente pelos valores
        /// </summary>
        /// <returns>Obtém a constante do coefiente definido.</returns>
        private double GetCoenficiente() {
            switch (Material) {
                case Material.Rocha:
                    switch (Classificacao) {
                        case Classification.VeryGood:
                            return 0.035;
                        case Classification.Good:
                            return 0.040;
                        case Classification.Normal:
                            return 0.045;
                        case Classification.Bad:
                            return 0;
                        default:
                            return 0;
                    }
                case Material.Fundo_em_terra_e_talude_com_pedra:
                    switch (Classificacao) {
                        case Classification.VeryGood:
                            return 0.028;
                        case Classification.Good:
                            return 0.030;
                        case Classification.Normal:
                            return 0.033;
                        case Classification.Bad:
                            return 0.035;
                        default:
                            return 0;
                    }
                case Material.Leito_pedregoso_e_talude_vegetado:
                    switch (Classificacao) {
                        case Classification.VeryGood:
                            return 0.025;
                        case Classification.Good:
                            return 0.030;
                        case Classification.Normal:
                            return 0.035;
                        case Classification.Bad:
                            return 0.040;
                        default:
                            return 0;
                    }
                case Material.Revestimento_de_concreto:
                    switch (Classificacao) {
                        case Classification.VeryGood:
                            return 0.012;
                        case Classification.Good:
                          return 0.014;
                        case Classification.Normal:
                            return 0.016;
                        case Classification.Bad:
                            return 0.018;
                        default:
                            return 0;
                    }
                case Material.Terra_retilineo_ou_uniforme:
                    switch (Classificacao) {
                        case Classification.VeryGood:
                            return 0.017;
                        case Classification.Good:
                            return 0.020;
                        case Classification.Normal:
                            return 0.023;
                        case Classification.Bad:
                            return 0.025;
                        default:
                            return 0;
                    }
                case Material.Canais_dragados:
                    switch (Classificacao) {
                        case Classification.VeryGood:
                            return 0.025;
                        case Classification.Good:
                            return 0.028;
                        case Classification.Normal:
                            return 0.030;
                        case Classification.Bad:
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
