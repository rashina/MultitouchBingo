﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Surface.Core;
using Microsoft.Xna.Framework.Input;

namespace ECE_700_BoardGame.Screens
{
    public interface Screen
    {
        void Draw(GameTime gameTime);
        void LoadContent(ContentManager content);
        void Update(GameTime gameTime, ReadOnlyTouchPointCollection touch);
        void Update(GameTime gameTime, MouseState Mouse_State);
    }
}
