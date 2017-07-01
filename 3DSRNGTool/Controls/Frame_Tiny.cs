﻿using System.Linq;
using Pk3DSRNGTool.RNG;

namespace Pk3DSRNGTool
{
    public class Frame_Tiny
    {
        public int Index { get; set; }
        public bool _sync;
        public byte _fs;
        public uint[] state;
        public uint rand;
        public int framemin;
        public int framemax;
        
        public TinyMT getTiny => new TinyMT(state);
        public bool unhitable => framemin == framemax;
        public bool rand2 => rand < 0x80000000;

        public string Status => string.Join(",", state.Select(v => v.ToString("X8")).Reverse());
        public char Sync => rand < 0x80000000 ? 'O' : 'X';
        public char PortalSync => _sync ? 'O' : 'X';
        public string FS => _fs > 0 ? _fs.ToString() : "X";
        public byte Rand100 => (byte)((rand * 100ul) >> 32);
        public ushort High16bit => (ushort)(rand >> 16);
        public string FrameRange => framemin == framemax ? "-" : (framemin + 2).ToString() + " ~ " + framemax.ToString();
        public byte Slot
        {
            get
            {
                if (rand < 0x1999999A)
                    return 1;
                if (rand < 0x33333334)
                    return 2;
                if (rand < 0x4CCCCCCD)
                    return 3;
                if (rand < 0x66666667)
                    return 4;
                if (rand < 0x80000000)
                    return 5;
                if (rand < 0x9999999A)
                    return 6;
                if (rand < 0xB3333333)
                    return 7;
                if (rand < 0xCCCCCCCD)
                    return 8;
                if (rand < 0xE6666666)
                    return 9;
                if (rand < 0xF3333333)
                    return 10;
                if (rand < 0xFD70A3D7)
                    return 11;
                return 12;
            }
        }
    }
}