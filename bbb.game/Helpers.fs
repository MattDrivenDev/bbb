[<AutoOpen>]
module Helpers

open System
open Microsoft.Xna.Framework


/// Point on Circle - returns the position given the radius from the centre
/// of a circle and an angle. Can be used to move objects "around" another.
let poc (centre:Vector2) radius angle = 
  new Vector2(
    x = (centre.X + float32 (radius * (Math.Cos(angle)))),
    y = (centre.Y + float32 (radius * (Math.Sin(angle)))))