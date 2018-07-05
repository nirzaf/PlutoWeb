using PlutoWeb.Core.Domain;
using PlutoWeb.Persistence;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PlutoWeb.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PlutoWeb.Persistence.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlutoContext context)
        {
            #region Add Tags
            var tags = new Dictionary<string, Tag>
            {
                {"c#", new Tag {Id = 1, Name = "c#"}},
                {"angularjs", new Tag {Id = 2, Name = "angularjs"}},
                {"javascript", new Tag {Id = 3, Name = "javascript"}},
                {"nodejs", new Tag {Id = 4, Name = "nodejs"}},
                {"oop", new Tag {Id = 5, Name = "oop"}},
                {"linq", new Tag {Id = 6, Name = "linq"}},
            };

            foreach (var tag in tags.Values)
                context.Tags.AddOrUpdate(t => t.Id, tag);
            #endregion

            #region Add Authors
            var authors = new List<Author>
            {
                new Author
                {
                    Id = 1,
                    Name = "Mosh Hamedani"
                },
                new Author
                {
                    Id = 2,
                    Name = "Anthony Alicea"
                },
                new Author
                {
                    Id = 3,
                    Name = "Eric Wise"
                },
                new Author
                {
                    Id = 4,
                    Name = "Tom Owsiak"
                },
                new Author
                {
                    Id = 5,
                    Name = "John Smith"
                }
            };

            foreach (var author in authors)
                context.Authors.AddOrUpdate(a => a.Id, author);
            #endregion

            #region Add Courses
            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "C# Basics",
                    AuthorId = 1,
                    FullPrice = 49,
                    Description = "Description for C# Basics",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    Id = 2,
                    Name = "C# Intermediate",
                    AuthorId = 1,
                    FullPrice = 49,
                    Description = "Description for C# Intermediate",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"],
                        tags["oop"]
                    }
                },
                new Course
                {
                    Id = 3,
                    Name = "C# Advanced",
                    AuthorId = 1,
                    FullPrice = 69,
                    Description = "Description for C# Advanced",
                    Level = 3,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    Id = 4,
                    Name = "Javascript: Understanding the Weird Parts",
                    AuthorId = 2,
                    FullPrice = 149,
                    Description = "Description for Javascript",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["javascript"]
                    }
                },
                new Course
                {
                    Id = 5,
                    Name = "Learn and Understand AngularJS",
                    AuthorId = 2,
                    FullPrice = 99,
                    Description = "Description for AngularJS",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["angularjs"]
                    }
                },
                new Course
                {
                    Id = 6,
                    Name = "Learn and Understand NodeJS",
                    AuthorId = 2,
                    FullPrice = 149,
                    Description = "Description for NodeJS",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["nodejs"]
                    }
                },
                new Course
                {
                    Id = 7,
                    Name = "Programming for Complete Beginners",
                    AuthorId = 3,
                    FullPrice = 45,
                    Description = "Description for Programming for Beginners",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    Id = 8,
                    Name = "A 16 Hour C# Course with Visual Studio 2013",
                    AuthorId = 4,
                    FullPrice = 150,
                    Description = "Description 16 Hour Course",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    Id = 9,
                    Name = "Learn JavaScript Through Visual Studio 2013",
                    AuthorId = 4,
                    FullPrice = 20,
                    Description = "Description Learn Javascript",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["javascript"]
                    }
                }
            };

            foreach (var course in courses)
                context.Courses.AddOrUpdate(c => c.Id, course);
            #endregion
        }
    }
}
