using System.Collections.Generic;

namespace D3FAU4TBOT_Hub
{
    public class LevelStructure
    {
        public string Level { get; set; }
        public string Language { get; set; }
        public string lang { get; set; }
        public string fakeLetters { get; set; }
        public string hiddenLetters { get; set; }
        public bool reveal { get; set; }
        public string level { get; set; }
        public Timebar timebar { get; set; }
        public List<Column> column1 { get; set; }
        public List<Column> column2 { get; set; }
        public List<Column> column3 { get; set; }
    }

    public class Column
    {
        public string word { get; set; }
        public string username { get; set; }
        public bool locked { get; set; }
        public int index { get; set; }
    }

    public class Timebar
    {
        public int timerPercentage { get; set; }
        public Locks locks { get; set; }
    }

    public class Locks
    {
        public int total { get; set; }
        public int expired { get; set; }
    }
}