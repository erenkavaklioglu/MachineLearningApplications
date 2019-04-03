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
    /// Prediction result for parity of two currencies
    /// </summary>
    public class ParityPrediction
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
