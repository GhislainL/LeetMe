# LeetMe
LeetMe is a leet speak translator for .Net Applications. 
Dictionnaries are based on :
* 1337 alphabet from [Leet speak (wikipedia FR)](https://fr.wikipedia.org/wiki/Leet_speak)
* faux cyrillics from [Faux cyrillique (wikipedia FR)](https://fr.wikipedia.org/wiki/Faux_cyrillique)

Target : .Net Standard 2.0

* LeetMeUp : base class
* LeetMeUp.Benchmark : benchmark of differents structures with [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)
* LeetMeUp.Sample : sample code 

### Getting started

```csharp
string sentence = "The quick brown fox jumps over the lazy dog";

Leet leetMe = new Leet();
leetMe.Translate(sentence, LeetLevel.Noob)
// T#3 qu!(k 8r0w~ f0* jump5 0v3r 7#3 142y d09

leetMe.Translate(sentence, LeetLevel.Leet)
// T(-)ë °|u!(|< 8.-¤'//|\| ƒohecks </u|v||^(o)$ ()\/312 7[-][- 1^>_λ ?[]6
// T]-[ë q(_)eye<|< (32[](n)// f0}{ (/u/|\[]Dz oh\/£ʁ -|-[-]3 |@>_λ |>()C-

leetMe.Translate(sentence, LeetLevel.Roxxor)
// T]-[& <|(_)][[< P>2°\X/// ƒohecks _/L|(\/)¶z °o|o£® †/-/|=- 1_aye>_Ψ )()&
// T]~[[- 0_|_||¢|{ !312¤\_|_/]\[ |#()}{ ¿(_)/^^\?es oho|o|=-ʁ †]-[|=- 1_/-\=/=φ ?oh(_+

FauxCyrillic fauxCyrillic = new FauxCyrillic();
fauxCyrillic.Translate(sentence)
// ThЭ qЦick bЯФШИ fФx jЦmps ФvЭЯ thЭ ГДzЧ dФg
```

### TODO :

* option for removing diacritics
