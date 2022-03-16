namespace FlourPower

module Recipes =
    type BakersMath = { 
        flourType: string
        hydration: float
        salt: float
    }
    let hello name =
        printfn "Hello %s" name

    let recipe = {
        flourType = "hey"
        hydration = 60.0
        salt = 2.0
    }

    let flour = recipe.flourType
    hello "me"