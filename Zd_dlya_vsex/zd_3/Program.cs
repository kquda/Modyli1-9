﻿using System;

class Author
{
    public string Name { get; set; }
    public int BirthYear { get; set; }

    public Author(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
}

class Book
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public Author Author { get; set; }

    public Book(string title, int releaseYear, Author author)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Книга: {Title}, Год выпуска: {ReleaseYear}, Автор: {Author.Name}, Год рождения автора: {Author.BirthYear}");
    }
}

class Program
{
    static void Main()
    {
        Author author = new Author("Александр Пушкин", 1799);
        Book book = new Book("Евгений Онегин", 1833, author);

        book.DisplayInfo();
    }
}
