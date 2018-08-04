using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class BgPurple : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer layBack = GetLayer("Back");
            double x;
            for (int i = 0; i < 30; i++)
            {
                x = i * 22;
                var bg = layBack.CreateSprite(@"SB\2dx_8.png", OsbOrigin.CentreLeft);
                bg.Move(0, 5926, 6423, x + 640, 240, x, 240);
                bg.Fade(11064, 1);
                bg.Move(0, 10567, 11064, x, 240, x - 640, 240);
            }

            double y;
            for (int j = -1; j < 11; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    x = i * (170 - 170 / 5) - 85;
                    y = j * (58 - 29 / 2 - 1);
                    var pattern = layBack.CreateSprite(@"SB\2dx_5.png", OsbOrigin.TopLeft);
                    pattern.Move(0, 5926, 6423, x + 640, y, x, y);
                    pattern.Fade(11064, 0.9);
                    pattern.Move(0, 10567, 11064, x, y, x - 640, y);
                }
            }
        }
    }
}
