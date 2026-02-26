let append list1 = 
    let list1 = ["List.map"; "List.filter"; "List.fold"; "List.iter"; "List.length"; "List.append"; "List.sort"; "List.head"; "List.tail"; "List.contains"; "List.zip"]
    list1  

[<EntryPoint>]
let main args = 
    printfn "Список из названия функций модуля List : %A" (append 0) 
    0