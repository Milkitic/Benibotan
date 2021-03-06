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
    public class BGPurpleStatic : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 125;
        [Configurable]
        public int endTime = 5097;
        public override void Generate()
        {
            StoryboardLayer lay_back = GetLayer("Back");
            double x = 320, y = 240;
            for (int i = 0; i < 30; i++)
            {
                x = i * 22;
                var BG = lay_back.CreateSprite(@"SB\2dx_8.png", OsbOrigin.CentreLeft);
                BG.Move(0, startTime, endTime, x, y, x, y);
                BG.Fade(startTime, 1);
            }

            for (int j = -1; j < 11; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    x = i * (170 - 170 / 5) - 85;
                    y = j * (58 - 29 / 2 - 1);
                    var Pattern = lay_back.CreateSprite(@"SB\2dx_5.png", OsbOrigin.TopLeft);
                    Pattern.Move(0, startTime, endTime, x, y, x, y);
                    Pattern.Fade(startTime, 0.9);
                }
            }

            var left = lay_back.CreateSprite(@"SB\2dx_62.png");
            left.Move(startTime, 600, 295);
            left.Scale(startTime, endTime, 1, 1);

            var right = lay_back.CreateSprite(@"SB\2dx_77.png");
            right.Move(startTime, 75, 270);
            right.FlipH(startTime, endTime);
            right.Scale(startTime, 1);
        }
    }
}
