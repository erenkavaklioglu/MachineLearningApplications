#region Information
/*
Author : Eren Kavaklıoğlu
Year   : 2019
*/
#endregion

using MachineLearningApplications.DataStructures.BinaryOperations;
using MachineLearningApplications.Predictors.BinaryOperations;
using System;

namespace MachineLearningTester
{
    /// <summary>
    /// Tests the binary prediction algorithm
    /// </summary>
    public static class BinaryOperationsPredictionTester
    {
        /// <summary>
        /// Tests prediction for Binary AND operation
        /// </summary>
        public static void PredictAND()
        {
            PredictBinaryOperation(@".\DATA\BinaryOperations\AND.csv");
        }

        /// <summary>
        /// Tests prediction for Binary OR operation
        /// </summary>
        public static void PredictOR()
        {
            PredictBinaryOperation(@".\DATA\BinaryOperations\OR.csv");
        }

        /// <summary>
        /// Tests prediction for Binary XOR operation
        /// </summary>
        public static void PredictXOR()
        {
            PredictBinaryOperation(@".\DATA\BinaryOperations\XOR.csv");
        }

        /// <summary>
        /// Tests prediction for Binary NAND operation
        /// </summary>
        public static void PredictNAND()
        {
            PredictBinaryOperation(@".\DATA\BinaryOperations\NAND.csv");
        }

        /// <summary>
        /// Predicts binary operation according to given dataset
        /// </summary>
        /// <param name="dataFilePath">Path for data file</param>
        private static void PredictBinaryOperation(string dataFilePath)
        {
            BinaryPredictor predictor = new BinaryPredictor(dataFilePath);
            predictor.Train();

            BinaryData data = new BinaryData();

            //0, 0
            data.FirstBit = 0; data.SecondBit = 0;
            BinaryPrediction predictionResult = predictor.Predict(data);
            Console.WriteLine("0, 0 Prediction: " + predictionResult.Prediction);

            //0, 1
            data.FirstBit = 0; data.SecondBit = 1;
            predictionResult = predictor.Predict(data);
            Console.WriteLine("0, 1 Prediction: " + predictionResult.Prediction);

            //1, 0
            data.FirstBit = 1; data.SecondBit = 0;
            predictionResult = predictor.Predict(data);
            Console.WriteLine("1, 0 Prediction: " + predictionResult.Prediction);

            //1, 1
            data.FirstBit = 1; data.SecondBit = 1;
            predictionResult = predictor.Predict(data);
            Console.WriteLine("1, 1 Prediction: " + predictionResult.Prediction);

            Console.ReadKey();
        }
    }
}
