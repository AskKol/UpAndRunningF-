namespace SampleCalculator

    module Maths =
        module Add =
            let Add (number:int) (lastResult:int, history:string ) : int * string =
                let result = lastResult + number
                result, history + (sprintf "Added %d and %d. " lastResult number)

        module Subtract =
            let Subtract (number:int)  (lastResult:int, history:string ) : int * string =
                let result = lastResult-number
                result, history + (sprintf "Subtracted %d from %d. "  number lastResult)

        module Multiple = 
            let Multiple (number:int) (lastResult:int, history:string) : int * string =
                let result = lastResult * number
                result, history + (sprintf "Multiplied %d with %d. "   lastResult number)

        module Divide = 
            let Divide (number:int) (lastResult:int, history:string) : int * string =
                let result =lastResult/ number
                result, history + (sprintf "Divided %d by %d. "lastResult number)

        module Double =
            /// Doubles a number.
            let double = Multiple.Multiple 2

        module Half =
            /// Halves a number.
            let halve = Divide.Divide 2