#region Information
/*
Author : Eren Kavaklıoğlu
Year   : 2019
*/
#endregion

using MachineLearningApplications.DataStructures.BinaryOperations;
using Microsoft.Data.DataView;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MachineLearningApplications.Predictors.BinaryOperations
{
    /// <summary>
    /// Class for binary operations prediction
    /// </summary>
    public class BinaryPredictor
    {
        #region Fields

        /// <summary>
        /// Path of ML data file
        /// </summary>
        private string _dataFilePath;

        /// <summary>
        /// Data set for ML
        /// </summary>
        private IDataView _dataSet;

        /// <summary>
        /// Context for ML
        /// </summary>
        private MLContext _MLContext;

        /// <summary>
        /// Prediction engine for binary operations
        /// </summary>
        private PredictionEngine<BinaryData, BinaryPrediction> _predictionEngine;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataFilePath">Path of ML data file</param>
        public BinaryPredictor(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
            _MLContext = new MLContext();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Train the ML according to given data set
        /// </summary>
        private void LoadDataSet()
        {
            _dataSet = _MLContext.Data.LoadFromTextFile<BinaryData>(path: _dataFilePath, hasHeader: true, separatorChar: ';');
        }

        /// <summary>
        /// Creates prediction engine and trains the data set
        /// </summary>
        private void CreatePredictionEngine()
        {
            if (null != _dataSet)
            {
                var pipeline = _MLContext.Transforms.Conversion.MapValueToKey("ResultBit")
                    .Append(_MLContext.Transforms.Concatenate("Features", "FirstBit", "SecondBit"))
                    .AppendCacheCheckpoint(_MLContext)
                    .Append(_MLContext.MulticlassClassification.Trainers.StochasticDualCoordinateAscent(labelColumnName: "ResultBit", featureColumnName: "Features"))
                    //.Append(_MLContext.MulticlassClassification.Trainers.NaiveBayes(labelColumnName: "End", featureColumnName: "Features"))
                    .Append(_MLContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                var model = pipeline.Fit(_dataSet);

                _predictionEngine = model.CreatePredictionEngine<BinaryData, BinaryPrediction>(_MLContext);
            }
        }

        /// <summary>
        /// Trains the predictor
        /// </summary>
        public void Train()
        {
            LoadDataSet();
            CreatePredictionEngine();
        }

        /// <summary>
        /// Predicts binary operation according to given data
        /// </summary>
        /// <param name="data">Data for prediction</param>
        /// <returns>Predicted data</returns>
        public BinaryPrediction Predict(BinaryData data)
        {
            BinaryPrediction result = null;

            if (null != data)
            {
                if (null != _predictionEngine)
                {
                    result = _predictionEngine.Predict(data);
                }
            }

            return result;
        }

        #endregion
    }
}
