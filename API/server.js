import express from 'express'

const app = express()

//plants CRUD
 
//osszes noveny lekerese
app.get('/api/plants', (req, res) => {
  res.send('Hello World')
})

//egy noveny lekerese id alapjan
app.get('/api/plants/:id', (req, res) => {
    res.send('Hello World')
})

//noveny hozzaadasa
app.post('/api/plants', (req, res) => {
    res.send('Hello World')
})

//noveny modositasa id alapjan
app.patch('/api/plants/:id', (req, res) => {
    res.send('Hello World')
})

//novenyek torlese
app.delete('/api/plants/:id', (req, res) => {
    res.send('Hello World')
})


//novenyek statisztikai
app.get('/api/plants/stats', (req, res) => {
    res.send('Hello World')
})


//ontozesi naplo

//egy noveny ontozese id alapjan
app.get('/api/plants/:id/waterings', (req, res) => {
    res.send('Hello World')
})

//uj ontozes felvetele
app.post('/api/waterings', (req, res) => {
    res.send('Hello World')
})

//ontozes torlese
app.delete('/api/waterings/:id', (req, res) => {
    res.send('Hello World')
})


app.listen(3000)