open System

let rec proverkachetchicel number =
    if number < 10 
    then number % 2 = 0
    else
        let lastchiclo = number % 10
        if lastchiclo % 2 = 0 then
            proverkachetchicel (number / 10)
        else
            false

[<EntryPoint>]
let main args = 
    printfn "Введите число:"
    let number = abs(int(Console.ReadLine())) // Берем модуль для отрицательных чисел
    
    let result = proverkachetchicel number
    printfn "Число %d состоит только из четных чисел: %b" number result
    0