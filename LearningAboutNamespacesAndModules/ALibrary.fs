namespace LearningAboutNamespacesAndModules

type Person = 
    {Name: string
     Age:int
     Gender:string
    }

// another way to define records is
type Pet ={Type:string; Gender:string}

module WorkerForPerson =
    let PrintInformation (aPerson:Person) = printfn "%A" aPerson

    module PrintAPersonNicely =
        let PrintInfo (aPerson:Person) = printfn "Hi %s, you are %d and you are a %s " aPerson.Name aPerson.Age aPerson.Gender

module WorkerForPet =
    let PrintInformation (aPet:Pet) = printfn "%A" aPet

    module PrintAPetNicely =
        let PrintInfo (aPet:Pet) = printfn "Hi, you are a %s %s " aPet.Type aPet.Gender


 // note that modules allow you to store types/records and vaule in them