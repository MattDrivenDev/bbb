namespace BBB

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input


type bbb() as this = 
  inherit FsGame(
    "Content", 
    fun gfx ->
        gfx.PreferredBackBufferWidth <- 520
        gfx.PreferredBackBufferHeight <- 520
        gfx.GraphicsProfile <- GraphicsProfile.HiDef
        gfx.IsFullScreen <- false)