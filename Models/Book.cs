namespace ModuleWork3.Models;

public class Book { }
public class Textbook : Book { public string Subject { get; set; } }
public class PoetryBook : Book { public bool IsDomesticAuthor { get; set; } }