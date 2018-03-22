using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBoi
{
   public class Ship
    {
        Texture2D texture;
       Rectangle hitbox;

       public Ship()
        {
            
        }

       public void LoadContent( )
        {
             //texture = Content.Load<Texture2D>("shuttle");
        }
    }
}
