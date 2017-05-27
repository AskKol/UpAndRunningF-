open System

let time= DateTime.Now

let TimeOfDay = 
    if time.Hour < 12 then "Morning"
    elif time.Hour <18 then "Afternoon"
    else "Evening"
