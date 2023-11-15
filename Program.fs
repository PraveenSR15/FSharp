// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let myDouble = 3.
let myArray = [|1.0;2;1|]
let myList = [1.0;2;1]
printfn "%A" myList

let newList = myList @ [1..5]
printfn "%A" newList

let Square x = x*x
printfn "%i" (Square 2)
let append (x, y) : string = x+y
printfn "%s" (append("yes ","sir"))

let add x y  = x + y
let res1 = add "a" "b"