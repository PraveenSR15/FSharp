open MilesAndYards
open MilesAndChains

let decimalMileYards = 1.0880 |> fromMilesPointYards |> toDecimalMileYards
printfn "%f" decimalMileYards

let decimalMileChains = 1.80 |> fromMilesPointChains |> toDecimalMileChains
printfn "%f" decimalMileChains

