namespace Automata_NET
{
    internal class Program
    {
        static void Main()
        {
            Automata automata = new Automata(4);
            int alphabetSize = automata.AlphabetSize;
            int statesSize = automata.StatesSize;
            automata.AddAlphabet(5);
        }
    }
}
