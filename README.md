# .NET 6 SDK Advanced Exploration: Attributes
This is the repository for the LinkedIn Learning course .NET 6 SDK Advanced Exploration: Attributes. The full course is available from [LinkedIn Learning][lil-course-url].

![.NET 6 SDK Advanced Exploration: Attributes][lil-thumbnail-url] 

Attributes add metadata to your programs and allow you to annotate given types, assemblies, modules, and methods. They’re especially handy if you’re an advanced .NET developer, as they lend your code base more declarative power with the additional services of .NET tools and code libraries. In this course, senior LinkedIn Learning instructor Walt Ritscher shows you how to use predefined, standard .NET attributes as well as how to create custom attributes on your own.

Learn about the features of attributes, how they function, and why they’re such a vital part of .NET programs. Get quick tips and user tricks on annotating your code like a seasoned pro, from testing for object quality to marking your testing methods. Along the way, Walt teaches you how to create custom attributes that meet the specific needs of your projects, such as attributes for the JSON serializer, PropertyGrid and the category attribute, the BindProperty attribute, and more.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"

## Installing
1. Clone this repository into your local machine using the terminal (Mac), CMD (Windows), or a GUI tool like SourceTree.

### Instructor

Walt Ritscher 
                            
Senior Staff Author

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/walt-ritscher).

[lil-course-url]: https://www.linkedin.com/learning/dot-net-6-sdk-advanced-exploration-attributes
[lil-thumbnail-url]: https://cdn.lynda.com/course/2462119/2462119-1652724554184-16x9.jpg
