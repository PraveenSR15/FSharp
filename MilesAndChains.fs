module MilesAndChains

open System

type MilesChains = private MilesChains of wholeMiles : int * chains : int

let fromMilesPointChains(milesPointChains : float) : MilesChains = 
    let wholeMile = milesPointChains |> floor |> int
    if wholeMile < 0 then
        raise <| ArgumentOutOfRangeException("Distance should not be negative")
    let fraction =  milesPointChains - float(wholeMile)
    if fraction > 0.79 then
        raise <| ArgumentOutOfRangeException("Fractional part should be <+ 79")
    let chains = fraction*100. |> round |> int
    MilesChains(wholeMile,chains)

let private (~~) = float
let toDecimalMileChains (MilesChains(miles,chains)) = ~~miles + (~~chains / 80.)
