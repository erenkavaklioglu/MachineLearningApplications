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
    /// Prediction result for binary operations
    /// </summary>
    public class BinaryPrediction
    {
        #region Properties

        /// <summary>
        /// Prediction result
        /// </summary>
        [ColumnName("PredictedLabel")]
        public float Prediction { get; set; }

        #endregion
    }
}
