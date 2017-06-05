type Quadrilaterals =
     |Square of length: double
     |Rectangle of length:double * Breath:double
     |Rhombus of Diagonal1:double * Diagonal2:double
     |Trapezoid of Base1:double * Base2:double * Height:double

type Shapes = 
    | Circle of Radius:float
    | Quadrilateral of Quadrilaterals
    | Triangle of Base:double * Height:double
    

let CalculateAreaOfShape aShape =
    match aShape with
    | Circle radius -> 3.14 * radius * radius 
    | Triangle(abase,height) -> (abase/2.0)* height
    | Quadrilateral aquad ->
        match aquad with
        | Square(length) -> length * length
        |Rectangle(length, breath) -> length * breath
        |Rhombus(diagonal1,diagonal2) -> (diagonal1 * diagonal2)/2.0
        |Trapezoid(base1,base2,height) -> ((base1+base2)/2.0)* height




let aShape = Triangle(8.0,9.0)
let aResult = CalculateAreaOfShape aShape