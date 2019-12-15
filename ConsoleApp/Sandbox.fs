module Sandbox

let eachMultFive = 5 |> (*) |> List.map

let eachPlusTwo = 2 |> (+) |> List.map

let filterOdd = (fun i -> i % 2 = 0) |> List.filter

let combined = eachMultFive >> filterOdd >> eachPlusTwo

let test (a:unit) =
    let result =
        [1..10] 
        |> combined
    printfn <| "result: %A" <| result // same as below
    printfn "result: %A" result // same as above

