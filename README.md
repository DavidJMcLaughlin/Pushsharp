# Pushsharp
A small .NET wrapper for the [pushshift api](https://pushshift.io)

Built in C# against the .NET v4.6.1 framework

## Examples

**Search a subreddit for comments with specific text**
```C#
var pushshift = new PushshiftApi();
var commentsList = pushshift.Reddit.SearchComments(new CommentSearchQuery()
{
    Query = "text to search for",
    Subreddit = "pics"
});
```


**Search a subreddit for posts with a specific title**
```C#
var pushshift = new PushshiftApi();
var submissionsList = pushshift.Reddit.SearchSubmissions(new SubmissionSearchQuery()
{
    Query = "text to search for",
    Subreddit = "videos"
});
```
