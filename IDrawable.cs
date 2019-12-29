using System;
using System.Collections.Generic;
using System.Drawing;   //çizim için gerekli kğütüphane.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob_proje_deneme
{
    interface IDrawable  //interfaceler içinde fonksiyon gövdesi olmaz. her şey publictir.
    {
        void Ciz(Graphics grp);
    }
}
