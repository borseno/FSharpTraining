module ErrorPrinter

open System
open Helpers

let isBiggerThanM charact = charact > 'm' 

let rec sumOfBiggerThanMRec str sum = 
    match str with 
    | [] -> 0
    | head :: [] -> if isBiggerThanM head then sum + 1 else sum 
    | head :: tail -> if isBiggerThanM head then sumOfBiggerThanMRec tail (sum + 1) else sumOfBiggerThanMRec tail sum 
    
let sumOfBiggerThanM (str: string) = sumOfBiggerThanMRec (str |> Seq.toList) 0 
let printerError(str: string) = string (sumOfBiggerThanM str) + "/" + getlength str