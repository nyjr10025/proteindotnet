using System;
using System.Collections.Generic;

namespace ProteinDotNet
{
    public class CalculationConstants
    {
        public CalculationConstants()
        {
        }
        #region Molecular Weight

        #endregion

        #region ExtinctionCoefficient

        #endregion
        #region IsoelectricPoint
        private static readonly IDictionary<char, (double Nterm, double Cterm)> SkoogWichmannPkas = new Dictionary<char, (double Nterm, double Cterm)>
        {
            { 'X', (9.5, 2.2) },
            { 'D', (9.8, 2.1) },
            { 'N', (8.8, 2.1) },
            { 'T', (9.1, 2.1) },
            { 'S', (9.2, 2.2) },
            { 'E', (9.7, 2.2) },
            { 'Q', (9.1, 2.2) },
            { 'P', (10.6, 2.0) },
            { 'G', (9.8, 2.4) },
            { 'A', (9.9, 2.4) },
            { 'V', (9.7, 2.3) },
            { 'C', (10.8, 1.7) },
            { 'M', (9.3, 2.1) },
            { 'I', (9.8, 2.3) },
            { 'L', (9.7, 2.3) },
            { 'Y', (9.1, 2.2) },
            { 'F', (9.2, 2.2) },
            { 'K', (9.0, 2.2) },
            { 'H', (9.2, 1.8) },
            { 'W', (9.4, 2.4) },
            { 'R', (9.0, 2.2) },
        };
        private static readonly IDictionary<char, (double Nterm, double Cterm)> FreeAminoAcidPkas = new Dictionary<char, (double Nterm, double Cterm)>
        {
            { 'X', (9.51, 2.21) },
            { 'D', (9.85, 2.02) },
            { 'N', (8.82, 2.06) },
            { 'T', (9.10, 2.09) },
            { 'S', (9.18, 2.20) },
            { 'E', (9.57, 2.15) },
            { 'Q', (9.13, 2.17) },
            { 'P', (10.62, 1.98) },
            { 'G', (9.78, 2.35) },
            { 'A', (9.87, 2.34) },
            { 'V', (9.68, 2.30) },
            { 'C', (10.40, 1.93) },
            { 'M', (9.24, 2.28) },
            { 'I', (9.72, 2.34) },
            { 'L', (9.67, 2.35) },
            { 'Y', (9.11, 2.20) },
            { 'F', (9.21, 2.37) },
            { 'K', (9.06, 2.17) },
            { 'H', (9.18, 1.79) },
            { 'W', (9.42, 2.40) },
            { 'R', (9.02, 1.91) },
        };
        private static readonly IDictionary<char, (double Nterm, double Cterm)> RickardStrohlNielsenPkas = new Dictionary<char, (double Nterm, double Cterm)>
        {
            { 'X', (8.8, 3.13) },
            { 'D', (8.6, 2.75) },
            { 'N', (7.3, 2.75) },
            { 'T', (8.2, 3.2) },
            { 'S', (7.3, 3.2) },
            { 'E', (8.3, 3.2) },
            { 'Q', (7.7, 3.2) },
            { 'P', (9.0, 3.2) },
            { 'G', (8.2, 3.2) },
            { 'A', (8.2, 3.2) },
            { 'V', (8.2, 3.2) },
            { 'C', (7.3, 2.75) },
            { 'M', (9.2, 3.2) },
            { 'I', (8.2, 3.2) },
            { 'L', (8.2, 3.2) },
            { 'Y', (7.7, 3.2) },
            { 'F', (7.7, 3.2) },
            { 'K', (7.7, 3.2) },
            { 'H', (8.2, 3.2) },
            { 'W', (8.2, 3.2) },
            { 'R', (8.2, 3.2) },
        };

        private static readonly IDictionary<char, double> SkoogWichmanSideChainPkas = new Dictionary<char, double>
        {
            { 'D', 3.9 },
            { 'E', 4.3 },
            { 'C', 8.3 },
            { 'Y', 10.1 },
            { 'K', 10.5 },
            { 'H', 6.0 },
            { 'R', 12.5 },
        };
        private static readonly IDictionary<char, double> FreeAminoAcidSideChainPkas = new Dictionary<char, double>
        {
            { 'D', 3.82 },
            { 'E', 4.18 },
            { 'C', 8.26 },
            { 'Y', 10.11 },
            { 'K', 10.66 },
            { 'H', 6.08 },
            { 'R', 12.48 },
        };
        private static readonly IDictionary<char, double> RickardStrohlNielsenSideChainPkas = new Dictionary<char, double>
        {
            { 'D', 3.5 },
            { 'E', 4.5 },
            { 'C', 10.3 },
            { 'Y', 10.3 },
            { 'K', 10.3 },
            { 'H', 6.2 },
            { 'R', 12.5 },
        };
        #endregion
    }
}
