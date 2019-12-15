// Learn more about F# at http://fsharp.org

open System
open RGBtoHEX
open ErrorPrinter
open qsort

let testRgb () = rgb 0 13 255 |> printf "%s"

let testErrorPrinter () = printerError "abckjfkldjhklsfxvcmanbleroiyqnnxmzmx" |> printf "%s" 

let strCtor (a:char[]) = new String(a)

let testQSort () = Seq.toList "bcz,xvb,xmcvnb,smdfwrwrsdksdadaslkdjsalkdjaslkdm,czcnzx,cmnzx,mcnzxm,czxcnzx,cnzm,xcnz,cmnoiiweorjweriowerweorhiewrh3454354353fjsdhfkjhkjhqweqwioiqwezx,mcna" |> qsort |> List.toArray |> strCtor |> printf "%s"

[<EntryPoint>]
let main argv =
    Pipes_Composition.test ()    
    0 // return an integer exit code
