require("dotenv").config()
const express = require('express');
const bodyparser = require('body-parser');
const ejs = require('ejs');
const Mongoose = require('mongoose');
const app = express();
const session = require("express-session");
const passport = require("passport");
const passportLocalMongoose = require('passport-local-mongoose');
const GoogleStrategy = require("passport-google-oauth20").Strategy;
const findOrCreate = require("mongoose-findorcreate");



app.use(express.static("public"))
app.set("view engine", "ejs")
app.use(bodyparser.urlencoded({ extended: true }))

app.use(session({
    secret: "My very long string.",
    resave: false,
    saveUninitialized: false
}));

app.use(passport.initialize())
app.use(passport.session())

Mongoose.connect("mongodb://localhost:27017/userDB", { useNewUrlParser: true, useUnifiedTopology: true })

Mongoose.set("useCreateIndex", true)

const userSchema = new Mongoose.Schema({
    email: String,
    password: String,
    googleId: String,
    secret: String
})

userSchema.plugin(passportLocalMongoose)
userSchema.plugin(findOrCreate)



// modelden önce yapmak lazım
// hangi fieldi encrypt etmek istiyorsan onu yazıyorsun birden fazla istersen virgülle ekle

const User = new Mongoose.model("User", userSchema)
passport.use(User.createStrategy())

passport.serializeUser(function (user, done) {
    done(null, user.id);
});

passport.deserializeUser(function (id, done) {
    User.findById(id, function (err, user) {
        done(err, user);
    });
});

passport.use(new GoogleStrategy({
    clientID: process.env.CLIENT_ID,
    clientSecret: process.env.CLIENT_SECRET,
    callbackURL: "http://localhost:3000/auth/google/secrets",
    userProfileURL: 'https://www.googleapis.com/oauth2/v3/userinfo',

},
    function (accessToken, refreshToken, profile, cb) {
        console.log(profile);
        User.findOrCreate({ googleId: profile.id }, function (err, user) {
            return cb(err, user);
        });
    }
));

app.get("/", function (req, res) {
    res.render("home")
})
app.get("/login", function (req, res) {
    res.render("login")
})
app.get("/register", function (req, res) {
    res.render("register")
})
app.get("/secrets", function (req, res) {
    User.find({ "secret": { $ne: null } }, function (err, foundUsers) {
        if (err)
            console.log(err);
        else {
            if (foundUsers) {
                res.render("secrets", { usersWithSecrets: foundUsers })
            }
        }
    })
})
app.get("/logout", function (req, res) {
    req.logOut()
    res.redirect("/")
})

app.get("/auth/google", passport.authenticate('google', {

    scope: ['profile']

}));

app.get('/auth/google/secrets',
    passport.authenticate('google', { failureRedirect: '/login' }),
    function (req, res) {
        // Successful authentication, redirect home.
        res.redirect('/secrets');
    });

app.get("/submit", function (req, res) {
    if (req.isAuthenticated()) {
        res.render("submit")
    }
    else {
        res.redirect("/login")
    }
})

app.post("/submit", function (req, res) {
    const submittedSecret = req.body.secret

    User.findById(req.user.id, function (err, foundUser) {
        if (err)
            console.log(err);
        else {
            if (foundUser) {
                foundUser.secret = submittedSecret
                foundUser.save(function () {
                    res.redirect("/secrets")
                })
            }
        }
    })
})

app.post("/register", function (req, res) {
    User.register({ username: req.body.username }, req.body.password, function (err, user) {
        if (err) {
            console.log(err);
            res.redirect("/register")
        }
        else {
            passport.authenticate("local")(req, res, function () {
                res.redirect("/secrets")
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

        } else {
            passport.authenticate("local")(req, res, function () {
                res.redirect("/secrets")
            })
        }
    })

})

app.listen(3000, function () {
    console.log("started on 3000");
})