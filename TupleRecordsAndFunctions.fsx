let CalculateNewHealth (weather:string, health:int) =
    if weather = "Sunny" || weather = "sunny" then health + 10
    elif weather = "Wet" || weather = "wet" then health / 2
    else health - 5

let weatherAndHealth = ("emmp",100)
let newHealth = CalculateNewHealth weatherAndHealth
let anotherNewhealth = CalculateNewHealth ("Sunny",90)

// Partially applied functions

let Bmi (weight:double) (height:double) :double =
    let intermidateAnswer = weight/height
    intermidateAnswer/height

1.7 |> Bmi 66.0

let BmiInWords (name:string) (bmi:double) =
    printfn "hi %s, your bmi is %A" name bmi


//>> called compose operator is used to pass the result of one function to another


let LetsTryLamdaInFSharp = fun x -> x + 10
//same thing as
let LetsTryLamdaInFSharpII x = x + 10