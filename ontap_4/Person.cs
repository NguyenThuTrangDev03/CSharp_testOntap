namespace ontap_4
{
    internal class Person
    {
        private string ten;
        private string sdt;

        public Person()
        {

        }

        public Person(string ten, string sdt)
        {
            this.ten = ten;
            this.sdt = sdt;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public virtual void inRaManHinh()
        {

        }
    }
}
