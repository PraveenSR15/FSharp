module MilesAndYards

open System

type MilesYards = private MilesYards of wholeMiles : int * yards : int

let fromMilesPointYards(milesPointyards : float) : MilesYards =
    let wholeMile = milesPointyards |> floor |> int
    if wholeMile < 0 then 
        raise <| ArgumentException("Distance should be positive")
    let fraction = milesPointyards - float(wholeMile)
    if fraction > 0.1759 then
        raise <| ArgumentOutOfRangeException("Fractional part must be <= 1759")
    let yards = fraction*10000. |> round |> int
    MilesYards(wholeMile,yards)
let private (~~) = float
let toDecimalMileYards (MilesYards(miles,yards)) : float =  ~~miles + (~~yards/1760.)
