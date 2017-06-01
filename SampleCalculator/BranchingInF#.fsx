type Employee = 
    {
        Name:string
        Department:string
        YearsOfExperience:int
    }

let tim = { Name="Tim";Department="IT";YearsOfExperience=4}

let GetEmployeeBonus (employee:Employee) = 
    match employee with
    | employee when employee.Department="IT" && employee.YearsOfExperience <= 3 -> 500
    | _ -> 100