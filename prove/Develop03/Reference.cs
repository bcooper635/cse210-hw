using System.Runtime.CompilerServices;

public class Reference
{

private string _book;
private int _chapter;

private int _verse;

private int? _endVerse;
//chose to make this member variable nullable if single verse is required

public Reference(string book, int chapter, int verse)
{
   _book = book;
   _chapter = chapter;
   _verse = verse;
   _endVerse = null;
   //null endverse since it is not used
}
public Reference(string book, int chapter, int verse, int endVerse)
{
    _book = book;
   _chapter = chapter;
   _verse = verse;
   _endVerse = endVerse;
}

public string GetDisplayText()
{
    if (_endVerse.HasValue)
    {
    return ($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }
    return ($"{_book} {_chapter}: {_verse}");
}




}