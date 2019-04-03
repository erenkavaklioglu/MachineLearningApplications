#region Information
/*
Author : Eren Kavaklıoğlu
Year   : 2019
*/
#endregion

using Microsoft.ML.Data;

namespace MachineLearningApplications.DataStructures.Currencies
{
    /// <summary>
    /// Data for parity of two currencies
    /// </summary>
    public class ParityData
    {
        #region Properties

        /// <summary>
        /// Day of the year
        /// </summary>
        [LoadColumn(0)]
        public float Day { get; set; }

        /// <summary>
        /// Month of the year
        /// </summary>
        [LoadColumn(1)]
        public float Month { get; set; }

        /// <summary>
        /// Year
        /// </summary>
        [LoadColumn(2)]
        public float Year { get; set; }

        /// <summary>
        /// Parity value at the start of the day
        /// </summary>
        [LoadColumn(3)]
        public float Start { get; set; }

        /// <summary>
        /// Minimum value during the day
        /// </summary>
        [LoadColumn(4)]
        public float Low { get; set; }

        /// <summary>
        /// Maximum value during the day
        /// </summary>
        [LoadColumn(5)]
        public float High { get; set; }

        /// <summary>
        /// Parity value at the end of the day
        /// </summary>
        [LoadColumn(6)]
        public float End { get; set; }

        #endregion
    }
}
