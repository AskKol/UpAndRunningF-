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


type ABmi = {Name:string;Weight:double;Height:double}

type ABmiStacked =
    {
        Name:string
        Age:int
        Weight:double
        Height:double
    }

let JamesBmi = {Name="James";Age=25; Weight=70.0; Height=1.8}
let CathysBmi =
    {
        Name="Cathy"
        Weight=69.0
        Height=1.67
    }

let CathysNewWeight={CathysBmi with Weight=60.0}