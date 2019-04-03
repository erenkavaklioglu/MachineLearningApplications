#region Information
/*
Author : Eren Kavaklıoğlu
Year   : 2019
*/
#endregion

using MachineLearningApplications.DataStructures.Currencies;
using MachineLearningApplications.Predictors.Currencies;
using System;

namespace MachineLearningTester
{
    /// <summary>
    /// Tests the currency prediction algorithm
    /// </summary>
    public static class CurrencyPredictionTester
    {
        /// <summary>
        /// Tests prediction for USD/TR Parity
        /// </summary>
        public static void Predict_USD_TR_Parity()
        {
            ParityPredictor predictor = new ParityPredictor(@".\DATA\Currencies\USD_TR_Parity_1M.csv");
            predictor.Train();

            ParityData data = new ParityData()
            {
                Day = 3,
                Month = 4,
                Year = 2019,
                Start = 5.6175f,
                Low = 5.5705f,
                High = 5.6588f
            };

            ParityPrediction predictionResult = predictor.Predict(data);

            Console.WriteLine("Prediction: " + predictionResult.Prediction);
            Console.ReadKey();
        }
    }
}
