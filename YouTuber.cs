using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcept
{
    //Encapsulation of access modifies of pubic methods other methods other than Create
    //Abtraction is internal methods not exposed
    public class YouTuber : Creator //Inheritance from abstract class
    {
        public override void Create()
        {
            if (CreativityLevel > 75 && base.Energy > 80)
            {
                this.BraingStormingVideoIdeas();
                this.CreateScripts();
                this.VideoTapeScript();
                this.EditingVideo();
                this.RenderingVideo();
            }
            else
            {
                throw new Exception("Cannot create a video out of ideas or energy");
            }
        }

        public void BraingStormingVideoIdeas()
        {
            base.CreativityLevel = base.Energy - 5;
            base.Energy = base.Energy - 5;
            Console.Write("Brainstorming video ideas....");
            Console.WriteLine();
        }

        public void CreateScripts()
        {
            base.CreativityLevel = base.Energy - 5;
            base.Energy = base.Energy - 5;
            Console.Write("Creating video scripts....");
            Console.WriteLine();
        }

        public void VideoTapeScript()
        {
            base.CreativityLevel = base.Energy - 1;
            base.Energy = base.Energy - 10;
            Console.Write("Video taping myself  executing the script....");
            Console.WriteLine();
        }

        public void EditingVideo()
        {
            base.CreativityLevel = base.Energy - 5;
            base.Energy = base.Energy - 5;
            Console.Write("Editing the video....");
            Console.WriteLine();
        }

        public void RenderingVideo()
        {
            base.CreativityLevel = base.Energy - 1;
            base.Energy = base.Energy - 1;
            Console.Write("Redering the video....");
            Console.WriteLine();
        }


    }
}
