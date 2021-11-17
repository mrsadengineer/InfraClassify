//const serviceUrl = 'https://localhost:44380/api/ImageClassification/classifyImage';

//const serviceUrl = 'http://localhost:5000/api/ImageClassification/classifyImage';

const serviceUrl = 'api/ImageClassification/classifyImage';
const form = document.querySelector('form');

form.addEventListener('submit', e => {
    e.preventDefault();

    const files = document.querySelector('[type=file]').files;
    const formData = new FormData();

    formData.append('imageFile', files[0]);

    // If multiple files uploaded at the same time:
    //for (let i = 0; i < files.length; i++) {
    //    let file = files[i];
    //
    //    formData.append('imageFile[]', file);
    //}
 

    fetch(serviceUrl, {
        method: 'POST',
        body: formData
    }).then((resp) => resp.json())
      .then(function (response) {
          console.info('Response', response);
          console.log('Response', response);

          //alert('Prediction is: ' + 'Label: ' + response.predictedLabel + ' Probability: ' + response.probability);
          
          document.getElementById('divImageId').innerHTML = "Name of image file was: " + response.imageId;
          document.getElementById('divPrediction').innerHTML = "Predicted label is: " + response.predictedLabel;
          document.getElementById('divProbability').innerHTML = "Probability is: " + (response.probability * 100).toFixed(3) + "%";
          document.getElementById('divExecutionTime').innerHTML = "Execution time was: " + response.predictionExecutionTime + " mlSecs";


        //  var imagesour = document.getElementById('imageupload');
         // imagesour.src = files[0];
          
         // var preview = document.querySelector('imageupload');

          var preview = document.getElementById('imageupload');
          var file = document.querySelector('input[type=file]').files[0];
          var reader = new FileReader();

          reader.onloadend = function () {
              preview.src = reader.result;
          }

          if (file) {
              reader.readAsDataURL(file);
          } else {
              preview.src = "";
          }




          return response;
        });


});