using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus
{
    internal class LabSim
    {
        List<string> Adatsorok = new List<string>();
        Lab = char[,];

        public bool KeresKesz { get; set};
        public int KijaratOszlopIndex { get; };
        public int KijaratSorIndex { get; };
        public bool NincsMegoldas { get; set };
        public int OszlopokSzama { get; };
        public int SorokSzama { get; };


    }
   private void BeolvasAdatsorok(string forras)
{

}
    private void FeltoltLab()
{

}

    public void KiirLab() 
{

}
    public LabSim(string forras) 
{

}
    public void Utkereses() 
{
    KeresesKesz = false;
    NincsMegoldas = false;
    byte r = 1, c = 0;

    while (!KeresesKesz && !NincsMegoldas)
    {
        Lab[r, c] = 'O';
            if (Lab[r, c + 1] = '')
            {
                c++;
            }
            else if (Lab[r + 1, c] = '')
            {
                r++;
            }
            else Lab[r, c] = '-';

            if (Lab[r, c - 1] = 'O')
            {
                c--;
            }
            else r--;

            KeresesKesz { r=KijaratSorIndex & c= KijaratOszlopIndex}
            if (KeresesKesz)
            {
                Lab[r, c] = 'O';
            }
                NincsMegoldas { r=1 & c=0};
    }
}

}
