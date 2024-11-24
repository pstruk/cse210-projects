using System;
using System.Collections.Generic;

public class ScriptureLibrary 
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _randomGen = new Random();

    public ScriptureLibrary()
    {
        InitializeLibrary();
    }

    private void InitializeLibrary()
    {
        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding; " +
            "In all thy ways acknowledge him, and he shall direct thy paths."));
        _scriptures.Add(new Scripture(new Reference("John", 3, 16, 17),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth " +
            "in him should not perish, but have everlasting life. For God sent not his Son into the world " +
            "to condemn the world; but that the world through him might be saved."));
        _scriptures.Add(new Scripture(new Reference("John", 20, 31),
            "But these are written, that ye might believe that Jesus is the Christ, the Son of God; and " +
            "that believing ye might have life through his name."));
        _scriptures.Add(new Scripture(new Reference("Mosiah", 18, 19),
            "And he commanded them that they should teach nothing save it were the things which he had taught, " +
            "and which had been spoken by the mouth of the holy prophets."));
        _scriptures.Add(new Scripture(new Reference("Moroni", 10, 5, 6),
            "And by the power of the Holy Ghost ye may know the truth of all things. And whatsoever thing is good " +
            "is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is."));  
        _scriptures.Add(new Scripture(new Reference("Doctrine & Covenants", 98, 11, 12),
            "And I give unto you a commandment, that ye shall forsake all evil and cleave unto all good, that ye " +
            "shall live by every word which proceedeth forth out of the mouth of God. For he will give unto the " +
            "faithful line upon line, precept upon precept; and I will try you and prove you herewith."));
        _scriptures.Add(new Scripture(new Reference("Moses", 1, 2),
            "And he saw God face to Face, and he talked with him, and the glory of God was upon Moses; therefore " +
            "Moses could endure his presence."));
    }

    public Scripture GetScripture()
    {
        int randomNumber = _randomGen.Next(0, _scriptures.Count);
        Scripture pickedScripture = _scriptures[randomNumber];
        return pickedScripture;
    }
}
