module BCL_wrappers

let replace (str:string) (old:string) (_new:string) = str.Replace(old, _new)

let betterForPartApplicationReplace o n s = replace s o n
let betterForPart1 (old:string) (new_:string) (str:string) = str.Replace(old, new_)