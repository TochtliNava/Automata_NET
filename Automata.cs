namespace Automata_NET
{
    public class Automata
    {
        public int StatesSize { get; set; }
        public int AlphabetSize { get; set; } = 0;
        private int[] _alphabet;
        public Automata(int states) 
        {
            StatesSize = states;
        }

        public void AddAlphabet(int sigma)
        {
            if (_alphabet == null)
            {
                _alphabet = new int[1];
                _alphabet[0] = sigma;
                AlphabetSize++;
                return;
            }
            int[] temp = _alphabet;
            _alphabet = new int[AlphabetSize + 1];

        }
    }
}
