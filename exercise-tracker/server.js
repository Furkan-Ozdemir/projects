const express = require('express')
const app = express()

require('dotenv').config()
const mongoose = require("mongoose")
const bodyParser = require("body-parser")
// Date yapılmadı null geliyor default çalışmıyor

app.use(express.static(__dirname + '/public'))
app.use(bodyParser.urlencoded({ extended: true }))

mongoose.connect(process.env.MONGO_URI, { useNewUrlParser: true, useUnifiedTopology: true });

mongoose.set("useCreateIndex", true)

const exerciseSchema = new mongoose.Schema({
    userId: String,
    description: String,
    duration: Number,
    date: { type: Date, default: Date.now }
})
const userSchema = new mongoose.Schema({
    username: String
})

const Exercise = new mongoose.model("Exercise", exerciseSchema)
const User = new mongoose.model("User", userSchema)

app.get('/', (req, res) => {
    res.sendFile(__dirname + '/views/index.html')
});

app.get("/api/exercise/users", function (req, res) {
    const foundUsers = []
    User.find({}, function (err, users) {
        if (err) console.log(err);
        else {
            for (let i = 0; i < users.length; i++) {
                foundUsers.push({ username: users[i].username, _id: users[i]._id })
            }

            res.json(foundUsers)
        }
    })

})
app.get("/api/exercise/log", function (req, res) {
    const log = []
    let count = 0
    const limit = req.query.limit
    const userId = req.query.userId
    const from = req.query.from
    const to = req.query.to
    const array = []

    Exercise.find({ userId: userId }, function (err, found) {

        if (err) console.log(err);
        else {
            for (let i = 0; i < found.length; i++) {
                log.push({ description: found[i].description, duration: found[i].duration, date: found[i].date.toDateString() })
                count++
            }
            User.findOne({ _id: userId }, function (error, user) {
                if (error) console.log(error)
                else {
                    if (from && to) {
                        if (!limit) {
                            log.forEach((exercise) => {
                                if (Number(new Date(exercise.date)) >= Number(new Date(from)) && Number(new Date(exercise.date)) <= Number(new Date(to))) {
                                    array.push(exercise)
                                }
                                else console.log(Number(new Date(exercise.date)))
                            })
                            res.json({ _id: userId, username: user.username, count: count, log: array })
                            console.log(array)
                        }
                        else {
                            for (let i = 0; i < limit; i++) {
                                if (Number(new Date(log[i].date)) >= Number(new Date(from)) && Number(new Date(log[i].date)) <= Number(new Date(to)))
                                    array.push(log[i])
                            }
                            res.json({ _id: userId, username: user.username, count: count, log: array })
                        }

                    }
                    else if (from) {
                        if (!limit) {
                            log.forEach((exercise) => {
                                if (Number(new Date(exercise.date)) >= Number(new Date(from)))
                                    array.push(exercise)
                            })
                            res.json({ _id: userId, username: user.username, count: count, log: array })
                        }
                        else {
                            for (let i = 0; i < limit; i++) {
                                if (Number(new Date(log[i].date)) >= Number(new Date(from)))
                                    array.push(log[i])
                            }
                            res.json({ _id: userId, username: user.username, count: count, log: array })
                        }
                    }
                    else if (to) {
                        if (!limit) {
                            log.forEach((exercise) => {
                                if (Number(new Date(exercise.date)) <= Number(new Date(to)))
                                    array.push(exercise)
                            })
                            res.json({ _id: userId, username: user.username, count: count, log: array })
                        }
                        else {
                            for (let i = 0; i < limit; i++) {
                                if (Number(new Date(log[i].date)) <= Number(new Date(to)))
                                    array.push(log[i])
                            }
                            res.json({ _id: userId, username: user.username, count: count, log: array })
                        }
                    }
                    else {
                        if (!limit) {
                            res.json({ _id: userId, username: user.username, count: count, log: log })

                        }
                        else {
                            for (let i = 0; i < limit; i++) {

                                array.push(log[i])
                            }
                            res.json({ _id: userId, username: user.username, count: count, log: array })

                        }

                    }
                }
            })
        }
    })

})
app.post("/api/exercise/new-user", function (req, res) {
    const username = req.body.username
    User.findOne({ username: username }, function (err, foundUser) {
        if (err) console.log(err);
        else if (foundUser) {
            res.send("username already taken")
        }
        else {
            const user = new User({
                username: username
            })
            user.save(function (err2, savedUser) {
                if (err2)
                    console.log(err2)
                else {
                    console.log(savedUser + "user saved");
                    User.findOne({ username: savedUser.username }, function (error, foundUser) {
                        if (error) console.log(error)
                        else {
                            res.json({ _id: foundUser._id, username: foundUser.username })
                        }
                    })
                }

            })
        }

    })




})
app.post("/api/exercise/add", function (req, res) {
    const userId = req.body.userId
    const description = req.body.description
    const duration = req.body.duration
    const date = req.body.date
    if (!userId || !description || !duration) {
        res.send("fill the required fields")
    }
    else {
        User.findOne({ _id: userId }, function (err, foundUser) {
            if (err) res.send(err)
            else {
                if (!date) {
                    const exercise = new Exercise({
                        userId: userId,
                        description: description,
                        duration: duration,

                    })
                    exercise.save(function (error, savedExercise) {
                        if (error) console.log(error);
                        else {
                            res.json({ _id: foundUser._id, username: foundUser.username, date: savedExercise.date.toDateString(), duration: savedExercise.duration, description: savedExercise.description })
                        }
                    })
                }
                else {
                    const exercise = new Exercise({
                        userId: userId,
                        description: description,
                        duration: duration,
                        date: date
                    })
                    exercise.save(function (error, savedExercise) {
                        if (error) console.log(error);
                        else {

                            res.json({ _id: foundUser._id, username: foundUser.username, date: savedExercise.date.toDateString(), duration: savedExercise.duration, description: savedExercise.description })
                        }
                    })
                }


            }
        })
    }

})





const listener = app.listen(process.env.PORT || 3000, () => {
    console.log('Your app is listening on port ' + listener.address().port)
})
