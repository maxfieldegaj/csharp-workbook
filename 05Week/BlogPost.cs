using System;

public class Program
{
	public static void Main()
    {
        BlogPost myBlog = new BlogPost("I am learning C#");
        myBlog.Description = "This is the content of the blog";
        myBlog.Created = DateTime.Now;

        // voting
        myBlog.IncrementDownvote();
        myBlog.IncrementUpvote();
        myBlog.IncrementUpvote();

        Console.WriteLine(myBlog.Title);
        Console.WriteLine(myBlog.Description);
        Console.WriteLine(myBlog.CreatedOn);

        Console.WriteLine(myBlog.Upvote);
        Console.WriteLine(myBlog.Downvote);



        Console.ReadLine();
    }
}

public class BlogPost
{
    //Field
    public string Title;
    public string Description;
    public DateTime Created;

    // Non public field
    // avoid having them set to zero
    private int _upvote;
    private int _downvote;

    // Constructor   // BlogPost myBlog = new BlogPost();
    public BlogPost()
    {
        _downvote = 0;
        _upvote = 0;
    }

    //Constructor OVerload
    public BlogPost(string title)
    {
        Title = title;
    }

    // Properties
    public string Upvote {
        get {
            return _upvote + " Upvotes";
        }
    }
    public string Downvote {
        get {
            return _downvote + " Downvotes";
        }

    }

    public string CreatedOn {
        get
        {
            return "Created On " + string.Format("{0:MM/dd/yy}", Created);
        }
    }
    // Methods
    public void IncrementUpvote()
    {
        _upvote++;
    }

    public void IncrementDownvote()
    {
        _downvote++;
    }
}
