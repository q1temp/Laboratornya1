open System
open System.Reflection

let printListMethods () =
    let t = typeof<int list>.Assembly.GetType("Microsoft.FSharp.Collections.ListModule")
     
    if t = null then
            printfn "Модуль List не найден"
        else
            [
                for m in t.GetMethods() do
                    yield m.Name
            ]
            |> List.distinct
            |> List.sort
            |> List.iter (printfn "%s")

[<EntryPoint>]
let main argv = 
    printListMethods()
    0

