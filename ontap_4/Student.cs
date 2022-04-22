using System;

namespace ontap_4
{
    internal class Student : Person
    {
        private string msv;
        private int nganh;

        public Student()
        {

        }

        public Student(string ten, string sdt, string msv, int nganh) : base(ten, sdt)
        {
            this.msv = msv;
            this.nganh = nganh;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public int Nganh
        {
            get => nganh;
            set => nganh = value;
        }

        public override void inRaManHinh()
        {
            //base.inRaManHinh();
            Console.WriteLine($"{Ten} | {Sdt} | {msv} | {Convert.ToString(nganh == 1 ? "UDPM" : nganh == 2 ? "WEB":"MOB")}");
        }
    }
}
