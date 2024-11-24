using System;

namespace Matrix
{
    internal class Matrix
    {
        private double[,] elemek;

        public Matrix()
        {
            elemek = new double[3, 3];
        }

        public Matrix(int meret)
        {
            elemek = new double[meret, meret];
        }

        public Matrix(int sorok, int oszlopok)
        {
            elemek = new double[sorok, oszlopok];
        }

        public static Matrix Osszead(Matrix elso, Matrix masodik)
        {
            if (elso.SorokSzama != masodik.SorokSzama || elso.OszlopokSzama != masodik.OszlopokSzama)
            {
                throw new ArgumentException("A mátrixok méretének egyeznie kell az összeadáshoz!");
            }

            Matrix eredmeny = new Matrix(elso.SorokSzama, elso.OszlopokSzama);

            for (int sor = 0; sor < elso.SorokSzama; sor++)
            {
                for (int oszlop = 0; oszlop < elso.OszlopokSzama; oszlop++)
                {
                    eredmeny.elemek[sor, oszlop] = elso.elemek[sor, oszlop] + masodik.elemek[sor, oszlop];
                }
            }

            return eredmeny;
        }

        public void Feltolt(double ertek)
        {
            for (int sor = 0; sor < SorokSzama; sor++)
            {
                for (int oszlop = 0; oszlop < OszlopokSzama; oszlop++)
                {
                    elemek[sor, oszlop] = ertek;
                }
            }
        }

        public int OszlopokSzama
        {
            get { return elemek.GetLength(1); }
        }

        public int SorokSzama
        {
            get { return elemek.GetLength(0); }
        }

        public override string ToString()
        {
            string eredmeny = "";

            for (int sor = 0; sor < SorokSzama; sor++)
            {
                for (int oszlop = 0; oszlop < OszlopokSzama; oszlop++)
                {
                    eredmeny += elemek[sor, oszlop] + " ";
                }
                eredmeny += "\n";
            }

            return eredmeny;
        }
    }
}
