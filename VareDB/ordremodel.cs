namespace VareDB
{
    public class ordremodel
    {
        public int id { get; set; }
        public int antal { get; set; }
        public int pris { get; set; }

        public ordremodel(int id, int antal, int pris)
        {
            this.id = id;
            this.antal = antal;
            this.pris = pris;
        }
        public ordremodel()
        {

        }
    }
}
