﻿using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantumify.Manager;

internal class TextureProcessor : IProcessor
{
    public object Load<T>(string path)
    {
        return Raylib.LoadTexture(path);
    }

    public void Unload(object texture)
    {
        Raylib.UnloadTexture((Texture2D)texture);
    }
}
