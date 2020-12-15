const express = require("express");
const app = express();
const bodyParser = require("body-parser");
const https = require("https");

app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static("public")); // css için public folderı yarat

app.set("view engine", "ejs")

app.get("/", function (req, res) {

    res.render("home");

})

app.post("/", function (req, res) {
    const query = req.body.cityName;
    const apiKey = "87cc56b891977c85416c370bca6506f6"
    const unit = "metric"

    const url = "https://api.openweathermap.org/data/2.5/weather?q=" + query + "&appid=" + apiKey + "&units=" + unit;

    https.get(url, function (response) { // fetch the data from external server

        console.log(response.statusCode);

        response.on("data", function (data) {

            const weatherData = JSON.parse(data)
            const temp = weatherData.main.temp;
            const description = weatherData.weather[0].description;
            console.log(temp);
            console.log(description);
            const icon = weatherData.weather[0].icon;
            console.log(icon);
            const iconUrl = "https://openweathermap.org/img/wn/" + icon + "@2x.png"
            // res.write(`<p style>The weather is ${description} </p>`)
            // res.write(`<h1>the temperature is in ${query} is  ${temp} degrees</h1>`)
            // res.write(`<img src=${iconUrl}>`)
            // res.send()
            res.render("index", { temp: temp, description: description, iconUrl: iconUrl, query: query })
        })
    })
})


app.listen(3000, function () {
    console.log("running on port 3000");
})