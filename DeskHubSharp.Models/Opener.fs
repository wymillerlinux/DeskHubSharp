module Opener

open System.IO
open System.Diagnostics

let file =
    try 
        use file = File.OpenRead "config.xml"
        Some <| file.Read
    with
        :? FileNotFoundException as ex ->
        printfn "%s was not found. Does it exist?" ex.FileName
        None
        _ -> printfn "Error loading file..."
        reraise()
