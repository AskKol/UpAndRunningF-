namespace SampleCalculator

module Maths=

    module Add =
        /// Adds two numbers together.
        let add x y = y + x

    module Subtract =
        /// Subtracts one number from another.
        let subtract x y = y - x

    module Multiple =
        /// Multiplies two numbers together.
        let times x y = x * y
    module Divide =
        /// Divides one number by another. Only works for whole numbers!
        let divideBy (x:int) (y:int) = y / x

    module Double =
        /// Doubles a number.
        let double = Multiple.times 2

    module Half =
        /// Halves a number.
        let halve = Divide.divideBy 2