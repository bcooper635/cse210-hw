using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

public class Scripture
{

public Reference _reference;

public List<Word> _words = new List<Word>();

public Scripture(Reference Reference, string text)
{
    _reference = Reference;
    string [] splitVar = text.Split(" ");
    foreach (string index in splitVar)
    {
        _words.Add(new Word(index));
    }
    
}

public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    int amountHidden = 0;

    while(amountHidden<numberToHide)
    {
        //adjusting my while loop to account for the issue when there was one word left in the scripture, and my program never ended
        //check number of words not hidden, then if only one word left, find it's index and hide it
        int visibleWordCount = _words.Count(word => !word.IsHidden());
        if (visibleWordCount == 1)
        {
            Word lastVisibleWord = _words.First(word => !word.IsHidden());
            lastVisibleWord.Hide();
            break;
        }



        int index = random.Next(_words.Count);
        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            amountHidden++;
        }
    }

}
public string GetDisplayText()
{
   string displayText = _reference.GetDisplayText()+" ";
   foreach(Word word in _words )
   {
    displayText += word.GetDisplayText() + " ";
   }
   return displayText.Trim();
}

public bool IsCompletelyHidden()
{
   foreach (Word word in _words)
   {
    if (!word.IsHidden())
    {
        return false; 
    }
    }
    return true;
}



}