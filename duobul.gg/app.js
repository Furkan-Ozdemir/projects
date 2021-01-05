const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const ejs = require('ejs');
const session = require('express-session');
const passport = require('passport');
const findOrCreate = require("mongoose-findorcreate")
const GoogleStrategy = require("passport-google-oauth20")
const app = express()

app.use(express.static("public"))
app.set("view engine", "ejs")
app.use(bodyParser.urlencoded({ extended: true }))

app.use(session({
    secret: "My very long string.",
    resave: false,
    saveUninitialized: false
}));

app.use(passport.initialize())
app.use(passport.session())

mongoose.connect("mongodb+srv://adminFurkan:Test123@cluster0.dpj3v.mongodb.net/duobulDB?retryWrites=true&w=majority", { useNewUrlParser: true, useUnifiedTopology: true });

mongoose.set("useCreateIndex", true)

const userSchema = new mongoose.Schema({
    email: String,
    nickName: String,
    password: String,
    googleId: String
})

userSchema.plugin(findOrCreate)

const User = new mongoose.model("User", userSchema)
passport.use(User.createStrategy())