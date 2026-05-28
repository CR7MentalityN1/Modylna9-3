using ModuleWork3.Models;

namespace ModuleWork3.Logic;

public static class BookUtils
{
    public static void DescribeBook(Book book)
    {
        if (book == null)
    {
            Console.WriteLine("Книга задана некорректно");
            return;
    }
        if (book is Textbook t) 
            Console.WriteLine($"Предмет: {t.Subject}");
        else if (book is PoetryBook p) 
            Console.WriteLine($"Автор: {(p.IsDomesticAuthor ? "Отечественный" : "Зарубежный")}");
        else 
            Console.WriteLine("Стандартное описание книги");
    }
}