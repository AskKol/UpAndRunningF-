// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "ALibrary.fs"
open LearningAboutNamespacesAndModules

// note that you can use open with module

let aPerson = {Name="Kola";Age=31;Gender="Male"}

WorkerForPerson.PrintInformation aPerson
WorkerForPerson.PrintAPersonNicely.PrintInfo aPerson

// Define your library scripting code here

