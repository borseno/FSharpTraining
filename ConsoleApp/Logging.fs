module Logging

// create an adder that supports a pluggable logging function
let adderWithPluggableLogger logger x y = 
    logger "x" x
    logger "y" y
    let result = x + y
    logger "x+y"  result 
    result 

// create a logging function that writes to the console
let consoleLogger = 
    printfn "%s=%A"

//create an adder with the console logger partially applied
let addWithConsoleLogger = adderWithPluggableLogger consoleLogger 

let test () =
        addWithConsoleLogger  1 2 |> ignore 
        addWithConsoleLogger  42 99 |> ignore
        addWithConsoleLogger  3 8 |> ignore 
        addWithConsoleLogger  11 11 |> ignore