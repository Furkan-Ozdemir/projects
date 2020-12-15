const express = require('express');
const bodyParser = require('body-parser');
const app = express();

app.set("view engine", "ejs")
app.use(bodyParser.urlencoded({ extended: true }))
app.use(express.static("public"))

let items = [];
//let newItemText = document.getElementById("newItemText").innerText;
app.get("/", function (req, res) {
    let today = new Date();
    let options = {
        weekday: "long",
        day: "numeric",
        month: "long"
    }
    let day = today.toLocaleDateString("tr-TR", options)
    res.render("list", { date: day, newListItems: items })
})

app.post("/", function (req, res) {
    let newItem = req.body.newItem;
    items.push(newItem)
    res.redirect("/");

})



app.listen(4000, function (req, res) {
    console.log("started on 4000");
})