# LeetMeUp
Leet speak translator

base on 1337 alphabet from https://fr.wikipedia.org/wiki/Leet_speak

base on faux cyrillics from https://fr.wikipedia.org/wiki/Faux_cyrillique

Target : .Net Standard 2.0

LeetMeUp
LeetMeUp.Benchmark
LeetMeUp.Sample

```csharp
string sentence = "The quick brown fox jumps over the lazy dog";

Leet leetMe = new Leet();
leetMe.Translate(sentence, LeetLevel.Noob)
//

leetMe.Translate(sentence, LeetLevel.Leet)
//

leetMe.Translate(sentence, LeetLevel.Roxxor)
//

FauxCyrillic fauxCyrillic = new FauxCyrillic();
fauxCyrillic.Translate(sentence)
//
```


TODO :
- option for removing diacritics
