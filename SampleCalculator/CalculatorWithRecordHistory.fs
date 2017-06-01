namespace SampleCalculator

    module RMaths =
        type Result = {Answer:double; History:ResizeArray<string>}

        let Add (aNumber:double) (state:Result) : Result =
            let anAddition = state.Answer + aNumber
            let newHistory = ResizeArray(state.History.AsReadOnly())
            newHistory.Add(sprintf "Added %f to %f" state.Answer aNumber)
            {Answer=anAddition; History = newHistory}

        let Subtract (aNumber:double) (state:Result) : Result =
            let aSubtraction = state.Answer - aNumber
            let newHistory = ResizeArray(state.History.AsReadOnly())
            newHistory.Add(sprintf "Subtracted %f from %f" state.Answer aNumber)
            {Answer=aSubtraction; History = newHistory}
        
        let Multiple (aNumber:double) (state:Result) : Result =
            let aMultiplication = state.Answer * aNumber
            let newHistory = ResizeArray(state.History.AsReadOnly())
            newHistory.Add(sprintf "Multiplied %f with %f" state.Answer aNumber)
            {Answer=aMultiplication; History = newHistory}

        let Division (aNumber:double) (state:Result) : Result =
            let aDivision = state.Answer / aNumber
            let newHistory = ResizeArray(state.History.AsReadOnly())
            newHistory.Add(sprintf "Divided %f by %f" state.Answer aNumber)
            {Answer=aDivision; History = newHistory}

        let Double = Multiple 2.0

        let Halve = Division 2.0