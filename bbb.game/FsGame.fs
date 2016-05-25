namespace BBB

open System
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics


[<AbstractClass>]
type FsGame(contentRoot, configureGfx) as this = 
  inherit Game()

  let random = new Random()
  let gfx = new GraphicsDeviceManager(this)
  let mutable spritebatch = Unchecked.defaultof<_>

  do
    this.Content.RootDirectory <- contentRoot
    configureGfx gfx
  
  member this.Graphics = gfx
  
  member this.Random = random

  override this.Initialize() = ()

  override this.LoadContent() = ()

  override this.Update(time) = ()

  override this.Draw(time) = ()