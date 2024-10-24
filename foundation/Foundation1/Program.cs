using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new("How to make bread","Gordon Ramsay",300);
        Video video2 = new("Beating the Ender Dragon","DanTDM",430);
        Video video3 = new("Polymorphism in C#", "Scott Burton", 1064);

        video1.AddComment("Blake","Love this recipe!");
        video1.AddComment("Jessica","Turned out great, thanks!");
        video1.AddComment("Brandon","My dough isn't rising the way it does in the video. What am I doing wrong?");
        video1.AddComment("Sky","Great recipe, ill be using this in the future for sure!");

        video2.AddComment("minecraftlover22", "Nice win, epic video!");
        video2.AddComment("Sam", "You can use snowballs to beat the bosss easier");
        video2.AddComment("enderPig16","Show us how to beat the wither skeleton!");

        video3.AddComment("Blake","Great video, really helped me understand polymorphism");
        video3.AddComment("Jared","What is the point of having a method that is unused in the parent class if it's going to be overriden anyways?");
        video3.AddComment("Joe", "What does it mean to initialize member variables as protected?");

        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();

    }
}