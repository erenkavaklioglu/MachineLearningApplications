#region Information
/*
Author : Eren Kavaklıoğlu
Year   : 2019
*/
#endregion

using System;

namespace MachineLearningTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //CurrencyPredictionTester.Predict_USD_TR_Parity();

            //Console.WriteLine("AND");
            //BinaryOperationsPredictionTester.PredictAND();

            //Console.WriteLine("OR");
            //BinaryOperationsPredictionTester.PredictOR();

            Console.WriteLine("XOR");
            BinaryOperationsPredictionTester.PredictXOR();

            //Console.WriteLine("NAND");
            //BinaryOperationsPredictionTester.PredictNAND();
        }
    }
}
