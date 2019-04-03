#region Information
/*
Author : Eren Kavaklıoğlu
Year   : 2019
*/
#endregion

using Microsoft.ML.Data;

namespace MachineLearningApplications.DataStructures.BinaryOperations
{
    /// <summary>
    /// Data for binary operations
    /// </summary>
    public class BinaryData
    {
        #region Properties

        /// <summary>
        /// First bit for binary operation
        /// </summary>
        [LoadColumn(0)]
        public float FirstBit { get; set; }

        /// <summary>
        /// Second bit for binary operation
        /// </summary>
        [LoadColumn(1)]
        public float SecondBit { get; set; }

        /// <summary>
        /// Result of the two bits
        /// </summary>
        [LoadColumn(2)]
        public float ResultBit { get; set; }

        #endregion
    }
}
