
using Microsoft.ML.Data;
namespace ImageClassificationInfraClassify.MyWebApp
{
    public class ImagePrediction
    {
      
            [ColumnName("Score")]
            public float[] Score;

            [ColumnName("PredictedLabel")]
            public string PredictedLabel;
  
    }
}
