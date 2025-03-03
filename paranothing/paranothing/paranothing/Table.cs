﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace paranothing
{
    class Table //: Collideable, Audible, Updatable, Drawable
    {
        # region Attributes

        //Collidable
        private Rectangle tableBound;
        private bool tableSolid;
        //Audible
        private Cue tableCue;
        //Drawable
        private Texture2D tableTexture;

        # endregion

        # region Constructor

        public Table(Texture2D inTexture, Rectangle inRect, bool inSolid)
        {
            tableTexture = inTexture;
            tableBound = inRect;
            tableSolid = inSolid;
        }

        # endregion

        # region Methods

        //Collideable
        public Rectangle getBound()
        {
            return tableBound;
        }
        public bool isSolid()
        {
           return tableSolid;
        }

        //Audible
        public Cue getCue()
        {
            return tableCue;
        }
        public void setCue(Cue cue)
        {
            tableCue = cue;
        }
        public void Play()
        {

        }

        //Drawable
        public Texture2D getImage()
        {
            return tableTexture;
        }
        public void draw(SpriteBatch reneder, Color tint)
        {

        }

        //Updatable
        public void update(GameTime time, GameController control)
        {

        }

        # endregion
    }
}
