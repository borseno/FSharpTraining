module RGBtoHEX

let isOverflow a = a > 255 || a < 0

let fix a = if a > 255 then 255 else if a < 0 then 0 else a 

let correctHEX(s: string) = if String.length s = 1 then "0" + s else s 

let format (num: int32) = sprintf "%02X" num

let fixAndFormat = fix >> format

let rec rgb r g b = 
    fixAndFormat r + fixAndFormat g + fixAndFormat b
