require("dotenv").config()
const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const ejs = require('ejs');
const session = require('express-session');
const passport = require('passport');
const findOrCreate = require("mongoose-findorcreate")
const GoogleStrategy = require("passport-google-oauth20").Strategy;
const app = express()
const passportLocalMongoose = require('passport-local-mongoose');

app.use(express.static("public"))
app.set("view engine", "ejs")
app.use(bodyParser.urlencoded({ extended: true }))

app.use(session({
    secret: process.env.SECRET,
    resave: false,
    saveUninitialized: false
}));

app.use(passport.initialize())
app.use(passport.session())

mongoose.connect("mongodb+srv://adminFurkan:" + process.env.MONGO_PASSWORD + "@cluster0.dpj3v.mongodb.net/duobulDB?retryWrites=true&w=majority", { useNewUrlParser: true, useUnifiedTopology: true });

mongoose.set("useCreateIndex", true)  // deprecation warning 

const userSchema = new mongoose.Schema({
    email: String,
    nickName: String,
    password: String,
    googleId: String
})

userSchema.plugin(passportLocalMongoose)
userSchema.plugin(findOrCreate)

const User = new mongoose.model("User", userSchema)
passport.use(User.createStrategy())

passport.serializeUser(User.serializeUser())
passport.deserializeUser(User.deserializeUser())


app.get("/", function (req, res) {
    res.render("home")
})
app.get("/login", function (req, res) {
    res.render("login")
})

app.get("/register", function (req, res) {
    res.render("register")
})
app.get("/welcome", function (req, res) {
    if (req.isAuthenticated())
        res.render("welcome")
    else
        res.redirect("/login")
})
app.get("/logout", function (req, res) {
    req.logOut()
    res.redirect("/")
})

app.post("/register", function (req, res) {
    User.register({ username: req.body.username }, req.body.password, function (err, user) {
        if (err) {
            console.log(err);
            res.redirect("/register")
        }
        else {
            passport.authenticate("local")(req, res, function () {
                res.redirect("/welcome")
            })
        }
    })
})
app.post("/login", function (req, res) {
    const user = new User({
        username: req.body.username,
        password: req.body.password
    })

    req.logIn(user, function (err) {
        if (err) {
            console.log(err);

        }
        else {
            passport.authenticate("local")(req, res, function () {
                res.redirect("/welcome")
            })
        }
    })
})


app.listen(3000, function () {
    console.log("started on 3000");
})