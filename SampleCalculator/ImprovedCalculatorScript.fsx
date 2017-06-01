#load "CalculatorWithTupleHistory.fs"

open SampleCalculator.Maths
open SampleCalculator.Maths.Add
open SampleCalculator.Maths.Subtract
open SampleCalculator.Maths.Multiple
open SampleCalculator.Maths.Divide
open SampleCalculator.Maths.Double
open SampleCalculator.Maths.Half

let addFiveAndDouble = Add 5 >> double

let simplePipeline = (0, "") |> Add 5 |> Multiple 3 |> Subtract 5 |> Divide 2 |> addFiveAndDouble