using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        //Video 1 
        //title, author and length in seconds
        Video video1 = new Video("Rags to riches: JDM edition", "Josh Fonoi", 1043);

        // comment section
        Comment video1Comment1 = new Comment("Edgar", "That is such a cool car! I hope I can get one someday.");
        Comment video1Comment2 = new Comment("Delbert", "I love the car kep up the good work.");
        Comment video1Comment3 = new Comment("Aaron", "fifty percent of something is better then a hundred percent of nothing");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videoList.Add(video1);





        //Video 2
        //title, author and length in seconds
        Video video2 = new Video("We got another project car", "Scott Moana", 964);



        //comment section
        Comment video2Comment1 = new Comment("Josh", "Excited to see a new project!");
        Comment video2Comment2 = new Comment("Jason", "interesting choice for a new project, but it likes like a fun one.");
        Comment video2Comment3 = new Comment("Uncle Del", "Glad to see you already started working on my old car.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videoList.Add(video2);






        //video 3 
        //title, author and lenght  in seconds

        Video video3 = new Video("Crossing the US in questionable cars", "Aaron Martin", 987);


        //comment section
        Comment video3Comment1 = new Comment("Ryan", "Glad to see you guys made it through the desert alive.");
        Comment video3Comment2 = new Comment("Janet", "Good thing you got the ac fixed before it got too hot.");
        Comment video3Comment3 = new Comment("Austin", "That looks like a fun trip, maybe i'll have to do it one day.");
        Comment video3Comment4 = new Comment("Scott", "I hope it was as fun as it looked.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);
        video3.ListComment(video3Comment4);
        videoList.Add(video3);



        foreach (Video video in videoList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            

        }
    }
}