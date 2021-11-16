﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace ImageClassifierInfrastructureMLModel_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ImageClassifierInfrastructureMLModel.ModelInput sampleData = new ImageClassifierInfrastructureMLModel.ModelInput()
            {
                ImageSource = @"E:\infrastructure_images\bridges\10 Famous Bridges In The U.S. - Cool ....jpg",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ImageClassifierInfrastructureMLModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");


            Console.WriteLine($"ImageSource: {@"E:\infrastructure_images\bridges\10 Famous Bridges In The U.S. - Cool ....jpg"}");


            Console.WriteLine($"\n\nPredicted Label value: {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}