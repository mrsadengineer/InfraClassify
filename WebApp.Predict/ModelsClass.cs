using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;


namespace ImageClassificationInfraClassify.MyWebApp
{

    public class ModelInput
    {
        public ModelInput(byte[] image, string label, string imageFileName, string imagesource)
        {
            Image = image;
            Label = label;
            ImageFileName = imageFileName;
            ImageSource = imagesource;
        }

      [ColumnName(@"Label")]
        public string Label { get; set; }

        [ColumnName(@"ImageSource")]
        public string ImageSource { get; set; }

        public readonly byte[] Image;

      //  public readonly string Label;

        public readonly string ImageFileName;
    }


    /// <summary>
    /// model output class for ImageClassifierInfrastructureMLModel.
    /// </summary>
  
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabel { get; set; }

        [ColumnName("Score")]
        public float[] Score { get; set; }
    }
}