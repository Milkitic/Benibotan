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
    public class Bamboo1 : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 6423;
        [Configurable]
        public int endTime = 11064;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var left = lay_fore.CreateSprite(@"SB\2dx_62.png");
            left.Rotate(startTime, 0.3);
            left.FlipH(startTime, startTime);
            left.Move(startTime, startTime + (6921 - 6423), 145, 330, 45, 330);
            left.Fade(startTime, startTime + (6921 - 6423), 0, 1);
            left.Scale(startTime, endTime, 0.75, 0.75);

            var right = lay_fore.CreateSprite(@"SB\2dx_77.png");
            right.Move(startTime, startTime + (6921 - 6423), 495, 330, 595, 330);
            right.Fade(startTime, startTime + (6921 - 6423), 0, 1);
            right.Scale(startTime, endTime, 0.75, 0.75);
        }
    }
}
