// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
 
open System 
open System.IO

let doesExist path = 
    match File.Exists(path) with
    | true -> printfn "Valid file path "
    | false -> printfn "Please Insert a Valid File Path "

let rec reverse file =
    match file with 
    |x::xs -> reverse xs ; printfn "%s" x 
    |_ -> printf ""

let readfile path = 
    let openfile = File.OpenRead(path)
    let file = (Array.toList (File.ReadAllLines (path)))
    reverse file 


[<EntryPoint>]
    let main args = 
        doesExist args.[0]
        Array.iter readfile args
        printfn "\n"
        0 // return an integer exit code

