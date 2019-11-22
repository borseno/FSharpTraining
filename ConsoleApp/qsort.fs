module qsort

let rec qsort list = 
    match list with 
    | [] -> []
    | head :: [] -> [head]
    | head :: tail -> qsort [for x in tail do if x < head then yield x] @ head :: qsort [for x in tail do if x >= head then yield x]