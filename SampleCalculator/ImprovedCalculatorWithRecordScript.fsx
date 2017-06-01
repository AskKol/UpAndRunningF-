#load "CalculatorWithRecordHistory.fs"
open SampleCalculator.RMaths

let addFiveAndDouble = Add 5.0 >> Double

let simplePipeline = { Answer = 0.0; History = ResizeArray() } |> Add 5.0 |> Multiple 3.0 |> Subtract 5.0 |> Division 2.0 |> addFiveAndDouble |> printf "%A"