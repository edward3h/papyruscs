﻿using System;
using System.Collections.Generic;
using Maploader.World;

namespace PapyrusCs.Strategies
{
    public class ImageInfo<TImage> where TImage : class
    {
        public TImage Image { get; set; }
        public int X { get; set; }
        public int Z { get; set; }
        public IEnumerable<SubChunkData> Cd { get; set; }

        public void Dispose()
        {
            if (Image is IDisposable disp)
            {
                disp.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}